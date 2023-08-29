namespace project_management_system_backend.Models
{
    public class User:BaseModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NIC { get; set; }
    }
}

