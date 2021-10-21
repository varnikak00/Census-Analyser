using POCO;

namespace IndianStateCensusAnalyser
{
    internal class CensusDTO
    {
        private StateCodeDAO stateCodeDAO;
        private CensusDataDAO censusDataDAO;

        public CensusDTO(StateCodeDAO stateCodeDAO)
        {
            this.stateCodeDAO = stateCodeDAO;
        }

        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.censusDataDAO = censusDataDAO;
        }
    }
}