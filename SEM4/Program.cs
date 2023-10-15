// Напишите массив из 12 элементов, который складывает сумму положительных и отрицательных чисел в нем

//int[] CreateRandomArray(int size, int minValue, int maxValue)
//{
   //int[] array = new int[size];
   //for (int i=0; i < size; i++)
   //{
    //array[i] = new Random().Next(minValue, maxValue +1);
   //}
   //return array;
//}

//void PrintArray(int[] array)
//{
   //for (int i=0; i < array.Length; i++)  
   //{
    //Console.Write(array[i]+ " ");
   //}
   //Console.WriteLine();
//}
//void PosNegSum(int[]array)
//{
    //int positiveSum = 0;
    //int negativeSum = 0;
    //for (int i = 0; i < array.Length; i++)
    //{
       // if (array[i] > 0)
       // {
           // positiveSum += array[i];
        //} else
        //{
            //negativeSum += array[i];
        //}
    //}
    //Console.Write($"Sum of positive array elements ->{positiveSum}\n Sum of negative array elements ->{negativeSum}");
//}
 
    
//Console.Write("Input size: ");
//int size = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input min value: ");
//int min = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input maxValue: ");
//int max = Convert.ToInt32(Console.ReadLine());

//int[]myArray = CreateRandomArray(size, min, max);
//PrintArray(myArray);
//PosNegSum(CreateRandomArray(size, min, max));


//Задайте одномерный массив из 123 случайных чисел. Найдите колво элементов массива, значения которых
// лежат в отрезке [10,99]
// Пример для массива из 5, а не для 123 элементов. В своем решении сделайте для 123*

// [5 18 123 6 2] -> 1

//int[] CreateRandomArray(int size, int minValue, int maxValue)
//{
   //int[] array = new int[size];
   //for (int i=0; i < size; i++)
   //{
    //array[i] = new Random().Next(minValue, maxValue +1);
   //}
//return array;
//}

//void PrintArray(int[] array)
//{
   //for (int i=0; i < array.Length; i++)  
   //{
    //Console.Write(array[i]+ " ");
   //}
   //Console.WriteLine();
//}

//int ElementsCounter(int[] array, int min, int max)
//{
    //int count = 0;
    //for (int i=0; i < array.Length; i++)
    //{
        //if (array[i] >=min && array[i] <= max)
        //{
//count++;
        //}
    //}
    //return count;
//}


//Console.Write("Input size: ");
//int size = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input min value: ");
//int minValue = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input maxValue: ");
//int maxValue = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input lower bound: ");
//int lower = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input upper bound: ");
//int upper = Convert.ToInt32(Console.ReadLine());

//int[]myArray = CreateRandomArray(size, minValue, maxValue);
//PrintArray(myArray);
//System.Console.WriteLine(ElementsCounter(myArray, lower, upper));

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
//4 массив[6 7 19 345 3] -> нет
//3 массив[6 7 19 345 3] -> да

//int[] CreateRandomArray(int size, int minValue, int maxValue)
//{
   //int[] array = new int[size];
   //for (int i=0; i < size; i++)
   //{
    //array[i] = new Random().Next(minValue, maxValue +1);
   //}
   //return array;
//}
//void PrintArray(int[] array)
//{
   //for (int i=0; i < array.Length; i++)  
   //{
    //Console.Write(array[i]+ " ");
   //}
   //Console.WriteLine();
//}


//bool FindElement(int[]array, int n)
//{
    //for (int i = 0; i<array.Length;i++)
    //{
      //if (n == array[i])
      //return true;
        //}
        //return false;
//}



//Console.Write("Input size: ");
//int size = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input min value: ");
//int minValue = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input maxValue: ");
//int maxValue = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int[]myArray = CreateRandomArray(size, minValue, maxValue);
//PrintArray(myArray);
//System.Console.WriteLine(FindElement(myArray, n));

//Напишите программу замена элесентов массива: положительные элементы замените на соответствующие
//отрицательные
// [-4 -8 8 2] -> [4 8 -8 -2]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   for (int i=0; i < size; i++)
   {
    array[i] = new Random().Next(minValue, maxValue +1);
   }
   return array;
}
void PrintArray(int[] array)
{
   for (int i=0; i < array.Length; i++)  
   {
    Console.Write(array[i]+ " ");
   }
   Console.WriteLine();
}

int[] MirrorNumbersInArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
System.Console.WriteLine("Изначальный массив ->");

int[]mirror_array = MirrorNumbersInArray(myArray);
System.Console.WriteLine("Зеркальный массив ->");
PrintArray(mirror_array);
