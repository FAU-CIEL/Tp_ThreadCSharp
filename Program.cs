namespace Tp_ThreadCSharp;

class Program
{
    static void AfficheA()
    {
        while (true)
        {
            Console.WriteLine("AfficheA thread : " + Thread.CurrentThread.Name);
            Thread.Sleep(1000);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine(Thread.CurrentThread.ThreadState);

        Thread.CurrentThread.Name = "Thread 1";
        Console.WriteLine(Thread.CurrentThread.Name);

        Thread thread1_fonction = new Thread(AfficheA);
        Thread thread2_fonction = new Thread(AfficheA);
        Thread thread3_fonction = new Thread(AfficheA);

        thread1_fonction.Name = "thread1_fonction1";
        thread2_fonction.Name = "thread2_fonction1";
        thread3_fonction.Name = "thread3_fonction1";

        thread1_fonction.Start();
        thread2_fonction.Start();
        thread3_fonction.Start();
    }
}