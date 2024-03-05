using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetBooks.Models
{
    public class Book
    {
        [DisplayName("Kitap No")]
        public int Id { get; set; }
        [DisplayName("Kitap Adı")]
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Yazar")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Publish Date")]
        [Required]
        public DateTime PublishDate { get; set; }

        [DisplayName("Page Size")]
        public int PageSize { get; set; }

        public Decimal Price { get; set; }

    }
}
