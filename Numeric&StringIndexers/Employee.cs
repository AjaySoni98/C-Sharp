namespace Numeric_StringIndexers
{
    public class Employee
    {
        private int Id;
        private string Name;
        private int Age;

        public int Length
        {
            get
            {
                return 3;
            }
        }

        public object this[int index]
        {
            set
            {
                if(index == 0)
                {
                    int.TryParse(value.ToString(), out Id);
                }
                if(index == 1)
                {
                    Name = value.ToString();
                }
                if(index == 2)
                {
                    int.TryParse(value.ToString(), out Age);
                }
            }

            get
            {
                if(index == 0)
                {
                    return Id;
                }
                if(index == 1)
                {
                    return Name;
                }
                if(index == 2)
                {
                    return Age;
                }
                return 0;
            }
        }

        public object this[string field]
        {
            set
            {
                if(field == "Id")
                {
                    int.TryParse(value.ToString(), out Id);
                }
                if(field == "Name")
                {
                    Name = value.ToString();
                }
                if(field == "Age")
                {
                    int.TryParse(value.ToString(), out Age);
                }
            }

            get
            {
                if(field == "Id")
                {
                    return Id;
                }
                if(field == "Name")
                {
                    return Name;
                }
                if(field == "Age")
                {
                    return Age;
                }
                return 0;
            }
        }
    }
}