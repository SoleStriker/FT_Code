using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
    static void Main()
    {
        // Write your main here
        
        Photo photo1 = new Photo(8, 10);
        Photo photo2 = new Photo(8, 9);
        MattedPhoto mattedPhoto = new MattedPhoto(10, 12, "white matting");
        FramedPhoto framedPhoto = new FramedPhoto(8, 10, "silver frame", "modern");

        WriteLine(photo1);
        WriteLine(photo2);
        WriteLine(mattedPhoto);
        WriteLine(framedPhoto);


    }
}

class Photo
{
    
    private int width;
    private int height;
    protected double price;
    
    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Price
    {
        get
        {
            return price;
        }
    }
    
    public Photo(int width, int height)
    {
        this.width = width;
        this.height = height;

        // Set the base price based on dimensions
        if (width == 8 && height == 10)
            price = 3.99;
        else if (width == 10 && height == 12)
            price = 5.99;
        else
            price = 9.99;
    }

    public override string ToString()
    {
        return $"{GetType().Name} - Width: {Width}, Height: {Height}, Price: ${Price}";
    }
}

class MattedPhoto : Photo
{
    private string color;
    
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public MattedPhoto(int Height, int Width, string color) :base(Width, Height)
    {
        this.color = color;
        price += 10;

    }
}

class FramedPhoto : Photo
{
    private string material;
    private string style;

    public string Material
    {
        get { return material; }
        set { style = value; }
    }

    public string Style
    {
        get { return style; }
        set { style = value;  }
    }
    
    public FramedPhoto(int Width, int Height, string material, string style) :base (Width, Height)
    {
        this.material = material;
        this.style = style;
        price += 10;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Material: {Material}, Style: {Style}";
    }
}
