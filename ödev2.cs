using System;




namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> psayılar = new List<int>();
          
          Console.Write("pozitif n sayisini girin : ");
          int n = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("pozitif m sayısını girin : ");
          int m = Convert.ToInt32(Console.ReadLine());

          for(int i=0 ;i<n;i++)
          {
            Console.Write("pozitif sayi giriniz: ");
             int sayilar = Convert.ToInt32(Console.ReadLine());
             if(sayilar%2==0){
              psayılar.Add(sayilar);
             }                                   
         }
            Console.Write("m sayisina eşit veya tam bölen sayilar : ");

            foreach(var item in psayılar)
            {
              if (item%m==0)
              {
                Console.Write(item+" ");
                
              }
            }

        }
           
        
    }

   
   
      
}
