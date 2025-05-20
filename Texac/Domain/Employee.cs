using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texac.RestClient;

namespace Texac.Domain
{
    [EntityPath("employees")]
    public class Employee : BaseEntity
    {
        public long employeeId { get; set; }
        public int employeeNo { get; set; }
        public long? deptId { get; set; }
        public String zveno { get; set; }
        public String firstName { get; set; }
        public String secondName { get; set; }
        public String fullName { get; set; }
        public long? position { get; set; }
        public int? rank { get; set; }
        public DateTime? dateOfEmployment { get; set; }
        public bool? working { get; set; }
        public long? categoryId { get; set; }
        public String address { get; set; }
        public String homePhone { get; set; }
        public DateTime? birthday { get; set; }
        public String birthplace { get; set; }
        public String education { get; set; }
        public int? eduYear { get; set; }
        public String faculty { get; set; }
        public String specialty { get; set; }
        public String previousEmployment { get; set; }
        public String note { get; set; }
        public double? workingConditions { get; set; }
        public double? salary { get; set; }
        public String userLogin { get; set; }
        public long? managerId { get; set; }
        public String passportSeries { get; set; }
        public String passportNumber { get; set; }
        public DateTime? passportDate { get; set; }
        public String passportOffice { get; set; }
        public String personalNumber { get; set; }
        public String realAddress { get; set; }
        public String familyStatus { get; set; }
        public String mobilePhoneZone { get; set; }
        public String mobilePhone { get; set; }
        public long? professionId1 { get; set; }
        public long? professionId2 { get; set; }
        public long? professionId3 { get; set; }
        public long? professionId4 { get; set; }
        public long? professionId5 { get; set; }
        public long? professionId6 { get; set; }
        public int? height { get; set; }
        public int? clothingSize { get; set; }
        public int? shoeSize { get; set; }
        public long? meansOfProtectionByPosition { get; set; }
        public long? clothingSizeTypeId { get; set; }
        public String gender { get; set; }
    }
}
