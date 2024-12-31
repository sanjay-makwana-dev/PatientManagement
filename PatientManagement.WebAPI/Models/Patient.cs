namespace PatientManagement.WebAPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Prefix { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Attachment { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

}
