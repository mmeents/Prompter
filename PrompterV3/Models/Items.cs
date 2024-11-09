using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrompterV3.Models {
  public class Items : ConcurrentDictionary<int, Item> {
    public Items() : base() { }
    public virtual Boolean Contains(int id) {
      try {
        return !(base[id] is null);
      } catch {
        return false;
      }
    }
    public virtual new Item this[int id] {
      get { return Contains(id) ? base[id] : null; }
      set { if (value != null) { base[id] = value; } else { Remove(id); } }
    }
    public virtual void Remove(int id) { if (Contains(id)) { _ = base.TryRemove(id, out _); } }

    public IEnumerable<Item> GetChildrenItems(int id) {
      return this.Select(x => x.Value).Where(x => x.OwnerId == id).OrderBy(x => x.ItemRank);
    }
    public int GetNextId() {
      int max = 0;
      if (this.Keys.Count > 0) {
        max = this.Select(x => x.Value).Max(x => x.Id);
      }
      return max + 1;
    }

    public ICollection<string> AsList {
      get {
        List<string> retList = new List<string>();
        foreach (Item i in Values) {
          retList.Add(i.AsChunk());
        }
        return retList;
      }
      set {
        base.Clear();
        foreach (var x in value) {
          Item n = new Item().FromChunk(x);
          this[n.Id] = n;
        }
      }
    }
  }


}
