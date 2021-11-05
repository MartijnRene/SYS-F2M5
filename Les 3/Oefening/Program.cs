using System;

namespace Oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 50);
            Rectangle vierkant = new Rectangle(50, 50, 50);

            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.Set(100, 100, 50, 50);

            Console.WriteLine("Hello World!");
        }
    }
}

class Rectangle
{
    private int x;
    private int y;
    private int width;
    private int height;

    public Rectangle(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public Rectangle(int x, int y, int size)
    {
        this.x = x;
        this.y = y;

        this.width = size;
        this.height = size;
    }
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public Rectangle(int size)
    {
        this.width = size;
        this.height = size;
    }

    public void MoveTo(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public bool IsSquare(bool i)
    {
        if (height == width)
        {
            i = true;
        }
        else
        {
            i = false;
        }
        return i;
    }

    public void Set(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }
}