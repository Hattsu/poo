class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------");
        OrdenBase pedido1 = new Cafe();

        pedido1 = new leche(pedido1);
        pedido1 = new azucar(pedido1);
        pedido1 = new miel(pedido1);

        Console.WriteLine($"Producto: {pedido1.Descripcion} tiene un costo de: ${pedido1.Costo}");
        
        Console.WriteLine("\n-------------------");
        OrdenBase pedido2 = new Cocoa();

        pedido2 = new leche(pedido2);
        pedido2 = new azucar(pedido2);
        pedido2 = new miel(pedido2);

        Console.WriteLine($"Producto: {pedido2.Descripcion} tiene un costo de: ${pedido2.Costo}");

        Console.WriteLine("\n -------------------");
        OrdenBase pedido3 = new Te();

        pedido3 = new leche(pedido3);
        pedido3 = new azucar(pedido3);
        pedido3 = new miel(pedido3);

        Console.WriteLine($"Producto: {pedido3.Descripcion} tiene un costo de: ${pedido3.Costo}");
    }
}