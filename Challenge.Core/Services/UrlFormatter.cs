using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Core.Services
{
    public class UrlFormatter
    {
        public string Format(string originalUrl)
        {
            Uri uri = new Uri(originalUrl);
            string sortedParameters = SortQueryParameters(uri.Query);
            string formattedUrl = $"{uri.Host}{uri.AbsolutePath}{sortedParameters}";
            return formattedUrl;
        }

        private string SortQueryParameters(string query)
        {
            if (string.IsNullOrEmpty(query))
                return string.Empty;
            string trimmedQuery = query.TrimStart('?');
            IEnumerable<string> sortedParameters = trimmedQuery.Split('&').OrderBy(x => x);
            string sortedParametersString = string.Join("&", sortedParameters);
            return $"?{sortedParametersString}";
        }
    }
}