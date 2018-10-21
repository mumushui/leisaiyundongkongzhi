using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csLTDMC;
namespace io检测
{
    public partial class Form1 : Form
    {
        UInt16 CardNo = 0;//设置运动控制卡卡号。
        int j;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LTDMC.dmc_board_init();
            UInt16 enable, alm_logic, alm_action;
            enable = 1;//ALM 信号使能，0：禁止，1：允许
            alm_logic = 1;//ALM 信号的有效电平，0：低有效，1：高有效
            alm_action = 0;
            LTDMC.dmc_set_alm_mode(CardNo, 0, enable, alm_logic, alm_action);
            LTDMC.dmc_get_alm_mode(CardNo, 0, ref enable, ref alm_logic, ref alm_action);


            LTDMC.dmc_set_alm_mode(CardNo, 1, enable, alm_logic, alm_action);
            LTDMC.dmc_get_alm_mode(CardNo, 1, ref enable, ref alm_logic, ref alm_action);
            if (alm_logic == 1)
            {
                almbox1.BackColor = Color.Green;
            }
            else almbox1.BackColor = Color.Red;
            enable = 1;
            LTDMC.dmc_set_alm_mode(CardNo, 3, enable, alm_logic, alm_action);
            LTDMC.dmc_get_alm_mode(CardNo, 3, ref enable, ref alm_logic, ref alm_action);
            if (alm_logic == 1)
            {
                almbox3.BackColor = Color.Green;
            }
            else almbox3.BackColor = Color.Red;
            //LTDMC.dmc_write_sevon_pin(CardNo, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uint x, y, z;

            double alm, el1, el2, emg, org, sl1, sl2, inp, ez, rdy, dstp;
            double[] signal0 = new double[20];
            double[] signal1 = new double[20];
            double[] signal3 = new double[20];
            {//获取信号监控返回的数值
                z = LTDMC.dmc_axis_io_status(0, 0);
                {
                    for (j = 0; j < 12; j++)
                    {
                        x = z / 2;
                        y = z % 2;
                        signal0[j] = y;
                        z = x;

                    }
                }


                z = LTDMC.dmc_axis_io_status(0, 1);
                {
                    for (j = 0; j < 12; j++)
                    {
                        x = z / 2;
                        y = z % 2;
                        signal1[j] = y;
                        z = x;

                    }

                }

                z = LTDMC.dmc_axis_io_status(0, 3);
                {
                    for (j = 0; j < 12; j++)
                    {
                        x = z / 2;
                        y = z % 2;
                        signal3[j] = y;
                        z = x;

                    }
                }
            }


            short i;
            string name;//设置两个中间变量。

            {//读取电机驱动使能状态；
                i = LTDMC.dmc_read_sevon_pin(0, 0);//返回值：0：低电平，1：高电平；初始电机驱动使能电平为低电平；
                if (i == 0)
                {
                    sevonbox0.BackColor = Color.Green;

                }
                else sevonbox0.BackColor = Color.Red;
                i = LTDMC.dmc_read_sevon_pin(0, 1);
                if (i == 0)
                {
                    sevonbox1.BackColor = Color.Green;

                }
                else sevonbox1.BackColor = Color.Red;
                i = LTDMC.dmc_read_sevon_pin(0, 1);
                if (i == 0)
                {
                    sevonbox3.BackColor = Color.Green;

                }
                else sevonbox3.BackColor = Color.Red;
            }
            {//读取电机驱动报警alm信号情况；

                if (signal0[0] == 0)
                {
                    almbox0.BackColor = Color.Green;
                }
                else almbox0.BackColor = Color.Red;
                if (signal1[0] == 0)
                {
                    almbox1.BackColor = Color.Green;
                }
                else almbox1.BackColor = Color.Red;


                if (signal3[0] == 0)
                {
                    almbox3.BackColor = Color.Green;
                }

                else almbox3.BackColor = Color.Red;
            }
            { //读取erc电平信号
                {
                    i = LTDMC.dmc_read_erc_pin(CardNo, 0);
                    if (i == 0)
                    {
                        ercbox0.BackColor = Color.Green;

                    }
                    else ercbox0.BackColor = Color.Red;
                }
                {
                    i = LTDMC.dmc_read_erc_pin(CardNo, 1);
                    if (i == 0)
                    {
                        ercbox1.BackColor = Color.Green;

                    }
                    else ercbox1.BackColor = Color.Red;
                }
                {
                    i = LTDMC.dmc_read_erc_pin(CardNo, 0);
                    if (i == 0)
                    {
                        ercbox3.BackColor = Color.Green;

                    }
                    else ercbox3.BackColor = Color.Red;
                }

            }
            {//读取正限位信号elup（el+）
                if (signal0[1] == 0)
                {
                    elupBox0.BackColor = Color.Green;
                }
                else elupBox0.BackColor = Color.Red;
                if (signal1[1] == 0)
                {
                    elupBox1.BackColor = Color.Green;
                }
                else elupBox1.BackColor = Color.Red;
                if (signal3[1] == 0)
                {
                    elupBox3.BackColor = Color.Green;
                }
                else elupBox3.BackColor = Color.Red;

            }
            {//读取负限位信号eldown（el-）
                if (signal0[2] == 0)
                {
                    eldownBox0.BackColor = Color.Green;

                }
                else eldownBox0.BackColor = Color.Red;
                if (signal1[2] == 0)
                {
                    eldownBox1.BackColor = Color.Green;

                }
                else eldownBox1.BackColor = Color.Red;
                if (signal3[2] == 0)
                {
                    eldownBox3.BackColor = Color.Green;

                }
                else eldownBox3.BackColor = Color.Red;

            }
            {//读取到达原点信号
                if (signal0[4] == 0)
                {
                    orgBox0.BackColor = Color.Green;

                }
                else orgBox0.BackColor = Color.Red;
                if (signal1[4] == 0)
                {
                    orgBox1.BackColor = Color.Green;

                }
                else orgBox1.BackColor = Color.Red;

                if (signal3[4] == 0)
                {
                    orgBox3.BackColor = Color.Green;

                }
                else orgBox3.BackColor = Color.Red;
            }
            
            

            {//读取电机停止信号inp
                if (signal0[8] == 0)
                {
                    inpbox0.BackColor = Color.Green;
                }
                else inpbox0.BackColor = Color.Red;
                if (signal1[8] == 0)
                {
                    inpbox1.BackColor = Color.Green;
                }
                else inpbox1.BackColor = Color.Red;


                if (signal3[8] == 0)
                {
                    inpbox3.BackColor = Color.Green;
                }

                else inpbox3.BackColor = Color.Red;
            }


            {//读取电机准备信号
                if (signal0[10] == 1)
                {
                    rdybox0.BackColor = Color.Green;
                }
                else rdybox0.BackColor = Color.Red;
                if (signal1[10] == 1)
                {
                    rdybox1.BackColor = Color.Green;
                }
                else rdybox1.BackColor = Color.Red;


                if (signal3[10] == 1)
                {
                    rdybox3.BackColor = Color.Green;
                }

                else rdybox3.BackColor = Color.Red;
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LTDMC.dmc_board_close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //读取电机驱动报警信号使能情况；
            
        }
    }
}
