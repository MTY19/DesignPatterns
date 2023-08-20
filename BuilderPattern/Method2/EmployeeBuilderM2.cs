using System;
namespace BuilderPattern
{
    public abstract class EmployeeBuilderM2 : IEmployeeBuilderM2
    {
        public EmployeeM2 Employee { get; set; }
        public EmployeeBuilderM2()
        {
            Employee = new EmployeeM2();
        }

        public abstract IEmployeeBuilderM2 SetFullName(string fullName);

        public abstract IEmployeeBuilderM2 SetEmailAddress(string emailAddress);

        public abstract IEmployeeBuilderM2 SetUserName(string userName);

        public EmployeeM2 BuildEmployee() => Employee;
    }
}

