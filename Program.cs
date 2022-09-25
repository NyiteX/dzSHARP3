using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;

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
                        WebSite Site = new WebSite();
                        Console.Write("Name: ");
                        Site.setName(Console.ReadLine());
                        Console.Write("Url: ");
                        Site.setUrl(Console.ReadLine());
                        Console.Write("Path: ");
                        Site.setPath(Console.ReadLine());
                        Console.Write("IP: ");
                        Site.setIP(Console.ReadLine());
                        Console.Write("Discription.");
                        Site.setDiscription();
                        Console.WriteLine();
                        Site.Print_All();
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '5':
                    {
                        Console.Clear();
                        Journal J = new();
                        Console.Write("Name: ");
                        J.setName(Console.ReadLine());
                        Console.Write("Email: ");
                        J.setEmail(Console.ReadLine());
                        Console.Write("Phone: ");
                        J.setPhone(Console.ReadLine());
                        Console.Write("Year.");
                        J.setYear();
                        Console.Write("Discription.");
                        J.setDiscription();
                        Console.WriteLine();
                        J.Print_All();
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    }
                case '6':
                    {
                        Console.Clear();
                        Console.WriteLine("3 последних задания - извращения какие-то =\\\n");
                        Magazine J = new();
                        Console.Write("Name: ");
                        J.setName(Console.ReadLine());
                        Console.Write("Email: ");
                        J.setEmail(Console.ReadLine());
                        Console.Write("Phone: ");
                        J.setPhone(Console.ReadLine());
                        Console.Write("Discription.");
                        J.setDiscription();
                        Console.WriteLine();
                        J.Print_All();
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
    public void FilterMas(string? filterStr)
    {
        try {
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
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
}
class WebSite
{
    private string? name, url, discription, ip, path;
    public WebSite() { }
    public WebSite(string? name, string? url, string? discription, string? ip, string? path)
    {
        this.name = name;
        this.url = url;
        this.discription = discription;
        this.ip = ip;
        this.path = path;
    }

    public void setName(string n) { name = n; }
    public void setUrl(string u) { url = u; }
    public void setDiscription() { discription = Vvod(); }
    public void setIP(string p) { ip = p; }
    public void setPath(string p) { path = p; }
    public string getName() { return name; }
    public string getUrl() { return url; }
    public string getDiscription() { return discription; }
    public string getIP() { return ip; }
    public string getPath() { return path; }
    public void Print_All()
    {
        Console.WriteLine("Name: " + name + "\nUrl: " + url + "\nIP: " + ip);
        Console.WriteLine("Path: " + path + "\nDiscription: " + discription);
    }
    public string Vvod()
    {
        string? str;
        Console.WriteLine("Enter text here: ");
        str = Console.ReadLine();

        char[] str2 = str.ToCharArray();
        bool first = true;
        for (int i = 0; i < str2.Length; i++)
        {
            if (first && Char.IsLetter(str[i]))
            {
                str2[i] = Char.ToUpper(str2[i]);
                first = false;
            }
            if (i > 0)
            {
                if (str[i - 1] == '.' || str[i - 1] == '!' || str[i - 1] == '?')
                {
                    while (!Char.IsLetter(str[i]))
                    {
                        if (i + 1 < str2.Length)
                            i++;
                        else
                            break;
                    }
                    str2[i] = Char.ToUpper(str2[i]);
                }
            }
        }
        return new string(str2);
    }
}
class Journal
{
    private string? name;
    private string? email;
    private string? phone, discription;
    private int year;

    public Journal(string? name = "Alo", string? email = "alo@gmail.com", string? phone = "+380923891823", int year = 1923)
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.year = year;
    }
    public void setName(string? nam) { this.name = nam; }
    public void setEmail(string? email) { this.email = email; }
    public void setPhone(string? phone) { this.phone = phone; }
    public void setDiscription() { discription = Vvod(); }
    public void setYear() { VvodYear(); }
    public string getName() { return name; }
    public string getEmail() { return email; }
    public string getPhone() { return phone; }
    public string getDiscription() { return discription; }
    public int getYear() { return year; }
    public void Print_All()
    {
        Console.WriteLine("Name: " + name + "\nEmail: " + email + "\nPhone: " + phone);
        Console.WriteLine("Year: " + year + "\nDiscription: " + discription);
    }
    public bool Prover(string? str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (!Char.IsDigit(str[i]))
                return false;
        }
        return true;
    }
    public string Vvod()
    {
        string? str;
        Console.WriteLine("Enter text here: ");
        str = Console.ReadLine();

        char[] str2 = str.ToCharArray();
        bool first = true;
        for (int i = 0; i < str2.Length; i++)
        {
            if (first && Char.IsLetter(str[i]))
            {
                str2[i] = Char.ToUpper(str2[i]);
                first = false;
            }
            if (i > 0)
            {
                if (str[i - 1] == '.' || str[i - 1] == '!' || str[i - 1] == '?')
                {
                    while (!Char.IsLetter(str[i]))
                    {
                        if (i + 1 < str2.Length)
                            i++;
                        else
                            break;
                    }
                    str2[i] = Char.ToUpper(str2[i]);
                }
            }
        }
        return new string(str2);
    }
    public void VvodYear()
    {
        string? str = "as";
        Console.WriteLine("Введите год основания " + "'" + name + "'");
        while (str.Length<1 || !Prover(str) || int.Parse(str) > 2022 || int.Parse(str) < 1500)
        {
            str = Console.ReadLine();
            if (str.Length < 1 || !Prover(str) || int.Parse(str) > 2022 || int.Parse(str) < 1500)
                Console.WriteLine("Ошибка. Введите цифры от 1500 до 2022.");
        }
        year = int.Parse(str);
    }
}
class Magazine
{
    private string? name;
    private string? email;
    private string? phone, discription;

    public Magazine(string? name = "Alo", string? email = "alo@gmail.com", string? phone = "+380923891823")
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
    }
    public void setName(string? nam) { this.name = nam; }
    public void setEmail(string? email) { this.email = email; }
    public void setPhone(string? phone) { this.phone = phone; }
    public void setDiscription() { discription = Vvod(); }

    public string getName() { return name; }
    public string getEmail() { return email; }
    public string getPhone() { return phone; }
    public string getDiscription() { return discription; }

    public void Print_All()
    {
        Console.WriteLine("Name: " + name + "\nEmail: " + email + "\nPhone: " + phone);
        Console.WriteLine("Discription: " + discription);
    }
    public string Vvod()
    {
        string? str;
        Console.WriteLine("Enter text here: ");
        str = Console.ReadLine();

        char[] str2 = str.ToCharArray();
        bool first = true;
        for (int i = 0; i < str2.Length; i++)
        {
            if (first && Char.IsLetter(str[i]))
            {
                str2[i] = Char.ToUpper(str2[i]);
                first = false;
            }
            if (i > 0)
            {
                if (str[i - 1] == '.' || str[i - 1] == '!' || str[i - 1] == '?')
                {
                    while (!Char.IsLetter(str[i]))
                    {
                        if (i + 1 < str2.Length)
                            i++;
                        else
                            break;
                    }
                    str2[i] = Char.ToUpper(str2[i]);
                }
            }
        }
        return new string(str2);
    }
}