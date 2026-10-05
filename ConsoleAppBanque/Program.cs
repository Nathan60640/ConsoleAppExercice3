namespace ConsoleAppBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital = 1200;
            double taux = 0.013;

            Console.Write("Quelle somme souhaitez-vous atteindre (en €) ? ");
            double objectif = double.Parse(Console.ReadLine());

            int annees = 0;

            while (capital < objectif)
            {
                capital = capital + capital * taux; 
                annees++;
            }

            Console.WriteLine($"Il faudra {annees} an(s) pour atteindre {objectif} €.");
            Console.WriteLine($"Capital au bout de {annees} an(s) : {capital:F2} €");
        }
    }
}
