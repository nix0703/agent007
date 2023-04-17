using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                while (true)
                {
                    Console.WriteLine("Kalkulator");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Sinus");
                    Console.WriteLine("6. Cosinus");
                    Console.WriteLine("7. Tangens");
                    Console.WriteLine("8. Kotangens");
                    Console.WriteLine("9. Pierwiastek");
                    Console.WriteLine("0. Masa czarnej dziury");
                    Console.WriteLine("------------------------------------");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Podaj pierwszą liczbę: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.Write("Podaj drugą liczbę: ");
                            double num2 = double.Parse(Console.ReadLine());
                            double sum = num1 + num2;
                            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
                            break;

                        case 2:
                            Console.Write("Podaj pierwszą liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Podaj drugą liczbę: ");
                            num2 = double.Parse(Console.ReadLine());
                            double difference = num1 - num2;
                            Console.WriteLine("{0} - {1} = {2}", num1, num2, difference);
                            break;

                        case 3:
                            Console.Write("Podaj pierwszą liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Podaj drugą liczbę: ");
                            num2 = double.Parse(Console.ReadLine());
                            double product = num1 * num2;
                            Console.WriteLine("{0} * {1} = {2}", num1, num2, product);
                            break;

                        case 4:
                            Console.Write("Podaj pierwszą liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Podaj drugą liczbę: ");
                            num2 = double.Parse(Console.ReadLine());
                            if (num2 == 0)
                            {
                                Console.WriteLine("Nie można dzielić przez zero!");
                            }
                            else
                            {
                                double quotient = num1 / num2;
                                Console.WriteLine("{0} / {1} = {2}", num1, num2, quotient);
                            }
                            break;

                        case 5:
                            Console.Write("Podaj liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            double sinValue = Math.Sin(num1);
                            Console.WriteLine("Sinus({0}) = {1}", num1, sinValue);
                            break;

                        case 6:
                            Console.Write("Podaj liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            double cosValue = Math.Cos(num1);
                            Console.WriteLine("Cosinus({0}) = {1}", num1, cosValue);
                            break;

                        case 7:
                            Console.Write("Podaj liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            double tanValue = Math.Tan(num1);
                            Console.WriteLine("Tangens({0}) = {1}", num1, tanValue);
                            break;

                        case 8:
                            Console.Write("Podaj liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            double cotValue = 1 / Math.Tan(num1);
                            Console.WriteLine("Kotangens({0}) = {1}", num1, cotValue);
                            break;

                        case 9:
                            Console.Write("Podaj liczbę: ");
                            num1 = double.Parse(Console.ReadLine());
                            double sqrtValue = Math.Sqrt(num1);
                            Console.WriteLine("Pierwiastek({0}) = {1}", num1, sqrtValue);
                            break;

                        case 0:
                            Console.Write("Podaj masę czarnej dziury w kg: ");
                            double mass = double.Parse(Console.ReadLine());
                            double radius = (2 * 6.6743e-11 * mass) / (29979 * 2997);
                            Console.WriteLine("Promień czarnej dziury wynosi {0} metrów", radius);
                            break;

                        default:
                            Console.WriteLine("Nieprawidłowa operacja!");
                            break;
                    }

                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                       
                    Console.ReadKey();
            }
        }
    }
}
    

