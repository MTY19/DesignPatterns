// See https://aka.ms/new-console-template for more information
using BuilderPattern;
using BuilderPattern.Method2;

Console.WriteLine("Hello, World!");

EndpointBuilder endPointBuilder = new EndpointBuilder("");

endPointBuilder.Append("https://192.168.1.1");
endPointBuilder.Append("api").Append("v1");
endPointBuilder.Append("GetList").AppendParam("id","3").AppendParam("username","Tahir");

Console.WriteLine(endPointBuilder.Builder());

var empBuilder = new EmployeeBuilderM1();


empBuilder.SetFullName("Tahir Yıldırım")
          .SetEmailAddress("tahiryildirim19@gmail.com")
          .SetUserName("MTY19")
          .SetFullName("MehmetTahir Yıldırım");

Console.WriteLine(empBuilder.BuildEmployee());

// sample methodv2
IEmployeeBuilderM2 employeeBuilderM2 = new InternalEmloyeeBuilder();
employeeBuilderM2.SetEmailAddress("tahiryildirim19@gmail.com")
                 .SetFullName("Tahir Yıldırım");
var emp = employeeBuilderM2.BuildEmployee();
Console.WriteLine(emp.EmailAddress);

IEmployeeBuilderM2 employeeBuilderM2v2 = new ExternalEmployeeBuilder();
employeeBuilderM2v2.SetEmailAddress("tahiryildirim19@gmail.com")
                   .SetFullName("Mehmet Yıldırım");

var emp2 = employeeBuilderM2v2.BuildEmployee();
Console.WriteLine(emp2.EmailAddress);