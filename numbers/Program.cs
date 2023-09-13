int age = int.Parse(Console.ReadLine() ?? "");

string msg;

if (age >= 18)
    msg = "Can drive!";
else
    msg = "Cannot drive!";

Console.WriteLine(msg);
