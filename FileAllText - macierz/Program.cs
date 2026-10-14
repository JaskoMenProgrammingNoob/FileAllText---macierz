using System.Globalization;
using System.IO;
class Program
{



    static void Main(string[] args)
    {
        
        
        string Macierz = "";
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if(i == j)
                {
                    Macierz += "1 ";
                } else
                {
                    Macierz += "0 ";
                }
                
            }
                Macierz += "\n";
            
        }
        
            File.WriteAllText("macierz.txt", Macierz);
        string odczyt = File.ReadAllText("macierz.txt");
        Console.WriteLine(odczyt);


    }
}