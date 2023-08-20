using System;
namespace BuilderPattern.Method2
{
    public class InternalEmloyeeBuilder : EmployeeBuilderM2
	{
		public InternalEmloyeeBuilder()
		{
		}

        public override IEmployeeBuilderM2 SetEmailAddress(string emailAddress)
        {
            Employee.EmailAddress = emailAddress;

            return this;
        }

        public override IEmployeeBuilderM2 SetFullName(string fullName)
        {
            var arr = fullName.Split(' ');
            Employee.FirstName = arr[0];
            Employee.LastName = arr[1];

            return this;
        }

        public override IEmployeeBuilderM2 SetUserName(string userName)
        {
            Employee.UserName = userName;

            return this;
        }
    }
}

