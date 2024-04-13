using System;
using System.Runtime.Serialization;


namespace PrompterV3.Models {
  /// <summary>
  ///   Example of how to create a decendent exception. 
  /// </summary>
  [Serializable]
  public class CryptoKeyNotSetException:Exception {
    public CryptoKeyNotSetException() : base() { }
    public CryptoKeyNotSetException(string message) : base(message) { }
    public CryptoKeyNotSetException(string message, Exception innerException) : base(message, innerException) { }
    protected CryptoKeyNotSetException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    public override void GetObjectData(SerializationInfo info, StreamingContext context) {
      base.GetObjectData(info, context);
    }
  }

}
