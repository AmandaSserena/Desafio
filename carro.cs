public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 10;
        Console.WriteLine("Acelerando o carro");
    }

    public override void Frear()
    {
        velocidade -= 5;
        Console.WriteLine("Freando o carro");
    }                         
}