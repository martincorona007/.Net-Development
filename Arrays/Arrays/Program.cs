using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program:arrays
    {
        static int[] uni;
        static int[,] bidi;
        static bool flag_0=false;
        static bool flag_1=false;
        static int[,] bidi_aux;
        static int[,] aux_A;
        static int[,] aux_B;


        static void Main(string[] args)
        {

            int op, np, nu = 0, ro = 0, col = 0, ro1 = 0, col1 = 0, aux, aux1;

            arrays obj = new arrays();
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 Perfect number");
                Console.WriteLine("2 Read Vector");
                Console.WriteLine("3 Read Matrix");
                Console.WriteLine("4 Sum Vector numbers");
                Console.WriteLine("5 Sum Matrix numbers");
                Console.WriteLine("6 Multiplication matrix by matrix");
                Console.WriteLine("7 Exit");
                Console.WriteLine("Write the option");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nPerfect Number\n");
                        Console.WriteLine("\nWrite a number: ");
                        np = Convert.ToInt32(Console.ReadLine());
                        if (obj.calc_perfect(np))
                        {
                            Console.WriteLine("\nPerfect Number\n");
                        }
                        else
                        {
                            Console.WriteLine("\nIs not Number\n");

                        }
                        break;
                    case 2:
                        Console.WriteLine("\nRead Vector\n");
                        Console.WriteLine("How many numbers? ");
                        nu = Convert.ToInt32(Console.ReadLine());
                        uni = obj.read_vector(nu);
                        obj.print_vector(uni);
                        flag_0 = true;
                        break;
                    case 3:
                        Console.WriteLine("\n3 Read Matrix");
                        Console.WriteLine("How many rows? ");
                        ro = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many columns? ");
                        col = Convert.ToInt32(Console.ReadLine());
                        bidi = obj.read_matrix(ro, col);
                        obj.print_matrix(bidi);
                        flag_1 = true;
                        break;
                    case 4:
                        if (flag_0==false)
                        {
                            Console.WriteLine("\nNel merenges you must first write the size of the vector\n");
                        }
                        else
                        {
                            Console.WriteLine("\n4 Sum Vector numbers");
                            aux = obj.sum_vector(uni);
                            Console.WriteLine("The sum [{0}]", aux);
                        }
                        
                        break;
                    case 5:
                        if (flag_1 == false)
                        {
                            Console.WriteLine("\nNel merenges you must first write the size of the matrix\n");
                        }
                        else
                        {
                            Console.WriteLine("\n4 Sum Matrix numbers");
                            aux1 = obj.sum_matrix(bidi);

                            Console.WriteLine("The sum [{0}]", aux1);

                        }
                        break;
                    case 6:
                        Console.WriteLine("Multiplication Matrix by Matrix");
                        Console.WriteLine("Read Matrix 1");
                        Console.WriteLine("How many rows? ");
                        ro = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many columns? ");
                        col = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        aux_A = obj.read_matrix_A(ro, col);
                        obj.print_matrix(aux_A);
                        Console.WriteLine("\n");
                        Console.WriteLine("Read Matrix 2");
                        Console.WriteLine("How many rows? ");
                        ro1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many columns? ");
                        col1 = Convert.ToInt32(Console.ReadLine());
                        aux_B = obj.read_matrix_B(ro, col);
                        obj.print_matrix(aux_B);
                        bidi_aux = obj.multiplication_matrix(aux_A, aux_B);
                        Console.WriteLine("\n");
                        Console.WriteLine("Result:");
                        obj.print_matrix(bidi_aux);
                        Console.WriteLine("\n");

                        break;
                    case 7:
                        op = 7;
                        break;

                }

            } while (op != 7);

        }
    }
}
