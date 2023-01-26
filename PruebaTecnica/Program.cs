using System.Text;

namespace PruebaTecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReverseWords("paco yunque");
            //Countcharacter("alan huanca villaverde");
            //removeduplicate("jiovanna");
            //findallsubstring("abcd"); //input: abcd , output : a ab abc abcd b bc bcd c cd d
            //RotateLeft(new[] { 1, 2, 3, 4, 5 });
            //RotateRight(new[] { 1, 2, 3, 4, 5 });
            //FindPrime(21);
            //SumOfDigits(1234);
            FindAngleinTime(12, 15);
        }

        internal static void ReverseWords(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();
            

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);

                    output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
            Console.ReadLine();
        }

        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadLine();
        }

        internal static void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        internal static void RotateRight(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = 0; j < size - 1; j++)
            {
                temp = array[0];
                array[0] = array[j + 1];
                array[j + 1] = temp;
            }
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }

        internal static void FindPrime(int number)
        {
            var result = true;
            if (number == 1) result= false;
            if (number == 2) result= true;
            if (number % 2 == 0) result= false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) result= false;
            }


            if (result)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            Console.ReadLine();
        }

        internal static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        internal static void FindAngleinTime(int hours, int mins)
        {
            double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
            double minuteDegrees = mins * 6;
            double diff = Math.Abs(hourDegrees - minuteDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", diff);
            Console.ReadLine();
        }
    }
}