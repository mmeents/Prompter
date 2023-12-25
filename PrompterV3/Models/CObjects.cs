using MessagePack;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrompterV3.Models {

  [MessagePackObject]
  public class CObjectItem {
    [IgnoreMember]
    public string Key { get; set; }
    [IgnoreMember]
    public string Value { get; set; }

    [Key(0)]
    public byte[] AsBytes { 
      get{ 
        return $"{Key.AsBase64Encoded()} {Value.AsBase64Encoded()}".AsBytes(); 
      }
      set{ 
        string bytesAsString = value.AsString();
        Key = bytesAsString.ParseFirst(" ").AsBase64Decoded();
        Value = bytesAsString.ParseLast(" ").AsBase64Decoded();        
      }
    }

  }


  public class CObject:ConcurrentDictionary<string, CObjectItem> {
    public CObject() : base() { }

    public CObject( ICollection<CObjectItem> asList) : base() { 
      AsList = asList;
    }
    public virtual Boolean Contains(String key) {
      try {
        return (!(base[key] is null));
      } catch {
        return false;
      }
    }

    public virtual new CObjectItem this[string key] {
      get { 
        if (!Contains(key)) base[key]=new CObjectItem() { Key=key, Value="" };
        return base[key];
      }
      set { if(value!=null) { base[key]=value; } else { Remove(key); } }
    }    
    public virtual void Remove(string key) { 
      if(Contains(key)) { _=base.TryRemove(key, out _); } 
    }

    public ICollection<CObjectItem> AsList { 
      get{ return base.Values; } 
      set{ 
        base.Clear();
        foreach(var x in value) {
          this[x.Key] = x;
        } 
      } 
    }

    public CObject Clone() { 
      var clone = new CObject();
      clone.AsList = AsList;
      return clone;
    }
  }

}
