using System;
namespace BuilderPattern
{
	public class EmployeeBuilderM1
	{
		private EmployeeM1 employeeM1 { get; set; }
		public EmployeeBuilderM1()
		{
            employeeM1 = new EmployeeM1();
        }

        public EmployeeBuilderM1 SetFullName(string fullName)
        {
            //validations yapılabilir
            var arr = fullName.Split(' ');
            employeeM1.FirstName = arr[0];
            employeeM1.LastName = arr[1];

            return this;
        }

        public EmployeeBuilderM1 SetEmailAddress(string emailAddress)
		{
            //email validations yapılabilir
			employeeM1.EmailAddress = emailAddress;

			return this;
		}

        public EmployeeBuilderM1 SetUserName(string userName)
        {
            employeeM1.UserName = userName;

            return this;
        }

        public EmployeeM1 BuildEmployee()
		{
			return employeeM1;
        }
	}
}

