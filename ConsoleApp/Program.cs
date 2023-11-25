namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*
			 * 1.Ініціалізувати цілу числову змінну x та присвоїти їй значення 10.
			 * 2.Ініціалізувати строку str з текстом "Hi from Hillel" та вивести її в консоль.
			 * 3.Ініціалізувати цілу числову змінну y та присвоїти значення x і ще додати 5.
			 * 4.Написати окремий метод Sum, що буде приймати два числа, а повертати їх суму.
			 */

            //START CODE HERE			

            int x = 10;

            string str = "Hi from Hillel";

            int y = x + 5;

            static int Sum(int num1,int num2)
            {
                return num1 + num2;
            }

            // END CODE HERE

            // Uncomment next code to check results

             Console.WriteLine(str);
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(Sum(x,y));

            /* Expected results:
			 * 
			 * Hi from Hillel
			 * 10
			 * 15
			 * 25
			 * 
			 */
        }

        // START CODE METHOD HERE			


        // END CODE METHOD HERE
    }
}
