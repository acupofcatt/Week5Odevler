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
        bool devam = false;
        List<Movie> movies = new List<Movie>();
        do
        {
            Console.WriteLine("Lütfen bir film ekleyiniz:");
            movies.Add(GetMovie());

            Console.WriteLine("Yeni bir film eklemek için 'Evet' sonlandırmak için 'Hayır' giriniz.");
            string input = Console.ReadLine().ToLower();
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

        foreach (Movie movie in movies)
        {
            Console.WriteLine(movie);
        }
        
        List<Movie> dortVeDokuzArasiFilmler = new List<Movie>();
        foreach (Movie movie in movies)
        {
            //Imdb puanı 4 ve 9 arası olan filmleri yeni bir listeye taşıdım
            if (movie.Rating > 4 && movie.Rating < 9)
            {
                dortVeDokuzArasiFilmler.Add(movie);
            }
        }

        Console.WriteLine(dortVeDokuzArasiFilmler);
        
        List<Movie> aileBaslayanFilmler = new List<Movie>();
        foreach (Movie movie in movies)
        {
            //StartsWith metoduyla a harfi ile başlayan filmleri yeni bir listeye taşıdım
            if (movie.Name.StartsWith("A"))
            {
                aileBaslayanFilmler.Add(movie);
            }
        }

        Console.WriteLine(aileBaslayanFilmler);
    }

    public static Movie GetMovie()
    {
        Movie movie = new Movie();
        
        Console.WriteLine("Lütfen film adı giriniz:");
        string nameIlk = Console.ReadLine().ToLower();
        string name = char.ToUpper(nameIlk[0]).ToString();

        movie.Name = name;

        Console.WriteLine("Lütfen film puanı giriniz:");
        string ratingStr = Console.ReadLine();

        // Double'a dönüştürmeye çalış
        if (double.TryParse(ratingStr, out double rating))
        {
            movie.Rating = rating;
        }
        else
        {
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz! 0 kabul edildi.");
            movie.Rating = 0;
        }

        return movie;
    }
}