﻿using System;
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
        #region ControlLatitudeTest
        [Fact]
        public void ControlLatitudeTest1()
        {
            //Act
            var result = ControlLatitude(55.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(55.0M);
        }

        [Fact]
        public void ControlLatitudeTest2()
        {
            //Act
            var result = ControlLatitude(100.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(90.0M);
        }

        [Fact]
        public void ControlLatitudeTest3()
        {
            //Act
            var result = ControlLatitude(-100.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(-90.0M);
        }
        #endregion

        #region ControlLongitudeTest
        [Fact]
        public void ControlLongitude1()
        {
            //Act
            var result = ControlLongitude(55.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(55.0M);
        }

        [Fact]
        public void ControlLongitude2()
        {
            //Act
            var result = ControlLongitude(190.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(180.0M);
        }

        [Fact]
        public void ControlLongitude3()
        {
            //Act
            var result = ControlLongitude(-190.0M);
            //Assert
            result.Should().BeOfType(typeof(decimal));
            result.Should().Be(-180.0M);
        }
        #endregion

        #region DictionaryConfidenceTest
        [Fact]
        public void DictionaryConfidenceTest1()
        {
            //Act
            var Lista = List[2];
            //Assert
            Lista.Should().Be("< 25 Km");
        }
        [Fact]
        public void DictionaryConfidenceTest2()
        {
            //Act
            var Lista = List[9];
            //Assert
            Lista.Should().Be("< 0,5 Km");
        }
        [Fact]
        public void DictionaryConfidenceTest3()
        {                   
            //Assert
            Assert.Throws<System.Collections.Generic.KeyNotFoundException>(() => List[12]);
        }
        [Fact]
        public void DictionaryConfidenceTest4()
        {
            //Assert
            Assert.Throws<System.Collections.Generic.KeyNotFoundException>(() => List[-12]);
        }
        #endregion
    }
}