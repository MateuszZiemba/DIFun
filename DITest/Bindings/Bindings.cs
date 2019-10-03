using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITest.BusinessObjects;
using DITest.Contracts;
using Ninject.Modules;

namespace DITest
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDocumentSender>().To<DocumentSenderMock>();
            Bind<IDocumentSender>().To<DocumentSender>();
        }
    }
}
