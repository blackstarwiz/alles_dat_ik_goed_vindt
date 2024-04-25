namespace GanzenBord_SinglePlayer
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkome Player to the Game GanzenBord");
            Console.WriteLine("Wil je kleurenersie (1) of de zwart-wit versie (2)");
            int keuze = int.Parse(Console.ReadLine());

            bool kleurenVersie = (keuze == 1);
             if(kleurenVersie)
                Console.WriteLine("---Gekozen versie: Kleuren");
            Console.WriteLine("---Gekozen versie: Zwart-Wit");

            Ganzenbord ganzenbord = new Ganzenbord(kleurenVersie);
            bool isFinished = false;

            while (!isFinished)
            {
                Console.Clear();
                ganzenbord.TekenBord();

                int aantalStappen = Dobbelsteen.Rol();
                Console.WriteLine("Je rolde: " + aantalStappen);
                Console.WriteLine("Druk op Enter om verder te gaan.");
                
                
                
                Console.ReadLine();

                isFinished = ganzenbord.BeweegPion(aantalStappen);
            }

            Console.WriteLine("Huidige score: " + ganzenbord.HuidigeScore);
        }
    }
}