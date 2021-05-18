using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PCTO;
using FluentAssertions;
using static PCTO.Package;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace PCTO_Test
{
   public class PackageTest
   {
        #region GetPackages
        [Fact]
        public void GetPackageByIdTest()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));
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
        public void GetPackagesQuantityTest()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));

            //Act          
            var quantitaPacchi = GetPackagesQuantity();

            //Assert
            quantitaPacchi.GetType().Should().Be(typeof(int));
            quantitaPacchi.Should().BeGreaterOrEqualTo(0);
        }
        [Fact]
        #endregion

        public void ToDto()
        {
            //Arrange
                       
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, 2, 3, "alfa");           

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
        public void Topackage()
        {
            //Arrange
            PackDTO pacco = new PackDTO("123", 2, 3, "12", "Via Giacomo Leopardi", "Calusco D'Adda", "BG");
            

            //Act          
            var package=pacco.ToPackage();


            //Assert
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

        #region Isvalid
        [Fact]
        public void Isvalidtest1()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, 2, 3, "alfa");

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
            Package pacco = new Package(address1, -1, 3, "alfa");

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
            Package pacco = new Package(address1, 2, -3, "alfa");

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
            Package pacco = new Package(address1, 2, -3, "alfa");

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
            Package pacco = new Package(address1, 2, -3, "alfa");

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
            Package pacco = new Package(address1, 2, -3, "alfa");

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
            Package pacco = new Package(address1, 2, -3, "alfa");

            //Act
            var valido = pacco.IsValid;

            //Assert
            valido.Should().Be(false);
        }
        [Fact]
        public void IsvalidtestCoordinates()
        {
            //Arrange

            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "");
            Package pacco = new Package(address1, 2, -3, "alfa");

            //Act
            var valido = pacco.IsValid;

            //Assert
            valido.Should().Be(false);
        }
        #endregion

        #region GetPackagesFromJson
        [Fact]
        public void GetPackagesFromJsonExist()
        {
            //Arrange
            string file = "file.json";
            
            //Act
            Assert.True(File.Exists(file));

        }
        [Fact]
        public void GetPackagesFromJsonNotExist()
        {
            //Arrange
            string file = "elif.json";

            //Act
            Assert.False(File.Exists(file));

        }

        [Fact]
        public void GetPackagesFromJsonCount()
        {
            //Act
            List<Package> json = GetPackagesFromJson();
            var jsoncount = json.Count();

            //Assert
            jsoncount.Should().Be(13);
        }
        
        [Fact]
        public void GetPackagesFromJsonFirst()
        {
            //Act
            var json = GetPackagesFromJson();
            var jsonfirst = json.First();

            //Assert
            jsonfirst.Id.Should().Be("AAAA");
            jsonfirst.Volume.Should().Be(3);
            jsonfirst.Weight.Should().Be(5);
            jsonfirst.Destination.Number.Should().Be("32");
            jsonfirst.Destination.Street.Should().Be("Via Giacomo Manzù");
            jsonfirst.Destination.Town.Should().Be("Terno d'Isola");
            jsonfirst.Destination.Province.Should().Be("BG");
            jsonfirst.Destination.Coordinates.Lat.Should().Be(45.68299M);
            jsonfirst.Destination.Coordinates.Lng.Should().Be(9.53841M);
            jsonfirst.Destination.Coordinates.Confidence.Should().Be(9);
        }
        #endregion

        #region Controlvalue
        [Fact]
        public void ControlValueTestNegative()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));
            var x = -2;

            //Assert
            Assert.Throws<ArgumentException>(() => ControlValue(x, ListaPacchi));
        }
        [Fact]
        public void ControlValueTestPositiveMorethanCount()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));
            var x = 10;

            //Assert
            Assert.Throws<ArgumentException>(() => ControlValue(x, ListaPacchi));
        }
        #endregion

        #region randomize
        [Fact]
        public void RandomizeResultTestCount()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));

            //Act
            var lista = RandomizeResult(ListaPacchi);

            //Assert
            lista.Count().Should().Be(ListaPacchi.Count());
        }
        /*
        [Fact]
        public void RandomizeResultTest()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, "beta", 1, 4));
            ListaPacchi.Add(new Package(address1, "alfa", 2, 3));

            //Act
            var lista = RandomizeResult(ListaPacchi).First();

            //Assert
            lista.Id.Should().NotBe(ListaPacchi[0].Id);
        }*/
        #endregion
    }
}
