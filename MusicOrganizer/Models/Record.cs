using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public string Type { get; set; }
    public int Id { get; }
    public List<Song> Songs { get; set; }
    private static List<Record> _instances = new List<Record>{};

    public Record(string title, string artist, string genre, string type)
    {
      Title = title;
      Artist = artist;
      Genre = genre;
      Type = type.ToUpper();
      _instances.Add(this);
      Id = _instances.Count;
      Songs = new List<Song>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }
  }
}