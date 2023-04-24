/*Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый 
массив, каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке. Если 
длины массивов не равны, необходимо как-то оповестить пользователя. */

void SubtractArrays(int[] arr1, int[] arr2)
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


