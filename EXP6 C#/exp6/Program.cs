using System;
using System.Threading;
class ThreadDemo
{
 static void PrintNumbers()
 {
 for (int i = 1; i <= 5; i++)
 {
 Console.WriteLine("Child Thread: " + i);
 Thread.Sleep(500);
 }
 }
 static void Main(string[] args)
 {
 Thread t1 = new Thread(PrintNumbers);
 t1.Start();
 for (int i = 1; i <= 5; i++)
 {
 Console.WriteLine("Main Thread: " + i);
 Thread.Sleep(500);
 }
 t1.Join();
 Console.WriteLine("Execution Completed.");
 }
}
