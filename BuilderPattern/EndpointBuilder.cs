using System;
using System.Text;

namespace BuilderPattern
{
	public class EndpointBuilder : IBuilder
	{
		private readonly StringBuilder sbUrl = new();
        private readonly StringBuilder sbParams = new();

        private const char defaultDelimeter = '/';
		public string BaseUrl { get; set; }
		
		public EndpointBuilder(string baseUrl)
		{
			BaseUrl = baseUrl;
        }

		public IBuilder Append(string text)
		{
			sbUrl.Append(text);
			sbUrl.Append(defaultDelimeter);

			return this;
		}

        public IBuilder AppendParam(string name,string value)
        {
            sbParams.AppendFormat("{0}={1}&",name,value);

            return this;
        }

		public string Builder()
		{
			if (BaseUrl.EndsWith(defaultDelimeter))
				sbUrl.Insert(0, BaseUrl);
			else
				sbUrl.Insert(0, BaseUrl + defaultDelimeter);

			//localhost//api/f1/user
			var url = sbUrl.ToString().TrimEnd('&');

			if (sbParams.Length > 0)
			{
				string qParams = sbParams.ToString().TrimEnd('&');
				url = sbUrl.ToString().TrimEnd(defaultDelimeter).TrimEnd('&');
                //localhost//api/f1/user?[id=5]
                url = $"{url}?{qParams}";
            }

            return url.TrimEnd(defaultDelimeter);
		}
    }
}

