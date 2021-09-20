using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Query1
    {
        [Key] 
        public int      id          { get; set; } 
	    public string   name        { get; set; }
        public int      ownerID     { get; set; }
        public double      percent     { get; set; }
        public bool     confirmed   { get; set; }
        public string   sourceOwner { get; set; }
    }
}