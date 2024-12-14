namespace Generics_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DataStore<string> dataStore1 = new()
            //{
            //    Data = "I am string data"
            //};

            //DataStore<int> dataStore2 = new()
            //{
            //    Data = 100
            //};

            //DataStore<bool> dataStore3 = new()
            //{
            //    Data = true
            //};



            //KeyValuePair<int, string> kvp1 = new()
            //{
            //    Key = 100,
            //    Value = "Hundred"
            //};

            //KeyValuePair<string, string> kvp2 = new()
            //{
            //    Key = "IT",
            //    Value = "Information Technology"
            //};


            //DataStore<string> cities = new DataStore<string>();
            //cities.AddOrUpdate(0, "Mumbai");
            //cities.AddOrUpdate(1, "Chicago");
            //cities.AddOrUpdate(2, "London");
            //Console.WriteLine(cities.GetData(2));

            //DataStore<int> empIds = new DataStore<int>();
            //empIds.AddOrUpdate(0, 50);
            //empIds.AddOrUpdate(1, 65);
            //empIds.AddOrUpdate(2, 89);
            //Console.WriteLine(empIds.GetData(0));


            Printer printer = new();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value

            printer.Print<bool>(false);


        }
    }

    class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }


    // Generic class with multiple Type Params.
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
