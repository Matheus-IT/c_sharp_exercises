var names = new List<string>{"matheus", "carol", "francisca", "edilson"};

foreach (string name in names)
    Console.WriteLine($"Hello, {name}!");


Console.WriteLine($"Found carol at {names.IndexOf("carol")}");

Console.WriteLine($"Last index {names[names.Count - 1]}");

int c = 0;
do {
    Console.WriteLine("hello");
    c++;
} while (c < 10);

for (int i = 0; i < names.Count; i++) {
    Console.WriteLine(names[i]);
}
