using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace PCTO
{
    public class CoordinateHelper
    {
        private readonly IApiCaller caller;

        public CoordinateHelper(IApiCaller caller)
        {
            this.caller = caller;
        }

        List<Coordinates> GetCoordinates(string completeAddress)
        {
            completeAddress = WebUtility.UrlEncode(completeAddress);
            var stuff = caller.GetApiResult(completeAddress);
            return stuff.Data.ToList();
        }

        public void SetCoordinates(Address address)
        {
            address.Coordinates = GetCoordinates(address.ToCompleteAddress()).FirstOrDefault();
        }
    }
}