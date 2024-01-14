using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldsProperties_Hongfei
{
    public class Student
    {
        //Add private fields to prevent public access and change it
        private string _name;
        private int _id;

        //Add public property to allow user return and assign value
        public string Name
        {
            //Return the value from the field 
            get { return _name; }
            //Alow the user to assign the value to _name 
            set 
            {
                if (value != "")
                _name = value; 
            }
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if ( value >0 && value < 100)
                _id = value; 
            }
        }

        //Add a Read-only properties,no set accessor
        // When user don't need check the value validation, only need get return the value of the variable
        public string ReadOnlyName
        { 
            get { return _name; }
        }
        //Add Write-only properties no get accessor
        //When user only need check the value if it is validation, don't need get the return value
        public string WriteOnlyName
        {
            set { _name = value; }
        }

        public int ReadOnlyID
        {
            get { return _id; }
        }

        public int WriteOnlyID
        {
            set
            {
                if (value >0 && value < 100)
                    _id = value;
            }
        }






    }
}
