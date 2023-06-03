
using System.ComponentModel.DataAnnotations;

namespace eUprava.Data
{
  public class Vloga
  {
    public int Id { get; set; }
    public User User { get; set; }

    [Required(ErrorMessage = "Prosim izberite Naèin Izvajanja.")]
    public string NacinIzvajanja { get; set; }

    [Required(ErrorMessage = "Prosim naložite Zdravniško Potrdilo.")]
    public string ZdravniskoPotrdilo { get; set; }

    [Required(ErrorMessage = " Prosim naložite Evidenèni Karton")]
    public string EvidencniKarton { get; set; }

    [Required(ErrorMessage = "Prosim naložite Kartico Prve Pomoèi.")]
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