// //int n = Random.Shared.Next(10000000);

// double s= 0;
// for (int n = 0; n < 15; n++)
// {
//  int i = n; 
//  int count = 0;
//  while (i>0)
// {
//     s+= i;
//     i = i / 2; // log(n) + 1 
//     count++;
// }
// System.Console.WriteLine($"n: {n} count: {count}");
// }




  /// <summary>
  /// Сортировка методом выбора
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив массив</returns>
   int[] SortSelection(int[] collection)
  {
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
      int pos = i;
      for (int j = i + 1; j < size; j++)
      {
        if (collection[j] < collection[pos]) pos = j;
      }
      int temp = collection[i];
      collection[i] = collection[pos];
      collection[pos] = temp;
    }
    return collection;
  }

var arr = new int [] {1,2,5,3,4,9};
System.Console.WriteLine(string.Join(',', arr));
SortSelection(arr);
System.Console.WriteLine(string.Join(',', arr));
