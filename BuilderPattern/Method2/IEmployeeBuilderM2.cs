namespace BuilderPattern
{
    public interface IEmployeeBuilderM2
    {
        EmployeeM2 BuildEmployee();
        IEmployeeBuilderM2 SetEmailAddress(string emailAddress);
        IEmployeeBuilderM2 SetFullName(string fullName);
        IEmployeeBuilderM2 SetUserName(string userName);
    }
}