class Canela: Decorador
{
    public Canela(OrdenBase orden): base(orden)
    {
    }

    public override double CalcularPrecio()
    {
        return base.CalcularPrecio() + 0.25;
    }
}  