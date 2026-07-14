namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            var appointment = new Appointment(now, "Mohadeseh Sanaei Nezhad");
            appointment.Reschedule(10);
            Console.WriteLine($"{appointment.Date} - {appointment.Name} - {appointment.DoctorName}");
        }
    }

    class Appointment
    {
        public DateTime Date;
        public string Name;
        public string DoctorName;

        public Appointment(DateTime date, string name, string doctorName)
        {
            Date = date;
            Name = name;
            DoctorName = doctorName;
        }

        public Appointment(DateTime date, string name) : this(date, name, "Arsalan Nury")
        {
            Date = date;
            Name = name;
        }

        public void Reschedule(int addDays, string name)
        {
            Date = Date.AddDays(addDays);
            Name = name;
        }

        public void Reschedule(int addDays)
        {
            Date = Date.AddDays(addDays);
        }
    }
}