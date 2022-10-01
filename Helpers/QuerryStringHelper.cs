using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UProject.Helpers
{
    public class QuerryStringHelper
    {
        public static int GetIntFromQueryString(HttpRequestBase request, string key, int fallbackValue = 0)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                if (request.QueryString[key] != null && !string.IsNullOrWhiteSpace(request.QueryString[key]) && int.TryParse(request.QueryString[key].ToString(), out var numericValue))
                {
                    return numericValue;
                }
            }
            return fallbackValue;
        }
    }
}