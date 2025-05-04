namespace Kelimebulucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "elma", "armut", "elma", "muz", "elma", "armut" };

            int elma = 0;
            int armut = 0;
            int muz = 0;

            foreach (var key in kelimeler)
            {
                switch (key)
                {
                    case "elma":
                        elma++;
                        break;
                    case "armut":
                        armut++;
                        break;

                    case "muz":
                        muz++;
                        break;

                }
            }
            Console.WriteLine("elma sayısı -> " + elma + "\n" + "armut sayısı -> " + armut + "\n" + "muz sayısı -> " + muz);
        }
    }
}
