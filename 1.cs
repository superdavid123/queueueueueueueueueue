Queue<char> pismena = new Queue<char>();
Console.WriteLine("napiš počet písmen v tom slově");
int x = Convert.ToInt32(Console.ReadLine());
char input_char;
string input = "";
while (x > 0)
{
	Console.WriteLine("Napiš pismeno");
	input_char = Console.ReadLine()[0];
	pismena.Enqueue(input_char);
	input = input + input_char;
	x--;
}

int i = 0;
int j = input.Length - 1;
bool jePalindrom = true;
while (i < j)
{
	if (pismena.Dequeue() != input[j])
	{
		jePalindrom = false;
		break;
	}
	j--;
	i++;
}
if (jePalindrom == true)
{
	Console.WriteLine("toto je PaLiNdRoM");
}
else
{
	Console.WriteLine("toto není pAlInDrOm");
}


