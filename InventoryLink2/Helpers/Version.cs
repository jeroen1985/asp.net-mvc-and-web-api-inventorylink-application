using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace InventoryLink2.Helpers
{
    public static class Version
    {
        public static string defaultVersion = "v1";

        public static string getVersion(this HttpRequestMessage request)
        {
            if (request.Headers.Contains("version"))
            {
                string version = request.Headers.GetValues("version").FirstOrDefault();

                if (!string.IsNullOrEmpty(version))
                {
                    return version;
                }

            }

            return defaultVersion;

        }

    }
}