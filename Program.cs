namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region video 1
            //Employee e01 = new Employee() { Id = 1, Name = "ahmed ", Salary = 1200 };
            var e01 = new { Id = 1, Name = "ahmed ", Salary = 1200 };

            Console.WriteLine(e01.Id); Console.WriteLine(e01.Name);

            Console.WriteLine(e01.GetType().Name);

            #endregion


            #region video 2 
            int number = 12345;
            var result = Intextension.Revers(number);
            Console.WriteLine(result);

            number.Revers(); 
            #endregion
        }
    }
}
