using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    internal class CloseCommand : ICommand
    {
            private Document document;
            public CloseCommand(Document doc)
            {
                document = doc;
            }
            public void Execute()
            {
                document.Close();
            }
        
    }
}
