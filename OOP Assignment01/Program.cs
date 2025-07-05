namespace OOP_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1.Q1
            //Console.WriteLine("Days of the week are:");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
           
            // {
            //   Console.WriteLine(day);
            // }
            #endregion


            #region 2.Q2
            Console.WriteLine("Enter the desired season:");
            string input = Console.ReadLine();

            //Season selectedSeason = (Season) input;

            //typeof(Season) is to indicate what ENUM we want to match our input
            //true is to ignore case sensitivity
            // out variable is object because the non generic TryParase returns an object
            Enum.TryParse(typeof(Season), input, true, out object selectedSeason);

            switch (selectedSeason)
            {
                case Season.Spring: 
                    Console.WriteLine("spring march to may");
                    break;
                case Season.Summer:
                    Console.WriteLine("summer june to august");
                    break;
                case Season.Autumn:
                    Console.WriteLine("autumn September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("winter December to February");
                    break;
            }


            #endregion


 






        }
    }
}
