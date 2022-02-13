using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureMVC.Domain
{
    [Table("Document")]
    public class Document : Entity
    {
        public Document(string title, string author)
        {
            Title = title;
            Author = author;
        }

        [MaxLength(255)]
        public string Title { get; protected set; }
        [MaxLength(255)]
        public string Author { get; protected set; }
    }
}
