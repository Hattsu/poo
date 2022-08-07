class Toping1 : ToppingDecorador
{
    public Toping1(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0.25;
    }
}