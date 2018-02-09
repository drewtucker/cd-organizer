using System.Collections.Generic;
namespace CdOrganizer.Models
{
  public class Cd
  {
    private string _title;
    private string _artist;
    private int _releaseYear;
    private int _id;
    private static List<Cd> _cdInstances = new List<Cd> {};

  public Cd(string title, string artist, int releaseYear)
  {
    _title = title;
    _artist = artist;
    _releaseYear = releaseYear;
    _id = _cdInstances.Count;
  }

  public string GetTitle()
  {
    return _title;
  }

  public void SetTitle(string newTitle)
  {
    _title = newTitle;
  }

  public string GetArtist()
  {
    return _artist;
  }

  public void SetArtist(string newArtist)
  {
    _artist = newArtist;
  }

  public int GetReleaseYear()
  {
    return _releaseYear;
  }

  public void SetReleaseYear(int newReleaseYear)
  {
    _releaseYear = newReleaseYear;
  }

  public static List<Cd> AllCds()
  {
    return _cdInstances;
  }

  public static Cd Find(int searchId)
  {
    return _cdInstances[searchId-1];
  }

  }
}
