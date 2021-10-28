using System.Threading.Tasks;
using System.Threading;
using System;

namespace TPLp
{
    class MyApp
    {
        public static void LongTask()   //act as dbcontext
        {
            Thread.Sleep(20000);
        }
        public async static void MyCall()   //act as userRepository
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("At this point new thread has been created");
        }
        public static void Main()  //act as controller
        {
            
            MyCall();
            Console.WriteLine("Im main thread");
            Console.ReadLine();
        }
    }
}
