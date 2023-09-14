// циклы в C#
// существует безусловный оператор goto
//metka:
// тут какой-то код
//goto metka;  //тут произойдет переход на строку с меткой

// операторы цикла
// общая логика - существует блок кода (тело цикла), который
// будет раз за разом выполняться до тех пор, пока выполняется
// условие работы цикла
// варианты циклов
// 1 цикл с предусловием
/*
while (условие)
{ 
   тело
}
// порядок работы:
1. Проверка условия
2. Если условие == true, выполняется блок тела
3. Проверка условия
....
N. Если условие == false, происходит выход из цикла
*/
/*
int i = 0;
while (i < 10)
{
    Console.WriteLine(i++);// выводим i и увеличиваем его на 1
}
*/
// 2 цикл с постусловием
/*
do
{
    тело
}
while (условие);
*/
/*
int i = 0;
do
{
    if (i % 2 != 0)
    {
        i++;
        continue;// переход на условие цикла
    }
    Console.WriteLine(i++);// выводим i и увеличиваем его на 1
    if (i > 10)
        break; // прервет цикл

    //return; // можно прервать работу программы
}
while (true);
*/
// 3 цикл с счетчиком
/*
for (создание счетчика;условие работы;изменение счетчика)
{
    Console.WriteLine("Выполняется цикл");
}
порядок выполнения
1. создается счетчик
2. проверка условия
3. если условие = true, выполняется тело цикла
4. изменение счетчика
5. проверка условия...
*/
/*
for (int i = 0; i < 10; i = i + 2)
    Console.WriteLine(i);

for (int i = 0, q = 10; q != 0 && i < 10; i++, q--)
{
    Console.WriteLine($"i = {i}, q = {q}");
}
*/
// существует цикл для перебора объектов в коллекциях (массивах)
// foreach (объект in коллекция)
// работа: перебирает все элементы коллекции и предоставляет
// к ним доступ (для чтения) с помощью переменной 'объект'
/*int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
foreach (int i in array)
    Console.WriteLine(i);*/
/*
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
        Console.Write(i*j + "\t");
    Console.WriteLine();
}
*/

int a, b, c, h;
double p, S = 0;
for (int choice = 1; choice > 0 && choice < 4;)
{
    Console.WriteLine("Число от 1 до 3?");
    int.TryParse(Console.ReadLine(), out choice);
    switch (choice)
    {
        case 1:
            Console.WriteLine("Основание?");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Высота?");
            int.TryParse(Console.ReadLine(), out h);
            S = (a * h) / 2;
            break;
        case 2:
            Console.WriteLine("Сторона а?");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Сторона б?");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Угол между а и б?");
            int.TryParse(Console.ReadLine(), out c);
            S = 0.5 * a * b * Math.Sin(c * 0.017);
            break;
        case 3:
            Console.WriteLine("Сторона а?");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Сторона б?");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Сторона c?");
            int.TryParse(Console.ReadLine(), out c);
            p = (a + b + c) / 2;
            S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            break;
        default:
            continue;
    }
    Console.WriteLine($"Площадь: {S}");
}