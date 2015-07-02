using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace Exercise
{
    public partial class Form_Con : Form
    {
        public static int chooseTotal = 5;
        public static int judgeTotal = 5;

        public static int  cPriCountCur = 0;
        public static int cMidCountCur = 0;
        public static int cHighCountCur = 0;

        public static int jPriCountCur = 0;
        public static int jMidCountCur = 0;
        public static int jHighCountCur = 0;

        public static List<int> cPriExist = new List<int>();
        public static List<int> cMidExist = new List<int>();
        public static List<int> cHighExist = new List<int>();

        public static List<int> jPriExist = new List<int>();
        public static List<int> jMidExist = new List<int>();
        public static List<int> jHighExist = new List<int>();

        private int chooseCur = 0;
        private int judgeCur = 0;

        private Controllers.Choose c;
        private Controllers.Judge j;

        private int errorNums = 0;
  
        public Form_Con()
        {
            InitializeComponent();
        }

        private void Form_Choose_Load(object sender, EventArgs e)
        {
            try
            {
                c = new Controllers.Choose();
                panel_con.Controls.Add(c);
                chooseCur++;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("请查看Office版本是否在2007以上");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bool checkSign = false;
            bool correctSign = false;
            string answer = "";
            switch (this.panel_con.Controls[0].Name)
            {
                case "Choose":
                    checkSign = c.GetChecked();
                    correctSign = c.GetCorrectSign();
                    answer = c.getAnswer();
                    break;
                case "Judge":
                    checkSign = j.GetChecked();
                    correctSign = j.GetCorrectSign();
                    answer = j.getAnswer();
                    break;
            }
            if(!checkSign)
            {
                MessageBox.Show("请选择");
            }
            else
            {
                //核对前一道题
                if (!correctSign)
                {
                    errorNums++;
                    MessageBox.Show("选择有误，正确答案是"+answer);
                }

                //显示下一道题
                Program.count++;

                //已完成所有题目
                if (Program.count == chooseTotal+judgeTotal+1)
                {
                    int total = chooseTotal + judgeTotal;
                    MessageBox.Show("已完成"+total+"道题，共错误"+errorNums+"道题");
                    this.Close();
                }

                //随机抽取选择或者判断
                if (chooseCur < chooseTotal && judgeCur < judgeTotal)
                {
                    Random rad = new Random();
                    int valueSign = rad.Next(1, 21);//  >=1，<21
                    if (0 == valueSign % 2)
                    {
                        j = new Controllers.Judge();
                        panel_con.Controls.Clear();
                        panel_con.Controls.Add(j);
                        judgeCur++;
                    } 
                    else
                    {
                        c = new Controllers.Choose();
                        panel_con.Controls.Clear();
                        panel_con.Controls.Add(c);
                        chooseCur++;
                    }
                }

                //只能选择
                else if (chooseCur < chooseTotal )
                {
                    c = new Controllers.Choose();
                    panel_con.Controls.Clear();
                    panel_con.Controls.Add(c);
                    chooseCur++;
                }

                //只能判断
                else if (judgeCur < judgeTotal)
                {
                    j = new Controllers.Judge();
                    panel_con.Controls.Clear();
                    panel_con.Controls.Add(j);
                    judgeCur++;
                }

                //最后一道题
                if (Program.count == chooseTotal+judgeTotal)
                {
                    this.btn_next.Text = "完成";
                }
            }
        }
    }
}
