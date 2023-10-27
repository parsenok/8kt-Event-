using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kt_Event_
{
    class Button
    {
        private string text;
        private event EventHandler click;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public event EventHandler Click
        {
            add
            {
                if (click == null || click.GetInvocationList().Length < 3)
                {
                    click += value;
                }
                else
                {
                    Console.WriteLine("Невозможно добавить более 3 подписчиков события.");
                }
            }
            remove
            {
                click -= value;
            }
        }

        public void ClickButton()
        {
            Console.WriteLine($"Button clicked: {Text}");
            click?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main()
        {
            Button button = new Button();
            button.Text = "Click Me!";
            EventHandler method1 = (sender, e) => Console.WriteLine("Method 1 executed.");
            EventHandler method2 = (sender, e) => Console.WriteLine("Method 2 executed.");
            EventHandler method3 = (sender, e) => Console.WriteLine("Method 3 executed.");
            button.Click += method1;
            button.Click += method2;
            button.Click += method3;
            button.Click += (sender, e) => Console.WriteLine("Method 4 executed (blocked).");
            button.ClickButton();
            button.Click -= method2;
            button.Click += (sender, e) => Console.WriteLine("Method 4 executed.");
            button.ClickButton();
        }
    }
}
