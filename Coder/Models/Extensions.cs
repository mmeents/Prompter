using System;
using System.Linq;
using System.Text;

namespace Prompter.Models {

  public static class Cs {
    public static string nl { get { return Environment.NewLine; } }

    public static string GetNamespaceText(string sDB) {
      return
        "using Dapper;  // data io is based on Dapper."+nl+
        "using System.Data;"+nl+
      //  "using System.Data.SqlClient;  // from nuget as well."+nl+
      //  "using StaticExtensions;  // see StaticExtensions in nuget."+nl+nl+
       $"namespace {sDB}"+"{"+nl+nl;
    }

    public static string SQLDefNullValueSQL(string sqlType) {
      string w = sqlType.ToLower().ParseString(" ()", 0);
      string result = "";
      if(w=="char") result="''";
      else if(w=="varchar") result="''";
      else if(w=="int") result="0";
      else if(w=="bigint") result="0";
      else if(w=="binary") result="null";
      else if(w=="bit") result="0";
      else if(w=="datetime") result="null";
      else if(w=="decimal") result="0.0";
      else if(w=="float") result="0.0";
      else if(w=="image") result="null";
      else if(w=="money") result="0.0";
      else if(w=="numeric") result="0.0";
      else if(w=="nchar") result="''";
      else if(w=="ntext") result="''";
      else if(w=="nvarchar") result="''";
      else if(w=="real") result="0.0";
      else if(w=="smallint") result="0";
      else if(w=="smallmoney") result="0.0";
      else if(w=="smalldatetime") result="null";
      else if(w=="text") result="''";
      else if(w=="timestamp") result="null";
      else if(w=="tinyint") result="0";
      else if(w=="uniqueidentifier") result="''";
      else if(w=="varbinary") result="null";
      return result;
    }

    public static string GetCTypeFromSQLType(string sqlType) {
      string w = sqlType.ToLower().ParseString(" ()", 0);
      string result = "";
      if(w=="char") result="string ";
      else if(w=="varchar") result="string";
      else if(w=="int") result="int";
      else if(w=="bigint") result="long";
      else if(w=="binary") result="byte";
      else if(w=="bit") result="bool";
      else if(w=="datetime") result="DateTime";
      else if(w=="decimal") result="decimal";
      else if(w=="float") result="float";
      else if(w=="image") result="Image";
      else if(w=="money") result="decimal";
      else if(w=="numeric") result="decimal";
      else if(w=="nchar") result="byte";
      else if(w=="ntext") result="string";
      else if(w=="nvarchar") result="string";
      else if(w=="real") result="decimal";
      else if(w=="smallint") result="short";
      else if(w=="smallmoney") result="decimal";
      else if(w=="smalldatetime") result="DateTime";
      else if(w=="text") result="string";
      else if(w=="timestamp") result="DateTime";
      else if(w=="tinyint") result="short";
      else if(w=="uniqueidentifier") result="string";
      else if(w=="varbinary") result="byte";
      return result;
    }

    public static string SQLDefNullValueCSharp(string sqlType) {
      string w = sqlType.ToLower().ParseString(" ()", 0);
      string result = "";
      if(w=="char") result="\"\"";
      else if(w=="varchar") result="\"\"";
      else if(w=="int") result="0";
      else if(w=="bigint") result="0";
      else if(w=="binary") result="null";
      else if(w=="bit") result="false";
      else if(w=="datetime") result="null";
      else if(w=="decimal") result="0.0";
      else if(w=="float") result="0.0";
      else if(w=="image") result="null";
      else if(w=="money") result="0.0";
      else if(w=="numeric") result="0.0";
      else if(w=="nchar") result="\"\"";
      else if(w=="ntext") result="\"\"";
      else if(w=="nvarchar") result="\"\"";
      else if(w=="real") result="0.0";
      else if(w=="smallint") result="0";
      else if(w=="smallmoney") result="0.0";
      else if(w=="smalldatetime") result="null";
      else if(w=="text") result="\"\"";
      else if(w=="timestamp") result="null";
      else if(w=="tinyint") result="0";
      else if(w=="uniqueidentifier") result="\"\"";
      else if(w=="varbinary") result="null";
      return result;
    }

    public static string GetRichTextEditor(string editorContent) { 
      string s = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <title>Summernote</title>\r\n  <link href=\"http://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n  <script src=\"http://code.jquery.com/jquery-3.5.1.min.js\"></script>\r\n  <script src=\"http://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js\"></script>\r\n  <link href=\"http://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote.min.css\" rel=\"stylesheet\">\r\n  <script src=\"http://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote.min.js\"></script>\r\n</head>\r\n<body>\r\n  <div id=\"summernote\">"+editorContent+"</div>\r\n  <script>\r\n    $(document).ready(function() {\r\n        $('#summernote').summernote();\r\n    });\r\n  </script>\r\n</body>\r\n</html>";
      return s;
      }

  }

  public static class Ext {
    //
    // Summary:
    //     Splits content by delims and count
    //
    // Returns:
    //     int
    public static int ParseCount(this string content, string delims) {
      return content.Split(delims.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;
    }

    //
    // Summary:
    //     Splits contents by delims into an array and returns item at take
    //
    // Returns:
    //     string
    public static string ParseString(this string content, string delims, int take) {
      string[] array = content.Split(delims.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
      return content.Split(delims.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0];
    }

    //
    // Summary:
    //     Splits contents by delims and takes last
    //
    // Returns:
    //     string
    public static string ParseLast(this string content, string delims) {
      string[] sr = content.Split(delims.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      if(sr.Length>0) {
        return sr[sr.Length-1];
      }
      return "";
    }

    public static string[] Parse(this string content, string delims) {
      string[] sr = content.Split(delims.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      return sr;      
    }


    //
    // Summary:
    //     Casts object as string, null is Exception
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
    public static int AsInt(this string obj) {      
      return int.TryParse(obj, out int r) ? r : 0;
    }
    //
    // Summary:
    //     Base 64 encodes string variant uses ? as fillers instead of = for inifiles.
    //
    // Returns:
    //     Base64 encoded string
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
      byte[] bytes = Convert.FromBase64String(Text.Replace('?', '='));
      return Encoding.UTF8.GetString(bytes);
    }

    //
    // Summary:
    //     General Location to put program data
    //
    // Remarks:
    //     string C:\ProgramData\MMCommons
    public static string MMCommonsFolder() {
      return "C:\\ProgramData\\MMCommons";
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

  }
}
