using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MyBaseClass
{
    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method in MyBaseClass.");
    }
}
class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMethod()
    {
        Console.WriteLine("Calling the protected method from MyDerivedClass.");
        ProtectedMethod();
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        derivedObject.AccessProtectedMethod();
    }
}
