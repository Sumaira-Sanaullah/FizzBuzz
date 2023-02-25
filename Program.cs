Console.Write("Enter the value of N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value of M: ");
int m = Convert.ToInt32(Console.ReadLine());

string sequence ="";

for(int i=n; i<=m; i++)
{
    string currentSequence = "";

    if(i % 3 == 0)
        currentSequence += "FiZZ";

    if(i % 5 == 0)
        currentSequence += "Buzz";

    sequence += i<m ? currentSequence.Length == 0 ? i + "," : currentSequence + "," : currentSequence.Length == 0 ? i : currentSequence ;
}
Console.WriteLine("");
Console.WriteLine(sequence);