using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace IsputCSharpWinFormsV2
{
    public partial class MainForm : Form
    {
        public string currentFileName = "";
        public bool needSave;
        public bool saveAs;

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
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "IsputCSharpWinFormsV2.exe";
                startInfo.Arguments = openFileDialog.FileName;
                Process.Start(startInfo);
            }
        }

        public void UIForTets()
        {
            for (int i = 0; i < Manager.Instance.CurrentTest.Questions.Count; i++)
            {
                CreateUIForSlide(i + 1);
                SlidesPanel.Controls[i.ToString()].BackgroundImage = Manager.Instance.CurrentTest.Questions[i].ImageSlide;
            }
            SlideGetFocus(this.SlidesPanel.Controls["0"]);
        }

        //Зберегти тест
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
            needSave = false;
            saveAs = false;
        }

        public void Save()
        {
            if (!saveAs)
            {
                for (int i = 0; i < Manager.Instance.CurrentTest.Questions.Count; i++)
                {
                    Manager.Instance.CurrentTest.Questions[i].ImageSlide = SlidesPanel.Controls[i.ToString()].BackgroundImage;
                }
                ReadWriteTest.GetInstance().WriteTest(currentFileName);
            }
            else
                SaveAs();
        }

        private void SaveFileAsButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            for (int i = 0; i < Manager.Instance.CurrentTest.Questions.Count; i++)
            {
                Manager.Instance.CurrentTest.Questions[i].ImageSlide = SlidesPanel.Controls[i.ToString()].BackgroundImage;
            }
            // Displays an OpenFileDialog so the user can select a Cursor.  
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Cursor Files|*.tst";
            openFileDialog.Title = "Select a Cursor File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string f = openFileDialog.FileName;
                ReadWriteTest.GetInstance().WriteTest(f);
                currentFileName = f;
                needSave = false;
                saveAs = false;
            }
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "IsputCSharpWinFormsV2.exe";
            startInfo.Arguments = "";
            Process.Start(startInfo);
        }

    }
}