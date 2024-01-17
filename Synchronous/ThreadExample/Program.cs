namespace ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
        }
    }
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);//wait for 2s
            }
        }
    }
}
