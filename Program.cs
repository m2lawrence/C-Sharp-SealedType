// Creating keyword to a "Sealed" class. 
//Sealed is used to STOP derived classes from inheriting variables.
using System;
namespace Inherit06
{
	sealed public class number //The number class is declared with the sealed modifier.
	{
		private float pi;
		
		//When a number object is created, the constructor below sets the data member, pi, to the value of 3.14159.
		//Constructor.
		public number()
		{
			pi = 3.14159F;
		}
		//-----------
		
		//The user can access this value by using the PI accessor defined below:
		public float PI
		{
			get
			{
				return pi;
			}
		}
		//-----------
	}

//------
//You CANNOT write this code below to inherit/derive from base class, because it's a "sealed" class. 

//	public class numbers : number  //Inherit06.numbers: cannot derive from sealed type. number is a sealed class.
//	{
//		public float myVal = 123.456F;
//	}
//------
	
	class myApp
	{
		public static void Main()
		{
			//class, object =new class(); builds the myNumbers Object, from a copy of the "number" class. 
			number myNumbers = new number(); //myNumbers Object built.
			//Write to screen: English PI=, placeHolder{0}, object, placeHolder's variable.
			Console.WriteLine("Mike, PI = {0}",myNumbers.PI);
			Console.ReadKey(true);//pause.
			
			//------------------------------------------------------------------------------------------
			//-- Cannot write this:
			//numbers moreNumbers = new numbers();
			//Console.WriteLine("PI = {0}", moreNumbers.PI);
			//Console.WriteLine("myVal = {0}", moreNumbers.myVal);--------------------------------------
			
			//NOTE!
			//If you try to declare a data type as protected within a "sealed" class, you will
			//get a compiler warning. You should declare your data as private because
			//the class won’t (can’t) be inherited.
		}
	}
}