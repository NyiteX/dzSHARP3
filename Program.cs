class Programm
{
    static void Main()
    {
        char vvod;
        do
        {
            Console.Clear();
            Console.WriteLine("1.Part 1\n2.Part 2\n3.Part 3\n4.Part 4\n5.Part 5\n6.Part 6\n");
            vvod = Console.ReadKey().KeyChar;

            switch (vvod)
            {
                case '1':
                    {
                        Console.Clear();
                        int symbol = 31;
                        Console.Write("Enter code for symbol or symbol: ");
                        try
                        {
                            symbol = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }
                        catch (Exception) { }
                  
                        Shape S = new Shape(5, symbol);
                        S.Zapolnenie();
                        S.PrintShape();
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '2':
                    {
                        Console.Clear();
                        
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '3':
                    {
                        Console.Clear();

                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '4':
                    {
                        Console.Clear();
                      
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '5':
                    {
                        Console.Clear();
                                         
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '6':
                    {
                        Console.Clear();
                        
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
            }
        } while (vvod != 27);
    }
}

class Shape
{
    private int x;
    private char[,] figure;
    char symbol;
    public Shape(int x, char symb)
    {
        this.x = x;
        figure = new char[x, x];
        this.symbol = symb;
    }
    public Shape(int x, int symb)
    {
        this.x = x;
        figure = new char[x, x];
        this.symbol = Convert.ToChar(symb);
    }
    public void Zapolnenie()
    {
        for (int i = 0; i < x; i++)
            for (int u = 0; u < x; u++)
                figure[i, u] = symbol;
    }
    public void PrintShape()
    {
        for (int i = 0; i < x; i++)
        {
            for (int u = 0; u < x; u++)
                Console.Write(figure[i, u] + "  ");
            Console.WriteLine();
        }
    }



}
