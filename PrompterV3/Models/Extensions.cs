using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrompterV3.Models {
  public static class Ext {

    public static string Nl(this string s) { 
      return s+Environment.NewLine;
     }
    public static string[] Parse(this string content, string delims) {      
      return content.Split(delims.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
    }
    //
    // Summary:
    //     Splits content by delims and count
    //
    // Returns:
    //     int
    public static int ParseCount(this string content, string delims) {
      return content.Parse(delims).Length;
    }

    //
    // Summary:
    //     Splits contents by delims into an array and returns item at take
    //
    // Returns:
    //     string
    public static string ParseString(this string content, string delims, int take) {
      string[] array = content.Parse(delims);
      if(take<array.Length) {
        return array[take];
      }
      return "";
    }

    //
    // Summary:
    //     Splits contents by delims and takes first
    //
    // Returns:
    //     string
    public static string ParseFirst(this string content, string delims) {
      return content.Parse(delims)[0];
    }

    //
    // Summary:
    //     Splits contents by delims and takes last
    //
    // Returns:
    //     string
    public static string ParseLast(this string content, string delims) {
      string[] sr = content.Parse(delims);
      if(sr.Length>0) {
        return sr[sr.Length-1];
      }
      return "";
    }

    public static string GetNextTag(this string content) {
      string returnstring = "";
      if(content.Contains('[')) {
        int startIndex = content.IndexOf("[", 0);
        int endIndex = content.IndexOf("]", startIndex);
        returnstring = content.Substring(startIndex, endIndex - startIndex+1);
      }
      return returnstring;
    }

    //
    // Summary:
    //     Casts object as string, null is Empty
    //
    // Returns:
    //     string
    public static string AsString(this object obj) {
      try {
        return Convert.ToString(obj)??string.Empty;
      } catch {
        return string.Empty;
      }
    }
    /// <summary>
    /// on fail or null return 0
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>int</returns>
    public static int AsInt(this string obj) {
      return int.TryParse(obj, out int r) ? r : 0;
    }

    public static byte[] AsBytes(this string text) { 
      return Encoding.UTF8.GetBytes(text);
    }

    public static string AsString(this byte[] bytes ) { 
      return Encoding.UTF8.GetString(bytes);
    }

    /// <summary>
    ///     Base 64 encodes string variant uses ? as fillers instead of = for inifiles.
    /// </summary>
    /// <param name="Text"></param>
    /// <returns></returns>
    public static string AsBase64Encoded(this string Text) {
      return Convert.ToBase64String(Encoding.UTF8.GetBytes(Text)).Replace('=', '?');
    }

    //
    // Summary:
    //     Base 64 decodes string variant uses converts ? back to = as fillers for inifiles.
    //
    // Returns:
    //     Base 64 decoded string
    public static string AsBase64Decoded(this string Text) {
      if (string.IsNullOrEmpty(Text)) return "";
      byte[] bytes = Convert.FromBase64String(Text.Replace('?', '='));
      return Encoding.UTF8.GetString(bytes);
    }    

    //
    // Summary:
    //     Remove all instances of CToRemove from content
    //
    // Returns:
    //     string
    public static string RemoveChar(this string content, char CToRemove) {
      string text = content;
      while(text.Contains(CToRemove)) {
        text=text.Remove(text.IndexOf(CToRemove), 1);
      }

      return text;
    }

    //
    // Summary:
    //     lower case first letter of content concat with remainder.
    //
    // Parameters:
    //   content:
    //
    // Returns:
    //     string
    public static string AsLowerCaseFirstLetter(this string content) {
      return content.Substring(0, 1).ToLower()+content.Substring(1);
    }

    //
    // Summary:
    //     Uppercase first letter of content concat with rest of content.
    //
    // Parameters:
    //   content:
    //
    // Returns:
    //     string
    public static string AsUpperCaseFirstLetter(this string content) {
      return content.Substring(0, 1).ToUpper()+content.Substring(1);
    }

    public static async Task<string> ReadAllTextAsync(this string filePath) {            
      using(var streamReader = new StreamReader(filePath)) {
        return await streamReader.ReadToEndAsync(); 
      }
    }

    public static async Task<int> WriteAllTextAsync(this string Content, string filePath) {       
      using (var streamWriter = new StreamWriter(filePath)) {
        await streamWriter.WriteAsync(Content);
      }
      return 1;
    }

  }
}
