/*
out�ؼ��ֵ����ӣ�ǿ��ĳ��������Ϊ����ֵ����
���������������ʱ���õ��Ǹñ��������á�
*/

using System;

class Out
{
	public static void Add(int x, int y, out int result)
	{
		result = x + y;
	}

	public static void Main()
	{
		int x = 1, y = 2, result = 0;
		Console.WriteLine("Before: x={0}, y={1}", x , y);
		Add(x, y, out result);
		Console.WriteLine("After: x={0}, y={1}", x , y);
		Console.WriteLine("Result: result={0}", result);
	}
}