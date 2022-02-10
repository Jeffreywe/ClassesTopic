using System;


namespace ClassesTopic {
	
	/*
	 classes
	 3 things go inside classes, 
	 1 is data/properties of the class
	 2 is actions/methods on the class
	*/

	//syntax for class example

	public class Student {
		static void Main() {
		}

		//static method can only access other static methods or static properties, not instance methods or instance properties, which is non-static
		public static int BootcampDaysRemaining { get; set; }
		private static int NextId = 1;
		public int id { get; set; }
		public string Name { get; set; }//means other classes can read and write from this one 
		private bool IsVeteran { get; set; } //properties / unique pieces of data
		public string Zipcode { get; set; }

		public void Print() {
			Console.WriteLine($"Student's Id is {id}, name is {Name} and zip is {Zipcode}");
			Console.WriteLine($"Days remaining is {BootcampDaysRemaining}");
		}
		public string GetMessage(string caller) {
			return $"Student's name is {Name} and zip is {Zipcode} from {caller}";
        }

		//constructor code, special method, simplified getmessage
		//constructor, no return type, always the class name
		public Student(string name, string zipcode) //parameter, has to be same name as property
		{
			this.id = NextId;
			NextId++;
			this.Name = name;
			this.Zipcode = zipcode;
        }
		public Student(string name) {
			this.Name = name;
        }
		public Student() { }
		public static void Run() {

			//constructor code
			Student Dawit = new Student("Dawit", "20202");
			//this property calls the constructor above, property gets assigned into parameter name
		

		Student Jeff = new Student(); //instances
			Jeff.Name = "Jeff"; //properties
			Jeff.Zipcode = "12345";

			Student Philip = new Student("Philip");
			Philip.Zipcode = "98765";

			Jeff.Print(); //executes the method .Print() of the property Jeff
			Philip.Print();

			/*
			string str = Philip.GetMessage();
			Console.WriteLine(str);
			*/
		}
	}
}
	/*
	public class Teacher {

	public static void Run() {
		Student Greg = new Student();
		Greg.Name == "Greg";
		Greg.IsVeteran = true; //false because does not have access to veteran property from Student Class due to private
		}
	}
	 
	// methods
	*/
