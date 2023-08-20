using System;
namespace ProxyPattern.SecondExample
{
	public interface PersonBean
	{
		String getName();
        String getGender();
        String getInterest();
        int getHotOrNotRating();
        
		void getName(string name);
        void getGender(string gender);
        void getInterest(string interest);
        void getHotOrNotRating(int rating);
    }
}

