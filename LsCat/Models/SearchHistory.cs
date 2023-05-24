using System.ComponentModel.DataAnnotations;

namespace LsCat.Models
{
    public class SearchHistory
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Query { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
