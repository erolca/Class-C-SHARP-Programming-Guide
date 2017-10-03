public class Product {

    public int yearBuilt;
    public double maximumSpeed;

    public int Age(int currentYear) {
        int maximumSpeed = 100;  // hides the field
        System.Console.WriteLine("In Age(): maximumSpeed = " + maximumSpeed);
        int age = currentYear - yearBuilt;
        return age;
    }

    public double Distance(double initialSpeed, double time) {
        System.Console.WriteLine("In Distance(): maximumSpeed = " + maximumSpeed);
        return (initialSpeed + maximumSpeed) / 2 * time;
    }

}


class MainClass{

    public static void Main() {
        Product redPorsche = new Product();
        redPorsche.yearBuilt = 2000;
        redPorsche.maximumSpeed = 150;

        int age = redPorsche.Age(2001);
        System.Console.WriteLine("redPorsche is " + age + " year old.");
        System.Console.WriteLine("redPorsche travels " + redPorsche.Distance(31, .25) + " miles.");

    }
}