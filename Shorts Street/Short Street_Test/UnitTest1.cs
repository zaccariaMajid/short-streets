using Shorts_Street;
using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Moq;

namespace Short_Street_Test
{
    public interface IPercorso
    {
        public List<int> Percorso(int vertice, int peso, int volume, int[] costi);
    }
    public class UnitTest1
    {
        [Fact]
        public void PercorsoMinimoTest()
        {
            //arrange
            List<vertici> dati = new List<vertici>();
            dati.Add(new vertici(1, new List<int>() { 6, 12, 17, 20 }, new List<int>() { 4, 2, 3, 3 }));
            dati.Add(new vertici(2, new List<int>() { 3, 10, 15, 19 }, new List<int>() { 4, 2, 2, 3 }));
            dati.Add(new vertici(3, new List<int>() { 2, 10, 12, 14, 20 }, new List<int>() { 4, 3, 2, 3, 2 }));
            dati.Add(new vertici(4, new List<int>() { 5, 9, 15 }, new List<int>() { 4, 2, 2 }));
            dati.Add(new vertici(5, new List<int>() { 4, 8, 9, 15 }, new List<int>() { 4, 6, 3, 2 }));
            dati.Add(new vertici(6, new List<int>() { 1, 16, 17 }, new List<int>() { 4, 2, 1 }));
            dati.Add(new vertici(7, new List<int>() { 14, 16 }, new List<int>() { 2, 3 }));
            dati.Add(new vertici(8, new List<int>() { 5, 13 }, new List<int>() { 6, 5 }));
            dati.Add(new vertici(9, new List<int>() { 4, 5, 11 }, new List<int>() { 2, 3, 7 }));
            dati.Add(new vertici(10, new List<int>() { 2, 3, 11, 14, 15 }, new List<int>() { 2, 2, 4, 4, 1 }));
            dati.Add(new vertici(11, new List<int>() { 9, 10, 13, 14, 18 }, new List<int>() { 7, 4, 6, 5, 1 }));
            dati.Add(new vertici(12, new List<int>() { 1, 3, 19 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(13, new List<int>() { 8, 11, 18 }, new List<int>() { 5, 6, 1 }));
            dati.Add(new vertici(14, new List<int>() { 3, 7, 10, 11 }, new List<int>() { 3, 2, 4, 5 }));
            dati.Add(new vertici(15, new List<int>() { 2, 4, 5, 10 }, new List<int>() { 2, 2, 2, 1 }));
            dati.Add(new vertici(16, new List<int>() { 6, 7 }, new List<int>() { 2, 3 }));
            dati.Add(new vertici(17, new List<int>() { 1, 6 }, new List<int>() { 3, 1 }));
            dati.Add(new vertici(18, new List<int>() { 11, 13 }, new List<int>() { 1, 1 }));
            dati.Add(new vertici(19, new List<int>() { 2, 12 }, new List<int>() { 3, 1 }));
            dati.Add(new vertici(20, new List<int>() { 1, 3 }, new List<int>() { 3, 2 }));

            //act
            var sol =Funzioni.CalcoloPercorso(dati);

            //assert
            sol.Percorso.Should().NotHaveCount(0);
            sol.Prezzo.Should().NotBe(null);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            List<vertici> dati = new List<vertici>();
            dati.Add(new vertici(1, new List<int>() { 6, 12, 17, 20 }, new List<int>() { 4, 2, 3, 3 }));
            dati.Add(new vertici(2, new List<int>() { 3, 10, 15, 19 }, new List<int>() { 4, 2, 2, 3 }));
            dati.Add(new vertici(3, new List<int>() { 2, 10, 12, 14, 20 }, new List<int>() { 4, 3, 2, 3, 2 }));
            dati.Add(new vertici(4, new List<int>() { 5, 9, 15 }, new List<int>() { 4, 2, 2 }));
            dati.Add(new vertici(5, new List<int>() { 4, 8, 9, 15 }, new List<int>() { 4, 6, 3, 2 }));
            dati.Add(new vertici(6, new List<int>() { 1, 16, 17 }, new List<int>() { 4, 2, 1 }));
            dati.Add(new vertici(7, new List<int>() { 14, 16 }, new List<int>() { 2, 3 }));
            dati.Add(new vertici(8, new List<int>() { 5, 13 }, new List<int>() { 6, 5 }));
            dati.Add(new vertici(9, new List<int>() { 4, 5, 11 }, new List<int>() { 2, 3, 7 }));
            dati.Add(new vertici(10, new List<int>() { 2, 3, 11, 14, 15 }, new List<int>() { 2, 2, 4, 4, 1 }));
            dati.Add(new vertici(11, new List<int>() { 9, 10, 13, 14, 18 }, new List<int>() { 7, 4, 6, 5, 1 }));
            dati.Add(new vertici(12, new List<int>() { 1, 3, 19 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(13, new List<int>() { 8, 11, 18 }, new List<int>() { 5, 6, 1 }));
            dati.Add(new vertici(14, new List<int>() { 3, 7, 10, 11 }, new List<int>() { 3, 2, 4, 5 }));
            dati.Add(new vertici(15, new List<int>() { 2, 4, 5, 10 }, new List<int>() { 2, 2, 2, 1 }));
            dati.Add(new vertici(16, new List<int>() { 6, 7 }, new List<int>() { 2, 3 }));
            dati.Add(new vertici(17, new List<int>() { 1, 6 }, new List<int>() { 3, 1 }));
            dati.Add(new vertici(18, new List<int>() { 11, 13 }, new List<int>() { 1, 1 }));
            dati.Add(new vertici(19, new List<int>() { 2, 12 }, new List<int>() { 3, 1 }));
            dati.Add(new vertici(20, new List<int>() { 1, 3 }, new List<int>() { 3, 2 }));

            //act
            var sol = Funzioni.CalcoloPercorso(dati);

            //assert
            sol.Prezzo.Should().Be(50);
        }

        [Fact]
        public void PercorsoMinimoTestMocking()
        {
            //arrange
            var mock = new Mock<IPercorso>();

            //act
            mock.Setup(x => x.Percorso(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int[]>())).Returns(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            var result = mock.Object.Percorso(1, 2, 3, new int[2] { 1, 2 });

            //assert

            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result);
        }
    }
}
