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
    public partial class Choose : UserControl
    {
        private DBServer dbs;
        private DataTable dt;

        private int priCountTotal = Convert.ToInt32(Form_Con.chooseTotal*0.3);
        private int midCountTotal = Convert.ToInt32(Form_Con.chooseTotal * 0.4);
        private int highCountTotal = Convert.ToInt32(Form_Con.chooseTotal * 0.3);

        private int priCountCur;
        private int midCountCur;
        private int highCountCur;

        private List<int> priExist;
        private List<int> midExist;
        private List<int> highExist;

        private string tabName = "";
        private string answer = "";
        private int tabNum = 0;

        public Choose()
        {
            InitializeComponent();
        }

        private void SetPriNameAndNum()
        {
            Random rad = new Random();
            tabName = "choose_pri";
            int tabRange = int.Parse(dbs.GetCount(tabName).Rows[0][0].ToString());
            do
            {
                tabNum = rad.Next(1, tabRange + 1);
            } while (priExist.Contains(tabNum));
            Form_Con.cPriExist.Add(tabNum);
            Form_Con.cPriCountCur++;
        }

        private void SetMidNameAndNum()
        {
            Random rad = new Random();
            tabName = "choose_mid";
            int tabRange = int.Parse(dbs.GetCount(tabName).Rows[0][0].ToString());
            do
            {
                tabNum = rad.Next(1, tabRange + 1);
            } while (midExist.Contains(tabNum));
            Form_Con.cMidExist.Add(tabNum);
            Form_Con.cMidCountCur++;
        }
        private void SetHighNameAndNum()
        {
            Random rad = new Random();
            tabName = "choose_high";
            int tabRange = int.Parse(dbs.GetCount(tabName).Rows[0][0].ToString());
            do
            {
                tabNum = rad.Next(1, tabRange + 1);
            } while (highExist.Contains(tabNum));
            Form_Con.cHighExist.Add(tabNum);
            Form_Con.cHighCountCur++;
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            this.lab_num.Text = Program.count + ".";
            dbs = new DBServer();
            Random rad = new Random();

            priCountCur = Form_Con.cPriCountCur;
            midCountCur = Form_Con.cMidCountCur;
            highCountCur = Form_Con.cHighCountCur;

            priExist = Form_Con.cPriExist;
            midExist = Form_Con.cMidExist;
            highExist = Form_Con.cHighExist;

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
                if (0 == valueSign%2)
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
            else if(priCountCur < priCountTotal && midCountCur < midCountTotal && highCountCur >= highCountTotal)
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
            this.A.Text = "A."+dt.Rows[0]["A"].ToString();
            this.B.Text = "B." + dt.Rows[0]["B"].ToString();
            this.C.Text = "C." + dt.Rows[0]["C"].ToString();
            this.D.Text = "D." + dt.Rows[0]["D"].ToString();
        }

        public bool GetChecked()
        {
            if (false == A.Checked && false == B.Checked && false == C.Checked && false == D.Checked)
                return false;
            return true;
        }

        public bool GetCorrectSign()
        {
            Control c = Controls.Find(answer,true)[0];
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
