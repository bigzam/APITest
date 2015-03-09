using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.MetaAnalytics.RestClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiDataTest
{
    [TestClass]
    public class ApiTest
    {
        private const string ApiKey = "DEMO_KEY";
        private const string BaseUrl = "http://api.data.gov/nrel/alt-fuel-stations/v1/";
        private const string NearestStationUrlFormat = "nearest.json?api_key={0}&location={1}";
        private const string StationByIdUrlFormat = "{0}.json?api_key={1}";
        private readonly HttpClientHelper client = new HttpClientHelper();

        [TestMethod]
        public void TestAltStationsApi()
        {
            Uri requestUri = GetRequestUri(NearestStationUrlFormat, ApiKey, "Austin+TX");

            NearestFuelStationResponse nearestResponse = client.Get<NearestFuelStationResponse>(requestUri);

            IEnumerable<FuelStationRecord> stations = nearestResponse.Fuel_Stations.Where(
                s => s.EV_Network.Equals("ChargePoint Network", StringComparison.InvariantCultureIgnoreCase));
            
            Assert.IsNotNull(stations, "List of stations is empty.");


            FuelStationRecord fuelStationRecord = stations.FirstOrDefault(s => s.Station_Name.Equals("HYATT AUSTIN", StringComparison.InvariantCultureIgnoreCase));

            Assert.IsNotNull(fuelStationRecord, "There is no fuel station with HYAT AUSTIN name");

            int? stationId = fuelStationRecord.Id;
            string stationAddress = fuelStationRecord.Street_Address;

            Assert.AreEqual(62029, stationId, "Expected and actual station Id are not equal");
            
            requestUri = GetRequestUri(StationByIdUrlFormat, stationId, ApiKey);
            StationResponse stationResponse = client.Get<StationResponse>(requestUri);

            Assert.IsNotNull(stationResponse.Alt_Fuel_Station, "There is no station with id " + stationId);
            Assert.AreEqual(stationAddress, stationResponse.Alt_Fuel_Station.Street_Address, true);
        }

        private static Uri GetRequestUri(string format, params object[] args)
        {
            string relativePath = string.Format(CultureInfo.InvariantCulture, format, args);
            return new Uri( Path.Combine(BaseUrl, relativePath));
        }
    }
}
