using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csLTDMC;

namespace 雷赛运动控制
{
    public partial class Form1 : Form
    {
        UInt16 CardNo =0;//定义控制卡卡号
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         short n;
         UInt16 i;//定义轴数



        n = LTDMC.dmc_board_init() ;                 //控制卡的初始化操作，调用后必须使用dmc_board_close关闭卡。
        //中间不可再次调用该初始化函数。
        
        if (n <= 0)            //正常的卡数在1- 8之间
            {
                MessageBox.Show("初始化运动控制卡失败,请关闭其他运动控制卡程序");
            }
        //else if(n>8)
        //{
        //        MessageBox.Show("运动控制卡过多，请拔除多余的运动控制卡");
        //}
        
      
        for ( i=0;i<4;i++)
            {  LTDMC.dmc_set_pulse_outmode(CardNo, i, 0) ;    //设定脉冲输出模式
               LTDMC.dmc_write_sevon_pin(CardNo, i, 0);
               LTDMC.dmc_set_alm_mode(CardNo, i, 1, 1, 0);
               LTDMC.dmc_set_pulse_outmode(CardNo, i, 0);  
            }
        



        }

        private void EmgStopBtn_Click(object sender, EventArgs e)
        {
            LTDMC.dmc_emg_stop(CardNo);
        }

        private void OrgBtn_Click(object sender, EventArgs e)
        {
            UInt16 Pos0, Pos1, Pos3;
            UInt16 HomeDir1, HomeDir0, HomeDir3; 
            if (PosBox0.Text == null | PosBox1.Text == null | PosBox3.Text == null)
            {
                MessageBox.Show("请输入三轴相对原点感应器的位置");
            }
            else
            {
                
                UInt16.TryParse(PosBox0.Text, out Pos0);
                UInt16.TryParse(PosBox1.Text, out Pos1);
                UInt16.TryParse(PosBox3.Text, out Pos3);
                if (Pos0 > 0)
                {
                    HomeDir0 = 0;
                }
                else
                {
                    HomeDir0 = 1;


                }

                if (Pos1 > 0)
                {
                    HomeDir1 = 0;
                }
                else
                {
                    HomeDir1 = 1;
                }
                if (Pos3 > 0)
                {
                    HomeDir3 = 0;
                }
                else
                {
                    HomeDir3 = 1;
                }
                LTDMC.dmc_set_homemode(CardNo, 0, HomeDir0, 0, 0, 0);
                LTDMC.dmc_set_homemode(CardNo, 1, HomeDir1, 0, 0, 0 );
                LTDMC.dmc_set_homemode(CardNo, 3, HomeDir3, 0, 0, 0);
                LTDMC.dmc_set_profile(CardNo, 0, 500, 1000, 0.1, 0.1, 500);
                LTDMC.dmc_home_move(CardNo,0);
                
            }
            
            }

        
    }
} 