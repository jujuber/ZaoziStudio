using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxHs
{
    /// <summary>
    /// 打印设置信息
    /// </summary>
    public class PrintSettingsInfo
    {
        /// <summary>
        /// 获取或者设置是否打印
        /// </summary>
        public bool IsPrint { get; set; }
        /// <summary>
        /// 获取或者设置打印输出设备
        /// </summary>
        public string PrintDevice { get; set; }
        /// <summary>
        /// 获取或者设置报表模板文件完整限制名
        /// </summary>
        public string ReportFileName { get; set; }
    }
}