using System;
using System.Collections.Generic;
namespace Examen
{
class B
{
    public int b { get; set;}
    public void tiparire()
    {
      Console.WriteLine(b);
    }
}

class D : B 
{
    public String d {get; set;}
    public void tiparire()
    {
        Console.WriteLine("b="+ b);
        Console.WriteLine("d"+ d);
    }
}

class Test
{
    public TList<B> initList()
    {
        return new TList<B>
        {
            new B { b=8},
            new D { b=5, d="D5"},
            new B { b = -3},
            new D { b=9, d="D9"}
        };

    }
    public TList<B> filterList(TList<B> list)
    {   var res = new TList<B>();
        foreach( var item in list)
        {
           if (item.b > 6) res.add(item);
        }
        return res;
    }
    static void main()
    {
       var list = initList();
       var filt = filterList(list);
       foreach(var item in filt) { item.tiparire();}
    }
}
}