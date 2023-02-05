using System;




namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kelimeler = new List<string>();
          
          Console.Write("pozitif n sayisini girin : ");
          int n = Convert.ToInt32(Console.ReadLine());

          for(int i=0 ;i<n;i++)
          {
            Console.Write("kelime giriniz: ");
             string kelime = Convert.ToString(Console.ReadLine());
             kelimeler.Add(kelime);
                                            
         }
        

            foreach(var item in kelimeler)
            {
              
                Console.Write(item+" ");
                
            }
           }

        }
           
        
    }

   
   
      
