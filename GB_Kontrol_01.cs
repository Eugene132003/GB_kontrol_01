Console.Write("Слова, числа или символы, разделяя их \", \": ");
int stringInner = Console.ReadLine();
String[] stringNew = stringInner.Split(", ");
CutStringToArray(stringNew);

String[] CutStringToArray(String[] stroka)
{
    int[] array = new int[];
Console.Write($"[{String.Join(", ", stroka)}]");
    return array;
}

void PrintArray(int[] inArray)
{
    Console.Write($"[{String.Join(", ", inArray)}]");
}