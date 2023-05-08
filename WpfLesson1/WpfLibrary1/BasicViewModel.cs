using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary1
{
    public class BasicViewModel
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public BasicViewModel()
        {
            Name = "James";
            IsChecked = true;
        }
    }
}
