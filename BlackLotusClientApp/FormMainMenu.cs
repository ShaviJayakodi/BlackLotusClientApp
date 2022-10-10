using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackLotusClientApp
{
    
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWhd, int wMsg, int wParam, int lParam);

        //method
        private Color SelectTheameColor()
        {
            int index =random.Next(TheamColor.ColorList.Count);
            while (tempIndex== index)
            {
               index= random.Next(TheamColor.ColorList.Count);
            }
            tempIndex = index;
            string color =TheamColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)

        {
            if(btnSender!=null)
            {
                if(currentButton!=(Button)btnSender)
                {
                    DisabledButton();
                    Color color = SelectTheameColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor= color;
                    panelLogo.BackColor = TheamColor.ChangeColorBrightness(color,-0.3);
                    TheamColor.PrimaryColor = color;
                    TheamColor.SecondaryColor = TheamColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }

        }
        private void DisabledButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        } 


        private void btnFlower_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFlower(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrder(), sender);

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

          
            OpenChildForm(new Forms.FormCategory(), sender);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStock(), sender);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
             OpenChildForm(new Forms.FormUser(),sender);

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm!=null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisabledButton();
            lblTitle.Text = "Black Lotus Management System";
            panelTitleBar.BackColor = Color.FromArgb(52, 52, 79);
            panelLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState=FormWindowState.Maximized;
            else
                this.WindowState=FormWindowState.Normal;
        }
    }
}
