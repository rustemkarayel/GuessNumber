namespace GuessNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd= new Random();
            Console.Write("Random sayı için oluşacak aralığın MİNİMUM değerini giriniz:");
            int min=Convert.ToInt32(Console.ReadLine());
            Console.Write("Random sayı için oluşacak aralığın MAXİMUM değerini giriniz:");
            int max = Convert.ToInt32(Console.ReadLine());
            int randomNumber=rnd.Next(min,max);

            List<int> Tahminler=new List<int>();

            Console.Write("Kaç tahminde bulunmak istersiniz:");
            int sayac = Convert.ToInt32(Console.ReadLine());
            int adet = sayac;
            for (int i = 0; i < sayac; i++)
            {
                Console.Write("Tahminde bulununuz (" + adet + " tane hakkınız bulunmaktadır):");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                Tahminler.Add(tahmin);
                if (tahmin > randomNumber)
                {
                    if (adet > 1)
                    {
                        Console.WriteLine("Sayıyı azaltınız...");
                    }
                    adet--;
                }
                else if (tahmin < randomNumber)
                {
                    if (adet > 1)
                    {
                        Console.WriteLine("Sayıyı yükseltiniz...");
                    }
                    adet--;
                }
                else
                {
                    Console.WriteLine("Tebrikler " + (i+1) + ".denemede bildiniz.Sayı=" + randomNumber);
                    break;
                }
            }

            if(adet==0)
            {
                Console.WriteLine("Maalesef hakkınız bitti...Sayı="+randomNumber);
            }
            Console.WriteLine();

            //1.yol = Tahminleri yazdırmak için:
            Console.WriteLine("TAHMİNLER:");
            foreach (var tahmin in Tahminler)
            {
                Console.WriteLine("-" +tahmin);
            }
            Console.ReadLine();

            //2.yol = Tahminleri yazdırmak için:
            Console.WriteLine("TAHMİNLER:");
            for (int i = 0; i < Tahminler.Count; i++)
            {
                Console.WriteLine((i+1)+".tahmin = " + Tahminler[i]);
            }
            Console.ReadLine();
        }
    }
}