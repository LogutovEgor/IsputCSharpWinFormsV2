using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace IsputCSharpWinFormsV2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Інформація про тести
        /// </summary>
        int indexQuestion;
        Thread thread;
        Question currentQuestion { get { return Manager.Instance.CurrentTest.Questions[indexQuestion]; } }
        int indexAnswer;

        /// </summary>
        private int activeAnswer = -1;
        private Point mouseStart;
        private Point mouseEnd;
        private bool isStartMatching;
        private int numberMatch;
        private char variantMatch;

        TestData test;

        public MainForm()
        {
            InitializeComponent();

            indexAnswer = 0;
            indexQuestion = 0;
            _arrows = new List<GraphicsPath>();
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
            MouseDown += MainForm_MouseDown;
            Paint += MainForm_Paint;
            isStartMatching = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            LeftMenuAndInfPanel.Visible = false;
            MainWorkSpacePanel.Visible = true;

            ////udalit!!!
            //MainTestForm form = new MainTestForm();
            //form.Show();

            //ReadWriteTest.GetInstance().WriteTest();
            CreateSlideButton();

            test = new TestData();
            test.Show();
            ReDraw();
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
            Test test = Manager.Instance.CurrentTest;
            int count = test.Questions.Count;
            for (int i = 0; i < count; i++)
            {
                this.CreateSlideButton();
            }
        }

        private int SlIndex(string num)
        {
            return Convert.ToInt32(num);
        }

        private void toolStripButtonCreateQuestion_Click(object sender, EventArgs e)
        {
            CreateSlideButton();
        }

        private void CreateSlideButton()
        {
            //Створ нове питання
            Manager.Instance.CurrentTest.Questions.Add(new Question());
            //Панель з питаннями та відповідями очищується
            QuestionTextGroupBox.Controls.Clear();
            panel3.Controls.Clear();
            //Кнопка-слайдом
            Bitmap printscreen = new Bitmap(panel2.Width, panel2.Height);
            panel2.DrawToBitmap(printscreen, new Rectangle(0, 0, panel2.Width, panel2.Height));
            int num = SlidesPanel.Controls.Count;
            Button pictureButton = new Button
            {
                Name = num.ToString(),
                BackgroundImage = printscreen,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat
            };
            pictureButton.FlatAppearance.BorderSize = 1;
            pictureButton.FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);
            pictureButton.MouseEnter += (object sender2, EventArgs e2) =>
            {
                if (Convert.ToInt32((sender2 as Button).Name) != indexQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(60, 155, 200);
            };
            pictureButton.MouseLeave += delegate (object sender2, EventArgs e2)
            {
                if (Convert.ToInt32((sender2 as Button).Name) != indexQuestion)
                    (sender2 as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);
            };
            pictureButton.MouseClick += delegate (object sender2, MouseEventArgs e2)
            {
                for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                    (SlidesPanel.Controls[i] as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

                (sender2 as Button).FlatAppearance.BorderColor = Color.White;
                indexQuestion = Convert.ToInt32(((sender2 as Button).Name));

            };
            SlidesPanel.Controls.Add(pictureButton);
            pictureButton.Size = new Size(pictureButton.Size.Width, (int)(pictureButton.Size.Width * 0.75f));
            SlidesPanel.Controls.SetChildIndex(pictureButton, 0);
            pictureButton.GotFocus += (senderPB, ev) =>
            {
                for (int i = 0; i < SlidesPanel.Controls.Count; i++)
                    (SlidesPanel.Controls[i] as Button).FlatAppearance.BorderColor = Color.FromArgb(17, 57, 83);

                (senderPB as Button).FlatAppearance.BorderColor = Color.White;
                indexQuestion = Convert.ToInt32(((senderPB as Button).Name));
            };
            pictureButton.Focus();
        }


        //Зберегти тест
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            ReadWriteTest.GetInstance().WriteTest();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            test.UpdateForm();
        }
    }
}
