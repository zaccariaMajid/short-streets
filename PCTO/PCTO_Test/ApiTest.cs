using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;
using PCTO;
using Moq;
using static PCTO.ResultApi;

namespace PCTO_Test
{
    public class ApiTest
    {
          [Fact]
        public void SetCordinates_ShouldWork()
        {
            Address a = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");

            var mock = new Mock<IApiCaller>();
            mock.Setup(foo => foo.GetApiResult(It.IsAny<string>()))
                .Returns(new ResultApi() { Data = new List<ApiData>() { new ApiData() { Latitude = 45.690494M, Longitude = 9.681876M } }.ToArray() });
            
            CoordinateHelper h = new CoordinateHelper(mock.Object);
            h.SetCoordinates(a);
            a.Latitude.Should().Be(45.690494M);
            a.Longitude.Should().Be(9.681876M);
        }
        //{"data":[{"latitude":45.690494,"longitude":9.681876,"type":"address","name":"Via Mauro Gavazzeni 29a","number":"29a","postal_code":"24125","street":"Via Mauro Gavazzeni","confidence":1,"region":"Bergamo","region_code":"BG","county":null,"locality":"Bergamo","administrative_area":"Bergamo","neighbourhood":null,"country":"Italy","country_code":"ITA","continent":"Europe","label":"Via Mauro Gavazzeni 29a, Bergamo, BG, Italy"},{"latitude":45.690181,"longitude":9.6809,"type":"address","name":"Via Mauro Gavazzeni 29","number":"29","postal_code":"24125","street":"Via Mauro Gavazzeni","confidence":1,"region":"Bergamo","region_code":"BG","county":null,"locality":"Bergamo","administrative_area":"Bergamo","neighbourhood":null,"country":"Italy","country_code":"ITA","continent":"Europe","label":"Via Mauro Gavazzeni 29, Bergamo, BG, Italy"}]}
    }


}
