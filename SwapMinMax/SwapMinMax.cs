namespace SwapMinMax;

public class SwapMinMax
{
    public int a;
    public int b;
    public string c;
    public string d;
    public decimal e;
    public decimal f;

    public SwapMinMax(int a, int b, string c, string d, decimal e, decimal f)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.e = e;
        this.f = f;
    }


    public  void SwapInt()
    {
        (a, b) = (b, a);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }

    public void SwapString()
    {
        (c, d) = (d, c);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    public void SwapDecimal()
    {
        (e, f) = (f, e);
        Console.WriteLine(e);
        Console.WriteLine(f);
    }

    public void MaxInt()
    {
        int max;
        if (a > b)
        {
            max = a;
            
        }
        else
        {
            max = b;
        }
        Console.WriteLine(max);
    }
    public void MaxDecimal()
    {
        decimal max;
        if (e > f)
        {
            max = e;
        }
        else
        {
            max = f;
        }
        Console.WriteLine(max);
    }

    public void MinInt()
    {
        int min;
        if (a < b)
        {
            min = a;
        }
        else
        {
            min = b;
        }
        Console.WriteLine(min);
    }
    public void MinDecimal()
    {
        decimal min;
        if (e < f)
        {
            min = e;
        }
        else
        {
            min = f;
        }
        Console.WriteLine(min);

    }
    
    
}