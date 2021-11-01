using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//建立判断类
class JudgeJoF
{
	//判断完成后路径定义
	public string Jpath = null;
	public string Fpath = null;
	//创建rs实例
	public ResSpliter rs = new ResSpliter();
	//创建rc实例
	public ResCrafter rc = new ResCrafter();
	//判断是json还是dir路径
	public void Judge(string filepath)
	{

		try
		{
			if (File.Exists(filepath))
			{
				Console.WriteLine("已检测到为json文件，进行分解处理");
				this.Jpath = filepath;
				rs.ResSplit(this.Jpath);
			}
			else if (Directory.Exists(filepath))
			{
				Console.WriteLine("已检测到为dir文件夹，进行合成处理");
				this.Fpath = filepath;
				rc.ResCraft(this.Fpath);
			}
			else
			{
				Console.WriteLine("未检测到文件或文件夹！请检查！");
			}
		}
		catch
		{
			Console.WriteLine("ERROR");

		}

	}
}