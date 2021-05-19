using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;
using PCTO;
using Moq;
using System.Text;
using static PCTO.ApiResult;
using static PCTO.PropertyControl;


namespace PCTO_Test
{
    public class PropertyControlTest
    {
        #region Province
        [Fact]
        public void ControlprovinceUPPER()
        {
            //Arrange
            string province = "BG";
            //Act
            var result=Province(province);
            //Assert
            result.Should().Be(province);

        }
        [Fact]
        public void ControlprovinceLOWER1()
        {
            //Arrange
            var provincia = "mi";
            string result=default(string);
            try
            {   //Act             
                result = Province(provincia);                
            }
            catch
            {
                //Assert
                result.Should().NotBe(provincia);
            }
        }
        [Fact]
        public void ControlprovincefirstUPPER1_2()
        {
            //Arrange
            var provincia = "Mi";
            string result = default(string);
            try
            {   //Act             
                result = Province(provincia);
            }
            catch
            {
                //Assert
                result.Should().NotBe(provincia);
            }
        }
        [Fact]
        public void ControlprovincefirstLOWER1_3()
        {
            //Arrange
            var provincia = "mI";
            string result = default(string);
            try
            {   //Act             
                result = Province(provincia);
            }
            catch
            {
                //Assert
                result.Should().NotBe(provincia);
            }
        }
        [Fact]
        public void ControlprovinceLOWER2_1()
        {
            //Arrange
            var provincia = "mi";
            var ex = false;
            try
            {
                //Act
                Province(provincia);
            }
            catch
            {
                ex = true;
            }
            //Assert
            ex.Should().Be(true);
        }

        [Fact]
        public void ControlprovincefirstUPPER2_2()
        {
            //Arrange
            var provincia = "Mi";
            var ex = false;
            try
            {
                //Act
                Province(provincia);
            }
            catch
            {
                ex = true;
            }
            //Assert
            ex.Should().Be(true);
        }
        [Fact]
        public void ControlprovincefirstLOWER2_3()
        {
            //Arrange
            var provincia = "mI";
            var ex = false;
            try
            {
                //Act
                Province(provincia);
            }
            catch
            {
                ex = true;
            }
            //Assert
            ex.Should().Be(true);

        }
        [Fact]
        public void controlexfirstLOWER()
        {
            //Arrange
            string province = "bG";

            //Act
            Action action = () => Province(province);

            //Assert
            action.Should().Throw<System.ArgumentException>().WithMessage("Province must be a 2 upper chars string");
        }
        [Fact]
        public void controlexLOWER()
        {
            //Arrange
            string province = "bg";

            //Act
            Action action = () => Province(province);

            //Assert
            action.Should().Throw<System.ArgumentException>().WithMessage("Province must be a 2 upper chars string");
        }
        [Fact]
        public void controlexfirstUPPER()
        {
            //Arrange
            string province = "Bg";

            //Act
            Action action = () => Province(province);

            //Assert
            action.Should().Throw<System.ArgumentException>().WithMessage("Province must be a 2 upper chars string");
        }
        [Fact]
        public void controlequalexfirstLOWER()
        {
            //Assert
            string province = "bG";
            //Act
            var ex = Assert.Throws<ArgumentException>(() => Province(province));
            //Assert
            Assert.Equal("Province must be a 2 upper chars string", ex.Message);
        }
        [Fact]
        public void controlequalexLOWER()
        {
            //Assert
            string province = "bg";
            //Act
            var ex = Assert.Throws<ArgumentException>(() => Province(province));
            //Assert
            Assert.Equal("Province must be a 2 upper chars string", ex.Message);
        }
        [Fact]
        public void controlequalexfirstUPPER()
        {
            //Assert
            string province = "Bg";
            //Act
            var ex = Assert.Throws<ArgumentException>(() => Province(province));
            //Assert
            Assert.Equal("Province must be a 2 upper chars string", ex.Message); ;
        }
        #endregion 

        #region Number
        [Fact]
        public void NegativeNumber1()
        {
            int Number = 5;
            var result = PositiveNumber(Number);
            result.Should().Be(Number);
        }
        [Fact]
        public void NegativeNumber2()
        {
            int Number = 5;
            int result = default(int);
            try
            {
                result = PositiveNumber(Number);
            }
            catch
            {
                result.Should().NotBe(Number);
            }
            
        }
        #endregion

        #region String
        [Fact]
        public void ValidString1()
        {
            //Arrange
            string word1 = "Abc";
            //Act
            var result = ValidString(word1);
            //Assert
            result.Should().Be(word1);
        }
        [Fact]
        public void ValidString2()
        {
            //Arrange
            string word = null;
            string result = default(string);
            try
            {   //Act             
                result = ValidString(word);
            }
            catch
            {
                //Assert
                result.Should().Be(null);
            }
        }
        [Fact]
        public void ToCompleteAddressTest1()
        {
            var Address = new Address("30a", "Via Manzoni", "Milano", "MI");
            var result = Address.ToCompleteAddress();
            result.Should().Be("Via Manzoni 30a Milano");
            result.Length.Should().Be(22);
        }

        [Fact]
        public void ToCompleteAddressTest2()
        {
            var Address = new Address("29a", "Via Gavazzeni", "Bergamo", "BG");
            var result = Address.ToCompleteAddress();
            result.Should().Be("Via Gavazzeni 29a Bergamo");
            result.Length.Should().Be(25);
        }
        #endregion
    }
}
