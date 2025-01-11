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
