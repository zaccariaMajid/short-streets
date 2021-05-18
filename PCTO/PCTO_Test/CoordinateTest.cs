using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using static PCTO.Confidences;
using PCTO;
using static PCTO.Coordinates;
using static PCTO.CoordinatesRange;

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

        //[Fact]
        //public void ControlLogicTest()
        //{
        //    Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
        //    //Act
        //    var result= ControlLogic(new Coordinates(70.0M, 120.0M), new Coordinates(80.0M, 130.0M));
        //    //Assert
        //    result.Should().BeOfType(typeof(decimal));
        //    result.Should().Be(-180.0M);
        //}
        #endregion
    }
}
