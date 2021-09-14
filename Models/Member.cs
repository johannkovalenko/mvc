using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Member
    {
        [Key] 
        public int      id          { get; set; } 
        public string   firstName   { get; set; }
        public string   middleName  { get; set; }
        public string   lastName    { get; set; }
    }
}