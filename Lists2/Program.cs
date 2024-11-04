//kullanıcının konsoldan gireceği 5 kahve ismiyle bir liste oluşturup, bu listeyi foreach döngüsüyle yazdıralım.

public class Program
{
    public static void Main(string[] args)
    {
        //string tipinde eleman içeren bir coffee listesi oluşturdum
        List<string> coffee = new List<string>();

        //for döngüsü kullanarak kullanıcıdan 5 kez kahve ismi alıp listeye ekledim
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Lüften bir kahve adı giriniz:");
            string kahve = Console.ReadLine();
            coffee.Add(kahve);
        }


        Console.WriteLine("Girilen kahve isimleri:");

        //foreach kullanarak kahve isimlerini ekrana yazdırdım.
        foreach (string item in coffee)
        {
            Console.WriteLine(item);
        }
    }
}