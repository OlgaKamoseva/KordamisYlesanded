using System.ComponentModel.Design;

namespace Mathinput1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//1. kirjuta programm, mis
			//omab täisarvu muutujat vanuse jaoks
			//küsib kasutajalt tema vanust. int.Parse() üritab muuta andmeid tekstist arvuks
			//omab täisarvu muutujat aastaarvu jaoks
			//küsib kasutajalt praegust kalendriaastat. int.Parse() üritab muuta andmeid tekstist arvuks
			//omab muutujat sünniaasta jaoks, siia sisse omimstatakse tehte tulemus, kus aastaarvust lahutatakse vanus

			/*     L E T' S   S T A R T   */

			int vanus = 0;
			Console.WriteLine("Kui vana sa oled?");
			vanus = int.Parse(Console.ReadLine());
			int aasta = 0;
			Console.WriteLine("Mis aasta hetkel on?");
			aasta = int.Parse(Console.ReadLine());
			Console.WriteLine("Kas sul juba oli sunnipaev sel aastal? (jah/ei)");
			string vastus = Console.ReadLine(); 
			int synniaasta = aasta - vanus;
			if (vastus == "jah")
			{

				Console.WriteLine($"Ahhaa, oled sündinud {synniaasta}'l aastal! ");
			}
			else
			{
				Console.WriteLine($"Ahhaa, oled sündinud {synniaasta - 1}'l aastal! ");
			}
		}
	}
}
