// Console.WriteLine("Введите число:");
// int[] array = { 17, 12, 21, 45, 34, 84, 92, 53, 75, 65, 21 };
// int n = array.Length;
// int index = 0;
// int find = Convert.ToInt32(Console.ReadLine());

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.Write($"index числа {find} = ");
//         Console.WriteLine(index);
//         break;                                       // break - (прервать) цикл после выполнение условия                              
//     }
//     index = index + 1;
// }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------


int[] array = { 17, 12, 21, 45, 34, 84, 92, 53, 75, 65, 21 };
int n = array.Length;
int index = 0;
int find = 21;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;                                       // break - (прервать) цикл после выполнение условия 
    }
    index = index + 1;
}