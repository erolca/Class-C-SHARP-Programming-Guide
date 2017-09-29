using System;

public class Product
{
    public string make;
    public string model;

    public Product(string make, string model)
    {
        this.make = make;
        this.model = model;
    }

    public void Display()
    {
        Console.WriteLine("make = " + make);
        Console.WriteLine("model = " + model);
    }

    public static Product Copy(Product p)
    {
        return (Product)p.MemberwiseClone();
        
    }
}
class MainClass
{

    public static void Main()
    {
        Console.WriteLine("Creating Product objects");
        Product myProduct = new Product("Toyota", "MR2");
        Product myOtherProduct = new Product("Porsche", "Boxter");
        myProduct.Display();
        myOtherProduct.Display();

        Console.WriteLine("myProduct.ToString() = " + myProduct.ToString());
        Console.WriteLine("myProduct.GetType() = " + myProduct.GetType());
        Console.WriteLine("myProduct.GetHashCode() = " + myProduct.GetHashCode());
        Console.WriteLine("Product.Equals(myProduct, myOtherProduct) = " + Product.Equals(myProduct, myOtherProduct));
        Console.WriteLine("Product.ReferenceEquals(myProduct, myOtherProduct) = " + Product.ReferenceEquals(myProduct, myOtherProduct));

        myProduct = myOtherProduct;

        Console.WriteLine("Product.Equals(myProduct, myOtherProduct) = " + Product.Equals(myProduct, myOtherProduct));
        Console.WriteLine("Product.ReferenceEquals(myProduct, myOtherProduct) = " + Product.ReferenceEquals(myProduct, myOtherProduct));

        Product myOldProduct = Product.Copy(myProduct);
        myOldProduct.Display();

    }

}