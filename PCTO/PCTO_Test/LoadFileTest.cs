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
    public class LoadFileTest
    {
        #region GetStreamTest
        [Fact]
        public void GetStreamTest1()
        {
            //Arrange
            string file = "comune_bergamo.pbf";

            //Act
            Assert.False(File.Exists(file));
        }

        [Fact]
        public void GetStreamTest2()
        {
            //Arrange
            string file = "elif.json";

            //Act
            Assert.False(File.Exists(file));
        }
        #endregion
    }
}
