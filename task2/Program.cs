/*Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив, 
каждый элемент которого равен частному элементов двух входящих массивов в той же ячейке. Если длины массивов 
не равны, необходимо как-то оповестить пользователя. Важно: При выполнении метода единственное исключение, 
которое пользователь может увидеть - RuntimeException, т.е. ваше. */

int[] arr1 = { 10, 20, 30 };
int[] arr2 = { 2, 4, 6 };
if (arr1.Length != arr2.Length)
    {
        Console.WriteLine("Длины массивов не равны!");
    return;
    }
int[] result = DivideArrays(arr1, arr2);
Console.WriteLine("Result:");
foreach (int num in result)
{
    Console.Write($"{num}, ", "");
}
    
int[] DivideArrays(int[] arr1, int[] arr2)
{
    int[] result = new int[arr1.Length];

    for (int i = 0; i < arr1.Length; i++)
    {
        result[i] = arr1[i] / arr2[i];
    }
    return result;
}







