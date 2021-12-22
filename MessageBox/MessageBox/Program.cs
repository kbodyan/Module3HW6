using System;
using System.Threading;
using System.Threading.Tasks;
using MessageBox;

namespace MessageBox
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var obj = new MessageBox();
            var tcs = new TaskCompletionSource();
            obj.WindowsClosedHandle += (state) =>
            {
                Console.WriteLine(state == State.Ok ? "Opened" : "Closed");
                tcs.SetResult();
            };
            obj.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
