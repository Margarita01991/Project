//                           0,1
// string[,] table = new string[2,5]; // 2 строки 5 столбцов
// String.Empty - ПО УМОЛЧАНИЮ инициализация строк происходит с помощью данной константы
// table[0,0]   table[0,1]   table[0,2]...table[0,4]
// table[1,0]   table[1,1]   table[1,2]...table[1,4]

// table[1, 2] = "слово";
// Нужен цикл в цикле чтобы распечатать данный массив:
// for (int rows = 0; rows < 2; rows++) // 2 == lenght
// {
//     for (int columns = 0; columns < 5; columns++)  // 2 == lenght
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
// ТО ЖЕ САМОЕ С ЧИСЛАМИ

//int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)      // Get.Lenght(0) выводит кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // Get.Lenght(1) выводит кол-во столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine(); // можно добавить строку для красивого вывода таблицы массива
    }
}

void Fillarray(int[,] matr)// дополнительный метод, который будет заполнять нашу матрицу случайными числами
{
    for (int i =0 ; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1;10]
        }
    }
}

int[,] matrix = new int [3, 4];
PrintArray(matrix); 
Fillarray(matrix); // БЕЗ ЭТОЙ СТРОКИ БЫЛА БЫ ПРОСТО ПРОВЕРКА
Console.WriteLine();
PrintArray(matrix);
