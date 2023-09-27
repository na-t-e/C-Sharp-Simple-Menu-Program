using System;
using static System.Console;



    class Program
    {
        static void Main()
        {
            string input;
            double choice;

            do
            {



                WriteLine("Nathan Vargas' Simple Menu Program :)\n");
                WriteLine("1. Calculate rectangular area (length x width)\n ");
                WriteLine("2. Calculate triangular area (1/2 base x height)\n");
                WriteLine("3. Calculate circumference of a cirlce given radius (2 x PI x r)\n");
                WriteLine("4. Print ordinal starting position of 'Mink' in the tagline 'Think Mink!'\n");
                WriteLine("5. Convert keyboard input to all uppercase.\n");
                WriteLine("6. Convert keyboard input to all lowercase\n");
                WriteLine("7. Exit Nathan's Simple Formula Program\n");
                WriteLine("Select Option: ");
                input = ReadLine();
                choice = Convert.ToDouble(input);



            if (choice == 1)
            {
                string num1;
                string num2;
                double length;
                double width;
                double area;

                WriteLine("Please enter two integers to calculate the rectangular area.\n");
                WriteLine("Length: \n");
                num1 = ReadLine();

                WriteLine("Width: \n");
                num2 = ReadLine();

                length = Convert.ToDouble(num1);
                width = Convert.ToDouble(num2);
                area = length * width;

                WriteLine("The area of the rectangle is {0}", area);
            }

            else if (choice == 2)

            {
                string num1;
                string num2;
                float triBase;
                float height;
                double area;
                double half = 0.5;

                WriteLine("Please enter two integers to calculate the triangular area.\n");
                WriteLine("Base: \n");
                num1 = ReadLine();

                WriteLine("Height: \n");
                num2 = ReadLine();

                triBase = float.Parse(num1);
                height = float.Parse(num2);
                area = (half * triBase * height);

                WriteLine("The triangular area is {0}", area);
            }

            else if (choice == 3)

            {
                string num1;
                double radius;
                double circumference;


                WriteLine("Please enter the circle's radius.\n");
                WriteLine("Radius: \n");
                num1 = ReadLine();
                radius = Convert.ToDouble(num1);
                circumference = (2 * 3.14 * radius);


                WriteLine("The circumference of the circle is {0}", circumference);
            }

            else if (choice == 4)

            {
                string s1 = "If you ain't first you're last";
                string s2 = "first";

                bool b = s1.Contains(s2);
                WriteLine("'{0}' is in the string '{1}': {2}", s2, s1, b);

                if (b)
                {
                    int index = s1.IndexOf(s2);
                    if (index >= 0)
                        WriteLine("'{0} starts at character position {1}", s2, index + 1);
                }


            }

            else if (choice == 5)
            {
                string sentence;
                string convert;

                WriteLine("Please type in a sentence.");
                sentence = ReadLine();

                convert = sentence.ToUpper();
                WriteLine(convert);

            }

            else if (choice == 6)
            {
                string sentence;
                string convert;

                WriteLine("Please type in a sentence.");
                sentence = ReadLine();

                convert = sentence.ToLower();
                WriteLine(convert);


            }

            else if (choice == 7)
            {
                WriteLine("Thank you for using Nathan's Simple Menu Program :D Hope you have a wonderful day!");

                return;
            }

               else 
                {

                WriteLine("Please enter a valid number");

                }

            } while (true);

        }
    }

