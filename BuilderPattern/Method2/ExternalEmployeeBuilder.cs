using System;
namespace BuilderPattern.Method2
{
	public class ExternalEmployeeBuilder : EmployeeBuilderM2
	{
		public ExternalEmployeeBuilder()
		{
		}

        public override IEmployeeBuilderM2 SetEmailAddress(string emailAddress)
        {
            //tahiryildirim19@gmail.com
            //ends witth @company.com.tr
            var arr = emailAddress.Split('@');

            Employee.EmailAddress = arr[0] + "@company.com.tr";

            return this;

        }

        public override IEmployeeBuilderM2 SetFullName(string fullName)
        {
            var arr = fullName.Split(' ','_','.');
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

