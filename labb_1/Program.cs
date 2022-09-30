//"29535123p48723487597645723645";

Console.WriteLine("Enter a string of numbers: ");
string input = Console.ReadLine();
Console.WriteLine();

long sum = 0;

for (int i = 0; i < input.Length; i++)
{
    if (char.IsNumber(input[i]) == false)
    {
        continue;
    }

    for (int j = i + 1; j < input.Length; j++)
    {
        if (char.IsNumber(input[j]) == true)
        {
            if (input[i] == input[j])
            {
                string numberMatch = input.Substring(i, j - i + 1);
                string firstMatch = input.Substring(0, input.IndexOf(numberMatch));
                string secondMatch = input.Substring(j + 1);

                Console.Write(firstMatch);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(numberMatch);
                Console.ResetColor();
                Console.WriteLine(secondMatch);

                long.TryParse(numberMatch, out long result);
                sum += result;
                break;
            }
        }
        else
        {
            break;
        }
    }
}

Console.WriteLine("");
Console.WriteLine($"Sum of numbers: {sum}");


Console.ReadKey();