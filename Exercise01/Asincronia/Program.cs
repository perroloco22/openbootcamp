using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

/*
Stopwatch sw = Stopwatch.StartNew();
// Task 1
Task task1 = new Task(() =>
{
    //cronometro
    Stopwatch sw = new Stopwatch();
    sw.Start();
    //funcion que se commporta parecida al setTimeOut de js
    Thread.Sleep(1000);
    sw.Stop();
    Console.WriteLine(sw.Elapsed);

});

Task task2 = new Task(() => 
{
    Stopwatch sw = new Stopwatch();
    sw.Start();
    Thread.Sleep(1000);
    sw.Stop();
    Console.WriteLine(sw.Elapsed);
});

Task task3 = new Task(() =>
{
    Stopwatch sw = new Stopwatch();
    sw.Start();
    Thread.Sleep(1000);
    sw.Stop();
    Console.WriteLine(sw.Elapsed);
});

task1.Start();
//codigo 
task2.Start();
//codigo
task3.Start();

await task1;
await task2;
await task3;

sw.Stop();

Console.WriteLine($"Time all main {sw.Elapsed}");// como los task se ejecutan de manera asincrona el tiempo total del main es aproximadamente 1 segundo. Si fuera sincrono el total del tiempo seria como minimo 3 segundos, 1 segundo por cada task.
*/


/*
// En el metodo RandomAsync adentro no tiene ningun await y se va a comportar de forma sincronica. Si la funcion en la firma esta delcarada como async adentro debe llevar un await
static async Task<string> RandomAsync()
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    Thread.Sleep(1000);
    int num = new Random().Next(1000);
    stopwatch.Stop();
    return $"El numero {num.ToString()} fue calculado en {stopwatch.Elapsed}";
}

*/

//Forma correcta

static async Task<string> RandomAsync()
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    int num = new Random().Next(1000);
    stopwatch.Stop();
    var task = new Task<string>(() => String.Concat(num, " calculado en: ", stopwatch.Elapsed));
    task.Start();
    string result = await task;
    return result;
}


/*string result = await RandomAsync();
Console.WriteLine(result);*/

var task4 = new Task(async () =>
{
    string str = await RandomAsync();
    Console.WriteLine(str);
});

task4.Start();
await task4;
