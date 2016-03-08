using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            ActionDelegate();

            //AnonymousDelegate();

            //LamdaExpressions();

            //TaskFactory();

            //Run();

            //ContinuationTasks();

            //NestedTasks();

            //ExceptionHandling();
        }

        private static void ActionDelegate()
        {
            Task t1 = new Task(new Action(GetTheTime));
            t1.Start();
        }

        private static void AnonymousDelegate()
        {
            Task t1 = new Task(delegate { Console.WriteLine("The time now is {0}", DateTime.Now); });
            t1.RunSynchronously();
        }

        private static void LamdaExpressions()
        {
            Task t1 = new Task(() => GetTheTime());
            t1.RunSynchronously();
        }

        private static void TaskFactory()
        {
            Task t1 = Task.Factory.StartNew(() => { Console.Write("Task Factory"); });            
        }

        private static void Run()
        {
            var t1 = Task.Run(() => Console.WriteLine("Task 1 has completed. "));
        }

        private static void ContinuationTasks()
        {
            // Creating a Task Continuation
            // Create a task that returns a string.
            Task<string> firstTask = new Task<string>(() => { return "Hello"; });
            // Create the continuation task. 
            // The delegate takes the result of the antecedent task as an argument.
            Task<string> secondTask = firstTask.ContinueWith((antecedent) => { return String.Format("{0}, World!", antecedent.Result); });
            // Start the antecedent task.
            firstTask.Start();
            // Use the continuation task's result.
            Console.WriteLine(secondTask.Result);
            // Displays "Hello, World!"
        }


        private static void NestedTasks()
        {
            // Creating Nested Tasks
            var outer = Task.Run(() =>
            {
                Console.WriteLine("Outer task starting…");
                var inner = Task.Run(() =>
                {
                    Console.WriteLine("Nested task starting…");
                    Thread.SpinWait(50000);
                    Console.WriteLine("Nested task completing…");
                });
            });
            outer.Wait();
            Console.WriteLine("Outer task completed.");
            /* Output:
                  Outer task starting…
                  Nested task starting…
                  Outer task completed.
                  Nested task completing…
            */
        }


        private static void ExceptionHandling()
        {
            // Create a cancellation token source and obtain a cancellation token.
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;

            // Create and start a long-running task.
            var task1 = Task.Run(() => DoWork(ct), ct);

            // Cancel the task
            cts.Cancel();

            try
            {
                task1.Wait();
            }
            catch(AggregateException ae)
            {
                foreach(var innerException in ae.InnerExceptions)
                {
                    if(innerException is TaskCanceledException)
                    {
                        Console.WriteLine("The task was cancelled.");
                        Console.ReadLine();
                    }
                    else
                    {
                        // If it's any other kind of exception, re-throw it.
                        throw;
                    }
                }
            }
        }

        private static void DoWork(CancellationToken token)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.SpinWait(500);
                // Throw an OperationCanceledException if cancellation was requested.
                token.ThrowIfCancellationRequested();
            }
        }

        private static void GetTheTime()
        {
            Console.WriteLine("The time now is {0}", DateTime.Now);
        }
    }

}
