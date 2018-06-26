namespace Exam
{
    public class Product
    {
        private string _id;
        private string _name;
        private int _price;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public Product(string id, string name, int price)
        {
            _id = id;
            _name = name;
            _price = price;
        }
    }
}