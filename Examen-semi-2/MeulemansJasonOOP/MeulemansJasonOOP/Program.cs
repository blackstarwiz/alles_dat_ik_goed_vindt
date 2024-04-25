namespace MeulemansJasonOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantaldozen = 0;
            Console.WriteLine("Geef SchipNaaam in:");
            string NaamSchip = Console.ReadLine();

            DHLSchip schip = new DHLSchip(NaamSchip);

            bool Running = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Options:\n1:Doos aanmaken en toevoegen aan schip\n2:Manifest afdrukken op scherm\n3:Programma Afsluiten");
                int optionChoice = int.Parse(Console.ReadLine());
                switch (optionChoice)
                {
                    case 1:
                        aantaldozen++;
                        Console.Clear();
                        Console.WriteLine("Menu Doos");
                        Console.WriteLine("********************");
                        Console.WriteLine("Wat voor type doos moet het zijn: PostDoos, Container, SecureContainer");
                        string type = Console.ReadLine();
                        Console.WriteLine("Voer het gewicht in");
                        int gewicht = int.Parse(Console.ReadLine());
                        Console.WriteLine("Voer inhoudt" );
                        string inhoudt = Console.ReadLine();
                       
                        //Belangrijk onderdeel, niet elke doos kan verzegeld worden
                        //Dit gedeelte moet nog aan gepast worden
                        Console.WriteLine("Moet het verzegeld worden?");
                        string verzegelen = Console.ReadLine();

                        if (type == "PostDoos" || type == "postdoos")
                        {
                            PostDoos doos = new PostDoos(aantaldozen);
                            
                            doos.Gewicht = gewicht;
                            doos.Inhoudt = inhoudt;
                            schip.VoegDoosToe(doos);
                        }else if (type == "Container" || type == "container")
                        {
                            Container doos = new Container(aantaldozen);
                            doos.Gewicht = gewicht;
                            doos.Inhoudt = inhoudt;
                            schip.VoegDoosToe(doos);
                        }
                        else
                        {
                            SecureContainer doos = new SecureContainer(aantaldozen);
                            doos.Gewicht = gewicht;
                            doos.Inhoudt = inhoudt;
                            schip.VoegDoosToe(doos);

                            if (verzegelen == "ja" || verzegelen == "Ja")
                            {
                                doos.VerzegelInhoudt();
                            }
                        }
                        break;
                    case 2:
                        
                        schip.ToonManifest();
                        Console.ReadKey();
                        break;
                    case 3:
                        Running = false;
                        break;
                }

            } while (Running);
        }
    }
}