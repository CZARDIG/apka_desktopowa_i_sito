/*****************************************
 * Nazwa funkcji:           sito
 * Parametry wejściowe:     tablica składająca się z wartości logicznych true
 * Wartość zwracana         brak
 * Informacje:              Aplikacja wyszukuje liczby pierwsze w zbiorze 2...100
 * Autor:                   Cezary Sobocinski
 * ***************************************/


internal class Program
{
    private static void Main(string[] args)
    {
        int n = 100;
        bool[] pierwsze = new bool[n];
        sito(pierwsze);
        wyswietl(pierwsze);
    }

    static void sito(bool[] pierwsze)
    {
        int n = pierwsze.Length - 1;
        double sqrtP = Math.Sqrt(n);

        // Wypelnianie tablicy wartoscia true
        for(int i = 0; i < n; i++)
        {
            pierwsze[i] = true;
        }

        // Sito

        for(int i = 2;i <= sqrtP; i++)
        {
            {
                for(int j = i * i; j <= n; j += i)
                {
                    pierwsze[j] = false;
                }
            }
        }
    }

    static void wyswietl(bool[] pierwsze)
    {
        for(int i = 2;i < pierwsze.Length;i++)
        {
            if(pierwsze[i])
            {
                Console.Write(i + ",");
            }
        }
    }
}