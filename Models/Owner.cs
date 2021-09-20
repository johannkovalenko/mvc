using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Owner
    {
        [Key] 
        public int      id          { get; set; } 
        public int      companyId   { get; set; }
        public int      ownerID     { get; set; }
        public int      percent     { get; set; }
        public bool     confirmed   { get; set; }
        public string   sourceOwner { get; set; }
    }
}