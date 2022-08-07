class Topping3:ToppingDecorador
{
    public Topping3(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0.45;
    }
}