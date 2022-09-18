
Console.WriteLine ("Введите некоторые строки разной длины через пробел \n");
string text = Console.ReadLine ();
string [] array = text.Split(' ');
for (int i = 0; i < array.Length; i++)
    {   
        if (array[i].Length <=3) Console.WriteLine(array[i]);
    }