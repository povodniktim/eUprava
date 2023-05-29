
namespace eUprava.Data
{
  public class Vloga {
    public int Id { get; set; }
    public User User { get; set; }
    public string NacinIzvajanja { get; set; }
    public DateTime Termin { get; set; }
    public string ZdravniskoPotrdilo { get; set; }
    public string EvidencniKarton { get; set; }
    public string KarticaPrvePomoci { get; set; }
  }
}