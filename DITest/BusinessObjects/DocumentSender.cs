using DITest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.BusinessObjects
{
    public class DocumentSender : IDocumentSender
    {
        public void SendDocument()
        {
            Console.WriteLine("This is document sender, I send documents to another system...");
        }
    }
}
