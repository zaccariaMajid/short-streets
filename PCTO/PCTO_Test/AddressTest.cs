using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using PCTO;

namespace PCTO_Test
{
    public class AddressTest
    {
        #region ToCompleteAddressTest
        [Fact]
        public void ToCompleteAddressTest1()
        {
            //Arrange
            var Address = new Address("30a", "Via Manzoni", "Milano", "MI");

            //Act
            var result = Address.ToCompleteAddress();

            //Assert
            result.Should().Be("Via Manzoni 30a Milano");
            result.Length.Should().Be(22);
        }

        [Fact]
        public void ToCompleteAddressTest2()
        {
            //Arrange
            var Address = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");

            //Act
            var result = Address.ToCompleteAddress();

            //Assert
            result.Should().Be("Via Gavazzeni 29a Bergamo");
            result.Length.Should().Be(25);
        }
        #endregion

        #region ToStringTest()
        [Fact]
        public void ToString1()
        {
            //Arrange
            var Address = new Address("30a", "Via Manzoni", "Milano", "MI");

            //Act
            var result = Address.ToString();

            //Assert
            result.Should().Be("Via Manzoni 30a, Milano (MI)");
        }

        [Fact]
        public void ToString2()
        {
            //Arrange
            var Address = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");

            //Act
            var result = Address.ToString();

            //Assert
            result.Should().Be("Via Gavazzeni 29a, Bergamo (BG)");
        }
        #endregion
    }
}
