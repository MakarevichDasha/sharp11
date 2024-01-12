// Открываем файл для чтения данных
StreamReader inlet = new StreamReader("Inlet.txt");
// Открываем файл для записи результатов
StreamWriter outlet = new StreamWriter("Outlet.txt");

// Читаем данные из файла и разделяем их по строкам
string[] lines = inlet.ReadToEnd().Split('\n');

// Обработка первой строки данных
string[] firstLine = lines[0].Split(" ");
int[] arrayA = new int[firstLine.Length];

// Преобразование строковых значений в целочисленные и сохранение в массив(с помощью фор)
for (int i = 0; i < firstLine.Length; i++)
{
    int value = Convert.ToInt32(firstLine[i]);
    arrayA[i] = value;
}

// Обработка второй строки данных
string[] secondLine = lines[1].Split(" ");
int[] arrayB = new int[secondLine.Length];

for (int i = 0; i < secondLine.Length; i++)
{
    int value = Convert.ToInt32(secondLine[i]);
    arrayB[i] = value;
}

// Обработка третьей строки данных
string[] thirdLine = lines[2].Split(" ");
int[] arrayC = new int[thirdLine.Length];

for (int i = 0; i < thirdLine.Length; i++)
{
    int value = Convert.ToInt32(thirdLine[i]);
    arrayC[i] = value;
}

// Создание списков и добавление значений из массивов
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();
List<int> list3 = new List<int>();

list1.AddRange(arrayA);
list2.AddRange(arrayB);
list3.AddRange(arrayC);

// Поиск индексов элементов массива A в списке list3 (с помощью ифа в форе)
int[] indices = new int[list1.Count];
for (int i = 0; i < arrayA.Length; i++)
{
    if (list3.Exists(p => p == arrayA[i]))
    {
        indices[i] = list3.IndexOf(arrayA[i]);
    }
}

// Удаление элементов из list3 по найденным индексам
list3.RemoveRange(indices[0], indices.Length);
// Вставка элементов из массива B на освободившиеся позиции
list3.InsertRange(indices[0], arrayB);

// Запись результатов в файл(с помрщью форэч)
foreach (int value in list3)
{
    outlet.WriteLine(value);
}

// Закрываем потоки чтения и записи файлов
inlet.Close();
outlet.Close();