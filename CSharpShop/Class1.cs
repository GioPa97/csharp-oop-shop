namespace CSharpShop
{
    public class prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;

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
        public int getIva()
        {
            return this.iva;
        }
        //SETTER//----------------------------------------------------------------------------------
        public void setCodice(int codice)
        {
            this.codice = codice;
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
        public void setIva(int iva)
        {
            this.iva = iva;
        }
        //Costruttori----------------------------------------------------------------------------

        public prodotto(int codice, string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }


        //Metodi----------------------------------------------------------------------------------
        public double calcolaprezzoIvato(double prezzo)
        {

            double prezzoivato = prezzo * 1.22f;
            return prezzoivato;
        }

        public void creaNomeEsteso()
        {
            string codiceString = this.codice.ToString();
            string nomeEsteso = codiceString += this.nome;


        }

        public void creaCodice()

        {
            Random num1 = new Random(8);
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(num1.Next());
            }


        }


        public void stampaProdotto()
        {
            int codice = getCodice();
            string nome = getNome();
            string descrizione = getDescrizione();
            double prezzo = getPrezzo();
            int iva = getIva();
            Console.WriteLine("Info" + " " + nome + "----------------------");
            Console.WriteLine("Codice prodotto:" + " " + codice);
            Console.WriteLine("Nome prodotto:" + " " + nome);
            Console.WriteLine("Descrizione prodotto:" + " " + descrizione);
            Console.WriteLine("Prezzo prodotto:" + " " + prezzo +"€");
            Console.WriteLine("Iva prodotto:" + " " + iva + "%");
            Console.WriteLine("____________________________________");
        }

        //------------------------------------------------------------------------------------------
    }
}
