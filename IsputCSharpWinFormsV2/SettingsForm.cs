using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IsputCSharpWinFormsV2
{
    public partial class SettingsForm : Form
    {
        //Для перемещения окна
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        //----------------------
        public SettingsForm()
        {
            InitializeComponent();
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
        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
