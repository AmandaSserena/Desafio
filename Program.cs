Carro c1 = new Carro();

Moto m1 = new Moto();

List<Veiculo> veiculos = new List<Veiculo>();

veiculos.Add(c1);
veiculos.Add(m1);


foreach(var veiculo in veiculos)
{

    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();

    
}