using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using PCTO;
using static PCTO.Demo;

namespace PCTO_Test
{
    public class DemoTest
    {
        #region SimulatePreviousAddressTest

        [Fact]
        public void SimulatePreviousAddressesTest()
        {
            //Arrange
            List<Address> addresslist = new List<Address>();

            //Act
            addresslist.AddRange(SimulatePreviousAddresses());

            //Assert
            addresslist.Count.Should().Be(3);
            addresslist[1].Number.Should().Be("53");
            addresslist[2].Number.Should().Be("9");
        }
        #endregion
    }
}
