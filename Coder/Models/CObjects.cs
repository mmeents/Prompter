using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prompter.Models {
  public interface ICObjectItem {
    string Key { get; set; }
    string Value { get; set; }
  }
  public interface ICObject : IDictionary<string, ICObjectItem> {
    bool Contains(string key);
    new ICObjectItem this[string key] { get; set; }
    new void Remove(string key);
  }

  public class CObject : ConcurrentDictionary<string, ICObjectItem>, ICObject {
    public CObject() : base() { }
    public virtual Boolean Contains(String key) {
      try {
        return (!(base[key] is null));
      } catch {
        return false;
      }
    }
    public virtual new ICObjectItem this[string key] {
      get { return Contains(key) ? base[key] : null; }
      set { if (value != null) { base[key] = value; } else { Remove(key); } }
    }
    public virtual void Remove(string key) { if (Contains(key)) { _ = base.TryRemove(key, out _); } }
  }

  public interface IVariableItem : ICObjectItem {
     IVariables Owner { get; set; }
    bool ValueChanged { get; set; }
    string AsChunk();
    IVariableItem FromChunk(string chunk);
  }

  public class CVariableItem : IVariableItem {
    public CVariableItem(IVariables owner, string key, string value) {
      Owner = owner;
      Key = key;
      _value = value;
    }
    public IVariables Owner { get; set; }
    public string Key { get; set; } = string.Empty;

    private bool _valueChanged = false;
    public bool ValueChanged {
      get { return _valueChanged; }
      set {
        _valueChanged = value;
        if (value) {
          _valueChanged = false;
          Owner[Key] = this;
        }
      }
    }

    private string _value;
    public string Value {
      get { return _value; }
      set { _value = value; ValueChanged = true; }
    }
    public string AsChunk() {
      return $"{Key.AsBase64Encoded()} {Value.AsBase64Encoded()}".AsBase64Encoded();
    }
    public virtual IVariableItem FromChunk(string chunk) {
      string base1 = chunk.AsBase64Decoded();
      _valueChanged = false;
      Key = base1.ParseFirst(" ").AsBase64Decoded();
      string val = base1.ParseString(" ", 1);
      _value = string.IsNullOrEmpty(val) ? "" : val.AsBase64Decoded();
      return this;
    }
  }

  public interface IVariables : ICObject {
    string FileName { get; set; }
    void SetVarValue(string name, IVariableItem value);
    IVariableItem GetVarValue(string name);
    new IVariableItem this[string key] { get; set; }
  }

  public class Variables : CObject, IVariables {
    public Variables() : base() { }
    public string FileName { get; set; } = string.Empty;
    public virtual void SetVarValue(string key, IVariableItem value) {
      if (!string.IsNullOrEmpty(FileName) && !string.IsNullOrEmpty(key)) {
        if (value == null) {
          RemoveVar(key);
        } else {
          IniFile f = IniFile.FromFile(FileName);
          f["Variables"][key] = value.AsChunk();
          f.Save(FileName);
          base[key] = value;
          value.ValueChanged = false;
        }
      }
    }
    public virtual IVariableItem GetVarValue(string key) {
      if (!string.IsNullOrEmpty(FileName) && !string.IsNullOrEmpty(key)) {
        if (this.Contains(key)) {
          if (base[key] is IVariableItem value) {
            return value;
          }
        }

        IniFile f = IniFile.FromFile(FileName);
        var itemChunk = f["Variables"][key];
        IVariableItem item = (itemChunk != null ?
          new CVariableItem(this, key, "").FromChunk(itemChunk) :
          new CVariableItem(this, key, ""));
        this[key] = item;
        return item;
      }
      throw new CryptoKeyNotSetException();
    }

    public void RemoveVar(string key) {
      IniFile f = IniFile.FromFile(FileName);
      f["Variables"].DeleteKey(key);
      f.Save(FileName);
      if (this.Contains(key)) {
        _ = base.TryRemove(key, out _);
      }
    }

    public ReadOnlyCollection<string> GetKeys() {
      IniFile f = IniFile.FromFile(FileName);
      return f["Variables"].GetKeys();
    }

    public new IVariableItem this[string key] {
      get { return GetVarValue(key); }
      set { SetVarValue(key, value); }
    }


  }


  public interface ICryptoVarItem : IVariableItem {
    new ICryptoVars Owner { get; set; }
    new string AsChunk();
    new ICryptoVarItem FromChunk(string chunk);
  }

  public class CryptoVarItem : CVariableItem, ICryptoVarItem {
    public CryptoVarItem(ICryptoVars owner, string key, string value) : base(owner, key, value) {
      Owner = owner;
    }
    public string encodedValue = "";
    public new ICryptoVars Owner { get; set; }
    public new string AsChunk() {
      return $"{Key.AsBase64Encoded()} {encodedValue}".AsBase64Encoded();
    }
    public new ICryptoVarItem FromChunk(string chunk) {
      string base1 = chunk.AsBase64Decoded();
      Key = base1.ParseFirst(" ").AsBase64Decoded();
      string val = base1.ParseString(" ", 1);
      encodedValue = string.IsNullOrEmpty(val) ? "" : val;
      return this;
    }

    public new string Value {
      get {
        var cryptoKey = Owner?.EncryptionKey;
        if ((!(cryptoKey is null)) && cryptoKey.HasCryptoKey) {
          if (string.IsNullOrEmpty(encodedValue)) {
            return "";
          } else {
            return Task.Run(async () => await cryptoKey.AsDecipherStringAsync(encodedValue)).Result;
          }
        }
        throw new CryptoKeyNotSetException();
      }
      set {
        var cryptoKey = Owner?.EncryptionKey;
        if ((!(cryptoKey is null)) && cryptoKey.HasCryptoKey) {
          encodedValue = string.IsNullOrEmpty(value)
            ? "" : Task.Run(async () => await cryptoKey.ToCipherStringAsync(value)).Result;
          ValueChanged = true;
        } else
          throw new CryptoKeyNotSetException();
      }
    }

    private bool _valueChanged = false;
    public new bool ValueChanged {
      get { return _valueChanged; }
      set {
        _valueChanged = value;
        if (value) {
          _valueChanged = false;
          Owner.SetVarValue(Key, this);
        }
      }
    }
  }

  public interface ICryptoVars : IVariables {
    ICryptoKey EncryptionKey { get; set; }
    void SetVarValue(string key, ICryptoVarItem value);
    new ICryptoVarItem GetVarValue(string key);
  }

  public class CryptoVars : Variables, ICryptoVars {
    public ICryptoKey EncryptionKey { get; set; }
    public CryptoVars(): base() { }
    public void SetKey(CryptoKey cryptoKey) {
      EncryptionKey = cryptoKey ?? throw new ArgumentNullException(nameof(cryptoKey));
      if (!string.IsNullOrEmpty(FileName) && File.Exists(FileName)) {
        this.LoadValues();
      }
    }

    public void SetVarValue(string key, ICryptoVarItem value) {
      if (!string.IsNullOrEmpty(FileName) && (!(EncryptionKey is null)) && !string.IsNullOrEmpty(key)) {
        if (value == null) {
          RemoveVar(key);
        } else {
          base.SetVarValue(key, value);
        }
      }
    }

    public new ICryptoVarItem GetVarValue(string key) {
      if (!string.IsNullOrEmpty(FileName) && (!(EncryptionKey is null)) && !string.IsNullOrEmpty(key)) {
        if (this.Contains(key)) {
          var valueAtBase = base.GetVarValue(key);
          if (valueAtBase is ICryptoVarItem item1) {
            return item1;
          }
        }

        IniFile f = IniFile.FromFile(FileName);
        var itemChunk = f["Variables"][key];
        ICryptoVarItem item = (itemChunk != null ?
          new CryptoVarItem(this, key, "").FromChunk(itemChunk) :
          new CryptoVarItem(this, key, ""));
        this[key] = item;
        return item;
      }
      throw new CryptoKeyNotSetException();
    }

    public void LoadValues() {
      foreach (string key in this.GetKeys()) {
        _ = this[key];
      }
    }
    public new ICryptoVarItem this[string key] {
      get { return GetVarValue(key); }
      set { SetVarValue(key, value); }
    }
  }

}
