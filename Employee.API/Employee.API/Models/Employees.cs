namespace Employee.API.Models
{
    public class Employees
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Phone { get; set; }
        public float Salary { get; set; }
        public string Department { get; set; }
    }
}
