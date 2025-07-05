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
            //Console.WriteLine("Enter the desired season:");
            //string input = Console.ReadLine();

            ////Season selectedSeason = (Season) input;

            ////typeof(Season) is to indicate what ENUM we want to match our input
            ////true is to ignore case sensitivity
            //// out variable is object because the non generic TryParase returns an object
            //Enum.TryParse(typeof(Season), input, true, out object selectedSeason);

            //switch (selectedSeason)
            //{
            //    case Season.Spring: 
            //        Console.WriteLine("spring march to may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("summer june to august");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("autumn September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("winter December to February");
            //        break;
            //}


            #endregion


            #region 3.Q3

 
            //Permissions userPermissions = Permissions.None;

            ////After granting permissions: 00000011 == 3
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            
            //Console.WriteLine("Current Permissions: " + userPermissions); // Output: Read, Write but their value will result in number 3 


            //if (userPermissions.HasFlag(Permissions.Write))
            //{
            //    Console.WriteLine("Write permission is granted."); 
            //}

            //userPermissions &= ~Permissions.Write;

            //Console.WriteLine("Updated Permissions: " + userPermissions); // Output: Read

 
            #endregion


            #region 4.Q4

            //Console.Write("Enter a color name: ");
            //string inputColor = Console.ReadLine();

            //// Try to parse the input as a member of the Colors enum (case-insensitive)
            //if (Enum.TryParse(typeof(Colors), input, true, out object result))
            //{
            //    Console.WriteLine($"{input} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is NOT a primary color.");
            //}

            #endregion


        }
    }
}
