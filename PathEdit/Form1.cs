using Microsoft.Win32;
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
using System.Security.Principal;
using System.Security.Permissions;
namespace PathEdit
{ 
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            savedValue = new List<string>(ReadReg().Split(';'));
            foreach (var v in savedValue)
            {
                lst_value.Items.Add(v);
            }
        }

        private List<string> savedValue; 
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                lst_value.Items.Add(browserDialog.SelectedPath); 
                WriteReg(lst_value.GetElementString()); 
            }
        }
         
        private void btn_remove_Click(object sender, EventArgs e)
        { 
            for (int i = lst_value.SelectedIndices.Count - 1; i >= 0; i--)// reverse-iterate
            {
                lst_value.Items.RemoveAt(lst_value.SelectedIndices[i]);
                WriteReg(lst_value.GetElementString());
            } 
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            lst_value.Items.Clear();
             
            foreach(var v in savedValue)
            {
                lst_value.Items.Add(v); 
            }

            WriteReg(lst_value.GetElementString()); 
        }

        private static string ReadReg()
        {
            try
            {
                return Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Control\Session Manager\Environment")
                .GetValue("Path") as string;
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error");
                return "";
            }
        }

        private static void WriteReg(string rawValue)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Control\Session Manager\Environment", true)
              .SetValue("Path", rawValue);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error");
            }
        }
    }

    public static class Extentions
    {
        public static string GetElementString(this ListBox listBox)
        {
            var stringBuilder = new StringBuilder();
            bool first = true;
            foreach(var item in listBox.Items)
            {
                if(first) 
                    first = false; 
                else 
                    stringBuilder.Append(";"); 
                stringBuilder.Append(item.ToString());
            } 
            return stringBuilder.ToString();
        }
    } 
}
 