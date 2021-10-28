using System;
namespace ExceptionHandlingSample  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Class1 cls1 = new Class1();  
            Console.WriteLine(cls1.Method1());  
            Console.Read();  
        }  
    }  
  
    class Class1  
    {  
        public String Method1()  
        {  
            try  
            {  
                Class2 cls2 = new Class2();  
                return cls2.Method2();  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine("-----Stack Trace for the Exception Occurred------");  
                Console.WriteLine(ex.StackTrace.ToString());  
                Console.WriteLine("-------Method in which Exception Occurred------");  
                Console.WriteLine(ex.TargetSite.ToString());  
            }  
            return "";  
        }  
    }  
  
    class Class2  
    {  
        public String Method2()  
        {  
            try  
            {  
                FaultyMethod2();  
                return "Method2 called";  
            }  
            catch(Exception ex) {  
                throw ex;  
            }  
        }  
        //This method is responsible for the exception  
        public void FaultyMethod2()  
        {  
            throw new TimeoutException();  
        }  
    }   
}  
