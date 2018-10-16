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
            ////udalit!!!
            MainTestForm form = new MainTestForm();
            form.Show();

            ReadWriteTest.GetInstance().WriteTest();
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
            
            
        }

        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            ///
            GroupBox groupBox = new GroupBox
            {
                Size = new Size(450, 44),
                Dock = DockStyle.Top,
                Padding = new Padding(10,2,2,2),
                Text = ""
            };
            ///
            CheckBox checkBox = new CheckBox
            {
                Size = new Size(25, 25),
                Dock = DockStyle.Right,
                Padding = new Padding(6,0,0,5),
                Text = "",
            };
            ///
            TextBox textBox = new TextBox
            {
                Size = new Size(10, 20),
                Dock = DockStyle.Fill,
                Margin = new Padding(0)        
            };
            groupBox.Controls.AddRange(new Control[] {checkBox, textBox});
            panel3.Controls.Add(groupBox);

            //Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Bitmap printPanel = new Bitmap(panel2.Bounds.Width, panel2.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printPanel as Image);
            //graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            graphics.CopyFromScreen(panel2.PointToScreen(Point.Empty), Point.Empty, printPanel.Size);
            //printscreen.Save(@"C:\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            /*PictureBox pictureBox = new PictureBox
            {
                Image = printPanel,
                Dock = DockStyle.Top,
                Size = new Size(170, 110),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Padding = new Padding(5)                

            };*/
            Manager.GetInstance().AddQuestion();
            int num = Manager.GetInstance().Questions.Count;
            num -= 1;
            Button pictureButton = new Button
            {
                Name = num.ToString(),
                BackgroundImage = printPanel,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat
            };
            //pictureBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 93, 149);
            //pictureBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 155, 200);
            pictureButton.FlatAppearance.BorderSize = 1;
            pictureButton.FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

            /*pictureBox.MouseEnter += delegate (object sender2, EventArgs e2)
            {
                (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(60, 155, 200);
            };*/
            pictureButton.MouseEnter += (object sender2, EventArgs e2) =>
            {
                if (Convert.ToInt32((sender2 as Button).Name) != Manager.GetInstance().ActiveQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(60, 155, 200);
            };
            pictureButton.MouseLeave += delegate (object sender2, EventArgs e2)
            {
                if (Convert.ToInt32((sender2 as Button).Name) != Manager.GetInstance().ActiveQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);
            };
            pictureButton.MouseClick += delegate (object sender2, MouseEventArgs e2)
            {
                for(int i=0;i<SlidesPanel.Controls.Count;i++)
                        (SlidesPanel.Controls[i] as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

                (sender2 as Button).FlatAppearance.BorderColor = Color.White;
                Manager.GetInstance().ActiveQuestion = Convert.ToInt32(((sender2 as Button).Name));
            };



            List<Control> slides = new List<Control>();
            foreach (Control nextButton in SlidesPanel.Controls)
            {
                slides.Add(nextButton);
            }


            SlidesPanel.Controls.Clear();
            SlidesPanel.Controls.Add(pictureButton);


            pictureButton.Size = new Size(pictureButton.Size.Width, (int)(pictureButton.Size.Width * 0.75f));
            foreach (Control item in slides)
            {
                SlidesPanel.Controls.Add(item);
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            //ControlCollection controlCollection = panel1.Controls;
            foreach(Control c in SlidesPanel.Controls)
            {
                c.Size = new Size(c.Size.Width, (int)(c.Size.Width * 0.75f));
            }
            
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Cursor Files|*.tst";
            openFileDialog.Title = "Select a Cursor File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string f = openFileDialog.FileName;
                ReadWriteTest.GetInstance().ReadTest(f);
            }
        }
    }
}
