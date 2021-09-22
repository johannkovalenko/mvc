using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Company
    {
        [Key] 
        public int      id          { get; set; } 
	    public string   name        { get; set; }
        public string   legalForm   { get; set; }
        public string   label       { get; set; }
        public bool     physical    { get; set; }
        public string   address          { get; set; }
        public string   branch      { get; set; }
        public string   chair       { get; set; }
        public string   sourceChair { get; set; }
        public string   ubo         { get; set; }
        public long      capital         { get; set; }
        public string   currency    {get; set;}
    }
}