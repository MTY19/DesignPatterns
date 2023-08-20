using System;
using System.Reflection;


namespace ProxyPattern.SecondExample
{
	public class OwnerInvocationHandler : IInvocationHandler
	{
		PersonBean personBean;
        public OwnerInvocationHandler(PersonBean personBean)
        {
            this.personBean = personBean;
        }

        public Object Invoke(Object obj, MethodInfo info, Object[] args) 
        {
            Type type = obj.GetType();

            try
            {
                if (type.Name.StartsWith("get"))
                {
                    return info.Invoke(personBean, args);
                }
            } catch (Exception ex) {
	
            }

            return null;
        }
    }
}

