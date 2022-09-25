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
                        Palindrom P = new Palindrom();
                        P.Vvod();
                        if(P.getPalindrom())
                            Console.WriteLine("Palindom");
                        else
                            Console.WriteLine("Not palindrom");
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '3':
                    {
                        Console.Clear();
                        string? str;
                        MyArray Mas = new();
                        Mas.PrintMas();
                        Console.Write("Enter filter numbers: ");
                        str = Console.ReadLine();
                        Mas.FilterMas(str);
                        Mas.PrintMas();
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
class Palindrom
{
    private int number;
    public Palindrom(int n = 0) { number = n; }
    public bool Prover(string str)
    {
        if (str.Length > 0)
        {
            for (int i = 0; i < str.Length; i++)
                if (!Char.IsDigit(str[i]))
                    return false;
            return true;
        }
        return false;
    }
    public void Vvod()
    {
        string? str = "ae";
        Console.WriteLine("Enter number: ");
        while(!Prover(str))
        {
            str = Console.ReadLine();
            if (!Prover(str)) Console.WriteLine("Wrong input.");
        }
        number = int.Parse(str);
    }
    public string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public bool getPalindrom()
    {
        string Rev = Reverse(number.ToString());
        if (Rev != number.ToString())
            return false;
        return true;
    }
}
class MyArray
{
    private int[] mas;
    private Random r = new Random();
    public MyArray(int k = 10)
    {
        mas = new int[k];
        Rand();
    }
    public void Rand()
    {
        for (int i = 0; i < mas.Length; i++)
            mas[i] = r.Next(10,50);
    }
    public void PrintMas()
    {
        for (int i = 0; i < mas.Length; i++)
            Console.Write(mas[i]+"  ");
        Console.WriteLine();
    }
    public void FilterMas(string filterStr)
    {
        int k = 0;
        int[] filterMas = null;
        {
            int[] temp = new int[filterStr.Length];
            bool flag = false;
            for (int i = 0; i < filterStr.Length; i++)
            {
                if (Char.IsDigit(filterStr[i]))
                {
                    if (flag)
                    {
                        k++;
                        flag = false;
                    }
                    temp[k] = temp[k] * 10 + (filterStr[i] - 48);
                }
                else
                    flag = true;
                if(i == filterStr.Length - 1)
                {
                    filterMas = new int[k+1];
                    for (int l = 0; l < filterMas.Length; l++)
                    {
                        filterMas[l] = temp[l];
                    }
                }
            }
        }
        for (int i = 0; i < filterMas.Length; i++)
            Console.Write(filterMas[i] + "  ");
        Console.WriteLine();

        k = 0;
        int[] tmpMas = new int[mas.Length-filterMas.Length];
        for (int i = 0; i < mas.Length; i++)
        {
            bool f = true;
            for (int u = 0; u < filterMas.Length; u++)
                if (mas[i] == filterMas[u])
                {
                    f = false;
                    break;
                }
            if (f)
                tmpMas[k++] = mas[i];
        }

        mas = new int[k];
        for (int i = 0; i < mas.Length; i++)
            mas[i] = tmpMas[i];
    }
}