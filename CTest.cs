namespace CTest
{
    public class CTest
    {

        private int div;

        private int calcul(int val)
        {
            div = val;
            if (div != 0)
            {
                Thread.Sleep(1);
                return (100 / div);
            }
            return 0;
        }

        public void AfficheB()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("AfficheB thread : " + Thread.CurrentThread.Name + " iteration " + i);
                Thread.Sleep(100);
            }
        }

        public void AfficheC()
        {
            for (int i = 1; i <= 100; i++)
            {
                div = 0;
                Console.WriteLine("AfficheC thread : " + Thread.CurrentThread.Name + " iteration " + i);
                Console.WriteLine(calcul(i-1));
                Thread.Sleep(100);
            }
        }
    }
}