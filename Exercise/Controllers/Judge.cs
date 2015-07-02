using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace Exercise.Controllers
{
    public partial class Judge : UserControl
    {
        private DBServer dbs;
        private DataTable dt;

        private int priCountTotal = Convert.ToInt32(Form_Con.judgeTotal * 0.3);
        private int midCountTotal = Convert.ToInt32(Form_Con.judgeTotal * 0.4);
        private int highCountTotal = Convert.ToInt32(Form_Con.judgeTotal * 0.3);
        
        private int priCountCur;
        private int midCountCur;
        private int highCountCur;

        private List<int> priExist;
        private List<int> midExist;
        private List<int> highExist;

        private string tabName = "";
        private string answer = "";
        private int tabNum = 0;

        public Judge()
        {
            InitializeComponent();
        }

        private void SetPriNameAndNum()
        {
            Random rad = new Random();
            tabName = "judge_pri";
            int tabRange = int.Parse(dbs.GetCount(tabName).Rows[0][0].ToString()); 
            do
            {
                tabNum = rad.Next(1, tabRange + 1);
            } while (priExist.Contains(tabNum));
            Form_Con.jPriExist.Add(tabNum);
            Form_Con.jPriCountCur++;
        }

        private void SetMidNameAndNum()
        {
            Random rad = new Random();
            tabName = "judge_mid";
            int tabRange = int.Parse(dbs.GetCount(tabName).Rows[0][0].ToString()); 
            do 
            {
                tabNum = rad.Next(1, tabRange + 1);
            } while (midExist.Contains(tabNum));
            Form_Con.jMidExist.Add(tabNum);
            Form_Con.jMidCountCur++;
        }
        private void SetHighNameAndNum()
        {
            Random rad = new Random();
            tabName = "judge_high";
            int tabRange = int.Parse(dbs.GetCount(tabName).Rows[0][0].ToString());
            do
            {
                tabNum = rad.Next(1, tabRange + 1);
            } while (highExist.Contains(tabNum));
            Form_Con.jHighExist.Add(tabNum);
            Form_Con.jHighCountCur++;
        }

        private void Judge_Load(object sender, EventArgs e)
        {
            this.lab_num.Text = Program.count+".";
            dbs = new DBServer();
            Random rad = new Random();

            priCountCur = Form_Con.jPriCountCur;
            midCountCur = Form_Con.jMidCountCur;
            highCountCur = Form_Con.jHighCountCur;

            priExist = Form_Con.jPriExist;
            midExist = Form_Con.jMidExist;
            highExist = Form_Con.jHighExist;

            if (priCountCur < priCountTotal && midCountCur < midCountTotal && highCountCur < highCountTotal)
            {
                int valueSign = rad.Next(1, 31);//  >=1，<31

                if (0 == valueSign % 3)
                {
                    SetPriNameAndNum();
                }
                else if (1 == valueSign % 3)
                {
                    SetMidNameAndNum();
                }
                else
                {
                    SetHighNameAndNum();
                }
            }
            else if (priCountCur >= priCountTotal && midCountCur < midCountTotal && highCountCur < highCountTotal)
            {
                int valueSign = rad.Next(1, 11);//  >=1，<11
                if (0 == valueSign % 2)
                {
                    SetMidNameAndNum();
                }
                else
                {
                    SetHighNameAndNum();
                }
            }
            else if (priCountCur < priCountTotal && midCountCur >= midCountTotal && highCountCur < highCountTotal)
            {
                int valueSign = rad.Next(1, 11);//  >=1，<11
                if (0 == valueSign % 2)
                {
                    SetPriNameAndNum();
                }
                else
                {
                    SetHighNameAndNum();
                }
            }
            else if (priCountCur < priCountTotal && midCountCur < midCountTotal && highCountCur >= highCountTotal)
            {
                int valueSign = rad.Next(1, 11);//  >=1，<11
                if (0 == valueSign % 2)
                {
                    SetPriNameAndNum();
                }
                else
                {
                    SetMidNameAndNum();
                }
            }
            else if (priCountCur >= priCountTotal && midCountCur >= midCountTotal && highCountCur < highCountTotal)
            {
                SetHighNameAndNum();
            }
            else if (priCountCur >= priCountTotal && midCountCur < midCountTotal && highCountCur >= highCountTotal)
            {
                SetMidNameAndNum();
            }
            else if (priCountCur < priCountTotal && midCountCur >= midCountTotal && highCountCur >= highCountTotal)
            {
                SetPriNameAndNum();
            }

            dt = dbs.GetCon(tabName, tabNum);
            answer = dt.Rows[0]["answer"].ToString().Trim();
            this.textBox.Text = dt.Rows[0]["contant"].ToString();
        }

        public bool GetChecked()
        {
            if (false == T.Checked && false == F.Checked)
                return false;
            return true;
        }

        public bool GetCorrectSign()
        {
            Control c = Controls.Find(answer, true)[0];
            object o = c.GetType().GetProperty("Checked").GetValue(c, null);
            bool res = (bool)o;

            return res;
        }

        public string getAnswer()
        {
            return answer;
        }
    }
}
