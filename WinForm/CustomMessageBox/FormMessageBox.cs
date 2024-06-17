using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace WinForm.CustomMessageBox
{
    public partial class FormMessageBox : KryptonForm
    {
        private int borderSize = 2;
        public FormMessageBox()
        {
            InitializeComponent();
        }
        public FormMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FormMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size
            this.labelMessage.MaximumSize = new Size(550, 0);
            this.Button1.DialogResult = DialogResult.Cancel;
            this.Button1.DialogResult = DialogResult.OK;
            this.Button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }
        private void SetFormSize()
        {
            int widht = (this.labelMessage.Width+6) + this.pictureBoxIcon.Width + this.panelTitleBar.Padding.Left;
            int height = this.panelTitleBar.Height + this.labelMessage.Height + this.panelButtons.Height + this.panelTitleBar.Padding.Top;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.panelButtons.Width - Button1.Width) / 2;
            int yCenter = (this.panelButtons.Height - Button1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    Button1.Visible = true;
                    Button1.Location = new Point(xCenter, yCenter);
                    Button1.Text = "Ok";
                    Button1.DialogResult = DialogResult.OK;//Set DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    Button1.Visible = true;
                    Button1.Location = new Point(xCenter - (Button1.Width / 2) - 5, yCenter);
                    Button1.Text = "Ok";
                    Button1.DialogResult = DialogResult.OK;//Set DialogResult

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancel";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    Button1.Visible = true;
                    Button1.Location = new Point(xCenter - (Button1.Width / 2) - 5, yCenter);
                    Button1.Text = "Retry";
                    Button1.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancel";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    Button1.Visible = true;
                    Button1.Location = new Point(xCenter - (Button1.Width / 2) - 5, yCenter);
                    Button1.Text = "Yes";
                    Button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    Button1.Visible = true;
                    Button1.Location = new Point(xCenter - Button1.Width - 5, yCenter);
                    Button1.Text = "Yes";
                    Button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Cancel";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Color.DimGray;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    Button1.Visible = true;
                    Button1.Location = new Point(xCenter - Button1.Width - 5, yCenter);
                    Button1.Text = "Abort";
                    Button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    Button1.BackColor = Color.Goldenrod;

                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Retry";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Ignore";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    Button1.Select();
                    Button1.ForeColor = Color.White;
                    Button1.Font = new Font(Button1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    button2.Select();
                    button2.ForeColor = Color.White;
                    button2.Font = new Font(button2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    button3.Select();
                    button3.ForeColor = Color.White;
                    button3.Font = new Font(button3.Font, FontStyle.Underline);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.done;
                    break;
                case MessageBoxIcon.Question://Question
                    this.pictureBoxIcon.Image = Properties.Resources.question;
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.pictureBoxIcon.Image = Properties.Resources.exclamation;
                    break;
                case MessageBoxIcon.None: //None
                    this.pictureBoxIcon.Image = Properties.Resources.chat;
                    break;
            }
        }

        //-> Events Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}
