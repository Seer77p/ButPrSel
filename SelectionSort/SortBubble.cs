public static class SortBubble
{
    //public static void SortSelection(int[] collection) 
    /// <summary>
    /// Сортировка пузырьком
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortBubbles(this int[] collection) //this добавляем для записи "10.SortSelection();" 
                                                             //int[] меняем для возврата значений
    {
        int size = collection.Length;
        for (int i = 0; i < size; i++)
        {
            int temp = i;
            for (int j = 0; j < size-1; j++)
            {
                if (collection[j] > collection[j+1])
                {
                    temp = collection[j];
                    collection[j] = collection[j + 1];
                    collection[j + 1] = temp;
                }
            }
        }
        return collection; //Возвращаем занчение
    }
}