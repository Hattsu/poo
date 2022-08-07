class Crema: Decorador
{
    public Crema(OrdenBase orden): base(orden)
    {
    }

    public override double CalcularPrecio()
    {
        return base.CalcularPrecio() + 1.00;
    }
}  