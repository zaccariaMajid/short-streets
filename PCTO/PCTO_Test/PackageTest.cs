using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PCTO;
using FluentAssertions;
using static PCTO.Package;
using System.IO;

namespace PCTO_Test
{
   public class PackageTest
   {
        [Fact]
        public void GetPackageByIdTest()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, "beta", 1, 4));
            ListaPacchi.Add(new Package(address1, "alfa", 2, 3));
            string codice = "alfa";
           
            //Act          
            var pacco = GetPackageById(codice);
            
            //Assert
            pacco.Destination.Number.Should().Be("20a");
            pacco.Destination.Street.Should().Be("Via Dante Alighieri");
            pacco.Destination.Town.Should().Be("Bergamo");
            pacco.Destination.Province.Should().Be("BG");
            pacco.Id.Should().Be(codice);
            pacco.Volume.Should().Be(2);
            pacco.Weight.Should().Be(3);

        }
        [Fact]
        public void ToDto()
        {
            //Arrange
                       
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, "alfa", 2, 3);           

            //Act          
            var paccodto = pacco.ToDTO();


            //Assert
            paccodto.Id.Should().Be(pacco.Id);
            paccodto.Volume.Should().Be(pacco.Volume);
            paccodto.Weight.Should().Be(pacco.Weight);
            paccodto.Number.Should().Be(pacco.Destination.Number);
            paccodto.Street.Should().Be(pacco.Destination.Street);
            paccodto.Town.Should().Be(pacco.Destination.Town);
            paccodto.Province.Should().Be(pacco.Destination.Province);
            paccodto.Lat.Should().Be(pacco.Destination.Coordinates.Lat);
            paccodto.Lng.Should().Be(pacco.Destination.Coordinates.Lng);
            paccodto.Confidence.Should().Be(pacco.Destination.Coordinates.Confidence);
        }
        [Fact]
        public void Isvalidtest1()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, "alfa", 2, 3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(true);
        }
        [Fact]
        public void IsvalidtestVolume()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, "alfa", -1, 3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void IsvalidtestWeight()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, "alfa", 2, -3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void IsvalidtestNumber()
        {
            //Arrange

            Address address1 = new Address("", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, "alfa", 2, -3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void IsvalidtestStreet()
        {
            //Arrange

            Address address1 = new Address("20a", "", "Bergamo", "BG");
            Package pacco = new Package(address1, "alfa", 2, -3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void IsvalidtestTown()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "", "BG");
            Package pacco = new Package(address1, "alfa", 2, -3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void IsvalidtestProvince()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "");
            Package pacco = new Package(address1, "alfa", 2, -3);

            //Act
            var valido = pacco.IsValid;


            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void GetPackagesFromJsonTest()
        {
            //Arrange
            var json = GetPackagesFromJson();
        }

    }
}
