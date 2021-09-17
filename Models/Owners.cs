using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Owners
    {
        [Key] 
        public int      id          { get; set; } 
	    public string   name        { get; set; }
        public string   legalForm   { get; set; }
        public bool     isPhysicalPerson { get; set; }
        public string   headquarters{ get; set; }
        public string   headquartersCountry { get; set; }
        public string   branch      { get; set; }
        public string   chair       { get; set; }
        public string   ubo         { get; set; }
    }
}