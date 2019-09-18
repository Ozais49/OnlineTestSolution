using System;

namespace AviraCodilityThree
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringMap<CustomClass> stringMap = new AviraCodilityThree.StringMap<CustomClass>();
           
            var abc = stringMap.AddElement("One",new CustomClass()
                    {
                        FirstName =  "Ram Sharan",
                        LastName = "Sharma"
                       });
            var abc1 = stringMap.AddElement("Two", new CustomClass()
            {
                FirstName = "Hari Sharan",
                LastName = "Sharma"
            });

            var abce = stringMap.AddElement("Two", new CustomClass()
            {
                FirstName = "Rajan Maharjan",
                LastName = "Sharma"
            });
            var abc2 = stringMap.RemoveElement("One");
           
            var abc3 = stringMap.GetValue("Two");
            try
            {
                stringMap.DefaultValue = new CustomClass()
                {
                    FirstName = "Rajan",
                    LastName = "Sharma"
                };
                var abc4 = stringMap.GetValue("One");
            }

            catch (Exception ex)
            {

                throw ex;
            }
            

        }
        public class CustomClass
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
