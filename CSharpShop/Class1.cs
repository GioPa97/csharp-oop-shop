namespace CSharpShop
{
    public class prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
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
        public float getPrezzo()
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
        public void setPrezzo(float prezzo)
        {
            this.prezzo = prezzo;
        }
        public void setIva(int iva)
        {
            this.iva = iva;
        }
        //Costruttori----------------------------------------------------------------------------

        public prodotto()
        {
            int codice;
            string nome;
            string descrizione;
            float prezzo;
            int iva;
        }


        //Metodi----------------------------------------------------------------------------------
        public float calcolaprezzoIvato(float prezzo)
        {

            float prezzoivato = prezzo * 1.22f;
            return prezzoivato;
        }
    }
}
