using System;
using System.Drawing;
using System.Windows.Forms;

namespace Regua
{
    public partial class Regua : Form
    {
        static Point prevpoint = new Point(0, 0);
        static Point offset = new Point(0, 0);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Regua()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Regua_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Regua_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if
                (
                    MessageBox.Show
                    (
                        "Deseja fechar a régua?",
                        "Mensagem",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2 // hit Enter == No !
                    )
                    == DialogResult.Yes
                )
                {
                    Application.Exit();
                }
            }
        }
    }
}
