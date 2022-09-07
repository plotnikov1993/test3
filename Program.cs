void Zadacha()
{
string[] array = {"Hey", ",", "my", "name", "is", "Andrew"};
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write(array[i] + " ");
    }
}
}
   Zadacha();