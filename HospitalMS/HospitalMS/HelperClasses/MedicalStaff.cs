using System.Collections.Generic;

namespace HospitalMS.HelperClasses
{
    public class MedicalStaff
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string shiftStart { get; set; }
        public string shiftEnd { get; set; }
        public int employmentYear { get; set; }
        public string specialization { get; set; }
        public string clinic { get; set; }
        public string gender { get; set; }
        public List<string> phones { get; set; }
        public string nationalID { get; set; }
        public string password { get; set; }
    }
}
