﻿using System.Collections.Generic;



namespace IndianStateCensusAnalyser
{

    public class CensusAnalyser
        {
            public enum Country
            {
                INDIA, US, BRAZIL
            }
            Dictionary<string, CensusDTO> dataMap;

            public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
            {
                dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
                return dataMap;
            }
        }
}
