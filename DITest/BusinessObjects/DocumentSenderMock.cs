using DITest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.BusinessObjects
{
    public class DocumentSenderMock : IDocumentSender
    {
        public void SendDocument()
        {
            Console.WriteLine("This is a mock document sender...");
        }
    }
}
