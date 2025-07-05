namespace OOP_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days of the week are:");

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
           
             {
               Console.WriteLine(day);
             }
            

        }
    }
}
