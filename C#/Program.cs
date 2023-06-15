using System.Drawing;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exceptionTriger = false;
            try
            {
                string? name = null;
                int? age = null;
                bool? isAlive = null;
                Console.Write("Input name: ");
                name = Console.ReadLine();
                Console.Write("Input age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input is Alive: ");
                isAlive = Convert.ToBoolean(Console.ReadLine());
                if (isAlive == false)
                {
                    exceptionTriger = true;
                    throw new ApplicationException("The person is dead!");
                }
                Console.WriteLine($"Name: {name}, Age: {age}, isAlive: {isAlive}.");
            }
            catch (ApplicationException ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ApplicationException -> ");
                Console.WriteLine(ex.Message);
                Console.ReadKey(); Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Exception -> ");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Console.ResetColor();
            }
            finally
            {
                if (exceptionTriger == true)
                {
                    Console.WriteLine("Exit app with exception...");
                }
                else
                {
                    Console.WriteLine("Exit app...");
                }
            }
        }
    }
}
