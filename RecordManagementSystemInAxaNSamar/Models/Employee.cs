using System;
using System.Collections.Generic;

namespace RecordManagementSystemInAxaNSamar.Model
{
    public class Employee
    {
        public int EmployeeId { get; internal set; }
        public string ELastName { get; set; }
        public string EMiddleName { get; set; }
        public string EFirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Age { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string CellphoneNo { get; set; }
        public string Address { get; set; }
        public string DesignatedPostion { get; set; }
        public string IdPicture { get; set; }


        public ICollection<Client> Client { get; internal set; }
    }
}