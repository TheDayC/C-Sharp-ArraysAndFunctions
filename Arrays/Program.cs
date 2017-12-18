using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("*** Array work ***");
			SimpleArrays();
			ArrayInitialization();
			ArrayofObjects();
			RectMultidimensionalArray();
			PassAndReceiveArrays();
			SystemArrayFunctionality();
			Console.ReadLine();
		}

		static void SimpleArrays() {
			Console.WriteLine("=> Simple Array Creation.");

			// Create an array of ints containing 3 elements indexed 0, 1, 2
			int[] myInts = new int[3];
			for(int i = 0; i < 3; i++) { myInts[i] = i * 100;  }
			foreach(int i in myInts) { Console.WriteLine(i);  }


			// Create a 100 item string array, indexed 0 - 99
			string[] booksOnDotNet = new string[100];
			Console.WriteLine();
		}

		static void ArrayInitialization() {
			Console.WriteLine("=> Array Initialization.");

			// Array initialization syntax using the "new keyword".
			string[] stringArray = new string[] {
				"one",
				"two",
				"three"
			};
			Console.WriteLine("stringArray has {0} elements.", stringArray.Length);

			// Array init without using "new" keyword
			bool[] boolArray = { false, false, true };
			Console.WriteLine("boolArray has {0} elements", boolArray.Length);

			// Array init with "new" keyword and size
			int[] intArray = new int[4] { 20, 25, 18, 0 };
			Console.WriteLine("intArray has {0} elements", intArray.Length);
		}

		static void ArrayofObjects() {
			Console.WriteLine("=> Array of Objects.");

			// An array of obnjects can be anything
			object[] myObjects = new object[4];
			myObjects[0] = 10;
			myObjects[1] = false;
			myObjects[2] = new DateTime(1969, 3, 24);
			myObjects[3] = "A string";

			foreach (object obj in myObjects) {
				// Print type and value per item
				Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
			}
		}

		static void RectMultidimensionalArray() {
			Console.WriteLine("=> Rectangular multidimensional array.");

			// Rectangular MD array
			int[,] myMatrix;
			myMatrix = new int[3, 4];

			// Populate a 3 * 4 array
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 4; j++) {
					myMatrix[i, j] = i * j;
				}
			}

			// Write 3 * 4 array.
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 4; j++) {
					Console.Write(myMatrix[i,j] + "\t");
				}
				Console.WriteLine();
			}
		}

		static void PrintArray(int[] myInts) {
			for(int i = 0; i < myInts.Length; i++) {
				Console.WriteLine("Item {0} is {1}", i, myInts[i]);
			}
		}
		static void PrintArrayOfStrings(string[] myStrings) {
			for (int i = 0; i < myStrings.Length; i++) {
				Console.WriteLine("{0}, ", myStrings[i]);
			}
		}

		static string[] GetStringArray() {
			string[] theStrings = { "Hello", "from", "GetStringArray" };
			return theStrings;
		}

		static void PassAndReceiveArrays() {
			Console.WriteLine("=> Arrays as params and return values.");

			// Pass array as param
			int[] ages = { 20, 22, 23, 0};
			PrintArray(ages);

			// Get array return value
			string[] strs = GetStringArray();
			foreach (string s in strs) {
				Console.WriteLine(s);
			}
			Console.WriteLine();
		}

		static void SystemArrayFunctionality() {
			Console.WriteLine("=> Working with System.Array");

			// Init items
			string[] rappers = { "Eminem", "Dr.Dre", "Nas" };

			// Print out names in declared order
			Console.WriteLine("-> Here are our rappers: ");
			PrintArrayOfStrings(rappers);
			Console.WriteLine("\n");

			// Reverse order
			Array.Reverse(rappers);
			Console.WriteLine("-> Here are our rappers in reverse: ");
			PrintArrayOfStrings(rappers);
			Console.WriteLine("\n");

			// Clear all but first assignment
			Console.WriteLine("-> Cleared out all but first assignment...");
			Array.Clear(rappers, 1, 2);
			PrintArrayOfStrings(rappers);

			Console.WriteLine();
		}
	}
}
