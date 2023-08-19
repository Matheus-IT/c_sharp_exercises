var names = new List<string>{"matheus", "carol", "francisca", "edilson"};

foreach (string name in names)
    Console.WriteLine($"Hello, {name}!");


Console.WriteLine($"Found carol at {names.IndexOf("carol")}");

int i = 0;
do {
    Console.WriteLine("hello");
    i++;
} while (i < 10);
