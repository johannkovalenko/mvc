using System.Collections.Generic;

namespace mvc
{
    public static class Data
    {
        public static List<mvc.Models.Member> members = new List<mvc.Models.Member>
        { 
            new mvc.Models.Member {firstName="Mieszko", middleName="Jan", lastName="Kovalenko"},
            new mvc.Models.Member {firstName="Karolina", middleName="Agnieszka", lastName="Kovalenko"},
            new mvc.Models.Member {firstName="Johann", middleName="", lastName="Kovalenko"},
        };
    }
}