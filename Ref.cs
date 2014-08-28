/**
ref关键字使用事例，强制对象按引用传递，而不是按值。
这个例子证明，在C#中，如果不指定ref，object instace是按值传递的
**/

using System;

class Ref {
	static void foo(string para1, ref string para2) {
		para1 = "another para1";
		para2 = "another para2";
	}
	
	static void Main(){
		string para1 = "para1";
		string para2 = "para2";
		Console.WriteLine("Before: para1 is {0}, para2 is {1}", para1, para2);
		foo(para1, ref para2);
		Console.WriteLine("After: para1 is {0}, para2 is {1}", para1, para2);
	}
}
