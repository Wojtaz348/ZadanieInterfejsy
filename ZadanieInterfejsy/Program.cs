// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Zadanie1
 interface IKalkulator
{
    double Dodaj(double a, double b);
    double Odejmij(double a, double b);
}

public class ProstyKalkulator : IKalkulator
{
    public double Dodaj(double a, double b)
    {
        return a + b;
    }

    public double Odejmij(double a, double b)
    {
        return a - b;
    }
}

public class aaaa
{
    static void Main()
    {
      
        IKalkulator kalkulator = new ProstyKalkulator();


        double wynikDodawania = kalkulator.Dodaj(5, 3);
        double wynikOdejmowania = kalkulator.Odejmij(8, 2);


        Console.WriteLine($"Wynik dodawania: {wynikDodawania}");
        Console.WriteLine($"Wynik odejmowania: {wynikOdejmowania}");

        Console.ReadKey();
    }
}

//zadanie2



public interface IDzialanieMatematyczne
{
    double Dodaj(double a, double b);
    double Odejmij(double a, double b);
    double Pomnoz(double a, double b);
    double Podziel(double a, double b);
    double Potegowanie(double x, double y);
}


public interface ILogowanie
{
    void ZalogujOperacje(string operacja);
}


public interface IStatystyki
{
    int LiczbaOperacji { get; }
    void ZwiekszLicznikOperacji();
}


public class ZaawansowanyKalkulator : IDzialanieMatematyczne, ILogowanie, IStatystyki
{
    private int liczbaOperacji;

    public double Dodaj(double a, double b)
    {
        ZwiekszLicznikOperacji();
        return a + b;
    }

    public double Odejmij(double a, double b)
    {
        ZwiekszLicznikOperacji();
        return a - b;
    }

    public double Pomnoz(double a, double b)
    {
        ZwiekszLicznikOperacji();
        return a * b;
    }

    public double Podziel(double a, double b)
    {
        ZwiekszLicznikOperacji();
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Błąd: Nie można dzielić przez zero.");
            return double.NaN;
        }
    }

    public double Potegowanie(double x, double y)
    {
        ZwiekszLicznikOperacji();
        return Math.Pow(x, y);
    }

    public void ZalogujOperacje(string operacja)
    {
        Console.WriteLine($"Log: {operacja}");
    }

    public int LiczbaOperacji => liczbaOperacji;

    public void ZwiekszLicznikOperacji()
    {
        liczbaOperacji++;
    }
}

class lol
{
    static void Main()
    {
        
        ZaawansowanyKalkulator kalkulator = new ZaawansowanyKalkulator();

        
        double wynikDodawania = kalkulator.Dodaj(5, 3);
        double wynikOdejmowania = kalkulator.Odejmij(8, 2);
        double wynikMnozenia = kalkulator.Pomnoz(4, 6);
        double wynikDzielenia = kalkulator.Podziel(9, 3);
        double wynikPotegowania = kalkulator.Potegowanie(2, 3);

        
        Console.WriteLine($"Wynik dodawania: {wynikDodawania}");
        Console.WriteLine($"Wynik odejmowania: {wynikOdejmowania}");
        Console.WriteLine($"Wynik mnożenia: {wynikMnozenia}");
        Console.WriteLine($"Wynik dzielenia: {wynikDzielenia}");
        Console.WriteLine($"Wynik potęgowania: {wynikPotegowania}");

       
        kalkulator.ZalogujOperacje("Wykonano kilka operacji matematycznych.");

        
        Console.WriteLine($"Liczba operacji: {kalkulator.LiczbaOperacji}");

        
        Console.ReadKey();
    }
}
//zadanie3
interface IDrukarka
{
    void Drukuj();
}

public class DrukarkaLaserowa : IDrukarka
{
    
    void IDrukarka.Drukuj()
    {
        Console.WriteLine("Drukowanie (niejawnie)...");
    }

   
    public void Drukuj()
    {
        Console.WriteLine("Drukowanie (jawne)...");
    }
}

class Drukowanie
{
    static void Main()
    {
      
        DrukarkaLaserowa drukarka = new DrukarkaLaserowa();

        
        ((IDrukarka)drukarka).Drukuj();

        
        drukarka.Drukuj();

        
        Console.ReadKey();
    }
}

//Zadanie5


public interface ILogowanie1
{
    void Loguj(string wiadomosc);
}


public class Uzytkownik
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
}


public static class LogowanieRozszerzenia
{
    public static void Loguj(this Uzytkownik uzytkownik, string wiadomosc)
    {
        Console.WriteLine($"Log: {uzytkownik.Imie} {uzytkownik.Nazwisko} - {wiadomosc}");
    }
}

class Logowanie
{
    static void Main()
    {
    
        Uzytkownik uzytkownik = new Uzytkownik
        {
            Imie = "Jacek",
            Nazwisko = "Mak"
        };

        
        uzytkownik.Loguj("Użytkownik zalogowany.");

       
        Console.ReadKey();
    }
}

//zadanie5

public interface IDzwiek
{
    void OdtwarzajDzwiek();
}

public class Samochod : IDzwiek
{
    public void OdtwarzajDzwiek()
    {
        Console.WriteLine("Dźwięk samochodu: Brum brum");
    }
}


public class Telefon : IDzwiek
{
    public void OdtwarzajDzwiek()
    {
        Console.WriteLine("Dźwięk telefonu: Dzwonek dzwonek");
    }
}

class Dzwiek
{
    static void Main()
    {
       
        List<IDzwiek> listaDzwiekow = new List<IDzwiek>();

        listaDzwiekow.Add(new Samochod());
        listaDzwiekow.Add(new Telefon());

        foreach (var obiektDzwiekowy in listaDzwiekow)
        {
            obiektDzwiekowy.OdtwarzajDzwiek();
        }

        
        Console.ReadKey();
    }
}