﻿/********************************************************************
 * Develop by Jimmy Hu												*
 * This program is licensed under the Apache License 2.0.			*
 * DataArray.cs														*
 * 本檔案建立繪圖資料陣列單元物件									*
 ********************************************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataGraphic.CSharpFiles
{                                                                               //	namespace start, 進入命名空間
	class DataArray                                                             //	DataArray class, DataArray類別
	{                                                                           //	DataArray class start, 開始DataArray類別
		/// <summary>
		/// GraphicData is the queue for storing the graphic data.
		/// GraphicData陣列用於儲存繪圖資料
		/// </summary>
		private object[] GraphicData;                                           //	GraphicData object, GraphicData陣列物件

		/// <summary>
		/// GraphicDataIndex variable is the number record the array index of the new data. 
		/// GraphicDataIndex變數用於紀錄新資料寫入index
		/// </summary>
		private int GraphicDataIndex;                                           //	GraphicDataIndex variable, GraphicDataIndex變數

		/// <summary>
		/// DataArrayName is the name of DataArray.
		/// DataArray名稱
		/// </summary>
		private string DataArrayName;                                           //	DataArrayName string, DataArrayName字串

		/// <summary>
		/// GraphicDataArrayMax is the max number of count of GraphData elements.
		/// GraphicDataArrayMax為GraphData物件數量上限
		/// </summary>
		private int GraphicDataArrayMax;                                        //	GraphicDataArrayMax variable, GraphicDataArrayMax變數

		/// <summary>
		/// DataArray constructor, DataArray建構子
		/// </summary>
		/// <param name="NewDataArrayName">為DataArray名稱</param>
		public DataArray(string NewDataArrayName)                               //	DataArray constructor, DataArray建構子
		{                                                                       //	DataArray constructor start, 進入DataArray建構子
			this.GraphicDataArrayMax = 100;                                     //	initialize GraphicDataArrayMax, 初始化GraphicDataArrayMax變數
			this.DataArrayName = NewDataArrayName;                              //	initialize DataArrayName, 初始化DataArrayName字串
			this.GraphicDataIndex = 0;                                          //	initialize GraphicDataIndex, 初始化GraphicDataIndex變數
			Array.Resize<object>(ref this.GraphicData, this.GraphicDataArrayMax);
			//	initialize GraphicData, 初始化GraphicData物件(配置陣列大小空間)
			InitializeGraphicData(0);                                           //	call InitializeGraphicData method, 呼叫InitializeGraphicData方法
		}                                                                       //	DataArray constructor end, 結束DataArray建構子

		/// <summary>
		/// DataArray constructor with NewGraphicDataArrayMax, 具NewGraphicDataArrayMax輸入之DataArray建構子
		/// </summary>
		/// <param name="NewDataArrayName">為DataArray名稱</param>
		/// <param name="NewGraphicDataArrayMax">為GraphicDataArray資料儲存數量上限值</param>
		public DataArray(string NewDataArrayName, int NewGraphicDataArrayMax)   //	DataArray constructor, DataArray建構子
		{                                                                       //	DataArray constructor start, 進入DataArray建構子
			this.DataArrayName = NewDataArrayName;                              //	initialize DataArrayName, 初始化DataArrayName字串
			this.GraphicDataArrayMax = NewGraphicDataArrayMax;                  //	initialize GraphicDataArrayMax, 初始化GraphicDataArrayMax變數
			this.GraphicDataIndex = 0;                                          //	initialize GraphicDataIndex, 初始化GraphicDataIndex變數
			Array.Resize<object>(ref this.GraphicData, this.GraphicDataArrayMax);
			//	initialize GraphicData, 初始化GraphicData物件(配置陣列大小空間)
			InitializeGraphicData(0);                                           //	call InitializeGraphicData method, 呼叫InitializeGraphicData方法
		}                                                                       //	DataArray constructor end, 結束DataArray建構子

		/// <summary>
		/// DataArray constructor with NewGraphicDataArrayMax, InitialValue, 具NewGraphicDataArrayMax與InitialValue輸入之DataArray建構子
		/// </summary>
		/// <param name="NewDataArrayName"></param>
		/// <param name="NewGraphicDataArrayMax"></param>
		/// <param name="InitialValue"></param>
		public DataArray(string NewDataArrayName, int NewGraphicDataArrayMax, int InitialValue)
		//	DataArray constructor, DataArray建構子
		{                                                                       //	DataArray constructor start, 進入DataArray建構子
			this.DataArrayName = NewDataArrayName;                              //	initialize DataArrayName, 初始化DataArrayName字串
			this.GraphicDataArrayMax = NewGraphicDataArrayMax;                  //	initialize GraphicDataArrayMax, 初始化GraphicDataArrayMax變數
			this.GraphicDataIndex = 0;                                          //	initialize GraphicDataIndex, 初始化GraphicDataIndex變數
			Array.Resize<object>(ref this.GraphicData, this.GraphicDataArrayMax);
			//	initialize GraphicData, 初始化GraphicData物件(配置陣列大小空間)
			InitializeGraphicData(InitialValue);                                //	call InitializeGraphicData method, 呼叫InitializeGraphicData方法
		}                                                                       //	DataArray constructor end, 結束DataArray建構子

		/// <summary>
		/// InitializeGraphicData method assign initial value to GraphicData
		/// InitializeGraphicData方法給定GraphicData初始值
		/// </summary>
		/// <param name="InitialValue">Initial value</param>
		private void InitializeGraphicData(int InitialValue)                    //	InitializeGraphicData method, InitializeGraphicData方法
		{                                                                       //	InitializeGraphicData method start, 進入InitializeGraphicData方法
			for (int index = 0; index < this.GraphicDataArrayMax; index++)      //	initialize GraphicData, 初始化GraphicData物件數值
			{                                                                   //	for statement start, 進入for敘述
				GraphicData[index] = InitialValue;								//	assign initial value, 填入初始數值
			}                                                                   //	for statement end, 結束for敘述
		}                                                                       //	InitializeGraphicData method end, 結束InitializeGraphicData方法

		/// <summary>
		/// GetGraphicDataArrayMax return GraphicDataArrayMax.
		/// GetGraphicDataArrayMax方法回傳GraphicDataArrayMax變數
		/// </summary>
		/// <returns>GraphicDataArrayMax</returns>
		public int GetGraphicDataArrayMax()                                     //	GetGraphicDataArrayMax method, GetGraphicDataArrayMax方法
		{                                                                       //	GetGraphicDataArrayMax method start, 進入GetGraphicDataArrayMax方法
			return this.GraphicDataArrayMax;                                    //	return GraphicDataArrayMax, 回傳GraphicDataArrayMax
		}                                                                       //	GetGraphicDataArrayMax method end, 結束GetGraphicDataArrayMax方法

		/// <summary>
		/// AddData method would add new data into queue.
		/// AddData方法用於存入新資料至Queue
		/// </summary>
		/// <param name="InputData">欲紀錄至Queue之資料</param>
		public void AddData(object InputData)                                   //	AddData method, AddData方法
		{                                                                       //	AddData method start, 進入AddData方法
			GraphicData[GraphicDataIndex] = InputData;                          //	add data into GraphicData, 新增資料至GraphicData陣列
			GraphicDataIndex = (GraphicDataIndex + 1) % this.GraphicDataArrayMax;
			//	calculate next index, 計算下一筆資料存放的位置
		}                                                                       //	AddData method end, 結束AddData方法

		/// <summary>
		/// GetGraphicData method would return the GraphicData object.
		/// GetGraphicData方法用於回傳GraphicData物件
		/// </summary>
		/// <returns>GraphicData object, GraphicData物件</returns>
		public object[] GetGraphicData()										//	GetGraphicData method, GetGraphicData方法
		{                                                                       //	GetGraphicData method start, 進入GetGraphicData方法
			return GraphicData;                                                 //	return GraphicData object, 回傳GraphicData物件
		}                                                                       //	GetGraphicData method end, 結束GetGraphicData方法

		/// <summary>
		/// GetDataArrayName method would return DataArrayName.
		/// GetDataArrayName方法用於回傳DataArrayName
		/// </summary>
		/// <returns>DataArrayName</returns>
		public string GetDataArrayName()                                        //	GetDataArrayName method, GetDataArrayName方法
		{                                                                       //	GetDataArrayName method start, 進入GetDataArrayName方法
			return this.DataArrayName;                                          //	return DataArrayName, 回傳DataArrayName
		}                                                                       //	GetDataArrayName method end, 結束GetDataArrayName方法

	}                                                                           //	DataArray class end, 結束DataArray類別
}                                                                               //	namespace end, 結束命名空間
