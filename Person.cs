using System;
using System.Reflection;

namespace DynamicToString
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        public int postcode;

        public Person() {        }
        public Person(string firstName, string lastName, string address, int postcode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.postcode = postcode;
        }
        public string FirstName {get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Address { get => this.address; set => this.address = value; }

        public override string ToString(){
            string output;
            
            output = this.GetType().Name + "[ \n " + "Fields{ \n   ";
            //get fields
            foreach (FieldInfo info in this.GetType().GetFields())
                output += info.Name + " : " + info.GetValue(this) + "\n   ";
            
            output += "} \n\n " + "Methods{ \n   ";
            //get methods
            foreach (PropertyInfo info in this.GetType().GetProperties())
                output += info.Name + " : " + info.GetValue(this) + "\n   ";
            
            output +="}\n]";             
            
            return output;
        }
    }
}