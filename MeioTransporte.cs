namespace Exercicio_heranca
{
    public class MeioTransporte
    {
        public double Velocidade { get; set; }
        public double Distancia { get; set; }

        public MeioTransporte(double velocidade, double distacia)
        {
            Velocidade = velocidade;
            Distancia = distacia;
        }

        public virtual double Tempo()
        {
            double tempo = Distancia / Velocidade;
            return tempo * 60;
        }
    }
}
