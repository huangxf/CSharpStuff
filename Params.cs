/**
params�ؼ��֣��ɱ������params�ں��������б���ֻ��
����һ�Σ����ұ�����������
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
