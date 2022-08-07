class Vainilla: Decorador
{
    public Vainilla(OrdenBase orden): base(orden)
    {
    }

    public override double CalcularPrecio()
    {
        return base.CalcularPrecio() + 0.50;
    }
}   

