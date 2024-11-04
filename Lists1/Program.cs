//Bu Pratik'te sizden ziyaretçilerin isimlerini eklediğimiz bir liste oluşturmanızı ve bu liste içerisinde
//for ya da foreach döngüsü ile dönerek isimlerini tek tek ekrana yazdırmanız isteniyor.

public class Program
{
    public static void Main(string[] args)
    {
        //string tipinde veri tutan bir davetliler listesi oluşturdum
        List<string> davetliler = new List<string>();
        
        //davetliler listesine ögeleri ekledim
        davetliler.Add("Ebru Gündeş");
        davetliler.Add("Bülent Ersoy");
        davetliler.Add("Ajda Pekkan");
        davetliler.Add("Hadise");
        davetliler.Add("Hande Yener");
        davetliler.Add("Tarkan");
        davetliler.Add("Funda Arar");
        davetliler.Add("Ebru Gündeş");
        davetliler.Add("Demet Akalın");
        
        //foreach döngüsüyle ekrana yazdırdım
        Console.WriteLine("Davetliler:");
        foreach (string isim in davetliler)
        {
            Console.WriteLine(isim);
        }
    }
}