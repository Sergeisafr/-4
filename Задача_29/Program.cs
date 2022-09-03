// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Array()
{
int [] array;
array = new int [8] {1,2,5,7,19,6,1,33};
Console.Write("[" + array[0]+", ");
Console.Write(array[1]+", ");
Console.Write(array[2]+", ");
Console.Write(array[3]+", ");
Console.WriteLine(array[4]+"]");
Console.Write("[" + array[5]+", ");
Console.Write(array[6]+", ");
Console.WriteLine(array[7]+"]");
}
Array();