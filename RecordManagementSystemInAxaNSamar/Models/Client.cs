using System;
using System.Collections.Generic;

namespace RecordManagementSystemInAxaNSamar.Model
{
    public class Client
    {
        public int ClientId { get; internal set; }
        public string CLastName { get; set; }
        public string CMiddleName { get; set; }
        public string CFirstName { get; set; }
        public string SpouseLastName { get; set; }
        public string SpouseMiddleName { get; set; }
        public string SpouseFirstName { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string PolicyStatus { get; set; }
        public DateTime CBirthday { get; set; }
        public string Age { get; set; }
        public string PlaceOfBirth { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string CAddress { get; set; }
        public string CellphoneNo { get; set; }
        public string TelephoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string Occupation { get; set; }
        public float WorkSalary { get; set; }
        public float BusinessIncome { get; set; }
        public float OtherSource { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyContact { get; set; }
        public string NatureOfBusiness { get; set; }
        public string TaxIdNumber { get; set; }
        public string Sss_gsisNumber { get; set; }
        //public string Answer1 { get; set; }
        //public string Answer2 { get; set; }
        public string ValidId1 { get; set; }
        public string ValidId2 { get; set; }

        public ICollection<ClientPlan> ClientPlan { get; internal set; }
        public ICollection<ClientBeneficiaries> ClientBeneficiaries { get; internal set; }
        public Employee Employee { get; internal set; }
        public int EmployeeId { get; internal set; }
    }
}