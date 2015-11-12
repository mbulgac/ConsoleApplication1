using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class App
    {


        static void Main(string[] args)
        {
            Alert1 alert1 = new Alert1();
            File1 file1 = new File1();
            String1 string1 = new String1();

            Console.WriteLine("Enter path to file:");



            string line1 = file1.ToLine(Console.ReadLine());


            if (string1.IsPalindrome(line1)) { alert1.Throw("Your string is Palindrom"); }
            else { alert1.Throw("Your string is NOT Palindrom"); }

            Console.ReadKey();
        }




        class File1
        {
            public string ToLine(string path1)
            {
                System.IO.StreamReader myFile = new System.IO.StreamReader(path1);
                string myString = myFile.ReadToEnd();
                myFile.Close();
                return myString;
            }
        }

        class String1
        {
            public bool IsPalindrome(string line)
            {
                string left_part = line.Substring(0, line.Length / 2);

                char[] arr = line.ToCharArray();
                Array.Reverse(arr);
                string reversed_line = new string(arr);

                string right_part = reversed_line.Substring(0, reversed_line.Length / 2);

                return left_part.Equals(right_part);

            }
        }

        class Alert1
        {
            public void Throw(string result)
            {

                Console.WriteLine(result);

            }


        }




    }


}
