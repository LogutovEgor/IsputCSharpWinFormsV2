using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IsputCSharpWinFormsV2
{
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            LeftMenuAndInfPanel.Visible = true;
            MainWorkSpacePanel.Visible = false;
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
        private void TabButton_Click(object sender, EventArgs e)
        {
            switch((sender as Button).Name)
            {
                case "FileTabButton":
                    SwitchMainPanel();
                    break;
                case "MainTabButton":
                    SetTab(TabName.MainTab);
                    break;
                case "InsertTabButton":
                    SetTab(TabName.InsertTab);
                    break;
            }
        }

        private void SwitchMainPanel()
        {
            MainWorkSpacePanel.Visible = !MainWorkSpacePanel.Visible;
            LeftMenuAndInfPanel.Visible = !LeftMenuAndInfPanel.Visible;
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            SwitchMainPanel();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddQuestionForm newAddQuestionForm = new AddQuestionForm();
            newAddQuestionForm.ShowDialog();
            
        }
    }
}
