using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200921
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //nothing
            int[] tomb = new int[100];
            //feltöltés
            for (int i = 0; i < tomb.Length; i++) {
                tomb[i] = rnd.Next(4, 34) * 3;
            }
            //kiírás
            for (int i = 0; i < tomb.Length; i++) {
                Console.Write($"{tomb[i]} ");
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }
            //elemek összege
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++) {
                osszeg += tomb[i];
            }
            Console.WriteLine($"Elemek összege: {osszeg}");
            //legnagyobb elem indexe
            int legnagyobb = 0;
            for (int i = 0; i < tomb.Length; i++) {
                if (tomb[i] > tomb[legnagyobb]) {
                    legnagyobb = i;
                }
            }
            Console.WriteLine($"A tömb legnagyobb elemének indexe: {legnagyobb}");
            //legkisebb elem
            int legkisebb = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < tomb[legkisebb])
                {
                    legkisebb = i;
                }
            }
            Console.WriteLine($"A tömb legkisebb eleme: {tomb[legkisebb]}");
            //30 és 50 közötti elemek száma
            int kozott = 0;
            for (int i = 0; i < tomb.Length; i++) {
                if (tomb[i] >= 30 && tomb[i] <= 50) {
                    kozott++;
                }
            }
            Console.WriteLine($"A tömb 30 és 70 közötti elemeinek száma: {kozott}");
            //szerepel-e a 66
            int szerepel = 0;
            while (szerepel < tomb.Length && tomb[szerepel] != 66)   {
                szerepel++;
            }
            if (szerepel >= tomb.Length) Console.WriteLine("Nem szerepel a tömbben 66");
            else Console.WriteLine("Szerepel a tömbben 66");





            Console.ReadKey();

        }
    }
}
