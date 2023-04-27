Console.Write("Слова, числа или символы, разделяя их \", \": "); // просим ввести строку
string stringInner = Console.ReadLine()!; // строку переводим в переменную
String[] stringNew = stringInner.Split(", "); // заполняем массив, сплитируя по ", "
PrintArray(CutStringToArray(stringNew)); 

String[] CutStringToArray(String[] stroka) // проверяем строки массива и отправляем нужные в новый массив (проще через list)
{
    String[] array = new String[stroka.Length-1]; // новый массив длинной как и основной
    int count=0; // счетчик нового массива, чтоб пустые строки не получать сразу
    foreach (string item in stroka) // заполнение нового массива строками менее 4х символов - от 1 до трех
    {
        if (item.Length<4){
            array[count]=item;
            count++;
        }
    }
    array = array.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); // удалем пустые строки в новом массиве
    return array;
}

void PrintArray(String[] inArray)
{
        Console.WriteLine("["+String.Join(", ", inArray)+"]");
}