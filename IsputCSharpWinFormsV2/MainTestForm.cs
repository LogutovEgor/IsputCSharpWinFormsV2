using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IsputCSharpWinFormsV2
{
    public partial class MainTestForm : Form
    {
        //Для перемещения окна
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        //----------------------
        //Для измнения размера окна
        private const int cGrip = 32;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        //----------------------
        public MainTestForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            for (int i = 1; i <= 5; i++)
                Temp(i);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = Location;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeWindowButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void RestoreWindowButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                (sender as Button).BackgroundImage = IsputCSharpWinFormsV2.Properties.Resources.Maximize_Window_32px;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                (sender as Button).BackgroundImage = IsputCSharpWinFormsV2.Properties.Resources.Restore_Window_32px;
            }
        }

        private void Temp(int i)
        {
            //Manager.GetInstance().AddQuestion();
            //int num = Manager.GetInstance().Questions.Count;
            //num -= 1;
            Button button = new Button
            {
                //Name = num.ToString(),
                //BackgroundImage = printPanel,
                Text = i.ToString(),
                
                BackgroundImageLayout = ImageLayout.Stretch,
                Padding = new Padding(0),
                Margin = new Padding(0),
                Dock = DockStyle.Left,
                FlatStyle = FlatStyle.Flat
            };
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

            /*pictureBox.MouseEnter += delegate (object sender2, EventArgs e2)
            {
                (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(60, 155, 200);
            };*/
            button.MouseEnter += (object sender2, EventArgs e2) =>
            {
                //if (Convert.ToInt32((sender2 as Button).Name) != Manager.GetInstance().ActiveQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(60, 155, 200);
            };
            button.MouseLeave += delegate (object sender2, EventArgs e2)
            {
                //if (Convert.ToInt32((sender2 as Button).Name) != Manager.GetInstance().ActiveQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);
            };
            button.MouseClick += delegate (object sender2, MouseEventArgs e2)
            {
                //for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                   // (SlidesPanel.Controls[i] as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

                (sender2 as Button).FlatAppearance.BorderColor = Color.White;
                //Manager.GetInstance().ActiveQuestion = Convert.ToInt32(((sender2 as Button).Name));
            };



            List<Control> slides = new List<Control>();
            foreach (Control nextButton in SlidesPanelInTest.Controls)
            {
                slides.Add(nextButton);
            }


            SlidesPanelInTest.Controls.Clear();
            SlidesPanelInTest.Controls.Add(button);


            button.Size = new Size(button.Size.Height, button.Size.Height);
            button.Font = new Font("Microsoft Sans Serif", button.Size.Height / 2);
            foreach (Control item in slides)
            {
                SlidesPanelInTest.Controls.Add(item);
            }
        }
        private void SlidesPanelInTest_SizeChanged(object sender, EventArgs e)
        {
            //ControlCollection controlCollection = panel1.Controls;
            foreach (Control c in SlidesPanelInTest.Controls)
            {
                //c.Size = new Size(c.Size.Width, (int)(c.Size.Width * 0.75f));
                c.Size = new Size(c.Size.Height, c.Size.Height);
                c.Font = new Font("Microsoft Sans Serif", c.Size.Height/2);
            }

        }
    }
}
