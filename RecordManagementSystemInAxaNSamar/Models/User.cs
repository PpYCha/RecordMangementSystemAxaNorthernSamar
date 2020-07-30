namespace RecordManagementSystemInAxaNSamar.Model
{
    public class User
    {
        public int UserId { get; internal set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string UFirstName { get; set; }
        public string UMiddleName { get; set; }
        public string ULastName { get; set; }
        public string UGender { get; set; }
        public string ContactNumber { get; set; }
        public string UAddress { get; set; }
        public bool? IsActive { get; set; }
    }
}