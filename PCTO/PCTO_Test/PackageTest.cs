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

        #region ToStringTest
        [Fact]
        public void ToStringTest1()
        {
            //Arrange
            Address address = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address, 2, 3, "alfa");

            //Act
            var result = pacco.ToString();

            //Assert
            result.Should().Be("Via Dante Alighieri 20a, Bergamo (BG) 2 m³ 3 Kg");
            result.Length.Should().Be(47);

        }

        [Fact]
        public void ToStringTest2()
        {
            //Arrange
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Package pacco = new Package(address, 6, 1, "alfa");

            //Act
            var result = pacco.ToString();

            //Assert
            result.Should().Be("Via Giacomo Leopardi 31a, Milano (MI) 6 m³ 1 Kg");
            result.Length.Should().Be(47);

        }
        #endregion

        #region IsvalidTest
        [Fact]
        public void IsValidTest1()
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
        public void IsValidTest2()
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
        public void IsValidTest3()
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
        public void IsValidTest4()
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
        public void IsValidTest5()
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
        public void IsValidTest6()
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
        public void IsValidTest7()
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
        public void IsValidTest8()
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

        #region GetPackagesByIdTest
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
        #endregion

        #region GetPackagesQuantityTest
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
        #endregion

        #region ToDTOTest
        [Fact]
        public void ToDTOTest()
        {
            //Arrange 
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, 2, 3, "alfa");           

            //Act          
            var paccodto = pacco.ToDTO();

            //Assert
            paccodto.Should().BeOfType(typeof(PackDTO));
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
        #endregion

        #region ToEmptyDTOTest
        [Fact]
        public void ToEmptyDTOTest()
        {
            //Arrange
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Package pacco = new Package(address1, 2, 3, "alfa");

            //Act          
            var paccodto = pacco.ToEmptyDTO();

            //Assert
            paccodto.Should().BeOfType(typeof(PackDTO));
            paccodto.Id.Should().Be(pacco.Id);
        }
        #endregion

        #region GetPresetDTOTest
        [Fact]
        public void GetPresetDTOTest()
        {
            //Arrange
            int x = 2;

            //Act
            var result = GetPresetDTO(x);

            //Assert
            result.Count.Should().Be(2);

        }
        #endregion

        #region GetPackagesFromJsonTest
        [Fact]
        public void GetPackagesFromJsonTest1()
        {
            //Arrange
            string file = "file.json";
            
            //Act
            Assert.True(File.Exists(file));
        }

        [Fact]
        public void GetPackagesFromJsonTest2()
        {
            //Arrange
            string file = "elif.json";

            //Act
            Assert.False(File.Exists(file));
        }

        [Fact]
        public void GetPackagesFromJsonTest3()
        {
            //Act
            List<Package> json = GetPackagesFromJson();
            var jsoncount = json.Count();

            //Assert
            jsoncount.Should().Be(13);
        }
        
        [Fact]
        public void GetPackagesFromJsonTest4()
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

        #region ControlvalueTest
        [Fact]
        public void ControlValueTest1()
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
        public void ControlValueTest2()
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

        #region RandomizeResultTest
        [Fact]
        public void RandomizeResultTest1()
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
        
        [Fact]
        public void RandomizeResultTest2()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            Address address2 = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));
            ListaPacchi.Add(new Package(address2, 3, 8, "Omega"));

            //Act
            var lista = RandomizeResult(ListaPacchi);

            //Assert
            lista.First().Id.Should().Be(ListaPacchi[0].Id);
        }
        #endregion
    }
}
