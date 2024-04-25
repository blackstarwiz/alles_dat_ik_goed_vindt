namespace Een_Eigen_Huis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Huis mijnhuis = new Huis();
            mijnhuis.VoegKamerToe(new Gang("eerste verdieping", 20));
            mijnhuis.VoegKamerToe(new Salon("buiten salon", 30, false));
            mijnhuis.VoegKamerToe(new Badkamer("badkamer eerste verdiep", 56));
            mijnhuis.VoegKamerToe(new Kamers( "slaapkamer 1", 40 ));

            mijnhuis.ToString();
            Console.ReadKey();
        }
    }
}