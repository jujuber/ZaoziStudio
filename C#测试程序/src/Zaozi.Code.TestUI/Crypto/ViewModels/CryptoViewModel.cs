using CommonUtils;
using Mapster;
using Newtonsoft.Json;
using Synyi.Framework.Wpf.Mvvm;
using Synyi.ThirdHis.Application.WebHospital.YBMobilePayment.DTO;
using Synyi.ThirdHis.HisV1.Application.WebHospital.YBMobilePayment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaozi.Code.TestUI.Crypto.Utils;

namespace Zaozi.Code.TestUI.Crypto.ViewModels;

[Plugin(ZaoziConst.Plugins.CryptoView, "加密解密", "加密解密")]
public class CryptoViewModel : PluginViewModelBase
{
    protected override Task DoOnNavigatedTo(NavigationContext context)
    {
        return Task.CompletedTask;
    }
    public CryptoViewModel()
    {
        this.Md5Command = new ActionCommand(this.ExecuteMd5Command);
        this.Ydybesm4DecCommand = new ActionCommand(this.ExecuteYdybesm4DecCommand);
        this.SM2EncCommand = new ActionCommand(this.ExecuteSM2EncCommand);
        this.SM2DecCommand = new ActionCommand(this.ExecuteSM2DecCommand);
        this.Ydybesm4Dec6203Command = new ActionCommand(this.ExecuteYdybesm4Dec6203Command);
    }
    public string InputText { get; set; }
    public string OutputText { get; set; }

    public ActionCommand Md5Command { get; }
    private void ExecuteMd5Command()
    {
        if (string.IsNullOrEmpty(this.InputText))
        {
            this.OutputText = "请输入需要加密的字符串";
            return;
        }

        this.OutputText = MD5Helper.MakeSigns(this.InputText, true);
    }

    public ActionCommand Ydybesm4DecCommand { get; }

    private void ExecuteYdybesm4DecCommand()
    {
        if (string.IsNullOrEmpty(this.InputText))
        {
            this.OutputText = "请输入需要解密的字符串";
            return;
        }
        string appId= "1HPCQAC0O1323F60C80A000053829811";
        string appSecret = "1HPCQAC0U1333F60C80A0000BC059BA7";//数字密钥
        this.OutputText = SignUtil.sm4Decrypt(appId, appSecret, this.InputText);

        var Result6202 = Newtonsoft.Json.JsonConvert.DeserializeObject<Trade6202OutData>(this.OutputText);
        var result = new Trade6202_Out { data = Result6202 };

        YB_26_6202_Result y62r = result.data.Adapt<YB_26_6202_Result>();
        y62r.extData = JsonConvert.SerializeObject(result.data.extData);

        var strobj = y62r.extData.ToString();
    }
    public ActionCommand Ydybesm4Dec6203Command { get; }
    /*
     InputText：
      c1bbb1abf7d8c420eebfea39c32b084d9160fe627f853fb2dcd38cbdd5059c8321ef99297a21a6f879cd085c0a8cfbe83e799d343da18db2325a9b3d6b495dd118a0f7e0e43769c0507ae1073153b8b60e393eda83394753791afe5f7a14cd49a6a74e718ed6858e9122a4f107747fd7b5b0e7c41e6b7ff94eb9c9cede3aeff5891db97de9109d43be56e5d7d88abf236f27684d7f0e9a493b71f05c871787cc0e3a5524d41cd479297f68e31ada3804c7ad8642c31c7d45663cee86627fc8414ebc7f24ae9466959c258f37eb0ac640b917f083a2dbce60da3e5469f47cefdabb43542ae34f1f66291dd32bbf915dcc0f141eb852a05a2b0e96cc3eed78584d7c458192579600a911f08442e3039c1f38820bf1d2a5842186841431c45bae2b9feef0b6581be3c63e327d0b9b858dafef5cff66d3684c9b9fe4915d3e3342abd09e3b033134fb643dcf8f472e7b5b8b9f6a82b7a154a87c1b5a74cf4b0e4777ec3adafbc55198d8f940527ca5d4d5c26a61ee6be4bb7013d809dc9c59d3c9d44b79862de6f4f9057e7ab956c8e98f19e5171d4a51fdcc4b28daa312909d7628df883b02c6c07f860324b5e7bd6211fc5998340761ea1e085814307d3637988747e4ba8d1cc04533b777a9f9a7af3c939f781069afac9d84e4f9a8a8c6b5247172e3cee6b21003dfc2606ffb22f50895fa0d164477b97066b8d0a2662caa709b635f798cf7580a8bb464a0560c9c974392057e214aa87eb25e8048a59db788843033e5cf0270ac3751d384fb6a63cae1af52ba6eb3702fe1bb3208cc49b378a441bd3bcec47955205549da1ae2c2f072321f70b3b4b1c8f28994213aca598913dd14917a43a9e7d418ac323c11fc6c4c11b7719faddc28e7db7cc2eda690df07fc4cf292d8a102fc780a2839f1ea88481c2b6fde582c21a4dd0efeca7320f930b3a768837bafa0fc2f927a2827a9bf7a16453a38c85a5744a42f5a4b836abb58a543d216787edfae4ac8d33dfdd7fceef4742e6e552d388ff5342ecf734c79958c92a591c33ac90e3147658cee726d29aebb2e4c1a8d8a12ff38fe346a6ae04c6270c6a9b3939da8ab5dad8c844f6734e77ccfa82bd7b0f66ca3006afb7bd23318c87587048e1c594919f8de8976a711263bec085a9832aabf08ffbc7fc78617ff628ef05c9020d1f125f845cf8c4ec82bc534b82089d390730230a76c00fbb2d3c8eb83bea21cdf831c7e6e5125321ea9bd1eae5933743cd73157b1eef3157bf5c88cd7e042d0d3e9a9b286e5270b6e57c95377826e509fd619ee4d8d2b485b9321f9fba9856cbb70e76e93fedecde7aa7bcce9bf65316cd5128c9eaf151a5877d9bd9c7561d0558271d9295ca52389633ca437d6a2b46de02516b828dbf9bd4ff69f9e2369faae85f1b892d0a3d5bef2b285e83ae0c7f2dfe483360658cf2fd41be592258f838251d3f9d1343e0792a56c32570ba8753ca324d646164eb85df839fd51fa6c0876998eb92b3b528f340e505101a135a8062fdeece16c9bccf1fc63dcfb310b18c8f4071db5ffd1e71d42f9c724c20d48b31514f9eac4f52f0a9195b236b067a41e0d0f2d5d0b2f2e3f3eedac8e138e24e8c4012f5bc4eeb8be6fa4c4b282874157d44d1179a7f0f3d5e23edc2dc2dd1a2600a098b888a5f7e6ba4e979898ca7e6579225ceae7cbb6847362b5f71b08512219434e461fc9feaf59e6eca18ea565695ea53c6ec592d17133aa4be1acd7cfe16b61189c396d8c215a98f73c286013aa878aebe41d8efa609be01133efa7f8b3452e36d3c6ee5d98b639ae1bc175a35d860c52d3350d778ed410c8027b3e9e6dccf20c9a3aad4c82e7346a23ff38588c665adfa4381bd14abf10388280efb78167778e11413c7766
     */
    private void ExecuteYdybesm4Dec6203Command()
    {
        if (string.IsNullOrEmpty(this.InputText))
        {
            this.OutputText = "请输入需要解密的字符串";
            return;
        }
        //1IBEB2P8903I8D430B0A0000A6490CF7 正式  1HPCQAC0O1323F60C80A000053829811 测试
        string appId ="1IBEB2P8903I8D430B0A0000A6490CF7";
        //1IBEB2P8903J8D430B0A0000A3E8713C 正式 1HPCQAC0U1333F60C80A0000BC059BA7 测试
        string appSecret = "1IBEB2P8903J8D430B0A0000A3E8713C";//数字密钥


        this.OutputText = SignUtil.sm4Decrypt(appId, appSecret, this.InputText);

        var Result6203 = Newtonsoft.Json.JsonConvert.DeserializeObject<Trade6203OutData>(this.OutputText);
        var result = new Trade_6203_Out { data = Result6203 };

       // YB_26_6202_Result y62r = result.data.Adapt<YB_26_6202_Result>();
      //  y62r.extData = JsonConvert.SerializeObject(result.data.extData);

        //var strobj = y62r.extData.ToString();
    }

