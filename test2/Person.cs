

namespace person {

    class Person {
        private string firstName;
        private string lastName;
        private string pId;

        public string FirstName {
            get {
                return firstName;
            }
            set { firstName = value; }
        }

        public Person(string pid, string fName, string lName) {
            pId = pid;
            firstName = fName;
            lastName = lName;
        }

        public void changeName(string fname, string lname) {
            firstName = fname;
            lastName = lname;
        }

        public string getFullName() {
            return string.Concat(firstName, " ", lastName);
        }

        public void showData() {
            Console.WriteLine("{");
            Console.WriteLine("\tPID: " +pId);
            Console.WriteLine("\tName: " +getFullName());
            Console.Write("}");
        }
    }
}