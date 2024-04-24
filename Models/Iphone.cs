namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(long numero, string modelo, long imei, int memoria) : base(numero, modelo,imei,memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} está sendo instalado pela Appstore no iPhone ");
        }
    }
}