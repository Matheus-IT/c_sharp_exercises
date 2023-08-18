var names = new List<string>{"matheus", "carol", "francisca", "edilson"};

foreach (string name in names)
    Console.WriteLine($"Hello, {name}!");


Console.WriteLine($"Found carol at {names.IndexOf("carol")}");
