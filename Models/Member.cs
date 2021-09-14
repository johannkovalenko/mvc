namespace mvc.Models
{
    public class Member
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public double salary;

        public Member(string firstName, string middleName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.salary = salary;
        }
    }
}