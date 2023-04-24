/*Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив, 
каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке. Если длины массивов 
не равны, необходимо как-то оповестить пользователя. */

 int[] SubtractArrays(int[] arr1, int[] arr2)

{
    if (arr1.Length != arr2.Length)
    {
        Console.WriteLine("Длины массивов не равны!");
        return null;
    }

    int[] result = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        result[i] = arr1[i] - arr2[i];
    }

    return result;
}

int[] arr1 = { 1, 2, 5 };
int[] arr2 = { 4, 5, 6 };

int[] result = SubtractArrays(arr1, arr2);

if (result != null)
{
    foreach (int num in result)
    {
        Console.Write(string.Join(" , " , num));
    }
}
