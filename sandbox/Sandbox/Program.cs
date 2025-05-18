using System;

class Program
{
    static void Main(string[] args)
    {
       
       //First Object
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");

        //Second Object
        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");
        Console.WriteLine($"{myCircle2.GetArea()}");

        //Third Object
        Cylinder myCylinder = new Cylinder();
        myCylinder.SetCircle(myCircle);
        myCylinder.SetHeight(10);
        Console.WriteLine($"{myCylinder.GetVolume}");
    }   

}