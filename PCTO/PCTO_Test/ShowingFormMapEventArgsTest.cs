using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using PCTO;

namespace PCTO_Test
{
    public class ShowingFormMapEventArgsTest
    {
        #region ShowingFormMapEventArgsTest
        [Fact]
        public void ShowingFormMapEventArgsTest1()
        {
            //Arrange
            List<Package> ListaPacchi = new List<Package>();
            Address address = new Address("31a", "Via Giacomo Leopardi", "Milano", "MI");
            Address address1 = new Address("20a", "Via Dante Alighieri", "Bergamo", "BG");
            ListaPacchi.Add(new Package(address, 1, 4, "beta"));
            ListaPacchi.Add(new Package(address1, 2, 3, "alfa"));

            //Act
            ShowingFormMapEventArgs s = new ShowingFormMapEventArgs(address, ListaPacchi);

            //Assert
            s.CurrentAddress.Number.Should().Be("31a");
            s.CurrentAddress.Street.Should().Be("Via Giacomo Leopardi");
            s.CurrentAddress.Town.Should().Be("Milano");
            s.CurrentAddress.Province.Should().Be("MI");

            s.Packages.Count.Should().Be(2);
            s.Packages[0].Destination.Should().Be(address);
            s.Packages[1].Destination.Should().Be(address1);
        }
        #endregion
    }
}
