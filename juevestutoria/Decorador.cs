class Decorador: OrdenBase
{
    protected OrdenBase orden;

    public Decorador (OrdenBase orden)
    {
        this.orden=orden;
    }

    public virtual double CalcularPrecio()
    {
        Console.WriteLine("Precio calculado desde el decorador");
        return orden.CalcularPrecio();
    }
}

