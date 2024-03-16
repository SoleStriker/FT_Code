using System;
using static System.Console;

class CookieDemo2
{
   static void Main()
   {
       CookieOrder order1 = new CookieOrder(101, "Arthur", "gluten-free chocolate chip", 1);
       CookieOrder order2 = new CookieOrder(102, "Brown", "sugar-free peanut butter", 2);
       CookieOrder order3 = new CookieOrder(103, "Cooper", "iced sugar", 3);

       SpecialCookieOrder specialOrder = new SpecialCookieOrder(104, "Davis", "Special: gluten-free chocolate chip", 1);

       WriteLine(order1);
       WriteLine(order2);
       WriteLine(order3);
       WriteLine(specialOrder);
   }
}

class CookieOrder
{
   public int OrderNum;
   public string Name;
   public string CookieType;
   public int Dozen;
   public int Price;

   public CookieOrder(int OrderNum, string Name, string CookieType, int Dozen)
   {
       this.OrderNum = OrderNum;
       this.Name = Name;
       this.CookieType = CookieType;
       this.Dozen = Dozen;
       this.Price = CalculatePrice(Dozen);
   }

   public virtual int CalculatePrice(int dozen)
   {
       if (dozen <= 2)
       {
           return 15 * dozen;
       }
       else
       {
           return 13 * dozen;
       }
   }

   public override string ToString()
   {
       string message = $"Order: {OrderNum}   Name: {Name}\n" +
                       $"    Type: {CookieType}\n" +
                       $"    {Dozen} dozen --- {Price} ";
       return message;
   }
}

class SpecialCookieOrder : CookieOrder
{
    public SpecialCookieOrder(int OrderNum, string Name, string CookieType, int Dozen)
        : base(OrderNum, Name, CookieType, Dozen)
   {
       this.OrderNum = OrderNum;
       this.Name = Name;
       this.CookieType = CookieType;
       this.Dozen = Dozen;
       this.Price = CalculatePrice(Dozen);
   }

   public override int CalculatePrice(int dozen)
   {
       if (dozen <= 2)
       {
           return 10 * dozen;
       }
       else
       {
           return 8 * dozen;
       }
   }

   public override string ToString()
   {
       string message = $"Order: {OrderNum}   Name: {Name}\n" +
                       $"    Type: {CookieType}\n" +
                       $"    {Dozen} dozen --- {Price} ";
       return message;
   }
}
