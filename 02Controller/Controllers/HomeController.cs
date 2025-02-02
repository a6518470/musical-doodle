﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02Controller.Controllers
{
    public class HomeController : Controller
    {
        //02-1-3 建立一般方法ShowAry()-計算陣列總合
        public string ShowAry()
        {
            int[] score = { 78, 99, 20, 100, 66 };
            string show = "";
            int sum = 0;
            foreach (var m in score)
            {
                show += m + ", ";
                sum += m;
            }
            show += "<hr>";
            show += "總合:" + sum;
            return show;
        }

        //02-1-5 建立一般方法ShowImages()-傳回顯示1.jpg~8.jpg的HTML字串
        public string ShowImages()
        {

            string show = "";
            for (int i = 1; i <= 8; i++)
            {
                show += "<img src='../images/" + i + ".jpg' width='150' />";
            }


            return show;
        }

        //02-1-7 建立一般方法ShowImageIndex()-依index參數取得對應圖示與說明
        public string ShowImagesIndex(int index)
        {

            string[] name = { "櫻桃鴨", "鴨油高麗菜", "鴨油麻婆豆腐", "櫻桃鴨握壽司", "片皮鴨捲三星蔥", "三杯鴨", "櫻桃鴨片肉", "慢火白菜燉鴨湯" };
            string show = string.Format("<p align='center'><img src='../images/{0}.jpg' /><br>{1}</p>", index, name[index - 1]);

            return show;
        }

        //輸出的結果必須從大到小排序 傳址寫法
        public string ShowSortAry()
        {
            int[] score = { 78, 99, 20, 100, 66 };
            score = MySort(score);
            string show = "";

            foreach (var m in score)
            {
                show += m + ", ";

            }

            return show;
        }    
        private int[] MySort(int[] arrScore)
        {
            int tmp = 0;
            for (int i = arrScore.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arrScore[j] < arrScore[j + 1])
                    {
                        tmp = arrScore[j];
                        arrScore[j] = arrScore[j + 1];
                        arrScore[j + 1] = tmp;
                    }
                }
            }

            return arrScore;
        }

        //輸出的結果必須從大到小排序 LinQ寫法
        public string ShowSortAry2()
        {
            int[] score = { 78, 99, 20, 100, 66 };

            //Linq
            var s = from m in score
                    orderby m descending
                    select m;

            string show = "";

            foreach (var m in s)
            {
                show += m + ", ";

            }

            return show;
        }



    }
}

//02-1 Controller撰寫練習-一般方法
//02-1-1 在Controllers資料夾上按右鍵,加入,控制器,選擇 MVC5Controller-Empty
//02-1-2 指定控制器名稱為HomeController,並開啟HomeController
//02-1-3 建立一般方法ShowAry()-計算陣列總合
//02-1-4 執行並測試 http://localhost:53468/Home/ShowAry (port可能不同)
//02-1-5 建立一般方法ShowImages()-傳回顯示images資料夾裡1.jpg~8.jpg的HTML字串
//02-1-6 執行並測試 http://localhost:53468/Home/ShowImages (port可能不同)
//02-1-7 建立一般方法ShowImageIndex()-依index參數取得對應圖示與說明
//02-1-8 執行並測試 http://localhost:53468/Home/ShowImageIndex?index=1 (port可能不同)