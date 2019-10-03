using DITest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Views
{
    public class DocumentListView
    {
        //this is a mock list view, to imitate document sending action
        private IDocumentSender documentSender;
        public DocumentListView(IDocumentSender documentSender)
        {
            this.documentSender = documentSender;
        }

        public void SendSelectedDocument()
        {
            documentSender.SendDocument();
        }
    }
}
