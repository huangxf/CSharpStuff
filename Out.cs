/*
out关键字的例子，强制某个变量作为返回值，在
函数体内做计算的时候用的是该变量的引用。
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