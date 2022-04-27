using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProxyCacheService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ProxyService : IProxyService
    {
        RequestsJCDecaux request;
        public Station GetStation(int number, string contractName)
        {
            string chaineItemName = number + "_" + contractName;
            ProxyCache<JCDecauxItem> cache = new ProxyCache<JCDecauxItem>();

            return cache.Get(chaineItemName).OneStation;
        }

        public List<Station> GetAllStations()
        {
            request = new RequestsJCDecaux();

            return request.GetAllStations();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
