using static System.Console; // Позовляет не писать "Console" в теле кода
using static System.String; // Позволяет не писать "String"

public static class Infrastructure // Заполняет массив случайными числами
{
    //public static int[] CreateArray(int size, int min=0, int max=10)
    public static int[] CreateArray(this int size, int min=0, int max=10) // Добавляем this для записи "10.CreateArray();"
    {
        return Enumerable.Range(1, size)
        .Select(item => Random.Shared.Next(min, max))
        .ToArray();
    }
    //public static void Print(int[] array) //Печатает массив
    //public static int[] Print(this int[] array) // добавляем this для записи ".Print();"
    public static int[] Print(this int[] array, string separator = ",") // изменяем для редактировния вывода в консоль
    {
        string output = Join(separator, array);//изменяем для редактировния вывода в консоль
        //WriteLine($"[{Join( ',', array)}]"); //Console.WriteLine($"[{String.Join( ',', array)}]");
        WriteLine($"[{output}]");//изменяем для редактировния вывода в консоль
       return array; // Возвращаем массив
    }
}