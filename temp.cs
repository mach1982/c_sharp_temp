using System;
using System.Text;

namespace SampleNamespace
{
    public class SampleClass
        
    {
        
        
        
        public float cel (){
            
            System.Console.WriteLine("Enter the in Tempature in Celsius");
             String temp_c=Console.ReadLine();
            //System.Console.WriteLine(""+temp_c); 
            float cel = float.Parse(temp_c);
            
            float far = cel*9/5+32;
            
            return far;
            
           

            
            
            
        }
        
        public float far (){
            
            System.Console.WriteLine("Enter the in Tempature in Fahrenheit");
             String temp_f=Console.ReadLine();
            //System.Console.WriteLine(""+temp_f); 
            float far = float.Parse(temp_f);
            
            float cel = (far -32)*5/9;
            
            return cel;
            
           

            
            
            
        }
        
        public static void Main()
        {
            
            
            SampleClass t = new SampleClass();
            // Write hello world to the console
            System.Console.WriteLine("Enter the in Tempature to conver to  : C for Celsius , F for Fahrenheit ");
            String temp=Console.ReadLine();
            
            char d = (char)176;
          
           if (temp =="F" ){  
           float f = t.cel();
           System.Console.WriteLine(""+f+d+"F"); 
           }
            
            if (temp =="C"){  
           float f = t.far();
           System.Console.WriteLine(""+f+d+"C"); 
           }
            System.Threading.Thread.Sleep(10000);
            
             
            
            
              
        } // End of Main function (program statup)
    } // End of SampleClass
} // End of SampleNamespace

