using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using static PCTO.Confidences;
using PCTO;
using static PCTO.Coordinates;
using static PCTO.CoordinatesRange;
using static PCTO.CoordinatesRangeManager;
using System.Linq;

namespace PCTO_Test
{
    public class CoordinateTest
    {
        #region dictionaryTest
        [Fact]
        public void DictionaryTest1()
        {
            //Act
            var Lista = List[2];
            //Assert
            Lista.Should().Be("< 25 Km");
        }
        [Fact]
        public void DictionaryTest2()
        {
            //Act
            var Lista = List[9];
            //Assert
            Lista.Should().Be("< 0,5 Km");
        }
        [Fact]
        public void DictionaryTest3()
        {                   
            //Assert
            Assert.Throws<System.Collections.Generic.KeyNotFoundException>(() => List[12]);
        }
        [Fact]
        public void DictionaryTest4()
        {
            //Assert
            Assert.Throws<System.Collections.Generic.KeyNotFoundException>(() => List[-12]);
        }
        #endregion

        #region latlngTest
        [Fact]
        public void Lat1()
        {
            //Act
            var result=ControlLatitude(55.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(55.0M);
        }

        [Fact]
        public void Lat2()
        {
            //Act
            var result = ControlLatitude(100.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(90.0M);
        }

        [Fact]
        public void Lat3()
        {
            //Act
            var result = ControlLatitude(-100.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(-90.0M);
        }

        [Fact]
        public void Lng1()
        {
            //Act
            var result = ControlLongitude(55.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(55.0M);
        }

        [Fact]
        public void Lng2()
        {
            //Act
            var result = ControlLongitude(190.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(180.0M);
        }

        [Fact]
        public void Lng3()
        {
            //Act
            var result = ControlLongitude(-190.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(-180.0M);
        }
        #endregion

        [Fact]
        public void ControlLogicTest1()
        {
            Address indirizzominimo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Address indirizzomassimo = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");

            indirizzominimo.Coordinates.Lat = 45.0M;
            indirizzominimo.Coordinates.Lng = 20.0M;
            indirizzomassimo.Coordinates.Lat = -5.0M;
            indirizzomassimo.Coordinates.Lng = 30.0M;
            //Act
            var ex = Assert.Throws<ArgumentException>(() => ControlLogic(indirizzominimo.Coordinates, indirizzomassimo.Coordinates));
            //Assert
            Assert.Equal("Min latitude must be lower than max latitude", ex.Message);
        }

        [Fact]
        public void ControlLogicTest2()
        {
            Address indirizzominimo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Address indirizzomassimo = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");

            indirizzominimo.Coordinates.Lat = 45.0M;
            indirizzominimo.Coordinates.Lng = 45.0M;
            indirizzomassimo.Coordinates.Lat = 60.0M;
            indirizzomassimo.Coordinates.Lng = 30.0M;
            //Act
            var ex = Assert.Throws<ArgumentException>(() => ControlLogic(indirizzominimo.Coordinates, indirizzomassimo.Coordinates));
            //Assert
            Assert.Equal("Min longitude must be lower than max longitude", ex.Message);
        }

        [Fact]
        public void ControlLogicTest3()
        {
            //Arrange
            Address indirizzominimo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Address indirizzomassimo = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");

            indirizzominimo.Coordinates.Lat = 45.0M;
            indirizzominimo.Coordinates.Lng = 20.0M;
            indirizzomassimo.Coordinates.Lat = 60.0M;
            indirizzomassimo.Coordinates.Lng = 30.0M;

            //Act
            var ex = ControlLogic(indirizzominimo.Coordinates, indirizzomassimo.Coordinates);

            //Assert
            ex.Should().BeOfType(typeof(List<Coordinates>));
            ex.Count.Should().Be(2);
            ex.First().Lat.Should().Be(45.0M);
            ex.First().Lng.Should().Be(20.0M);
            ex.Last().Lat.Should().Be(60.0M);
            ex.Last().Lng.Should().Be(30.0M);
        }

        #region IsInRange
        [Fact]
        public void IsInRangeTest1()
        {
            //Arrange
            CoordinatesRange a = new CoordinatesRange();
            a.MinCoordinates.Lat = -45.00M;
            a.MinCoordinates.Lng = -90.0M;
            a.MaxCoordinates.Lat = 45.00M;
            a.MaxCoordinates.Lng = 90.0M;

            Address indirizzo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            indirizzo.Coordinates.Lat = -30.0M;
            indirizzo.Coordinates.Lng = 20.0M;

            //Act
            bool result = IsInRange(a, indirizzo.Coordinates);

            //Assert
            result.Should().Be(true);
        }

        [Fact]
        public void IsInRangeTest2()
        {
            //Arrange
            CoordinatesRange a = new CoordinatesRange();
            a.MinCoordinates.Lat = -45.00M;
            a.MinCoordinates.Lng = -90.0M;
            a.MaxCoordinates.Lat = 45.00M;
            a.MaxCoordinates.Lng = 90.0M;

            Address indirizzo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            indirizzo.Coordinates.Lat = -60.0M;
            indirizzo.Coordinates.Lng = 20.0M;

            //Act
            bool result = IsInRange(a, indirizzo.Coordinates);

            //Assert
            result.Should().Be(false);
        }

        [Fact]
        public void IsInRangeTest3()
        {
            //Arrange
            CoordinatesRange a = new CoordinatesRange();
            a.MinCoordinates.Lat = -45.00M;
            a.MinCoordinates.Lng = -90.0M;
            a.MaxCoordinates.Lat = 45.00M;
            a.MaxCoordinates.Lng = 90.0M;

            Address indirizzo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            indirizzo.Coordinates.Lat = -30.0M;
            indirizzo.Coordinates.Lng = 110.0M;

            //Act
            bool result = IsInRange(a, indirizzo.Coordinates);

            //Assert
            result.Should().Be(false);
        }

        [Fact]
        public void IsInRangeTest4()
        {
            //Arrange
            CoordinatesRange a = new CoordinatesRange();
            a.MinCoordinates.Lat = -45.00M;
            a.MinCoordinates.Lng = -90.0M;
            a.MaxCoordinates.Lat = 45.00M;
            a.MaxCoordinates.Lng = 90.0M;

            Address indirizzo = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            indirizzo.Coordinates.Lat = -60.0M;
            indirizzo.Coordinates.Lng = 110.0M;

            //Act
            bool result = IsInRange(a, indirizzo.Coordinates);

            //Assert
            result.Should().Be(false);
        }

        #endregion
    }
}