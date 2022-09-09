//Показать натуральные числа от N до 1, N задано


int Numbers(int n,int count)
    {
	if (n < 1)
	{
	    return count;
	}
	else Console.Write(" {0} ",n);
		n--;
	return Numbers(n,count);
    }

	Console.Write(" Показать натуральные числа : ");
	int n= Convert.ToInt32(Console.ReadLine());
	Numbers(n,1);
