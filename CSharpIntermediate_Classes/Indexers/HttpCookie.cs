using System.Collections.Generic;
using System;

namespace CSharpIntermediate_Classes
{
    class HttpCookie
    {
        readonly Dictionary<string, string> _dict = new Dictionary<string, string>();
        public DateTime ExpireDate { get; set; }

        public string this[string key]
        {
            get
            {
                return _dict[key];
            }
            set
            {
                _dict[key] = value;
            }
        }

    }
}
