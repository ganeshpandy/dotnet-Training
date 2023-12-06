namespace Medical
{
    class Example
    {
        static void Main(string[] args)
        {
            //CRUDOperation selectOption = new CRUDOperation();
            CRUDOperation cRUDOperation = new CRUDOperation();
            cRUDOperation.ChooseOption();

            Console.ReadKey();
        }
    }
}