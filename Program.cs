using CTest;

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

        CTest.CTest test = new CTest.CTest();

        Thread thread1_fonction1 = new Thread(AfficheA);
        Thread thread2_fonction1 = new Thread(AfficheA);
        Thread thread3_fonction1 = new Thread(AfficheA);
        Thread thread4_fonction2 = new Thread(test.AfficheB);
        Thread thread5_fonction3 = new Thread(test.AfficheC);
        Thread thread6_fonction3 = new Thread(test.AfficheC);

        thread1_fonction1.Name = "thread1_fonction1";
        thread2_fonction1.Name = "thread2_fonction1";
        thread3_fonction1.Name = "thread3_fonction1";
        thread4_fonction2.Name = "thread4_fonction2";
        thread5_fonction3.Name = "thread5_fonction3";
        thread6_fonction3.Name = "thread6_fonction3";

        //thread1_fonction1.Start();
        //thread2_fonction1.Start();
        //thread3_fonction1.Start();
        thread4_fonction2.Start();

        // attent la fin du thread pour passer a la suite
        thread4_fonction2.Join();


        thread5_fonction3.Start();
        thread6_fonction3.Start();

        thread5_fonction3.Join();
        thread6_fonction3.Join();

        Console.WriteLine("Tous les threads ont terminés");
    }
}