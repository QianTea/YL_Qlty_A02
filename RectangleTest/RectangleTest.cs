using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleTest;
using Assignment02;
using NUnit.Framework;


namespace RectangleTest
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleTest1
        {
			//test getlength
            [Test]
            public void GetLength_Input1_Result1()
            {
                Rectangle r = new Rectangle();

                //Arrange
                int expected = 1;

                //Act
                int actual = r.GetLength();

                //Assert
                Assert.AreEqual(expected,actual);
            }

			[Test]
			public void GetLength_Input2_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 2;

				//Act
				int actual = r.GetLength();

				//Assert
				Assert.AreNotEqual(expected, actual);
			}

			[Test]
			public void GetLength_Input3_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 3;

				//Act
				int actual = r.GetLength();

				//Assert
				Assert.AreNotSame(expected, actual);
			}

			//test getwidth
			[Test]
			public void GetWidth_Input1_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 1;

				//Act
				int actual = r.GetWidth();

				//Assert
				Assert.AreEqual(expected, actual);
			}

			[Test]
			public void GetWidth_Input2_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 2;

				//Act
				int actual = r.GetWidth();

				//Assert
				Assert.AreNotEqual(expected, actual);
			}

			[Test]
			public void GetWidth_Input3_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 3;

				//Act
				int actual = r.GetWidth();

				//Assert
				Assert.AreNotSame(expected, actual);
			}

			//test setLenth
			[Test]
			public void SetLength_Input1_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 1;

				//Act
				int actual = r.SetLength(1);

				//Assert
				Assert.AreEqual(expected, actual);
			}

			[Test]
			public void SetLength_Input3_Result2()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 2;

				//Act
				int actual = r.SetLength(3);

				//Assert
				Assert.AreNotEqual(expected, actual);
			}

			[Test]
			public void SetLength_Input5_Result3()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 3;

				//Act
				int actual = r.SetLength(5);

				//Assert
				Assert.AreNotSame(expected, actual);
			}

			//test setWidth
			[Test]
			public void SetWidth_Input1_Result1()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 1;

				//Act
				int actual = r.SetWidth(1);

				//Assert
				Assert.AreEqual(expected, actual);
			}

			[Test]
			public void SetWidth_Input3_Result2()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 2;

				//Act
				int actual = r.SetWidth(3);

				//Assert
				Assert.AreNotEqual(expected, actual);
			}

			[Test]
			public void SetWidth_Input5_Result3()
			{
				Rectangle r = new Rectangle();

				//Arrange
				int expected = 3;

				//Act
				int actual = r.SetWidth(5);

				//Assert
				Assert.AreNotSame(expected, actual);
			}

			//test GetPerimeter
			[Test]
			public void GetPerimeter_Input12_Result12()
			{
				Rectangle r = new Rectangle();

				//Arrange
				r.SetLength(3);
				r.SetWidth(3);
				int expected = 12;

				//Act
				int actual = r.GetPerimeter();

				//Assert
				Assert.AreEqual(expected, actual);
			}

			[Test]
			public void GetPerimeter_Input12_Result2()
			{
				Rectangle r = new Rectangle();

				//Arrange
				r.SetLength(3);
				r.SetWidth(3);
				int expected = 2;

				//Act
				int actual = r.GetPerimeter();

				//Assert
				Assert.AreNotEqual(expected, actual);
			}

			[Test]
			public void GetPerimeter_Input12_Result4()
			{
				Rectangle r = new Rectangle();

				//Arrange
				r.SetLength(3);
				r.SetWidth(3);
				int expected = 4;

				//Act
				int actual = r.GetPerimeter();

				//Assert
				Assert.AreNotSame(expected, actual);
			}

			//test GetArea
			[Test]
			public void GetArea_Input9_Result9()
			{
				Rectangle r = new Rectangle();

				//Arrange
				r.SetLength(3);
				r.SetWidth(3);
				int expected = 9;

				//Act
				int actual = r.GetArea();

				//Assert
				Assert.AreEqual(expected, actual);
			}

			[Test]
			public void GetArea_Input16_Result9()
			{
				Rectangle r = new Rectangle();

				//Arrange
				r.SetLength(4);
				r.SetWidth(4);
				int expected = 9;

				//Act
				int actual = r.GetArea();

				//Assert
				Assert.AreNotEqual(expected, actual);
			}

			[Test]
			public void GetArea_Input9_Result4()
			{
				Rectangle r = new Rectangle();

				//Arrange
				r.SetLength(3);
				r.SetWidth(3);
				int expected = 4;

				//Act
				int actual = r.GetArea();

				//Assert
				Assert.AreNotSame(expected, actual);
			}
		}
	}
}
