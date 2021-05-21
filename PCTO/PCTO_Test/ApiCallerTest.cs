using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using PCTO;


namespace PCTO_Test
{
    public class ApiCallerTest
    {
        #region GetApiResultTest
        [Fact]
        public void GetApiReultTest1()
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

        [Fact]
        public void GetApiReultTest2()
        {
            //Arrange
            Address a = new Address("18", "Viale Giulio Cesare", "Bergamo", "BG");
            //Act
            var mock = new Mock<IApiCaller>();
            mock.Setup(foo => foo.GetApiResult(It.IsAny<string>()))
                .Returns(new ApiResult() { Data = new List<Coordinates>() { new Coordinates() { Lat = 45.709380M, Lng = 9.680813M } }.ToArray() });
            CoordinateHelper h = new CoordinateHelper(mock.Object);
            h.SetCoordinates(a);
            //Assert
            a.Coordinates.Lat.Should().Be(45.709380M);
            a.Coordinates.Lng.Should().Be(9.680813M);
        }
        #endregion
    }
}
