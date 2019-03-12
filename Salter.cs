namespace Laboratoriska1
{
    internal class Salter
    {
        private string ime;
        private string prezime;
        private int godini;
        private string destinacija;

        public Salter()
        {
        }

        public Salter(string ime, string prezime, int godini, string destinacija)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godini = godini;
            this.destinacija = destinacija;

        }

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public int Godini
        {
            get
            {
                return godini;
            }
            set
            {
                godini = value;
            }
        }
        public string Destinacija
        {
            get
            {
                return destinacija;
            }
            set
            {
                destinacija = value;
            }
        }


    }
}