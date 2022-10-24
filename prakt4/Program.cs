

using System.Runtime.InteropServices;

class prakt4
{
    private const string path = "C:\\Users\\k5469\\RiderProjects\\prakt4\\prakt4\\";
    [DllImport(path+"lib1.dll")]
    static extern void enter(int n, int[] mas);
    [DllImport(path+"lib1.dll")]
    static extern void random(int n, int[] mas);
    [DllImport(path+"lib1.dll")]
    static extern void print(int n, int[] mas);
    [DllImport(path+"lib1.dll")]
    static extern void check_mas(int n, int[] mas);

    unsafe static void first_part()
    {
        const int N = 4;
        double[] A = new double[N];
        fixed (double* p = A)
        {
            Console.WriteLine("Enter mas");
            for (int i = 0; i < N; i++)
            {
                Double.TryParse(Console.ReadLine(), out *(p+i));
            }
        }

        fixed (double* p = A)
        {
            Console.WriteLine("Your mas");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(*(p+i));
            }
        }

        fixed (double* p = A)
        {
            for (int i = 1; i < N - 1; i++)
            {
                Console.WriteLine(*(p + i - 1)+" and "+ *(p + i) + " and "+ *(p + i + 1));
                if (*(p + i - 1) < *(p + i) && *(p + i + 1) < *(p + i))
                {
                    Console.WriteLine(*(p + i) + " is a local max");
                }
            }
        }

        fixed (double* p = A)
        {
            Console.WriteLine("Your mas");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(*(p+i));
            }
        }
    }

    unsafe static void second_part()
    {
        
    }
       unsafe static void Main()
       {
           const int N = 45;
           int[] mas = new int[N];
           random(N,mas);
           check_mas(N,mas);
       }
}
/*Вариант 12
В целочисленном массиве А (45) найти локальные максимумы,
определить их местоположение. Локальным максимумом считается
элемент массива, значение которого больше, чем значения двух соседних с ним элементов.*/
/*
 * Первая часть. Создать с использованием C или C++ динамическую библиотеку для работы с массивом, которая позволяет вводить
массив, выводить массив и выполнять над ним действие согласно индивидуальному варианту. Далее необходимо подключить её к программе, написанной на C#, и продемонстрировать её возможности, соответствующим образом учтя разницу в используемых типах данных.
Вторая часть. Нарисовать кота или кошку (или капибару) программным способом. Использовать готовые изображения нельзя.
 */