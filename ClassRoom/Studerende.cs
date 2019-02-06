namespace ClassRoom
{
    public class Studerende
    {
        public string _navn;
        public int _fødselsdagmåned;
        public int _fødselsdag;

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