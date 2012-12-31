using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Service.Interface;
using BodyByKurt.Service;

namespace BodyByKurt.Business
{
    public class BusinessManager
    {
        protected IService getService(String name)
        {
            return (Factory.getInstance()).getService(name);
        }
    }
}
