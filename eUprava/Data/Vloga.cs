
using System.ComponentModel.DataAnnotations;

namespace eUprava.Data
{
  public class Vloga {
    public int Id { get; set; }
    public User User { get; set; }

    [Required]
    public string NacinIzvajanja { get; set; }
    public DateTime Termin { get; set; }
    [Required]
    public string ZdravniskoPotrdilo { get; set; }
    [Required]
    public string EvidencniKarton { get; set; }
    [Required]
    public string KarticaPrvePomoci { get; set; }
  }
}