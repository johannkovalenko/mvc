using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Query2
    {
        [Key] 
        public int      companyId   { get; set; } 
	    public string   companyName { get; set; }
        public int      ownerId     { get; set; }
	    public string   ownerName   { get; set; }
        public double      percent     { get; set; }
        public bool     confirmed   { get; set; }
        public string   legalForm   { get; set; }
        public string   label       { get; set; }
        public bool     physical { get; set; }
        public string   address{ get; set; }
        public string   branch      { get; set; }
        public string   chair       { get; set; }
        public string   sourceChair { get; set; }
        public string   ubo         { get; set; }
        public long      capital         { get; set; }
        public string   currency    {get; set;}
        public string   sourceOwner { get; set; }
    }
}