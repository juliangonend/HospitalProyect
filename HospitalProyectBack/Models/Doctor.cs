namespace HospitalProyect.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int  Tuition { get; set; }//matricula
        public Speciality Speciality { get; set; }
        public bool State { get; set; }
    }
    public enum Speciality
    {
        General,
        Pediatra,
        Ginecología
    }
}
