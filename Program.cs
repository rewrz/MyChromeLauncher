/*
 * 由SharpDevelop创建。
 * 用户： ChiaS(www.chias.me)
 * 日期: 2015/10/11
 * 时间: 14:31
 * GitHub：https://github.com/ChIaSg
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Diagnostics;

namespace MyChromeLauncher
{
	class Program
	{
		public static void Main(string[] args)
		{
			//自定义用户数据目录
			string userdata = "--user-data-dir=" + "\"" + System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "MyChromeData" + "\"";
			//自定义用户缓存目录
			string cache = "--disk-cache-dir=" + "\"" + System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "MyChromeCache" + "\""; 
			Console.WriteLine("用户数据目录：");
			Console.WriteLine(userdata);
			Console.WriteLine("用户缓存目录:");
			Console.WriteLine(cache);
			Console.WriteLine ("3秒后自动退出。");
			Process chrome = new Process();//建立外部调用线程
			chrome.StartInfo.FileName =@".\chrome.exe";//调用chrome（绝对路径）
			chrome.StartInfo.Arguments = userdata + " " + cache;//Chrome启动参数
			chrome.Start();//启动线程
			chrome.WaitForExit(3000);//等待进程结束(3秒后自动退出本进程)
			chrome.Close();//关闭线程
			chrome.Dispose();//释放资源
			System.Environment.Exit(0);//完全退出
		}
	}
}