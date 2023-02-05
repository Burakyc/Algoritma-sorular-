using System;




namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> pçiftsayılar = new List<int>();
            
            
          Console.Write("Kaç tane sayi gireceksiniz: ");
          int sayi = Convert.ToInt32(Console.ReadLine());
          for(int i=0 ;i<sayi;i++)
          {
            Console.Write("pozitif sayı giriniz: ");
             int sayilar = Convert.ToInt32(Console.ReadLine());
             if(sayilar%2==0){
            pçiftsayılar.Add(sayilar);
             }
             
          }

          Console.Write("Girdiğiniz pozitif çift sayilar : ");
          foreach(var item in pçiftsayılar)
          {
            Console.Write(item+" ");
          }
          

        
                                  
        }
           
        
    }

   
   
      
}
