//Sinema Filmlerini listeleyeceğimiz bir liste oluşturalım.
// 
// Film için propertyler -> Imdb Puanı (Double) - İsmi 
// 
// Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.
// 
//  Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun. Kullanıcı evet cevabını
// verirse döngüde başa dönülerek yeni bir film oluşturulup ilgili listeye aktarılsın. Hayır cevabı verilirse program
// aşağıdaki çıktıları ayrı ayrı sunarak sonlandırılsın.
// 
//     Uygulamanın sonunda
// 
//  Bütün filmler listelensin.
// 
//  Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.
// 
//  İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.

using Imdb;

public class Program
{
    public static void Main()
    {
        //programa devam edip etmeme isteğini tanımlıyorum
        bool devam = false;
        List<Movie> movies = new List<Movie>();
        do
        {
            //kullanıcıdan yeni bir film bilgisi alıyorum
            Console.WriteLine("Lütfen bir film ekleyiniz:");
            
            //film nesnesi oluşturan GetMovie metodunu çağırıorum
            movies.Add(GetMovie());
        
            //kullanıcı devam etmek istiyor mu?
            Console.WriteLine("Yeni bir film eklemek için 'Evet' sonlandırmak için 'Hayır' giriniz.");
            string input = Console.ReadLine().ToLower();
            //eğer evet girerse döngü devam etsin ve yeni film eklemeye devam etsin
            if (input == "evet")
            {
                devam = true;
            }
            //evet harici bir girişte hayır kabul ederek döngüyü sonlandırıyorum
            else
            {
                devam = false;
            }
        } while (devam == true);
        

        //kullanıcının girdiği tüm filmleri yazdırıyorum
        Console.WriteLine("Girdiğiniz tüm filmler:");
        foreach (Movie movie in movies)
        {
            Console.WriteLine(movie.Name +" - "+ movie.Rating);
        }

        //Imdb puanı 4 ve 9 arası olan filmleri yazdırıyorum
        Console.WriteLine("Imdb puanı 4 ve 9 arası olan filmler:");
        foreach (Movie movie in movies)
        {
            if (movie.Rating > 4 && movie.Rating < 9)
            {
                Console.WriteLine(movie.Name +" - "+ movie.Rating);
            }
        }

        //A ile başlayan filmleri yazdırıyorum
        Console.WriteLine("A ile başlayan filmler:");
        foreach (Movie movie in movies)
        {
            if (movie.Name.StartsWith("A"))
            {
                Console.WriteLine(movie.Name +" - "+ movie.Rating);
            }
        }
        
    }

    //Bu metot içinde Movie classından oluşturduğumuz nesneler için atamalar yapıyorum
    public static Movie GetMovie()
    {
        //yeni bir nesne oluşturuyorum
        Movie movie = new Movie();
        
        Console.WriteLine("Lütfen film adı giriniz:");
        
        //Kullanıcının girdiği ismi ilk harfi büyük diğerleri küçük olacak şekilde düzenledim
        //A ile başlayan filmleri yazdırırken de daha kolay oldu
        string nameIlk = Console.ReadLine().ToLower();
        string name = char.ToUpper(nameIlk[0]).ToString();

        //kullanıcıdan aldığım ismi filmin ismine atadım
        movie.Name = name;

        Console.WriteLine("Lütfen film puanı giriniz:");
        string ratingStr = Console.ReadLine();

        // Double'a dönüştürmeye çalış
        if (double.TryParse(ratingStr, out double rating))
        {
            //kullanıcıdan aldığım sayıyı filmin puanına atadım
            movie.Rating = rating;
        }
        else
        {
            //hata verdi
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz! 0 kabul edildi.");
            movie.Rating = 0;
        }

        return movie;
    }
}