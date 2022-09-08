// Задание 25
System.Console.WriteLine("Задание 25");

int GetDegree(int N1, int N2){
    int numconst = N1;
    for(int i = 1; i != N2; i++)
    {
        N1 *= numconst;
    }
    return N1;
}
System.Console.WriteLine("Введите число 1");
int N1 = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите число 2");
int N2 = int.Parse(System.Console.ReadLine());
System.Console.WriteLine(GetDegree(N1,N2));

// Задание 27. Программа должна принимать число и выводить сумму чисел (121 --> 3)
System.Console.WriteLine("Задание 27");
System.Console.WriteLine("Введите число");

int GetSum(string num){
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum += Convert.ToInt32(num[i] - '0');

    }
    return sum;
}
string a = System.Console.ReadLine();
System.Console.WriteLine($"Сумма цифр в числе {a} = {GetSum(a)}");

// Задание 29.  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
System.Console.WriteLine("Задание 29.");

int[] RandArray ()
{
    int [] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}
System.Console.WriteLine($"[{string.Join(", ", RandArray())}]");



