using static System.Console; // Позовляет не писать "Console" в теле кода
using static System.String; // Позволяет не писать "String"

public static class Infrastructure // Заполняет массив случайными числами
{
    //public static int[] CreateArray(int size, int min=0, int max=10)
    /// <summary>
    /// Метод, создания и заполнения массива
    /// </summary>
    /// <param name="size">Размер нового массива</param>
    /// <param name="min">Нижняя граница заполнения</param>
    /// <param name="max">Верхняя граница заполнения</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(this int size, int min=0, int max=10) // Добавляем this для записи "10.CreateArray();"
    {
        return Enumerable.Range(1, size)
        .Select(item => Random.Shared.Next(min, max))
        .ToArray();
    }
    //public static void Print(int[] array) //Печатает массив
    //public static int[] Print(this int[] array) // добавляем this для записи ".Print();"
    /// <summary>
    /// Печать массива в консоль
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="separator">Символ-разделитель элементов массива</param>
    /// <returns>Исходный массив</returns>
    public static int[] Print(this int[] array, string separator = ",") // изменяем для редактировния вывода в консоль
    {
        string output = Join(separator, array);//изменяем для редактировния вывода в консоль
        //WriteLine($"[{Join( ',', array)}]"); //Console.WriteLine($"[{String.Join( ',', array)}]");
        WriteLine($"[{output}]");//изменяем для редактировния вывода в консоль
       return array; // Возвращаем массив
    }
}