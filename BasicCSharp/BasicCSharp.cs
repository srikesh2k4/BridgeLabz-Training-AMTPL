using System;
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
        public BasicCSharp()
		{
            //int x;
            //int y;
            //int z;
            //initialization
            int x = 10,
            //    y = 20,
                z = 30;

            Console.WriteLine(x + z);
            Console.WriteLine(x + "21" + z);
            Variable();
            TypeConverstion();
            Operator();

        }
	}
}

