namespace Exercicio_heranca
{
    public class Carro : MeioTransporte
    {
        public double Gasolina { get; set; }
        public double Consumo { get; set; }

        public Carro(double velocidade, double distacia) : base(velocidade, distacia)
        {
            Velocidade = velocidade;
            Distancia = distacia;
        }

        public double Gasto()
        {
            return Distancia / Consumo * Gasolina;
        }
    }
}
