using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Capital
    {
        [Key]
        public int      id      { get; set; }
        public string   country { get; set; }
        public string   capital { get; set; }  
    }
}