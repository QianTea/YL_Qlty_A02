using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
	 class Rectangle
	{
		private int length;
		private int width;
		private int perimeter;
		private int area;

		public int Length { get; set; }
		public int Width { get; set; }
		public int Perimeter { get; set; }
		public int Area{get; set; }



		//default constructor
		public Rectangle()
		{
			length = 1;
			width = 1;
		}

		//non-default constructor
		public void InputRectangle(int inLength, int inWidth)
		{
			Length = inLength;
			Width = inWidth;
		}

		public int GetLength()
		{
			return Length;
		}

		public int SetLength(int length)
		{
			Length = length;
			return Length;
		}
		public int GetWidth()
		{
			return Width;
		}
		public int SetWidth(int width)
		{
			Width = width;
			return Width;
		}
		public int GetPerimeter()
		{
			perimeter = (Length + Width) * 2;
			return perimeter;
		}
		public int GetArea()
		{
			area = Length * Width;
			return area;
		}
	}

}
