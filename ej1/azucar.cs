public class azucar:AdicionalDecordador
{
    public azucar(OrdenBase bebida):base(bebida){}
    public override double Costo => _bebida.Costo + 0.5;
    public override string Descripcion => string.Format($"{_bebida.Descripcion}, azucar");
}