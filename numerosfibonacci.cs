var fibonacciNumbers = new List<int> {1, 1};
/*var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);*/

for(int x=2;x<20;x++){
    fibonacciNumbers.Add(fibonacciNumbers[x-1]+fibonacciNumbers[x-2]);
    Console.WriteLine($"{fibonacciNumbers[fibonacciNumbers.Count-1]}");
}
/*var fibonacciNumbers = new List<int> {1, 1};

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);*/
