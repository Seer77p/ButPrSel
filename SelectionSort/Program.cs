using static Sorting; //Дает возможность пользоваться функцией из файла Sirting.cs
using static Infrastructure; //Дает возможность пользоваться функцией из файла Infrastructure.cs
using static SortBubble; //Дает возможность пользоваться функцией из файла Sirting.cs
                      // int[] array = CreateArray(10);  // Классическая запись
                      // Print(array);
                      // SortSelection(array);
                      // Print(array);

// 10.CreateArray() //Запись при добавлении this в функциях
//   .Print()
//   .SortSelection()
//   .Print();

//10.CreateArray().Print().SortSelection().Print(); аналогичная запись (Запись при добавлении this в функциях)

//   10.CreateArray(10,15) //Запись при добавлении this в функциях (задаем min и max вручную)
//   .Print()
//   .SortSelection()
//   .Print();
10.CreateArray(10, 100) 
  .Print(" | ")//изменяем для редактировния вывода в консоль
  .SortSelection()
  .Print(" <> ");//изменяем для редактировния вывода в консоль 

Console.WriteLine();

10.CreateArray(5, 50)
  .Print(" | ")//изменяем для редактировния вывода в консоль
  .SortBubbles()// Сортировка пузырьком
  .Print(" <> ");//изменяем для редактировния вывода в консоль
