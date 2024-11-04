// 1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
// 
// 2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
// 
// 3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
// 
// 4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.

public class Program
{
    public static void Main(string[] args)
    {
        //10 elemanlı bir integer dizisi oluşturdum.
        int[] array = new int[10];
        
        //for döngüsü içinde kullanıcıdan dizi için değerler aldım
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Dizi için {i + 1}. elemanı giriniz:");
            string? sayiStr = Console.ReadLine();

            //integer bir değer girildiyse direkt o değeri atıyor
            if (int.TryParse(sayiStr, out int sayi))
            {
                array[i] = sayi;
            }
            //integer harici girilen her değer için 0 atadım.
            else
            {
                array[i] = 0;
            }
        }
  

        //foreach döngüsüyle ekrana diziyi yazdırdım.
        Console.WriteLine("Dizinin elemanları:");
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
        
        //kullanıcıdan 11.değeri alabilmek için 11 boyutlu yeni bir dizi oluşturdum
        int[] newArray = new int[11];

        //eski dizinin elemanlarını yeni dizinin ilk 10 elemanına eşitledim
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        
        
        
        //11. eleman için kullanıcıdan değer istedim
        Console.WriteLine("Dizi için 11. elemanı giriniz:");
        string? newSayiStr = Console.ReadLine();

        //integer bir değer girildiyse direkt o değeri atıyor
        if (int.TryParse(newSayiStr, out int newSayi))
        {
            newArray[10] = newSayi;
        }
        //integer harici girilen her değer için 0 atadım.
        else
        {
            newArray[10] = 0;
        }
        
        //önce Array.Sort metoduyla dizideki sayıları küçükten büyüğe sıraladım
        Array.Sort(newArray);
        
        //sonra Array.Reverse metoduyla dizideki elemanları tersine çevirdim.
        Array.Reverse(newArray);

        //foreach kullanarak ekrana yazdırıyorum.
        Console.WriteLine("Büyükten küçüğe dizinin tüm elemanları:");
        foreach (int item in newArray)
        {
            Console.WriteLine(item);
        }
    }
}