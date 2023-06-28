string[] s = Console.ReadLine().Split();

int a = int.Parse(s[0]);
int b = int.Parse(s[1]);

if (a > b) Console.WriteLine(">");
if (a < b) Console.WriteLine("<");
if (a == b) Console.WriteLine("==");