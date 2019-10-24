using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAexercise
{
    class DNAexercise
    {
        // Objective #1
        public static void EncodeToDNA(byte[] asciiBytesArr)
        {
            string tempStr = "";
            string dnaLetter = "";
            string dnaSequence = "";

            if (asciiBytesArr?.Length > 0)
            {
                foreach (char c in asciiBytesArr)
                {
                    tempStr += Convert.ToString(c, 2).PadLeft(8, '0');
                }
            }
            else
            {
                Console.WriteLine("Sorry the input string was empty");
            }

            for (var i = 0; i < tempStr.Length - 1; i += 2)
            {
                string tempSubStr = tempStr.Substring(i, 2);

                switch (tempSubStr)
                {
                    case "00":
                        dnaLetter = "A";
                        break;
                    case "01":
                        dnaLetter = "T";
                        break;
                    case "10":
                        dnaLetter = "G";
                        break;
                    case "11":
                        dnaLetter = "C";
                        break;
                }

                dnaSequence += dnaLetter;
                //Console.Write($"{(tempSubStr)}");         
            }

            Console.WriteLine($"DNA Encoding: {dnaSequence}");
        }

        // Objective #2
        public static void EncodeToRNA(byte[] asciiBytesArr)
        {
            string tempStr = "";
            string rnaLetter = "";
            string rnaSequence = "";

            if (asciiBytesArr?.Length > 0)
            {
                foreach (char c in asciiBytesArr)
                {
                    tempStr += Convert.ToString(c, 2).PadLeft(8, '0');
                }
            }
            else
            {
                Console.WriteLine("Sorry the input string was empty");
            }

            foreach (char c in asciiBytesArr)
            {
                tempStr += Convert.ToString(c, 2).PadLeft(8, '0');
            }

            for (var i = 0; i < tempStr.Length - 1; i += 2)
            {
                string tempSubStr = tempStr.Substring(i, 2);

                switch (tempSubStr)
                {
                    case "00":
                        rnaLetter = "A";
                        break;
                    case "01":
                        rnaLetter = "U";
                        break;
                    case "10":
                        rnaLetter = "G";
                        break;
                    case "11":
                        rnaLetter = "C";
                        break;
                }

                rnaSequence += rnaLetter;
                //Console.Write($"{(tempSubStr)}");         
            }

            Console.WriteLine($"RNA Encoding:  {rnaSequence}");
        }


        static void Main(string[] args)
        {
            Console.Write("Hello, please enter a string to encode:  ");

            string inputStr = Console.ReadLine();
            byte[] asciiBytesArr = Encoding.ASCII.GetBytes(inputStr);


            // Call to DNA encoding method.
            EncodeToDNA(asciiBytesArr);


            // Call to RNA encoding method.
            EncodeToRNA(asciiBytesArr);

            
            // Pause the terminal screen from flashing.
            Console.ReadKey();
        }
    }
}
