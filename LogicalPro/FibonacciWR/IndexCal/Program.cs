namespace IndexCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    int a = 0, b = 0, c = 0, d = 0;
            //    for (int i = 0; i < s.Length; i++)      //Tharmesh@123          a=1
            //    {

            //        if (isUpper(s[i]))
            //        {
            //            a = 1;
            //        }
            //        else if (isLower(s[i]))
            //        {
            //            b = 1;
            //        }
            //        else if (isDigit(s[i]))
            //        {
            //            c = 1;
            //        }
            //        else
            //            d = 1;
            //    }

            //    if ((a + b + c + d) == 4)
            //    {
            //        Console.WriteLine("Valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Valid");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}


            int[] arr1 = new int[] { 9, 8, 7, 4, 2 };
            //int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == arr1.Length - 1)
                        break;
                    int x = arr1[i] + arr1[i + 1] * 9;
                    int y = arr1[i + 1] + arr1[i + 2];
                    //arr2[i] = x;
                    //arr2[i + 1] = y;
                    Console.WriteLine(x + "  " + y + "  ");
                }
            }

        }

        public static bool isUpper(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        public static bool isLower(char x)
        {
            return x >= 'a' && x <= 'z';
        }
        public static bool isDigit(char x)
        {
            return x >= '0' && x <= '9';
        }
        public static bool isSpecialChar(char x)
        {
            if (!isUpper(x) && !isLower(x) && !isDigit(x))
            {
                return true;
            }
            return false;
        }

        //public static bool isEmailValid(string s)  //tharmesh12     @gmail.com
        //{
        //    if (!"@gmail.com".Contains(s))
        //        return false;
        //    if (isDigit(s[0]))
        //        return false;
        //    if((!isSpecialChar(s)))

        //}
    }


}
// 1    2     3     4     10
 
// 0    1     2     3      4
 
//pos(0+1)  1+2*9 = 19   pos(1+2) = 5
//pos(2+3)  3+4*9 = 39   pos(3+4) = 14
        
    

