using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyCacheService
{
    public class JCDecauxItem
    {
        //List<Station> stations;

        /*public List<Station> Stations        
        {
            get { return stations; }
        }*/

        Station oneStation;

        public Station OneStation
        {
            get { return oneStation; }
        }

        RequestsJCDecaux request = new RequestsJCDecaux();
        public JCDecauxItem(string chaineItemName)
        {
            string[] stationNumberAndContractName = chaineItemName.Split('_');
            int stationNumber = int.Parse(stationNumberAndContractName[0]);
            string contractName = stationNumberAndContractName[1];

            //stations = request.GetAllStations();

            station = request.GetOneStation(stationNumber, contractName);
        }

    }
}
