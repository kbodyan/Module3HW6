using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MessageBox
{
    public class MessageBox
    {
        public event Action<State> WindowsClosedHandle;
        public async void Open()
        {
            Console.WriteLine("Window opened");
            await Task.Delay(3000);
            Console.WriteLine("Window closed");
            var random = new Random();
            var state = random.Next(0, 1) == 0 ? State.Ok : State.Cancel;
            WindowsClosedHandle?.Invoke(state);
        }
    }
}
