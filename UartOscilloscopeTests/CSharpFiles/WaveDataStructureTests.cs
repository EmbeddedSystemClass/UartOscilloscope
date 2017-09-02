﻿using Microsoft.VisualStudio.TestTools.UnitTesting;                             //	使用Microsoft.VisualStudio.TestTools.UnitTesting函式庫
using UartOscilloscope;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UartOscilloscope.Tests                                                //	UartOscilloscope.Tests命名空間
{                                                                               //	進入命名空間
	[TestClass()]
	public class WaveDataStructureTests                                         //	WaveDataStructureTests類別
	{                                                                           //	進入WaveDataStructureTests類別
		[TestMethod()]
		public void AddDataTest()                                               //	AddDataTest方法
		{                                                                       //	進入AddDataTest方法
			WaveDataStructure WaveDataStructureTest1;                           //	宣告WaveDataStructureTest1物件
			int ArrayMax = 3;                                                   //	宣告ArrayMax變數，用於給定WaveDataStructureTest物件空間
			int[] TestData = new int[]{ 3, 2, 1 };								//	建立測試資料
			WaveDataStructureTest1 = new WaveDataStructure(ArrayMax);           //	初始化測試物件

			WaveDataStructureTest1.AddData(3);

			WaveDataStructureTest1.AddData(2);

		}                                                                       //	結束AddDataTest方法
		/// <summary>
		/// WaveDataStructureInitialTest方法用於測試WaveDataStructure初始化功能
		/// 若順利初始化，則內部陣列空間資料皆為0
		/// </summary>
		/// <returns></returns>
		private bool WaveDataStructureInitialTest()                             //	WaveDataStructureInitialTest方法
		{                                                                       //	進入WaveDataStructureInitialTest方法

		}                                                                       //	結束WaveDataStructureInitialTest方法
	}                                                                           //	結束WaveDataStructureTests類別
}                                                                               //	結束命名空間