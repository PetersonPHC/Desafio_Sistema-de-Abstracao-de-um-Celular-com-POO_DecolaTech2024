namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string _Numero { get; set; }
        protected string _Modelo { get; set; }
        protected string _IMEI { get; set; }
        protected int _Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this._Numero = numero;
            this._Modelo = modelo;
            this._IMEI = imei;
            this._Memoria = memoria;
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