using System;
using System.Globalization;
using System.Threading;
namespace BridgeLabzApp.BasicCSharp
{
	public class BasicCSharp
	{
		public static void Variable()
		{
            bool value = true;
            Console.WriteLine(value);

            int age = 23;
            Console.WriteLine("Int->" + age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -900000000L;
            Console.WriteLine("Long->" + bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.5;
            Console.WriteLine("Double" + negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 22.2222F;
            Console.WriteLine("Float->" + precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 3222.22M;
            Console.WriteLine("decimal->" + money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            string name = "Srikesh";
            Console.WriteLine("string->" + name);

            char gender = '\0';
            gender = 'a';
            Console.WriteLine("Char->" + gender);

        }

        public static void TypeConverstion()
        {
            string textAge = "21";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);


            string longText = "10200202010";
            long longNum = Convert.ToInt64(longText);
            Console.WriteLine(longNum);

            string doubleText = "9898398232";
            double doubleNum = Convert.ToDouble(doubleText);
            Console.WriteLine(doubleNum);

            string floatText = "9898398232";
            float floatNum = Convert.ToSingle(floatText);
            Console.WriteLine(floatNum);

            string decimalText = "8.222333";
            decimal decimalNum = Convert.ToDecimal(decimalText);
            Console.WriteLine(decimalNum);
        }

        public static void Operator()
        {
            int age = 20;
            age++;
            age += 10;
            age -= 10;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);

            string name = "Srikesh";
            name += "is Programmer!";
            Console.WriteLine(name);

            char a = 'a';
            a += 'A';
            Console.WriteLine(a);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(++i);

            int firstNum = 10;
            int secondNum = 2;
            Console.WriteLine(firstNum / secondNum);
            Console.WriteLine(firstNum % secondNum);

            var intNumber = 23;
            Console.WriteLine(intNumber);

            var floatNumber = 232222F;
            Console.WriteLine(floatNumber);

            var strVal = "Sri";
            Console.WriteLine(strVal);

            const int VAT = 20;
            int balance = 01000;//zero wont matter and print
            //PI += 1; ERROR
            Console.WriteLine(balance * (VAT / 100D));


        }

        public static void IfStatement()
        {
            Console.WriteLine("Enter First number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter solution"+number1+"*"+number2);
            int solution = Convert.ToInt32(Console.ReadLine());
            if (solution == (number1 * number2))
            {
                Console.WriteLine("Correct Solution");
            }
            else
            {
                Console.WriteLine("Wrong Solution");
            }
        }

        public static void SwitchStatement()
        {
            int day = 0;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }

        public static void IterativeStatement()
        {
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine(i);
            }
            int j = 0;
            while (j<10)
            {
                Console.WriteLine(j);
                j++;
            }

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 0);

        }


        public static void TernaryOperator()
        {
            int age = 10;
            string result = age >= 0 ? "Valid" : "not valid";
            Console.WriteLine(result);
            Console.WriteLine(age >= 0 ? "Valid" : "not valid");
        }

        public static void NummericFormating()
        {
            double value = 10000D / 12D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}",value));
            double money = 10.000D;
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(money.ToString("C3"));
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));

        }

        public static void TryParseFunction()
        {
            string numString = "1n";
            bool success = int.TryParse(numString, out int num);
            Console.WriteLine(success);
            Console.WriteLine(num);
        }

        public static void VerbatimStringLiteral()
        {
            string speech = "he is \"this is \"";
            Console.WriteLine(speech);
            string path = "c:\\window\\new";
            Console.WriteLine(path);
            //verbatim String literal
            string path1 = @"\nthis\is ""workin""";
            Console.WriteLine(path1);

        }

        public static void StringFormating()
        {
            double ageIs = 21.0212;
            string nameIs = "Srikesh";
            Console.WriteLine("My name is {0} and age is {1:0}", nameIs, ageIs);
            Console.WriteLine($"My name is {nameIs} and age is {ageIs} ");
            string nameAndAge = String.Concat("My name is ", nameIs, "\nAge is ", ageIs);
            Console.WriteLine(nameAndAge);
        }
        public static void EmptyString()
        {
            string name = String.Empty;
            Console.WriteLine(name);
        }

        public static void EqualStringOrNot()
        {
            string name = "Srikesh";
            string name2 = "Srikesh";
            if (name == name2)
            {
                //both value and memory refrence is checked
            }
            if (name.Equals(name2))
            {
                //check only literal value
            }
        }

        public static void StringIteration()
        {
            string message = "Srikesh is name";
            //Console.WriteLine(message[0]);
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("S"));
        }

        public static void IsNullOrEmpty()
        {
            string? name = null;
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("is is null or empty");
            }
        }
        public BasicCSharp()
		{
            //int x;
            //int y;
            //int z;
            //initialization
            //int x = 10,
            //    y = 20,
            //z = 30;

            //Console.WriteLine(x + z);
            //Console.WriteLine(x + "21" + z);
            //Variable();
            //TypeConverstion();
            //Operator();
            //IfStatement();
            //SwitchStatement();
            //IterativeStatement();
            //TernaryOperator();
            //NummericFormating();
            //TryParseFunction();
            //VerbatimStringLiteral();
            //StringFormating();
            //EmptyString();
            //EqualStringOrNot();
            //StringIteration();
            IsNullOrEmpty();

        }
	}
}

