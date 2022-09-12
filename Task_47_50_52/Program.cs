// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
/*
void CountOfNumber (int min,int max){
    float[,] array=new float [3,4];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=(float)new Random().Next(min,max+1)/10f;
            Console.Write(array[i,j]+" ");
            
        }
        Console.WriteLine(" ");
    }
    
    }
Console.WriteLine("Input min of real numbers: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of real numbers: ");
int max=Convert.ToInt32(Console.ReadLine());

CountOfNumber(min,max);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandomArray (){
    int[,] array=new int [3,4];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(-9,11);
    }}
    return array; 
    }

void ShowArray (int [,] array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Console.Write(array[i,j]+" ");
    }
    Console.WriteLine(" ");
}}

void FindElementPosition (int [,] array, int rows,int cols){
    int num=001;
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            if (i==rows && j==cols){
                num=array[i,j];
                Console.WriteLine($" Element {num} with element position {rows},{cols} is found");
            }
}}
    if (num==001) {
        Console.WriteLine("Element doesn't exist ");}
}

Console.WriteLine("Input rows of element position, wich you find: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input cols of element position, wich you find: ");
int cols=Convert.ToInt32(Console.ReadLine());

int [,] arr=CreateRandomArray();
FindElementPosition(arr,rows,cols);
ShowArray(arr);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(-9,11);
    }}
    return array; 
    }

void ShowArray (int [,] array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Console.Write(array[i,j]+" ");
    }
    Console.WriteLine(" ");
}}

void FindAverage (int [,] array){
    int sum=0;
    double average=0;
    double y=array.GetLength(0);
    for (int j=0; j<array.GetLength(1);j++){
        sum=0;
        for (int i=0; i<array.GetLength(0);i++){
            sum+=array[i,j];
            } 
        average=sum/y;
        Console.WriteLine($"Average of {j} column is {average}");
        }
}
   
Console.WriteLine("Input number of rows of array: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of cols of array: ");
int cols=Convert.ToInt32(Console.ReadLine());

int [,] arr=CreateRandomArray(rows,cols);
Console.WriteLine("Array:");
ShowArray(arr);
Console.WriteLine("");
FindAverage(arr);
*/