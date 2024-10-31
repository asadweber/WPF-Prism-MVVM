using CLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Abstract
{
    public abstract class BaseResourceProvider : IResourceProvider
    {
        // Cache list of resources
        private Dictionary<string, ResourceEntry> resources = null;
        private object lockResources = new object();

        public BaseResourceProvider()
        {
            Cache = false; // By default, enable caching for performance
        }

        protected bool Cache { get; set; } // Cache resources ?

        /// <summary>
        /// Returns a single resource for a specific culture
        /// </summary>
        /// <param name="name">Resorce name (ie key)</param>
        /// <param name="culture">Culture code</param>
        /// <returns>Resource</returns>
        public object GetResource(string name, string culture)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Resource name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(culture))
                throw new ArgumentException("Culture name cannot be null or empty.");

            // normalize
            culture = culture.ToLowerInvariant();

            if (resources == null)
            {
                // Fetch all resources

                lock (lockResources)
                {

                    if (resources == null)
                    {
                        resources = ReadResources().ToDictionary(r => string.Format("{0}.{1}", r.Culture.ToLowerInvariant(), r.Name));
                    }
                }
            }

            //if (Cache)
            //{
            try
            {
                //return resources[string.Format("{0}.{1}", culture, name)].Value;
                ResourceEntry retRes = new ResourceEntry();
                if (resources.TryGetValue(string.Format("{0}.{1}", culture, name), out retRes))
                {
                    return retRes.Value;
                }
                else
                {
                    // return new System.Collections.Generic.KeyNotFoundException(string.Format("{0}.{1}", culture, name));
                    throw new Exception("Resource key: " + name + " not found." );
                    //return name;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //}

            // return ReadResource(name, culture).Value;

        }


        /// <summary>
        /// Returns all resources for all cultures. (Needed for caching)
        /// </summary>
        /// <returns>A list of resources</returns>
        protected abstract IList<ResourceEntry> ReadResources();


        /// <summary>
        /// Returns a single resource for a specific culture
        /// </summary>
        /// <param name="name">Resorce name (ie key)</param>
        /// <param name="culture">Culture code</param>
        /// <returns>Resource</returns>
        protected abstract ResourceEntry ReadResource(string name, string culture);

    }
}
