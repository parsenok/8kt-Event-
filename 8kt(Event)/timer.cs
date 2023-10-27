//using System;
//using System.Timers;
//namespace kt
//{
//    public class CustomTimer
//    {
//        public event EventHandler Tick;
//        public CustomTimer()
//        {
//            var timer = new System.Timers.Timer(1000);
//            timer.Elapsed += OnTick; timer.AutoReset = true;
//            timer.Enabled = true;
//        }
//        private void OnTick(object sender, ElapsedEventArgs e)
//        {
//            Tick?.Invoke(this, EventArgs.Empty);
//        }
//    }
//    class Clock
//    {
//        public Clock(CustomTimer timer)
//        {
//            timer.Tick += OnTick;
//        }
//        private void OnTick(object sender, EventArgs e)
//        {
//            Console.WriteLine($"Current time: {DateTime.Now.ToLongTimeString()}");
//        }
//    }
//    class Counter
//    {
//        private int counter;
//        public Counter(CustomTimer timer)
//        {
//            timer.Tick += OnTick;
//        }
//        private void OnTick(object sender, EventArgs e)
//        {
//            counter++; Console.WriteLine($"Counter value: {counter}");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            CustomTimer customTimer = new CustomTimer();
//            Clock clock = new Clock(customTimer); Counter counter = new Counter(customTimer);
//            Console.ReadLine();
//        }
//    }
//}