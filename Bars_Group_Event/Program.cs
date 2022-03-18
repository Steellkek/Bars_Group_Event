using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Group_Event
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var key = new Key();
            key.OnKeyPressed += (Sender,ButtonKey) => Console.WriteLine("\n"+ButtonKey);
            
            key.Run();
        }

        internal class Key
        {
            public event EventHandler<char>? OnKeyPressed;
            public void Run()
            {
                char i = Console.ReadKey().KeyChar;
                while ((char.ToLower(i) != 'c') & (char.ToLower(i) != 'с') )
                {
                    OnKeyPressed?.Invoke(this,i);
                    i = Console.ReadKey().KeyChar;
                }
            }
        }
    }
}