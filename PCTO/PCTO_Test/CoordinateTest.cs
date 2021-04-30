using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using static PCTO.Confidences;


namespace PCTO_Test
{
    public class CoordinateTest
    {
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
    }
}
