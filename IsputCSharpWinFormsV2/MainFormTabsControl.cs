using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IsputCSharpWinFormsV2
{
    public enum TabName { FileTab, MainTab }
    public partial class MainForm
    {
        private ToolStrip activeToolStrip;
        private Button activeTabButton;
        void SetTab(TabName tabName)
        {
            if ((activeTabButton != null) && (tabName.ToString() + "Button" == activeTabButton.Name.ToString()))
            {
                activeToolStrip.Visible = false;
                activeTabButton.BackColor = Color.FromArgb(17, 57, 83);
                activeTabButton.ForeColor = Color.White;
                activeTabButton = null;
                activeToolStrip = null;
                return;
            }
            if (activeToolStrip != null)
                activeToolStrip.Visible = false;
            if (activeTabButton != null)
            {
                activeTabButton.BackColor = Color.FromArgb(17, 57, 83);
                activeTabButton.ForeColor = Color.White;
            }
            switch (tabName)
            {
                case TabName.FileTab:

                    break;
                case TabName.MainTab:
                    activeTabButton = MainTabButton;
                    activeToolStrip = ToolStripMain;
                    break;
            }
            activeTabButton.BackColor = Color.FromArgb(241, 241, 241);
            activeTabButton.ForeColor = Color.FromArgb(17, 57, 83);
            activeToolStrip.Visible = true;
        }
    }
}