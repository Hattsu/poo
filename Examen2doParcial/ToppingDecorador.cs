class ToppingDecorador : OrdenBase
{
    protected OrdenBase orden;

    public ToppingDecorador (OrdenBase orden)
    {
        this.orden = orden;
    }
    public virtual double CalcularTotalPrecio()
    {
        Console.WriteLine("Precio Calculado desde el decorador");
        return orden.CalcularTotalPrecio();
    }
}