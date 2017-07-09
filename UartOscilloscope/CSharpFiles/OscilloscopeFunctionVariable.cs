﻿/********************************************************************
 * Develop by Jimmy Hu												*
 * This program is licensed under the Apache License 2.0.			*
 * OscilloscopeFunctionVariable.cs								*
 * 本檔案撰寫OscilloscopeFunctionVariable類別以宣告Oscilloscope	*
 * 功能實作變數														*
 ********************************************************************
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UartOscilloscope														//	命名空間為本程式
{																				//	進入命名空間
	/**	OscilloscopeFunctionVariable類別宣告示波器功能實作變數 **
	 */
	class OscilloscopeFunctionVariable											//	OscilloscopeFunctionVariable類別
	{																			//	進入OscilloscopeFunctionVariable類別
		public static int[] ADC_Raw_Data_X;										//	宣告ADC_Raw_Data_X全域整數陣列變數，記錄X通道ADC原始資料
		public static int[] ADC_Raw_Data_Y;										//	宣告ADC_Raw_Data_Y全域整數陣列變數，記錄Y通道ADC原始資料
		public static int[] ADC_Raw_Data_Z;										//	宣告ADC_Raw_Data_Z全域整數陣列變數，記錄Z通道ADC原始資料
		public static int ADC_Raw_Data_X_num = 0;								//	宣告ADC_Raw_Data_X_num全域整數變數，記錄ADC_Raw_Data_X資料量
		public static int ADC_Raw_Data_Y_num = 0;								//	宣告ADC_Raw_Data_Y_num全域整數變數，記錄ADC_Raw_Data_Y資料量
		public static int ADC_Raw_Data_Z_num = 0;								//	宣告ADC_Raw_Data_Z_num全域整數變數，記錄ADC_Raw_Data_Z資料量
		private static int ADC_Raw_Data_Max = 100;								//	宣告ADC_Raw_Data_Max全域整數變數，記錄ADC_Raw_Data陣列大小
		public static Queue<int> Data_Graphic_Queue_X;							//	宣告X通道資料繪圖用整數型態佇列Data_Graphic_Queue_X
		public static Queue<int> Data_Graphic_Queue_Y;							//	宣告Y通道資料繪圖用整數型態佇列Data_Graphic_Queue_Y
		public static Queue<int> Data_Graphic_Queue_Z;							//	宣告Z通道資料繪圖用整數型態佇列Data_Graphic_Queue_Z

		public static int Get_ADC_Raw_Data_Max()								//	宣告Get_ADC_Raw_Data_Max方法
		{																		//	進入Get_ADC_Raw_Data_Max方法
			return OscilloscopeFunctionVariable.ADC_Raw_Data_Max;				//	回傳ADC_Raw_Data_Max數值
		}																		//	結束Get_ADC_Raw_Data_Max方法
	}																			//	結束OscilloscopeFunctionVariable類別
}																				//	結束命名空間
