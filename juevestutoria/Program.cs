class  Program
{
    public static void Main (string []args)
    {
        var orden1=new CafeAme();
        Console.WriteLine($"El precio de un cafe americano es de: {orden1.CalcularPrecio()}");
        var vainilla=new Vainilla(orden1);
        Console.WriteLine($"El precio de un cafe americano mas vainilla es de: {vainilla.CalcularPrecio()}");
        var crema=new Crema(orden1);
        Console.WriteLine($"El precio de un cafe americano mas crema es de: {crema.CalcularPrecio()}");

    }
}
