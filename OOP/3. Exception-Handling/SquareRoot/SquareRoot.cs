using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SquareRoot
{
    static void Main(string[] args)
    {

        try
        {
            int num = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(num);
            Console.WriteLine(result);
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Number shoud be positive!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is to big!");
        }
        catch (Exception)
        {
            Console.WriteLine("Ivalid number!");
        }
        finally
        {
            Console.WriteLine("Good Bye!");
        }    
    }
}

