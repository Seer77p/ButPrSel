public static class Sorting
{
//public static void SortSelection(int[] collection) 
/// <summary>
/// Сортировка методом выбора
/// </summary>
/// <param name="collection">Исходный массив</param>
/// <returns>Отсортированный массив</returns>
public static int[] SortSelection(this int[] collection) //this добавляем для записи "10.SortSelection();" 
                                                        //int[] меняем для возврата значений
{
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
       int pos=i;
       for (int j = i+1; j < size; j++)
       {
        if(collection[j]<collection[pos]) pos=j;
       } 
       int temp = collection[i];
       collection[i] = collection[pos];
       collection[pos]=temp;
    }
    return collection; //Возвращаем занчение
}
}