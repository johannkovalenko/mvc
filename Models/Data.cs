using System.Collections.Generic;

namespace Models
{
    public class Data
    {
        public List<Company> companies;
        public int id;

        public Data(List<Company> companies, int id)
        {
            this.companies = companies;
            this.id = id;
        }
    }
}