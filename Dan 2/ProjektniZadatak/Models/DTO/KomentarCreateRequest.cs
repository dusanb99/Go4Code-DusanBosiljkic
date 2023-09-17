using System.ComponentModel.DataAnnotations;

namespace ProjektniZadatak.Models.DTO
{
    public class KomentarCreateRequest
    {
        public string Tekst { get; set; }

        [Required]
        public int ObjavaId { get; set; }
    }
}
