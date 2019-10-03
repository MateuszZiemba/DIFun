using DITest.Contracts;
using DITest.Views;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DITest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var documentSender = kernel.Get<IDocumentSender>();
            DocumentListView listView = new DocumentListView(documentSender);
            listView.SendSelectedDocument();
            Console.ReadKey();
        }
    }
}
