using System.Collections.Generic;
namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public override string ToString()
    {
      return $"id: {DoctorId} | name:{DoctorName} | description:{DoctorSpecialty}";
    }
    public Doctor()
    {
      this.Patients = new HashSet<Patient>();
    }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string DoctorSpecialty { get; set; }
    public virtual ICollection<Patient> Patients { get; set; }
  }
}