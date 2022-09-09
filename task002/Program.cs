//Показать натуральные числа от M до N, N и M заданы

 int Numbers(int M,int N)
    {
	if (M < N)
	{
	    return N;
	}
	else Console.Write(" {0} ",N);
		N--;
	return Numbers(M,N);
    }

	
Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"От{M} до{N} натуральных чисел {Numbers(M, N-1)}");