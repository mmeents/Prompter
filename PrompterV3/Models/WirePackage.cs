using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrompterV3.Models {

  [MessagePackObject]
  public class WirePackage {
    [Key(0)]
    public string Name { get; set; }
    [Key(1)]
    public ICollection<CObjectItem> SettingsList { get; set; } = new List<CObjectItem>();

    [Key(2)]
    public ICollection<string> ItemChunks { get; set; } = new List<string>();

  }


}
