using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_redactor
{
    public partial class ToolStrip : Form
    {
        Button btn,btn1, btn2, btn3, btn4, btn5 ,btn6 ,btn7, btn8,btn9, btn10 ;
        public ToolStrip()
        {
            btn = new Button();
            btn.Height = 40;
            btn.Width = 100;
            btn.Location = new Point(150, 50);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn1.Visible = true;
            btn1 = new Button();
            btn1.Height = 40;
            btn1.Width = 100;
            btn1.Location = new Point(150, btn.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn2.Visible = true;
            btn2 = new Button();
            btn2.Height = 40;
            btn2.Width = 100;
            btn2.Location = new Point(150, btn1.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn3.Visible = true;
            btn3 = new Button();
            btn3.Height = 40;
            btn3.Width = 100;
            btn3.Location = new Point(150, btn2.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn3.Visible = true;
            btn4 = new Button();
            btn4.Height = 40;
            btn4.Width = 100;
            btn4.Location = new Point(150, btn3.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn4.Visible = true;
            btn5 = new Button();
            btn5.Height = 40;
            btn5.Width = 100;
            btn5.Location = new Point(150, btn4.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn5.Visible = true;
            btn6 = new Button();
            btn6.Height = 40;
            btn6.Width = 100;
            btn6.Location = new Point(150, btn5.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn6.Visible = true;
            btn7 = new Button();
            btn7.Height = 40;
            btn7.Width = 100;
            btn7.Location = new Point(150, btn6.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn7.Visible = true;
            btn8 = new Button();
            btn8.Height = 40;
            btn8.Width = 100;
            btn8.Location = new Point(150, btn7.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn8.Visible = true;
            btn9 = new Button();
            btn9.Height = 40;
            btn9.Width = 100;
            btn9.Location = new Point(150, btn8.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn9.Visible = true;
            btn10 = new Button();
            btn10.Height = 40;
            btn10.Width = 100;
            btn10.Location = new Point(150, btn9.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn10.Visible = true;

        }
    }
}
