using System;
using System.Threading.Tasks;

namespace ThreadTest2 {
    class Program {

        static void Main(string[] args) {

            // Task task = new Task(() => {
            //     Console.WriteLine("Running task in another thread.");
            //     int result = AddNumber(10, 20);
            //     Console.WriteLine($"Result: {result}");
            // });

            // task.Start();

            // Console.WriteLine("Threading done..");

            // Task.Delay(3000).Wait();
            // Console.ReadLine();


            Thread thread = Thread.CurrentThread;
            thread.Name = "Main thread";
            Console.WriteLine("Thread name - " +thread.Name);
            Console.WriteLine("Current thread - " +Thread.CurrentThread);

        }

        static int AddNumber(int a, int b) {
            return a + b;
        }
    }
}