
public class Program
{
    public static void Main()
    {
        //ilk kez döngüye girmesi için değeri false atadık
        bool isValidInput = false;

        //kullanıcı geçerli veri girene kadar döngüde kalsın
        while (!isValidInput)
        {
            try
            {
                Console.WriteLine("Sayı giriniz: ");

                string input = Console.ReadLine();

                int number = Convert.ToInt32(input); 
                //kullanıcı bu satırda int girmezse hata verecek ve catch bloğuna düşecek.
                //int girerse sonraki satıra geçip ekrana sayının karesini yazdıracak
                
                Console.WriteLine(number*number);
                
                //döngüden çıkması için de true eşitlemesi yapıyoruz.
                isValidInput = true;
            }
            //burada hangi sebeple olursa olsun hata vermesi durumunda catch çalışıyor.
            catch (Exception ex)
            {
                Console.WriteLine("Geçersiz giriş.");
            }
        }
    }
}