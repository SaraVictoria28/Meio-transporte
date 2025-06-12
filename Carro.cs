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

        public virtual double Gasto()
        {
            return Distancia / Consumo * Gasolina;
        }
        public override double Tempo()
        {
            return base.Tempo();
        }
        public virtual string ToString()
        {
            return $"O tempo de duração em média vai ser de {Tempo()}m, gastando R${Gasto()} ";
        }
    }
}
