using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Service.Interface;
using BodyByKurt.Service.Plugin;
using BodyByKurt.Exceptions.Service;
using System.Collections.Specialized;
using System.Configuration;

namespace BodyByKurt.Service
{
    public class Factory
    {
        private static Factory factory = new Factory();

        private Factory()
        {

        }

        //Get singleton instance of factory
        public static Factory getInstance()
        {
            return factory;
        }

        private String getImplName(String serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }

        public IService getService(String serviceName)
        {
            Type type;
            IService svc = null;
            try
            {
                type = Type.GetType(getImplName(serviceName));
                svc = (IService)Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                throw new ServiceLoadException(ex.Message);
            }
            return svc;
        }

    }
}
