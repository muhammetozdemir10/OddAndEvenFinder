namespace OddAndEvenFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");

            try
            {
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                IsOddOrEvenAndPrintMassage(inputNumber);

            }
            catch (Exception)
            {
                Console.WriteLine("Hata olustu.");
            }
        }


        static void IsOddOrEvenAndPrintMassage(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Sayi tektir.");
            }
        }
    }
}