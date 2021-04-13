using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;
using PCTO;
using Moq;
using static PCTO.ResultApi;

namespace PCTO_Test
{
    public class UnitTest1
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
       [Fact]
        public void Correttezzacoordinate1()
        {
            Address a = new Address("25a","Via San Rocco", "Solza", "BG");
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            a.Latitude.Should().BeInRange(45.6M,45.7M);
            a.Longitude.Should().BeInRange(9.4M,9.5M);
        }
        [Fact]
        public void Correttezzacoordinate2()
        {
            Address a = new Address("58", "Via Dante Alighieri", "Cagliari", "CA");
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            a.Latitude.Should().BeInRange(39.2M, 39.3M);
            a.Longitude.Should().BeInRange(9.1M, 9.2M);
        }

    }
}
