using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startProgress()
        {
            progressBar1.Visible = true;// 顯示進度條控制元件.
            progressBar1.Minimum = 1;// 設定進度條最小值.
            progressBar1.Maximum = 15;// 設定進度條最大值.
            progressBar1.Value = 1;// 設定進度條初始值
            progressBar1.Step = 1;// 設定每次增加的步長
                           //建立Graphics物件
            Graphics g = this.progressBar1.CreateGraphics();
            for (int x = 1; x <= 15; x++)
            {
                //執行PerformStep()函式
                progressBar1.PerformStep();
                string str = Math.Round((100 * x / 15.0), 2).ToString("#0.00 ") + "%";
                Font font = new Font("Times New Roman", (float)10, FontStyle.Regular);
                PointF pt = new PointF(this.progressBar1.Width / 2 - 17, this.progressBar1.Height / 2 - 7);
                g.DrawString(str, font, Brushes.Blue, pt);
                //每次迴圈讓程式休眠300毫秒
                System.Threading.Thread.Sleep(300);
            }
            progressBar1.Visible = false;
            //MessageBox.Show("success!");
        }

        //private void startProgress()
        //{
        //    // 顯示進度條控制元件.
        //    progressBar1.Visible = true;
        //    // 設定進度條最小值.
        //    progressBar1.Minimum = 1;
        //    // 設定進度條最大值.
        //    progressBar1.Maximum = 15;
        //    // 設定進度條初始值
        //    progressBar1.Value = 1;
        //    // 設定每次增加的步長
        //    progressBar1.Step = 1;

        //    // 迴圈執行
        //    for (int x = 1; x <= 15; x++)
        //    {
        //        // 每次迴圈讓程式休眠300毫秒
        //        System.Threading.Thread.Sleep(300);
        //        // 執行PerformStep()函式
        //        progressBar1.PerformStep();
        //    }
        //    progressBar1.Visible = false;
        //    MessageBox.Show("success!");
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {
            startProgress();
        }
        
    }
}
