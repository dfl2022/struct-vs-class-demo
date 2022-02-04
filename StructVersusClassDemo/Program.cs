static void MyClassMethod(MyClass pClass)
{
    pClass.MyInt++;
    Console.WriteLine($"Myint is {pClass.MyInt}"); // Myint is 3
}

static void MyMethod(MyStruct pStruct)
{
    pStruct.MyInt++;
    Console.WriteLine($"Myint is {pStruct.MyInt}"); // Myint is 3
}

Console.WriteLine("Class demo");

MyClass aClass = new();
aClass.MyInt = 2;

Console.WriteLine($"Myint is {aClass.MyInt}"); // Myint is 2

MyClassMethod(aClass);

Console.WriteLine($"Myint is {aClass.MyInt}"); // Myint is 3

Console.WriteLine("Struct demo");

MyStruct aStruct; 
aStruct.MyInt = 2;

Console.WriteLine($"Myint is {aStruct.MyInt}"); // Myint is 2

MyMethod(aStruct);

Console.WriteLine($"Myint is {aStruct.MyInt}"); // Myint is 2


public class MyClass
{
    public int MyInt;
}

public struct MyStruct
{
    public int MyInt;
}


