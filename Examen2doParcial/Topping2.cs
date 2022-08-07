class Topping2:ToppingDecorador
{
     public Topping2(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0.50;
    }
}