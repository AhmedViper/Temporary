using System;

namespace ConsoleApplicationC_Sharp
{
    class Program
    {
        class student
        {
            public string lastName, firstName;
            public student(string lastname, string firstname)
            {
                lastName = lastname;
                firstName = firstname;
            }
        }
        static void Main(string[] args)
        {
            var st = new student("lastName", "firstName"); //Initalized a new student object with lastname = 'lastName' and firstName = 'firstName'
            
            student st1 = st; //Initalized a new student object with the values at st student object;
            st.lastName = "mohamed"; //Changed lastName attribute in st student object to 'mohamhed'
            st1.firstName = "ahmed";  //Changed firstName attributes in st1 student object to 'ahmed'

            Console.WriteLine(st.lastName); // mohamed
            Console.WriteLine(st1.firstName); // ahmed
        }
    }
}
