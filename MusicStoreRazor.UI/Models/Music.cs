using System.ComponentModel.DataAnnotations;

namespace MusicStoreRazor.UI.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string BarcodeNumber { get; set; }

    }
}
