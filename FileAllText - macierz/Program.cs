using System.Globalization;
using System.IO;
class Program
{



    static void Main(string[] args)
    {
        int n = 10;
        int[,] macierz = new int[n, n];
        string Macierz = "";
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(i == j)
                {
                    macierz[i, j] += 1;
                } else
                {
                    macierz[i, j] += 0;
                }
            }
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Macierz += macierz[i, j] + " ";
            }
            Macierz += "\n";
        }
            File.WriteAllText("macierz.txt", Macierz);
        string odczyt = File.ReadAllText("macierz.txt");
        Console.WriteLine(odczyt);


    }
}