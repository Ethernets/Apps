namespace Apps5
{
    using System;

   public class Staff
    {
        Employee employee;

        Employee employee2 = new Employee("ss", "ffff") { Position = "manager", Experience = 5 };

        public void AssignFuckingNames()
        {
            this.employee = new Employee("Вася", "Пупкин");

            this.employee2 = new Employee("Ангелина", "Петрова");

            employee.Position = "Мастер";

            employee.Experience = 4;

            employee2.Experience = 7;
        }

        public void ShowFuckingInfo()
        {
            Console.WriteLine("Employee 1: {0} {1}\nPosition: {2}\n", employee.Name, employee.Surname, employee.Position);

            employee.WriteSalary();

            Console.WriteLine("\nEmployee 2: {0} {1}\nPosition: {2}\n", employee2.Name, employee2.Surname, employee2.Position);

            employee2.WriteSalary();
        }
    }
}
