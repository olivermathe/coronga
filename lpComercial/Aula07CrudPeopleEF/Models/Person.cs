namespace Aula07CrudPeopleEF.Models {
    public class Person {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone {get; set;}

        public Person(int id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }

}