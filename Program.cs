/*
 * 由SharpDevelop创建。
 * 用户： fangyixin
 * 日期: 2018/12/8
 * 时间: 11:41
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
namespace _stringtest
{
	public class Car
	{
		public string color;
		public string carType;
		public int doorNum;
		public int speed;
		public void speedup()
		{
			speed +=5;
		}
		
		void speeddown()
		{
			speed-=5;
		}
		
		
	}
	class Program
	{
		public static void Main(string[] args)
		{		
			Car mycar = new Car();
			mycar.doorNum = 4;
			mycar.carType = "normal car";
			mycar.color = "Red";
			mycar.speed = 50;
			Console.WriteLine("mycar.doorNum="+mycar.doorNum+"\nmycar.color:"+mycar.color+"\r\nmycar.carType:"+mycar.carType+"\r\nspeed:"+mycar.speed);
			mycar.speedup();
			Console.WriteLine("after speed up the speed is:"+mycar.speed);
			Console.WriteLine("Press anykey to continue!...");
			Console.ReadKey();
			
		}
		

	}
}