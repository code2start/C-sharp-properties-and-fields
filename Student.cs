namespace properties_and_fields
{
    public class Student
    {
        //class members 
        private int age;//field
        public int Age
        {
            set
            {
                if (value > 10)
                    age = value;
            }
            get { return age; }
        }
        public string Name { get; set; }

    }
}