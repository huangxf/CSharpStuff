using System;
using System.Threading;
using System.Threading.Tasks;

class StartNewDemo
{
    // Demonstrated features: 
    //		Task ctor() 
    // 		Task.Factory 
    //		Task.Wait() 
    //		Task.RunSynchronously() 
    // Expected results: 
    // 		Task t1 (alpha) is created unstarted. 
    //		Task t2 (beta) is created started. 
    //		Task t1's (alpha) start is held until after t2 (beta) is started. 
    //		Both tasks t1 (alpha) and t2 (beta) are potentially executed on threads other than the main thread on multi-core machines. 
    //		Task t3 (gamma) is executed synchronously on the main thread. 
    // Documentation: 
    //		http://msdn.microsoft.com/en-us/library/system.threading.tasks.task_members(VS.100).aspx 
    static void Main()
    {
        Action<object> action = (object obj) =>
        {
            Console.WriteLine("Task={0}, obj={1}, Thread={2}", Task.CurrentId, obj.ToString(), Thread.CurrentThread.ManagedThreadId);
        };

        // Construct an unstarted task
        Task t1 = new Task(action, "alpha");

        // Cosntruct a started task
        Task t2 = Task.Factory.StartNew(action, "beta");

        // Block the main thread to demonstate that t2 is executing
        t2.Wait();

        // Launch t1 
        t1.Start();

        Console.WriteLine("t1 has been launched. (Main Thread={0})", Thread.CurrentThread.ManagedThreadId);

        // Wait for the task to finish. 
        // You may optionally provide a timeout interval or a cancellation token 
        // to mitigate situations when the task takes too long to finish.
        t1.Wait();

        // Construct an unstarted task
        Task t3 = new Task(action, "gamma");

        // Run it synchronously
        t3.RunSynchronously();

        // Although the task was run synchrounously, it is a good practice to wait for it which observes for  
        // exceptions potentially thrown by that task.
        t3.Wait();
    }


}