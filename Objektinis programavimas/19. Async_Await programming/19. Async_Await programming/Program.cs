
using _19._Async_Await_programming.Models;

namespace _19._Async_Await_programming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ProgressBar bar = new ProgressBar();
            var ticsTask =  TicsOfNumber(bar);
            var progressTask = OutputProgess(bar);
            var progressBarTask= new List<Task> { ticsTask, progressTask };
            while (progressBarTask.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(progressBarTask);
                await finishedTask;

            }
        }

        private static async Task<ProgressBar> TicsOfNumber(ProgressBar bar)
        {
            
            for (int i = 0; i < 100; i++)
            {
                bar.Progress += 1;
                await Task.Delay(1000);
            }
            return new ProgressBar();
        }

        private static async Task<ProgressBar> OutputProgess(ProgressBar bar)
        {
            while (bar.Progress < 100)
            {

                Console.WriteLine(bar.Progress);
                await Task.Delay(3000);
            }
            return new ProgressBar();
        }
    }
}