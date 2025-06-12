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

        public double Cobrador()
        {
            return Tarifa * Passagem;
        }

    }
}
