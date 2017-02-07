﻿using MWinNet.Dock;

namespace MWinNet.Frame
{
    public class ToolWindow : DockContent
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ToolWindow
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ToolWindow";
            this.ShowHint = MWinNet.Dock.DockState.Document;
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }
    }
}