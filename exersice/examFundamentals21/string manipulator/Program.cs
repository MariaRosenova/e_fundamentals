using System;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        string inputs = Console.ReadLine();
        StringBuilder sb = new StringBuilder(inputs);

        string[] commands = Console.ReadLine().Split(" ");

        while (commands[0] != "End")
        {
            if (commands[0] == "Translate")
            {
                sb.Replace(commands[1], commands[2]);
                Console.WriteLine(sb);
            }
            else if (commands[0] == "Includes")
            {
                if (sb.ToString().Contains(commands[1]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (commands[0] == "Start")
            {
                int b = commands[1].Length;
                if (commands[1] == sb.ToString().Substring(0, b))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (commands[0] == "Lowercase")
            {
                for (int i = 0; i < sb.ToString().Length - 1; i++)
                {
                    sb[i] = char.Parse(sb[i].ToString().ToLower());
                }
                Console.WriteLine(sb);
            }
            else if (commands[0] == "FindIndex")
            {
                Console.WriteLine(sb.ToString().LastIndexOf(commands[1]));
            }
            else if (commands[0] == "Remove")
            {
                sb.Remove(int.Parse(commands[1]), int.Parse(commands[2]));
                Console.WriteLine(sb);
            }



            commands = Console.ReadLine().Split(" ");
        }
    }
}