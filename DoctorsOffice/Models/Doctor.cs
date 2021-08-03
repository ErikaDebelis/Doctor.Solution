using System.Collections.Generic;
namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JointEntities = new HashSet<DoctorPatient>();
    }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public virtual ICollection<DoctorPatient> JointEntities { get; set; }
  }
}