﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraDeMedias_UNINTER.Base.Program
{
    public class GlobalEvents
    {
        public Form frm { get; set; }

        public GlobalEvents(Form parent)
        {
            frm = parent;
        }
        #region Drag borderless window
        //https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable

        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();

        //public void Frm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        Panel senderPane = (Panel)sender;
        //        ReleaseCapture();
        //        SendMessage(senderPane.Parent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        


        public Point mouseLocation;
        public void frm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        public void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                frm.Location = mousePos;
            }
        }
        #endregion

        public void btnMin_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Panel titleBar = (Panel)btn.Parent;
            Form frm = (Form)titleBar.Parent;
            frm.WindowState = FormWindowState.Minimized;
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Panel titleBar = (Panel)btn.Parent;
            Form frm = (Form)titleBar.Parent;
            frm.Close();
        }

    }
}
