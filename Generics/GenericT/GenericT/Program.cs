namespace GenericT
{
     class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> list = new GenericList<string>();
            list.Name = "Alex";            
            list.Display(list.GetName());
            list.Address = "Chennai";
            list.Display(list.GetAddress());
            
            GenericList<int> list2 = new GenericList<int>();
            list2.Id = 1;
            list2.Display(list2.GetId());

            GenericList<long> list3 = new GenericList<long>();
            list3.Phno = 1234567890;
            list3.Display(list3.GetPhno());

            GenericList<double> list4 = new GenericList<double>();
            list4.Salary = 150000;
            list4.Display(list4.GetSalary());

            GenericList<DateOnly>list5= new GenericList<DateOnly>();
            list5.DOJ = new DateOnly(2023, 11, 21);
            list5.Display(list5.GetDOJ());

           





        }
    }

}
