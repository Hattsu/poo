internal class Program
{
    private static void Main(string[] args)
    {
     
        Console.WriteLine("HELADO DE COCO");
       var heladoCoco = new HeladoDeCoco();
       Console.WriteLine($"El precio del helado de coco es de: {heladoCoco.CalcularTotalPrecio()}");
       var topping1 = new Toping1(heladoCoco);
       Console.WriteLine($"El precio del helado de coco con un topping es de: {topping1.CalcularTotalPrecio()}");
       var topping2 = new Topping2(heladoCoco);
       Console.WriteLine($"El precio del helado de coco con dos toppings es de: {topping2.CalcularTotalPrecio()}");
       var topping3 = new Topping3(heladoCoco);
       Console.WriteLine($"El precio del helado de coco con tres toppings es de: {topping3.CalcularTotalPrecio()}");
       Console.WriteLine();
       
       Console.WriteLine("HELADO DE FRESA");
       var heladoFresa = new HeladoFresa();
       Console.WriteLine($"El precio del helado de fresa es de: {heladoFresa.CalcularTotalPrecio()}");
       var toppingUno = new Toping1(heladoFresa);
       Console.WriteLine($"El precio del helado de fresa con un topping es de: {toppingUno.CalcularTotalPrecio()}");
       var toppingDos = new Topping2(heladoFresa);
       Console.WriteLine($"El precio del helado de fresa con dos toppings es de: {toppingDos.CalcularTotalPrecio()}");
       var toppingTres = new Topping3(heladoFresa);
       Console.WriteLine($"El precio del helado de fresa con tres toppings es de: {toppingTres.CalcularTotalPrecio()}");
       Console.WriteLine();
       
       Console.WriteLine("HELADO DE CHOCOLATE");
       var heladoChocolate = new HeladoChocolate();
       Console.WriteLine($"El precio del helado de chocolate es de: {heladoChocolate.CalcularTotalPrecio()}");
       var topUno = new Toping1(heladoChocolate);
       Console.WriteLine($"El precio del helado de chocolate con un topping es de: {topUno.CalcularTotalPrecio()}");
       var topDos = new Topping2(heladoChocolate);
       Console.WriteLine($"El precio del helado de chocolate con dos toppings es de: {topDos.CalcularTotalPrecio()}");
       var topTres = new Topping3(heladoChocolate);
       Console.WriteLine($"El precio del helado de chocolate con tres toppings es de: {topTres.CalcularTotalPrecio()}");
       Console.WriteLine();
    }
}