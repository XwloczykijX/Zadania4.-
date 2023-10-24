using System.ComponentModel.Design;

class Kolo
{
    public double Obwod(double r)
    {
        double obw = 2 * Math.PI *r;
        return obw;
    }
}

internal class program
{
    static void TestKola1()
    {
        // wczytanie danych
        Console.Write("Podaj promień: ");
        double r = Double.Parse(Console.ReadLine());
        // tworzenie instancji klasy Kolo
        Kolo k = new Kolo();
        // wywolanie metody Obwod
        double obw = k.Obwod(r);
        // wypisanie wyniku
        Console.WriteLine("Obwod koła o promieniu {0:0.00} wynosi:{1:0.00}", r, obw);
    }
    public static void Main(string[] args)
    {
        TestKola1();
    }
}