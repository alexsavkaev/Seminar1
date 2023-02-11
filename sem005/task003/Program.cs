/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/
int[] StringToArray(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for(int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
bool FindElement(int[] array, int el)
{
    foreach(var item in array)
    {
        if(el == item) return true;
    }
    return false;
}
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = StringToArray(elements);
Console.Write("Введите искомое число: ");
int num = int.Parse(Console.ReadLine());
if(FindElement(baseArray, num))
{
    Console.WriteLine("Да.");
}
else
{
    Console.WriteLine("Нет.");
}

