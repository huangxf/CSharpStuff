/**
params关键字，可变参数。params在函数声明列表中只能
出现一次，而且必须出现在最后。
**/

using System;

class Params
{
	static double Average(params double[] values)
	{
		double sum = 0, n = values.Length;
		for( int i = 0; i< n; i++)
		{
			sum += values[i];
		}
		return sum/n;
	}
	
	static void Main()
	{
		Console.WriteLine("Result:{0}", Average(1.0, 2.0, 3.0, 4.0, 5.0));
	}
}
