using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHssfz
{
    public class IdentityCardInfo: INotifyPropertyChanged
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Folk { get; set; }

        public string BirthDay { get; set; }

        public string Code { get; set; }

        public string Address { get; set; }

        public string Agency { get; set; }

        public string ExpireStart { get; set; }

        public string ExpireEnd { get; set; }

        public ResultInfo resultInfo { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    public class ResultInfo
    {
        public string Code { get; set; }

        public string Msg { get; set; }
    }
}
