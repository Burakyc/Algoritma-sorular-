using System;




namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kelimeler = new List<string>();
          
          Console.Write("cümle yazınız : ");
          string cümle = Convert.ToString(Console.ReadLine());

          int spaceCount= cümle.Split(' ').Length - 1;
          int kelimesayisi = spaceCount+1;
          Console.WriteLine("kelime sayısı "+kelimesayisi);
          int harf = cümle.Length-spaceCount;  
          Console.Write("harf sayisi "+harf);              
         
        

           }

        }
           
        
    }

   
   
      
