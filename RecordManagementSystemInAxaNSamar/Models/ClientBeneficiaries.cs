namespace RecordManagementSystemInAxaNSamar.Model
{
    public class ClientBeneficiaries
    {
        public int ClientBeneficiaresId { get; internal set; }
        public string BFirstName { get; set; }
        public string BMiddleName { get; set; }
        public string BLastName { get; set; }
        public string Birthday { get; set; }
        public string BirthPlace { get; set; }
        public string Relationship { get; set; }
        public string Occupation { get; set; }
        public float Share { get; set; }

        public Client Client { get; internal set; }
        public int ClientId { get; internal set; }
    }
}