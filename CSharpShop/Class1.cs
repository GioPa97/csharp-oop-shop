namespace CSharpShop
{
    public class prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;
        private double prezzoIvato;

        //GETTER//--------------------------------------------------------------------------------
        public int getCodice()
        {
            return this.codice;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getDescrizione()
        {
            return this.descrizione;
        }
        public double getPrezzo()
        {
            return this.prezzo;
        }

        public double getPrezzoIvato()
        {
            return this.prezzoIvato;
        }
        public int getIva()
        {
            return this.iva;
        }
        //SETTER//----------------------------------------------------------------------------------
        private int setCodice()
        {

            Random number = new Random();
            return number.Next(0, 100000000);

        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }
        public void setPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        public void setPrezzoIva(double prezzoIvato)
        {
            this.prezzoIvato = prezzoIvato;
        }
        public void setIva(int iva)
        {
            this.iva = iva;
        }
        //Costruttori----------------------------------------------------------------------------

        public prodotto( string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = this.setCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }


        //Metodi----------------------------------------------------------------------------------
        public void calcolaprezzoIvato()
        {

            int iva = getIva();
            double prezzo = getPrezzo();
            double percentualeIva = (prezzo * iva) / 100;
            double prezzoIvato = prezzo + percentualeIva;

            Console.WriteLine("Prezzo finale:" + " " + prezzoIvato + "EUR");
            Console.WriteLine("");
            Console.WriteLine("Di cui Iva:" + " " + percentualeIva);
        }

        public void creaNomeEsteso()
        {
            string codiceString = this.codice.ToString();
            string nomeEsteso = codiceString + this.nome;
            Console.WriteLine("Nome esteso:"+nomeEsteso);

        }


        public void stampaProdotto()
        {
            
            string nome = getNome();
            string descrizione = getDescrizione();
            double prezzo = getPrezzo();
            int iva = getIva();
            Console.WriteLine("Info" + " " + nome + "----------------------");
            creaNomeEsteso();
            Console.WriteLine("Codice prodotto:" + " " + this.codice);
            Console.WriteLine("Nome prodotto:" + " " + nome);
            Console.WriteLine("Descrizione prodotto:" + " " + descrizione);
            Console.WriteLine("Prezzo prodotto:" + " " + prezzo + "EUR");
            Console.WriteLine("Iva prodotto:" + " " + iva + "%");
            calcolaprezzoIvato();
            Console.WriteLine("____________________________________");
        }

        //------------------------------------------------------------------------------------------
    }
}
