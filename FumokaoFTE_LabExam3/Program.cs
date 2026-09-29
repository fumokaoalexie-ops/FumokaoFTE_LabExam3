using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        string[] name = new string[4];
        int[,] score = new int[4, 3];
        int[] total = new int[4];
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("============================");
            Console.WriteLine("COMMUNITY FUN RUN SYSTEM");
            Console.WriteLine("============================");
            Console.WriteLine("[1] - RECORD SCORES");
            Console.WriteLine("[2] - SHOW PARTICIPANT SCORES");
            Console.WriteLine("[3] - SHOW RANKING");
            Console.WriteLine("[4] - EXIT");
            Console.WriteLine("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Player Name: ");
                    name[i] = Console.ReadLine();
                    total[i] = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Round " + (j + 1) + ": ");
                        score[i, j] = Convert.ToInt32(Console.ReadLine());
                        total[i] += score[i, j];
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("PARTICIPANTS SCORES");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(name[i] + "\t\t" +
                        score[i, 0] + "\t " +
                        score[i, 1] + "\t " +
                        score[i, 2] + "\t " +
                        total[i]);
                }
                Console.ReadKey();
            }
            else if (choice == 3)
            {
                for (int pass = 1; pass <= 2; pass++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (total[i] < total[i + 1])
                        {
                            int t = total[i];
                            total[i] = total[i + 1];
                            total[i + 1] = t;
                            string n = name[i];
                            name[i] = name[i + 1];
                            name[i + 1] = n;
                            for (int j = 0; j < 3; j++)
                            {
                                int s = score[i, j];
                                score[i, j] = score[i + 1, j];
                                score[i + 1, j] = s;
                            }
                        }
                }
                    Console.Write("Pass " + pass + ": ");
                    for (int i = 0; i < 3; i++)
                        Console.Write(total[i] + " ");
                    Console.WriteLine();

                }
                Console.Write("\nFUN RUN RANKING");
                for (int i = 0; i < 3; i++)
                    Console.Write((i + 1) + ". " + name[i] + " - " + total[i]);
                Console.WriteLine();

            }

        }while (choice != 4) ;
        Console.Write("Thankyou");
    }
}

