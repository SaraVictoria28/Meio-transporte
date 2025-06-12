namespace Exercicio_heranca
{
    public class Onibus : MeioTransporte
    {
        public double Tarifa { get; set; }
        public int Passagem { get; set; }

        public Onibus(double velocidade, int distancia)
            : base(velocidade, distancia)
        {
            Velocidade = velocidade;
            Distancia = distancia;
        }

        public virtual double Gasto()
        {
            return Tarifa * Passagem;
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
