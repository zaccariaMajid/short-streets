using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using PCTO;
using static PCTO.ApiResult;


namespace PCTO_Test
{
    public class ApiTest
    {
        #region Coordinates
        [Fact]
        public void SetCordinates_ShouldWork()
        {
            //Arrange
            Address a = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");
            //Act
            var mock = new Mock<IApiCaller>();
            mock.Setup(foo => foo.GetApiResult(It.IsAny<string>()))
                .Returns(new ApiResult() { Data = new List<Coordinates>() { new Coordinates() { Lat = 45.690494M, Lng = 9.681876M } }.ToArray() });
            CoordinateHelper h = new CoordinateHelper(mock.Object);
            h.SetCoordinates(a);
            //Assert
            a.Coordinates.Lat.Should().Be(45.690494M);
            a.Coordinates.Lng.Should().Be(9.681876M);
        }


        //{"data":[{"latitude":45.690494,"longitude":9.681876,"type":"address","name":"Via Mauro Gavazzeni 29a","number":"29a","postal_code":"24125","street":"Via Mauro Gavazzeni","confidence":1,"region":"Bergamo","region_code":"BG","county":null,"locality":"Bergamo","administrative_area":"Bergamo","neighbourhood":null,"country":"Italy","country_code":"ITA","continent":"Europe","label":"Via Mauro Gavazzeni 29a, Bergamo, BG, Italy"},{"latitude":45.690181,"longitude":9.6809,"type":"address","name":"Via Mauro Gavazzeni 29","number":"29","postal_code":"24125","street":"Via Mauro Gavazzeni","confidence":1,"region":"Bergamo","region_code":"BG","county":null,"locality":"Bergamo","administrative_area":"Bergamo","neighbourhood":null,"country":"Italy","country_code":"ITA","continent":"Europe","label":"Via Mauro Gavazzeni 29, Bergamo, BG, Italy"}]}
        [Fact]
        public void Correttezzacoordinate1()
        {
            //Arrange
            Address a = new Address("25a", "Via San Rocco", "Solza", "BG");
            //Act
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            //Assert
            a.Coordinates.Confidence.Should().BeInRange(0, 10);
            a.Coordinates.Lat.Should().BeInRange(45.6M, 45.7M);
            a.Coordinates.Lng.Should().BeInRange(9.4M, 9.5M);
        }
        [Fact]
        public void Correttezzacoordinate2()
        {
            //Arrange
            Address a = new Address("58", "Via Dante Alighieri", "Cagliari", "CA");
            //Act
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            //Assert
            a.Coordinates.Confidence.Should().BeInRange(0, 10);
            a.Coordinates.Lat.Should().BeInRange(39.2M, 39.3M);
            a.Coordinates.Lng.Should().BeInRange(9.1M, 9.2M);
        }

        [Fact]
        public void GetCoordinatesTest()
        {
            //Arrange
            Address a = new Address("58", "Via Dante Alighieri", "Cagliari", "CA");
            //Act
            var indirizzo = a.ToCompleteAddress();
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            var result= helper.GetCoordinates(indirizzo);
            //Assert
            result.Should().BeOfType(typeof(List<Coordinates>));
        }


        //[Fact]
        //public void Correttezzacoordinate3()
        //{
        //    //Arrange
        //    ApiCaller.Result Result = new ApiCaller.Result();
        //    Result.Results[0] = new ApiCaller.Results() { "45.690494", "9.681876", "9" };
        //    //Act
        //    IApiCaller caller = new ApiCaller();
        //    CoordinateHelper helper = new CoordinateHelper(caller);
        //    helper.SetCoordinates(a);
        //    //Assert
        //    a.Coordinates.Confidence.Should().BeInRange(0, 10);
        //    a.Coordinates.Lat.Should().BeInRange(39.2M, 39.3M);
        //    a.Coordinates.Lng.Should().BeInRange(9.1M, 9.2M);
        //}
        #endregion

        #region Api
        [Fact]
        public void FirstControlCoordinates()
        {
            Address a = new Address("32", "Via Giacomo Manzù", "Terno d'Isola", "BG");
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            a.Coordinates.Confidence.Should().BeInRange(0, 10);
            a.Coordinates.Lat.Should().BeInRange(45.6825M, 45.6833M);
            a.Coordinates.Lng.Should().BeInRange(9.5362M, 9.540M);
        }

        [Fact]
        public void SecondControlCoordinates()
        {
            Address a = new Address("3c", "Via Largo del Roccolo", "Terno d'Isola", "BG");
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            a.Coordinates.Confidence.Should().BeInRange(0, 10);
            a.Coordinates.Lat.Should().BeInRange(45.6878M, 45.6891M);
            a.Coordinates.Lng.Should().BeInRange(9.5240M, 9.5297M);
        }

        [Fact]
        public void ThirdControlCoordinates()
        {
            Address a = new Address("18", "Viale Giulio Cesare", "Bergamo", "BG");
            IApiCaller caller = new ApiCaller();
            CoordinateHelper helper = new CoordinateHelper(caller);
            helper.SetCoordinates(a);
            a.Coordinates.Confidence.Should().BeInRange(0, 10);
            a.Coordinates.Lat.Should().BeInRange(45.7074M, 45.7105M);
            a.Coordinates.Lng.Should().BeInRange(9.6787M, 9.6826M);
        }
        #endregion
    }
}
