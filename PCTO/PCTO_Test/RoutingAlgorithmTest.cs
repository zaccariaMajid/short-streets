using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using PCTO;
using static PCTO.RoutingAlgorithm;

namespace PCTO_Test
{
    public class RoutingAlgorithmTest
    {
        #region GetTripTest
        [Fact]
        public void GetTripTest1()
        {
            //Arrange
            List<RoutingPoint> listpoints = new List<RoutingPoint>();
            RoutingPoint point = new RoutingPoint(1, new List<int>() { 1, 2, 3 }, new List<int>() { 0, 1576, 1842}, 0, 0, false);

            RoutingPoint point1 = new RoutingPoint(2, new List<int>() { 1, 2, 3 }, new List<int>() { 1576, 0, 380 }, 8, 5, false);
            
            RoutingPoint point2 = new RoutingPoint(3, new List<int>() { 1, 2, 3 }, new List<int>() { 1842, 380, 0 }, 3, 1, false);
            
            listpoints.Add(point);
            listpoints.Add(point1);
            listpoints.Add(point2);

            //Act
            var result = GetTrip(listpoints);

            //Assert
            result.Should().BeOfType(typeof(List<Trip>));
            result.Count.Should().Be(1);
            result[0].Sol.Percorso.Count.Should().Be(3);
            result[0].Sol.Prezzo.Should().Be(3798);
        }

        [Fact]
        public void GetTripTest2()
        {
            //Arrange
            List<RoutingPoint> listpoints = new List<RoutingPoint>();
            RoutingPoint point = new RoutingPoint(1, new List<int>() { 1, 2, 3 }, new List<int>() { 0, 1577, 1820 }, 0, 0, false);

            RoutingPoint point1 = new RoutingPoint(2, new List<int>() { 1, 2, 3 }, new List<int>() { 1577, 0, 510 }, 8, 5, false);

            RoutingPoint point2 = new RoutingPoint(3, new List<int>() { 1, 2, 3 }, new List<int>() { 1820, 510, 0 }, 3, 1, false);

            listpoints.Add(point);
            listpoints.Add(point1);
            listpoints.Add(point2);

            //Act
            var result = GetTrip(listpoints);

            //Assert
            result.Should().BeOfType(typeof(List<Trip>));
            result.Count.Should().Be(1);
            result[0].Sol.Percorso.Count.Should().Be(3);
            result[0].Sol.Prezzo.Should().Be(3907);
            result[0].Sol.Percorso[0].Should().Be(1);
            result[0].Sol.Percorso[1].Should().Be(2);
            result[0].Sol.Percorso[2].Should().Be(3);
        }
        #endregion
    }
}
