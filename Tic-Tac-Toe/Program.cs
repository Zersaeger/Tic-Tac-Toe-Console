class Program
{
    public static void Main(string[] args)
    {
        Game();
    }
    public static void Game()
    {
        string input = "";
        int place = 0;
        string[] field = new string[9];
        bool xOrY = true;
        for(int i = 0; i < 9; i++)
        {
            field[i] = "/";
        }
        while (true)
        {
            Console.Write(field[0]);
            Console.Write(field[1]);
            Console.Write(field[2] + "\n");
            Console.Write(field[3]);
            Console.Write(field[4]);
            Console.Write(field[5] + "\n");
            Console.Write(field[6]);
            Console.Write(field[7]);
            Console.Write(field[8] + "\n");
            Console.Write("Where do you want to set you sign?: ");
            input = Console.ReadLine();
            place = int.Parse(input);
            if (place <= 0 || place > 9)
            {
                Console.Clear();
                continue;
            }

            if (xOrY)
            {
                if(field[place-1] == "O")
                {
                    Console.Clear();
                    continue;
                }
                field[place-1] = "X";
                Console.Clear();
                xOrY = false;
                Console.Clear();
            }
            else if (!xOrY)
            {
                if (field[place - 1] == "X")
                {
                    Console.Clear();
                    continue;
                }
                field[place-1] = "O";
                xOrY = true;
                Console.Clear();
            }
            
            if (field[0] == field[1] && field[1] == field[2] && field[0] != "/")
            {
                Console.WriteLine(field[0] + " wins! Congratulations!!!");
                break;
            }
            else if(field[0] == field[3] && field[3] == field[6] && field[0] != "/")
            {
                Console.WriteLine(field[0] + " wins! Congratulations!!!");
                break;
            }
            else if (field[0] == field[4] && field[4] == field[8] && field[0] != "/")
            {
                Console.WriteLine(field[0] + " wins! Congratulations!!!");
                break;
            }
            else if (field[1] == field[4] && field[4] == field[7] && field[1] != "/")
            {
                Console.WriteLine(field[1] + " wins! Congratulations!!!");
                break;
            }
            else if (field[2] == field[5] && field[5] == field[8] && field[2] != "/")
            {
                Console.WriteLine(field[2] + " wins! Congratulations!!!");
                break;
            }
            else if (field[3] == field[4] && field[4] == field[5] && field[3] != "/")
            {
                Console.WriteLine(field[3] + " wins! Congratulations!!!");
                break;
            }
            else if (field[6] == field[7] && field[7] == field[8] && field[6] != "/")
            {
                Console.WriteLine(field[6] + " wins! Congratulations!!!");
                break;
            }
            else if (field[2] == field[4] && field[4] == field[6] && field[2] != "/")
            {
                Console.WriteLine(field[2] + " wins! Congratulations!!!");
                break;
            }

        }
        
    }
}
