namespace lapkricio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validation = new Validation<int?>();
           
            var isValid = validation.Validate(null);
            Console.WriteLine(isValid);

            // showitem
            //ShowItem<int>(5);
            //ShowItem<string>("string");

            var list = new MyList<string>();
            var list1 = new MyList<int>();
           // list.Add("agnius");
            //list1.Add(3); 

            for(int i = 0; i< 1000; i++)
            {
                list1.Add(i*44);
            }
        }

        public static void ShowItem<T>(T item)
        {
            Console.WriteLine(item);
        }

    }
}