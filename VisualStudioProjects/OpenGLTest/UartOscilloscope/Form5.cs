﻿using System;                                                                   //  使用System函式庫
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                                                     //  使用System.Windows.Forms函式庫
using System.Globalization;                                                     //  使用System.Windows.Forms函式庫

namespace WindowsFormsApplication6                                              //  命名空間為本程式
{                                                                               //  進入命名空間
    public partial class Form5 : Form                                           //  Form5類別
    {                                                                           //  進入Form5類別
        public Form5()                                                          //  宣告Form5
        {                                                                       //  進入Form5
            InitializeComponent();                                              //  初始化表單
        }                                                                       //  結束Form5
        private void Form5_Load(object sender, EventArgs e)                     //  宣告Form5_Load副程式，Form5表單載入時執行
        {                                                                       //  進入Form5_Load副程式
            label2.Text = Form4.Debug_Login_Account_Input.Debug_Login_Account;  //  顯示登入之除錯帳號
            Debug_Information_Refresh();                                        //  呼叫Debug_Information_Reflash副程式
            timer1.Interval = 100;                                              //  設定timer1執行頻率
            timer1.Enabled = true;                                              //  啟動timer1，即時更新除錯資訊
        }                                                                       //  結束Form5_Load副程式
        private void timer1_Tick(object sender, EventArgs e)                    //  宣告timer1_Tick副程式
        {                                                                       //  進入timer1_Tick副程式
            Debug_Information_Refresh();                                        //  呼叫Debug_Information_Reflash副程式
        }                                                                       //  結束timer1_Tick副程式
        private void button1_Click(object sender, EventArgs e)                  //  宣告button1_Click副程式，當按下button1時執行
        {                                                                       //  進入button1_Click副程式
            Debug_Information_Reset();                                          //  呼叫Debug_Information_Reset除錯資料重置副程式
        }                                                                       //  結束button1_Click副程式
        public void Debug_Information_Refresh()                                 //  宣告Debug_Information_Refresh除錯資料更新副程式
        {                                                                       //  進入除錯資料更新副程式
            Form1.localDate = DateTime.Now;                                     //  更新現在時間
            label4.Text = Form4.Login_Date.ToString();                          //  顯示除錯模式登入時間
            label6.Text = (Form1.localDate.ToString());                         //  顯示現在時間
            label8.Text = Form1.COM_Port_num.ToString();                        //  顯示已連線之Serialport數量
            label10.Text = Form1.list_SerialPort_Runtimes.ToString();           //  顯示list_SerialPort副程式執行次數
            label12.Text = Form1.comport_DataReceived_Runtimes.ToString();      //  顯示comport_DataReceived副程式執行次數
            label14.Text = Form1.Uart_comport_handle_Runtimes.ToString();       //  顯示Uart_comport_handle副程式執行次數
            label16.Text = Form1.DisplayText_Runtimes.ToString();               //  顯示DisplayText副程式執行次數
            label18.Text = Form1.button1_Click_Runtimes.ToString();             //  顯示button1_Click副程式執行次數
            label20.Text = Form1.button2_Click_Runtimes.ToString();             //  顯示button2_Click副程式執行次數
            label22.Text = Form1.button3_Click_Runtimes.ToString();             //  顯示button3_Click副程式執行次數
            label24.Text = Form1.Transmission_Setting_Click_Runtimes.ToString();
            //  顯示設定_傳輸設定ToolStripMenuItem_Click副程式
            label26.Text = Form1.User_Interface_Setting_Click_Runtimes.ToString();
            //  顯示設定_介面設定ToolStripMenuItem_Click副程式執行次數
            label101.Text = Form1.Uart_Buffer_Size.ToString();                  //  顯示Uart接收資料Buffer大小
            textBox1.Text = Form1.Uart_Buffer_ASCII_Data;                       //  顯示Uart傳輸之Buffer資料(ASCII編碼值)
            label201.Text = Form1.Error_Code.ToString();                        //  顯示Error_Code
        }                                                                       //  結束除錯資料更新副程式
        public void Debug_Information_Reset()                                   //  宣告Debug_Information_Reset除錯資料重置副程式
        {                                                                       //  進入除錯資料重置副程式
            Form1.list_SerialPort_Runtimes = 0;                                 //  將list_SerialPort_Runtimes變數歸零
            Form1.comport_DataReceived_Runtimes = 0;                            //  將comport_DataReceived_Runtimes變數歸零
            Form1.Uart_comport_handle_Runtimes = 0;                             //  將Uart_comport_handle_Runtimes變數歸零
            Form1.DisplayText_Runtimes = 0;                                     //  將DisplayText_Runtimes變數歸零
            Form1.button1_Click_Runtimes = 0;                                   //  將button1_Click_Runtimes變數歸零
            Form1.button2_Click_Runtimes = 0;                                   //  將button2_Click_Runtimes變數歸零
            Form1.button3_Click_Runtimes = 0;                                   //  將button3_Click_Runtimes變數歸零
            Form1.Transmission_Setting_Click_Runtimes = 0;                      //  將Transmission_Setting_Click_Runtimes變數歸零
            Form1.User_Interface_Setting_Click_Runtimes = 0;                    //  將User_Interface_Setting_Click_Runtimes變數歸零
        }                                                                       //  結束除錯資料重置副程式
    }                                                                           //  結束Form5類別
}                                                                               //  結束命名空間
