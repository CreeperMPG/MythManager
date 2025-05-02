﻿using System.Windows;
using System.Windows.Controls;

namespace MythManager.Pages.About
{
    /// <summary>
    /// AboutIndex.xaml 的交互逻辑
    /// </summary>
    public partial class AboutIndex : UserControl
    {
        public AboutIndex()
        {
            InitializeComponent();
            VersionInfoBlock.Text = "1.1.0 Release";
            UpdateLogBlock.Text = "更新日志\n" +
                "1.1.0 Release\n" +
                "发布时间 2025-5-2 22:44\n" +
                "\t1. 修复了 1.1.0 Canary 2 限制解除失败的 Bug\n" +
                "\t2. 添加了解除任务栏右键菜单限制和强制⚡结束机房管理助手的功能\n" +
                "\n" +
                "1.1.0 (Canary 2)\n" +
                "发布时间 2025-5-1 23:00\n" +
                "\t1. 优化禁用机房管理助手的流程，修复了 1.1.0 Canary 1 禁用机房管理助手后右上角计算机名称未关闭的 Bug\n" +
                "\n" +
                "1.1.0 (Canary 1)\n" +
                "发布时间 2025-5-1 17:58\n" +
                "\t1. 优化界面\n" +
                "\t2. 新增“建议的操作”板块，程序未以管理员权限运行时会建议使用管理员权限\n" +
                "\t3. 优化禁用机房管理助手的流程，修复了 1.0.2 禁用机房管理助手后右上角计算机名称未关闭的 Bug\n" +
                "\n" +
                "1.0.2 Release\n" +
                "发布时间 2025-4-30 02:22\n" +
                "\t1. 新增 学生机房管理助手 控制板块，支持破解学生机房管理助手\n" +
                "\t2. 修复了主页极域打开后按钮文字未改变为“关闭极域”的 Bug\n" +
                "\n" +
                "1.0.1 Release\n" +
                "发布时间 2025-4-29 03:29\n" +
                "\t1. 重放攻击新增举手攻击\n" +
                "\t2. 重放攻击可以设置为无限攻击轮数\n" +
                "\t3. 修复了 1.0.1 Canary 2 出现的重放攻击对话框点击“暂停”“清空日志”按钮时窗口异常关闭的 Bug\n" +
                "\t4. 将重放攻击的日志功能改为仅发送错误日志\n" +
                "\t5. 添加关于页面\n" +
                "\n" +
                "1.0.1 (Canary 2)\n" +
                "发布时间 2025-4-27 01:52\n" +
                "\t1. 修复了 1.0.1 Canary 1 中新增的消息重放攻击无法正常使用的 Bug\n" +
                "\t2. 修复了 1.0.0 中极域关闭后重新打开时状态无法及时更新的 Bug\n" +
                "\n" +
                "1.0.1 (Canary 1)\n" +
                "发布时间 2025-4-26 00:42\n" +
                "\t1. 添加发送消息功能\n" +
                "\n" +
                "1.0.0 Release\n" +
                "发布时间 2025-4-23 02:41\n" +
                "\t1. 添加基础界面\n" +
                "\t2. 添加极域启停功能\n" +
                "\t3. 添加重放攻击功能，支持 指定多个IP 枚举局域网IP 分组发送数据包 多轮发送 日志显示。频繁发送不会失效\n" +
                "\t4. 重放攻击方式支持远程 CMD 命令（支持参数）";
#if LITE
            VersionInfoBlock.Text += " (轻量版)";
            VersionInfo.Description = "轻量版不支持部分功能。";
#endif
        }

        private void SettingsCard_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateLogBlock.Width = e.NewSize.Width - 50;
        }
    }
}