    public ActionCommand SM2EncCommand { get; }

    private void ExecuteSM2EncCommand()
    {
        //if (string.IsNullOrEmpty(this.InputText))
        //{
        //    this.OutputText = "请输入需要加密的字符串";
        //    return;
        //}
        string sm2PublicKey = "MFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAETTUUyt6HTN2RZM1GZBgmyB02kx1BLTfDBNTkemcsFWlEHOaq/J/U1HWwP3QMtQ2jw6YWxyqChKCgCMhOBagTMA==";
        
        // 生成签到的 model
        string currentTime = DateTime.Now.ToString("yyyyMMddHHmmss");

        // 拼接当前时间和 app_id
        string dataToEncrypt = currentTime + "xxk001";
        this.InputText = "1. 加密对象：\n" + dataToEncrypt + "\n";

        string authenticateStr = SM2Util.Encrypt(sm2PublicKey, dataToEncrypt);
        this.OutputText += "2. 加密后的 authenticate_str：\n" + authenticateStr + "\n";
    }

    public ActionCommand SM2DecCommand { get; }
    private void ExecuteSM2DecCommand()
    {
        //将【ExecuteSM2EncCommand】 方法中的加密后的 authenticate_str 复制到这里
        if (string.IsNullOrEmpty(this.InputText))
        {
            this.OutputText = "请输入需要解密的字符串";
            return;
        }

        string sm2PrivateKey = "MIGTAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBHkwdwIBAQQgg9J/vPHk7iBrSKH+vBN4aVYp7S19R8S0HpvL/oda+emgCgYIKoEcz1UBgi2hRANCAARNNRTK3odM3ZFkzUZkGCbIHTaTHUEtN8ME1OR6ZywVaUQc5qr8n9TUdbA/dAy1DaPDphbHKoKEoKAIyE4FqBMw";
        
        string decryptText = SM2Util.Decrypt(sm2PrivateKey, this.InputText);
        this.OutputText = " (测试SM2私钥解密)：\n" + decryptText + "\n";
    }
}
