using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PCTO;
using FluentAssertions;
using static PCTO.Package;
using System.IO;
using System.Linq;

namespace PCTO_Test
{
    public class PackDTOTest
    {
        #region ToStringTest
        [Fact]
        public void ToStringTest1()
        {
            //Arrange
            PackDTO packdto = new PackDTO("alfa", 3, 4, "20a", "Via Dante Alighieri", "Bergamo", "BG");

            //Act
            var result = packdto.ToString();

            //Assert
            result.Length.Should().Be(58);
            result.Should().Be("alfa - 3 m³ - 4 Kg - Via Dante Alighieri 20a, Bergamo (BG)");
        }

        [Fact]
        public void ToStringTest2()
        {
            //Arrange
            PackDTO packdto = new PackDTO("beta", 5, 9, "31a", "Via Giacomo Leopardi", "Milano", "MI");

            //Act
            var result = packdto.ToString();

            //Assert
            result.Length.Should().Be(58);
            result.Should().Be("beta - 5 m³ - 9 Kg - Via Giacomo Leopardi 31a, Milano (MI)");
        }
        #endregion

        #region ToPackageTest
        [Fact]
        public void ToPackageTest()
        {
            //Arrange
            PackDTO pacco = new PackDTO("123", 2, 3, "12", "Via Giacomo Leopardi", "Calusco D'Adda", "BG");

            //Act          
            var package = pacco.ToPackage();

            //Assert
            package.Should().BeOfType(typeof(Package));
            package.Id.Should().Be(pacco.Id);
            package.Volume.Should().Be(pacco.Volume);
            package.Weight.Should().Be(pacco.Weight);
            package.Destination.Number.Should().Be(pacco.Number);
            package.Destination.Street.Should().Be(pacco.Street);
            package.Destination.Town.Should().Be(pacco.Town);
            package.Destination.Province.Should().Be(pacco.Province);
            package.Destination.Coordinates.Lat.Should().Be(pacco.Lat);
            package.Destination.Coordinates.Lng.Should().Be(pacco.Lng);
            package.Destination.Coordinates.Confidence.Should().Be(pacco.Confidence);
        }
        #endregion
    }
}
