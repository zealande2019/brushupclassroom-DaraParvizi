using System;
using System.Collections.Generic;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string _KlasseNavn;
        public  List<Studerende> _klasseListe;
        public DateTime _semesterStart;

        public string KlasseNavn
        {
            get { return _KlasseNavn; }
            set { _KlasseNavn = value; }
        }

        public List<Studerende> KlasseListe
        {
            get { return _klasseListe;}
            set { _klasseListe = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }
    }
}