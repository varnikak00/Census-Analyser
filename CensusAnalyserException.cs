using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    class CensusAnalyserException
    {
        private string v;
        private object nO_SUCH_COUNTRY;

        public CensusAnalyserException(string v, object nO_SUCH_COUNTRY)
        {
            this.v = v;
            this.nO_SUCH_COUNTRY = nO_SUCH_COUNTRY;
        }

        public static object ExceptionType { get; internal set; }
    }
}
