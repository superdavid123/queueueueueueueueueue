Queue<string> vp = new Queue<string>();
Queue<string> np = new Queue<string>();

string input;
while (true)
{
	input = Console.ReadLine();
	if (input == "konec")
	{
		break;
	}
	if (input.StartsWith("vp"))
	{
		vp.Enqueue(input);
	}
	else if (input.StartsWith("np"))
	{
		np.Enqueue(input);
	}
	else
	{
		Console.WriteLine("NEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
		Console.Write("zkus to znovu");
	}
}
int taskNumber = 1;
while (vp.Count > 0)
{
	Console.WriteLine($"{taskNumber++}. {vp.Dequeue()}");
}

while (np.Count > 0)
{
	Console.WriteLine($"{taskNumber++}. {np.Dequeue()}");
}

