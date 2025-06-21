using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using WpdDemo.Commands;
using YLW.UHIS.Utility;

namespace WpfHssfz
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public int IUsbPort { get; set; } = 1001;
        public IdentityCardInfo Data { get; set; }

        public MainViewModel()
        { 
            Data = new IdentityCardInfo();
            this.ReadCommand = new RelayCommand(ExecuteReadCommand);
            this.ReadCRVCommand = new RelayCommand(ExecuteReadCRVCommand);
        }

        public ICommand ReadCommand { get; }
        public ICommand ReadCRVCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void ExecuteReadCRVCommand(object obj)
        {
            Data = CVRSDK.GetData();
        }

        private void ExecuteReadCommand(object obj)
        {
            int port = IUsbPort; // 假设使用USB口1
            int active = 1; // 读取所有信息
            MessageBox.Show($"使用USB口：{port}");
            if (ApiHelper.CVR_InitComm(port) != 1)
            {
                MessageBox.Show("初始化连接失败！");
                //Console.WriteLine("初始化连接失败！");
                return;
            }
            MessageBox.Show("初始化连接成功！");
            var isauth = ApiHelper.CVR_Authenticate();
            if (isauth != 1)
            {
                MessageBox.Show($"卡认证失败！CVR_Authenticate返回：{isauth}"); 
                var isclose =  ApiHelper.CVR_CloseComm();
                MessageBox.Show($"卡认证失败！CVR_CloseComm返回：{isclose}");
                return;
            }
            MessageBox.Show("卡认证成功！");
            if (ApiHelper.CVR_Read_Content(active) != 1)
            {
                MessageBox.Show("读卡失败！"); 
                ApiHelper.CVR_CloseComm(); ;
                return;
            }
            MessageBox.Show("读卡成功！");
            StringBuilder sb = new StringBuilder(256);
            int len = sb.Capacity;



            //  
            if (ApiHelper.GetPeopleName(sb, ref len) == 1)
                Data.Name = sb.ToString();

            sb.Clear();
            //  
            if (ApiHelper.GetPeopleSex(sb, ref len) == 1)
                Data.Gender = sb.ToString();

            sb.Clear();
            //  
            if (ApiHelper.GetPeopleNation(sb, ref len) == 1)
                Data.Folk = sb.ToString();
            sb.Clear();
            //  
            if (ApiHelper.GetPeopleBirthday(sb, ref len) == 1)
                Data.BirthDay = sb.ToString();
            sb.Clear();
            //  
            if (ApiHelper.GetPeopleIDCode(sb, ref len) == 1)
                Data.Code = sb.ToString();


            MessageBox.Show("成功");
        }

    }
}
