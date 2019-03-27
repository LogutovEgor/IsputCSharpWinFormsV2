using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace IsputCSharpWinFormsV2
{
    public partial class MainForm
    {
        /// <summary>
        private Point _start;
        private Point _end;
        private bool _drawMode;
        private readonly List<GraphicsPath> _arrows;

        //Для перемещения окна
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        //----------------------

        //Для измнения размера окна
        private const int cGrip = 32;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        //----------------------

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.Red) { DashStyle = DashStyle.Dash })
            {
                e.Graphics.DrawPath(pen, GetArrow(_start, _end, 25, 20));
            }
            foreach (var arrow in _arrows)
            {
                e.Graphics.DrawPath(Pens.Blue, arrow);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _start = e.Location;
            _drawMode = true;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _end = e.Location;
            _drawMode = false;
            _arrows.Add(GetArrow(_start, _end, 25, 20));
            Invalidate();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_drawMode) return;
            _end = e.Location;
            Invalidate();
        }

        /// <summary>
        /// Рисование отрезка со стрелкой посередине
        /// </summary>
        /// <param name="start">Начало отрезка</param>
        /// <param name="end">Конец отрезка</param>
        /// <param name="h">Раствор стрелки</param>
        /// <param name="l">Длина стрелки</param>
        private GraphicsPath GetArrow(Point start, Point end, float h, float l)
        {
            var gp = new GraphicsPath();
            //Вектора
            var v = new PointF(end.X - start.X, end.Y - start.Y);
            //Длина
            float len = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y);
            //Нормированный вектор
            var norm = new PointF(v.X / len, v.Y / len);
            //середина отрезка.
            var mid = new PointF((end.X + start.X) / 2f, (end.Y + start.Y) / 2f);
            //Отступаем на длину стрелки
            var mid1 = new PointF(mid.X - l * norm.X, mid.Y - l * norm.Y);
            //Нормали для раствора стрелки
            var n1 = new PointF(-norm.Y * h / 2 + mid1.X, norm.X * h / 2 + mid1.Y);
            var n2 = new PointF(norm.Y * h / 2 + mid1.X, -norm.X * h / 2 + mid1.Y);
            gp.AddLine(start, end);
            gp.StartFigure();
            gp.AddLine(n1, mid);
            gp.AddLine(mid, n2);
            return gp;
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
            RedrawMatchingLines(true);
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
            if (needSave)
            {
                DialogResult rezult = MessageBox.Show(
                    "Зберегти зміни в " + currentFileName + "?",
                    "ТЕСТ",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (rezult == DialogResult.Yes)
                    Save();
                if (rezult != DialogResult.Cancel)
                    Close();
                if (rezult == DialogResult.Cancel)
                    TopMost = true;
            }
            else
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
            switch ((sender as Button).Name)
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

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            //ControlCollection controlCollection = panel1.Controls;
            foreach (Control c in SlidesPanel.Controls)
            {
                if (c is Button)
                    c.Size = new Size(c.Size.Width, (int)(c.Size.Width * 0.75f));
            }

        }
        private void Header_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                ButtonMaximizeWindow.BackgroundImage = IsputCSharpWinFormsV2.Properties.Resources.Maximize_Window_32px;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                ButtonMaximizeWindow.BackgroundImage = IsputCSharpWinFormsV2.Properties.Resources.Restore_Window_32px;
            }
        }

        //private void ReDraw()
        //{

        //    RedrawMatchingLines();
        //    thread = new System.Threading.Thread(this.ReDraw);
        //    thread.Start();
        //    System.Threading.Thread.Sleep(0);
        //}

    }
}
