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
        #region ProvinceTest
        [Fact]
        public void ProvinceTest1()
        {
            //Arrange
            string province = "BG";
            //Act
            var result=Province(province);
            //Assert
            result.Should().Be(province);

        }
        [Fact]
        public void ProvinceTest2()
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
        public void ProvinceTest3()
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
        public void ProvinceTest4()
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
        public void ProvinceTest5()
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
        public void ProvinceTest6()
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
        public void ProvinceTest7()
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
        public void ProvinceTest8()
        {
            //Arrange
            string province = "bG";

            //Act
            Action action = () => Province(province);

            //Assert
            action.Should().Throw<System.ArgumentException>().WithMessage("Province must be a 2 upper chars string");
        }
        [Fact]
        public void ProvinceTest9()
        {
            //Arrange
            string province = "bg";

            //Act
            Action action = () => Province(province);

            //Assert
            action.Should().Throw<System.ArgumentException>().WithMessage("Province must be a 2 upper chars string");
        }
        [Fact]
        public void ProvinceTest10()
        {
            //Arrange
            string province = "Bg";

            //Act
            Action action = () => Province(province);

            //Assert
            action.Should().Throw<System.ArgumentException>().WithMessage("Province must be a 2 upper chars string");
        }
        [Fact]
        public void ProvinceTest11()
        {
            //Assert
            string province = "bG";
            //Act
            var ex = Assert.Throws<ArgumentException>(() => Province(province));
            //Assert
            Assert.Equal("Province must be a 2 upper chars string", ex.Message);
        }
        [Fact]
        public void ProvinceTest12()
        {
            //Assert
            string province = "bg";
            //Act
            var ex = Assert.Throws<ArgumentException>(() => Province(province));
            //Assert
            Assert.Equal("Province must be a 2 upper chars string", ex.Message);
        }
        [Fact]
        public void ProvinceTest13()
        {
            //Assert
            string province = "Bg";
            //Act
            var ex = Assert.Throws<ArgumentException>(() => Province(province));
            //Assert
            Assert.Equal("Province must be a 2 upper chars string", ex.Message); ;
        }
        #endregion 

        #region PositiveNumberTest
        [Fact]
        public void PostitiveNumberTest1()
        {
            int Number = 5;
            var result = PositiveNumber(Number);
            result.Should().Be(Number);
        }
        [Fact]
        public void PositiveNumberTest2()
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

        #region ValidStringTest
        [Fact]
        public void ValidStringTest1()
        {
            //Arrange
            string word1 = "Abc";
            //Act
            var result = ValidString(word1);
            //Assert
            result.Should().Be(word1);
        }
        [Fact]
        public void ValidStringTest2()
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
        
        #endregion
    }
}
