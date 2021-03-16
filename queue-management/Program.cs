using System;



namespace queue_management
{
    class Program
    {
        static void Main(string[] args)
        {

            Appointment app = new Appointment(5, 5, 10, "21/03/21");
            Console.WriteLine(app);
        }
    }
}
