using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_game
{
    public partial class Form1 : Form
    {
        Game s;
        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox10.Visible = false;
            button6.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e) // 遊戲中堆疊 1
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e) // 遊戲中堆疊 4
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // 開始遊戲
        {

            string s1 = textBox6.Text , s2 = textBox7.Text , s3 = textBox8.Text , s4 = textBox9.Text;

            bool ok = true;
            int one = 0, two = 0, three = 0;

            for (int i=0;i<s1.Length;i++)
            {
                if (i % 2 == 1 && s1[i] != ' ') ok = false;
                else if (i % 2 == 1) continue;

                if (s1[i] >= '4') ok = false;


                if (i % 2 == 0 && s1[i] == '1') one++;
                else if (i % 2 == 0 && s1[i] == '2') two++;
                else if (i % 2 == 0) three++;
            }
            for(int i=0;i<s2.Length;i++)
            {
                if (i % 2 == 1 && s2[i] != ' ') ok = false;
                else if (i % 2 == 1) continue;

                if (s2[i] >= '4') ok = false;

                if (i % 2 == 0 && s2[i] == '1') one++;
                else if (i % 2 == 0 && s2[i] == '2') two++;
                else if (i % 2 == 0) three++;
            }
            for(int i=0;i<s3.Length;i++)
            {
                if (i % 2 == 1 && s3[i] != ' ') ok = false;
                else if (i % 2 == 1) continue;

                if (s3[i] >= '4') ok = false;

                if (i % 2 == 0 && s3[i] == '1') one++;
                else if (i % 2 == 0 && s3[i] == '2') two++;
                else if (i % 2 == 0) three++;
            }
            for(int i=0;i<s4.Length;i++)
            {
                if (i % 2 == 1 && s4[i] != ' ') ok = false;
                else if (i % 2 == 1) continue;

                if (s4[i] >= '4') ok = false;

                if (i % 2 == 0 && s4[i] == '1') one++;
                else if (i % 2 == 0 && s4[i] == '2') two++;
                else if (i % 2 == 0) three++;
            }

            if (one != 3 || two != 3 || three != 3) ok = false;

            if (ok == false) textBox5.Text = "測資錯誤";
            else
            {
                textBox5.Text = "請輸入測資";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
                richTextBox3.Visible = true;
                richTextBox4.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                textBox10.Visible = true;
                button6.Visible = true;

                textBox5.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button5.Visible = false;

                s.init();

                string[] sp1 = s1.Split(' ');
                string[] sp2 = s2.Split(' ');
                string[] sp3 = s3.Split(' ');
                string[] sp4 = s4.Split(' ');

                string u2 = "";

                for(int i=0;i<9;i++) u2 += "\n";
                richTextBox1.Text = u2;
                richTextBox2.Text = u2;
                richTextBox3.Text = u2;
                richTextBox4.Text = u2;

                for(int i=0;i<sp1.Length;i++)
                {
                    s.add(1,sp1[i]);
                }
                for(int i=0;i<sp2.Length;i++)
                {
                    s.add(2,sp2[i]);
                }
                for(int i=0;i<sp3.Length;i++)
                {
                    s.add(3,sp3[i]);
                }
                for(int i=0;i<sp4.Length;i++)
                {
                    s.add(4,sp4[i]);
                }

                for(int i=1;i<=4;i++)
                {
                    string u = "";

                    for(int k=9;k>=1;k--)
                    {
                        if( s.size(i) >= k ) u += s.output(i,k-1);
                        else u += "\n";
                    }

                    if( i == 1 ) richTextBox1.Text = u;
                    if( i == 2 ) richTextBox2.Text = u;
                    if( i == 3 ) richTextBox3.Text = u;
                    if( i == 4 ) richTextBox4.Text = u;
                }

                if( s.win() == true )
                {
                    button1.Text = "贏";
                    button2.Text = "贏";
                    button3.Text = "贏";
                    button4.Text = "贏";
                    textBox10.Text = "你贏了";

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e) // 堆疊 1
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e) // 堆疊 2
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e) // 堆疊 3
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e) // 堆疊 4
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) // 請輸入測資
        {

        }

        private void label5_Click(object sender, EventArgs e) // 堆疊 1 文字
        {

        }

        private void label6_Click(object sender, EventArgs e)// 堆疊 2 文字
        {

        }

        private void label7_Click(object sender, EventArgs e)// 堆疊 3 文字
        {

        }

        private void label8_Click(object sender, EventArgs e)// 堆疊 4 文字
        {

        }

        private void label4_Click(object sender, EventArgs e) // 遊戲中堆疊 2
        {

        }

        private void label3_Click(object sender, EventArgs e) // 遊戲中堆疊 3
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // 選取 1
        {
            if( button1.Text == "選取" )
            {
                textBox10.Text = "你選取了堆疊 1";
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button1.Text = "放置";

                for(int i=1;i<=4;i++)
                {
                    if( s.cantake(i) == false )
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }

                button1.Enabled = true;
            }
            else
            {
                int idx = 0;
                if (textBox10.Text == "你選取了堆疊 1") idx = 1;
                if (textBox10.Text == "你選取了堆疊 2") idx = 2;
                if (textBox10.Text == "你選取了堆疊 3") idx = 3;
                if (textBox10.Text == "你選取了堆疊 4") idx = 4;

                s.move(idx, 1);

                for(int i=1;i<=4;i++)
                {
                    string u = "";

                    for(int k=9;k>=1;k--)
                    {
                        if( s.size(i) >= k ) u += s.output(i,k-1);
                        else u += "\n";
                    }

                    if( i == 1 ) richTextBox1.Text = u;
                    if( i == 2 ) richTextBox2.Text = u;
                    if( i == 3 ) richTextBox3.Text = u;
                    if( i == 4 ) richTextBox4.Text = u;
                }

                button1.Text = "選取";
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";

                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake2(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }
            }

            if (s.win() == true)
            {
                button1.Text = "贏";
                button2.Text = "贏";
                button3.Text = "贏";
                button4.Text = "贏";
                textBox10.Text = "你贏了";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) // 2
        {
            if( button2.Text == "選取" )
            {
                textBox10.Text = "你選取了堆疊 2";
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button1.Text = "放置";


                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }

                button2.Enabled = true;
            }
            else
            {
                int idx = 0;
                if (textBox10.Text == "你選取了堆疊 1") idx = 1;
                if (textBox10.Text == "你選取了堆疊 2") idx = 2;
                if (textBox10.Text == "你選取了堆疊 3") idx = 3;
                if (textBox10.Text == "你選取了堆疊 4") idx = 4;

                s.move(idx, 2);

                for(int i=1;i<=4;i++)
                {
                    string u = "";

                    for(int k=9;k>=1;k--)
                    {
                        if( s.size(i) >= k ) u += s.output(i,k-1);
                        else u += "\n";
                    }

                    if( i == 1 ) richTextBox1.Text = u;
                    if( i == 2 ) richTextBox2.Text = u;
                    if( i == 3 ) richTextBox3.Text = u;
                    if( i == 4 ) richTextBox4.Text = u;
                }

                button1.Text = "選取";
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";

                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake2(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }
            }

            if (s.win() == true)
            {
                button1.Text = "贏";
                button2.Text = "贏";
                button3.Text = "贏";
                button4.Text = "贏";
                textBox10.Text = "你贏了";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) // 3
        {
            if( button3.Text == "選取" )
            {
                textBox10.Text = "你選取了堆疊 3";
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button1.Text = "放置";

                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }

                button3.Enabled = true;
            }
            else
            {
                int idx = 0;
                if (textBox10.Text == "你選取了堆疊 1") idx = 1;
                if (textBox10.Text == "你選取了堆疊 2") idx = 2;
                if (textBox10.Text == "你選取了堆疊 3") idx = 3;
                if (textBox10.Text == "你選取了堆疊 4") idx = 4;

                s.move(idx, 3);
                
                for(int i=1;i<=4;i++)
                {
                    string u = "";

                    for(int k=9;k>=1;k--)
                    {
                        if( s.size(i) >= k ) u += s.output(i,k-1);
                        else u += "\n";
                    }

                    if( i == 1 ) richTextBox1.Text = u;
                    if( i == 2 ) richTextBox2.Text = u;
                    if( i == 3 ) richTextBox3.Text = u;
                    if( i == 4 ) richTextBox4.Text = u;
                }

                button1.Text = "選取";
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";

                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake2(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }
            }

            if (s.win() == true)
            {
                button1.Text = "贏";
                button2.Text = "贏";
                button3.Text = "贏";
                button4.Text = "贏";
                textBox10.Text = "你贏了";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e) // 4
        {
            if( button4.Text == "選取" )
            {
                textBox10.Text = "你選取了堆疊 4";
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button1.Text = "放置";

                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }

                button4.Enabled = true;
            }
            else
            {
                int idx = 0;
                if (textBox10.Text == "你選取了堆疊 1") idx = 1;
                if (textBox10.Text == "你選取了堆疊 2") idx = 2;
                if (textBox10.Text == "你選取了堆疊 3") idx = 3;
                if (textBox10.Text == "你選取了堆疊 4") idx = 4;

                s.move(idx, 4);

                for(int i=1;i<=4;i++)
                {
                    string u = "";

                    for(int k=9;k>=1;k--)
                    {
                        if( s.size(i) >= k ) u += s.output(i,k-1);
                        else u += "\n";
                    }

                    if( i == 1 ) richTextBox1.Text = u;
                    if( i == 2 ) richTextBox2.Text = u;
                    if( i == 3 ) richTextBox3.Text = u;
                    if( i == 4 ) richTextBox4.Text = u;
                }

                button1.Text = "選取";
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";

                for (int i = 1; i <= 4; i++)
                {
                    if (s.cantake2(i) == false)
                    {
                        if (i == 1) button1.Enabled = false;
                        if (i == 2) button2.Enabled = false;
                        if (i == 3) button3.Enabled = false;
                        if (i == 4) button4.Enabled = false;
                    }
                }
            }

            if (s.win() == true)
            {
                button1.Text = "贏";
                button2.Text = "贏";
                button3.Text = "贏";
                button4.Text = "贏";
                textBox10.Text = "你贏了";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e) // ...
        {

        }

        private void button6_Click(object sender, EventArgs e) // 回主畫面
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox10.Visible = false;

            textBox5.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            button5.Visible = true;
            button6.Visible = false;

            button1.Text = "選取";
            button2.Text = "選取";
            button3.Text = "選取";
            button4.Text = "選取";
            textBox10.Text = "...";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
    }
}
