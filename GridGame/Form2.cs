using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace GridGame
{
    public partial class textBoxForm : Form
    {
        // To disable the X button 
        //https://www.c-sharpcorner.com/uploadfile/itsraj007/how-do-i-disable-the-close-x-button-in-a-windows-form-using-C-Sharp/
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        public textBoxForm()
        {
            InitializeComponent();
            
            //more stuff to disable the X button
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(string.IsNullOrEmpty(inpBox.Text) || string.IsNullOrWhiteSpace(inpBox.Text))
            {
                MessageBox.Show("Please enter your name into the field.");
                return;
            }
            GridGame.userName = inpBox.Text;
            GridGame.WriteScoreToFile();
           this.Hide();
        }
    }
}
