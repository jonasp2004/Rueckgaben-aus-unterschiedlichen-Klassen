using Rückgaben_aus_unterschiedlichen_Klassen;

namespace rauk {
    class Program {
        static void Main() {
            Console.WriteLine("Hallo!\nWie heißen Sie?");
            string name = Console.ReadLine().ToString();
            Console.WriteLine("Guten Tag, " + Verarbeitung.Anrede(name) + name + "!\nWie Alt sind Sie?\n");
            try {
                int Alter = Convert.ToInt32(Console.ReadLine());
                if(Verarbeitung.Alter(Alter) == true) {
                    Console.WriteLine("Guten Tag, " + Verarbeitung.Anrede(name) + name + "! Sie dürfen dieses Programm benutzen!");
                } else {
                    Console.WriteLine(Verarbeitung.Anrede(name) + name + ", Sie sind nicht dazu berechtigt, dieses Programm zu nutzen!");
                }
                Console.Read();
            } catch (Exception ex) {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Read();
                Main();
            }
        }
    }
}