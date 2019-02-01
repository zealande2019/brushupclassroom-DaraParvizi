namespace ClassRoom
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsdagmåned;
        private int _fødselsdag;

        public Studerende( string Navn, int FødselsdagsMåned,int Fødselsdag)
        {
            Navn = _navn;
            _fødselsdagmåned = FødselsdagsMåned;
            _fødselsdag = Fødselsdag;
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int FødselsdagsMåned
        {
            get { return _fødselsdagmåned; }
            set { _fødselsdagmåned = value; }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag = value; }
        }
    }
}