using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ExamplesTests
    {

        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork() {

            //Arrange

            //Actual
            string actual = Examples.ExampleLoadTextFile("This is a valid text file name");
            //string actual = Examples.ExampleLoadTextFile("");

            //Assert
            Assert.True(actual.Length > 0);
        
        }


        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {

            //Arrange

            //Actual
            //string actual = Examples.ExampleLoadTextFile("This is a valid text file name");
            //string actual = Examples.ExampleLoadTextFile("");

            //Assert
            //Assert.True(actual.Length > 0);
            //Assert.Throws<Exception>(() => Examples.ExampleLoadTextFile(""));

            Assert.Throws<Exception>(() => Examples.ExampleLoadTextFile(""));
             

        }



    }
}
