public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 15;
        Console.WriteLine("Acelerando a moto");
    }

    public override void Frear()
    {
        velocidade -= 10;
        Console.WriteLine("Freando a moto");
    }
}