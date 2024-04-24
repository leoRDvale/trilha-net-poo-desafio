namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public long Numero { get; set; }
        private string Modelo { get; set;}
        private long Imei { get; set;}
        private int Memoria { get; set;}
        



        public Smartphone(long numero, string modelo, long imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}