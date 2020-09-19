using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.EventArguments
{
    public class FileOpenEventArgs : EventArgs
    {
        public FileOpenEventArgs(string filename)
        {
            this.FileName = filename;
        }

        public string FileName { get; set; }
    }
}
