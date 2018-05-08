using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMedia_UNINTER.Utils
{
    public class UIMethods
    {
        #region Drag borderless window
        //https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void Frm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel senderPane = (Panel)sender;
                ReleaseCapture();
                SendMessage(senderPane.Parent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
