
using System.ComponentModel.DataAnnotations;

namespace eUprava.Data
{
  public class Vloga
  {
    public int Id { get; set; }
    public User User { get; set; }

    [Required(ErrorMessage = "Prosim izberite Na�in Izvajanja.")]
    public string NacinIzvajanja { get; set; }

    [Required(ErrorMessage = "Prosim nalo�ite Zdravni�ko Potrdilo.")]
    public string ZdravniskoPotrdilo { get; set; }

    [Required(ErrorMessage = " Prosim nalo�ite Eviden�ni Karton")]
    public string EvidencniKarton { get; set; }

    [Required(ErrorMessage = "Prosim nalo�ite Kartico Prve Pomo�i.")]
    public string KarticaPrvePomoci { get; set; }

    public DateTime Termin { get; set; }

    public Status StatusVloge { get; set; }
  }

  public enum Status
  {
    Oddana,
    Potrjena,
    Zavrnjena
  }
}