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

            // init savedUsrVar and savedSysVar
            savedUsrVar = new List<string>(ReadReg(RegSource.User).Split(';'));
            savedSysVar = new List<string>(ReadReg(RegSource.System).Split(';'));

            savedUsrVar.ForEach(v => lst_usrVar.Items.Add(v));
            savedSysVar.ForEach(v => lst_sysVar.Items.Add(v)); 

           
        }

        // 

        /// <summary>
        /// the old user PATH var
        /// </summary>
        private List<string> savedUsrVar;

        /// <summary>
        /// the old system PATH var 
        /// </summary>
        private List<string> savedSysVar;

    
        /// <summary>
        /// are we setting user PATH or system PATH
        /// </summary>
        private RegSource activeSource;
 
        /// <summary>
        /// the ListBox we operate (current PATH value is saved directly in ListBox.Items), depending on activeSource
        /// </summary>
        private ListBox activeListBox { get => (activeSource == RegSource.System) ? lst_sysVar : lst_usrVar; }
         
        /// <summary>
        /// equals savedUsrVar or savedSysVar, depending on activeSource
        /// </summary>
        private List<string> activeSavedVar { get => (activeSource == RegSource.System) ? savedSysVar : savedUsrVar; }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog(); 
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                activeListBox.Items.Add(browserDialog.SelectedPath); 
                WriteReg(activeSource, activeListBox.GetElementString()); 
            }
        }
         
        private void btnRemove_Click(object sender, EventArgs e)
        { 
            for (int i = activeListBox.SelectedIndices.Count - 1; i >= 0; i--)// reverse-iterate to delete
            {
                activeListBox.Items.RemoveAt(activeListBox.SelectedIndices[i]);
            }
            WriteReg(activeSource, activeListBox.GetElementString());
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            activeListBox.Items.Clear(); 
            foreach(var v in activeSavedVar)
            {
                activeListBox.Items.Add(v); 
            }
            WriteReg(activeSource, activeListBox.GetElementString()); 
        }

        private static string ReadReg(RegSource src)
        {
            try
            {
                if(src == RegSource.System)
                {
                    return Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Control\Session Manager\Environment").GetValue("Path") as string;
                } 
                return Registry.CurrentUser.OpenSubKey(@"Environment").GetValue("Path") as string;  
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error");
                return "";
            }
        }

        private static void WriteReg(RegSource src, string rawValue)
        {
            try
            {
                if (src == RegSource.System)
                {
                    Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Control\Session Manager\Environment", true).SetValue("Path", rawValue);
                }
                else
                {
                    Registry.CurrentUser.OpenSubKey(@"Environment", true).SetValue("Path", rawValue); 
                } 
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error");
            }
        }

        enum RegSource
        {
            User,System
        }

        private void tab_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tabpg_sys)
            {
                activeSource = RegSource.System;
            }
            else
            {
                activeSource = RegSource.User; 
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

//%USERPROFILE%\AppData\Local\Microsoft\WindowsApps;;C:\Software\Microsoft VS Code\bin;%USERPROFILE%\.dotnet\tools
//C:\Program Files (x86)\Intel\Intel(R) Management Engine Components\iCLS\;C:\Program Files\Intel\Intel(R) Management Engine Components\iCLS\;C:\Windows\system32;C:\Windows;C:\Windows\System32\Wbem;C:\Windows\System32\WindowsPowerShell\v1.0\;C:\Windows\System32\OpenSSH\;C:\Program Files (x86)\Intel\Intel(R) Management Engine Components\DAL;C:\Program Files\Intel\Intel(R) Management Engine Components\DAL;C:\Program Files (x86)\Intel\Intel(R) Management Engine Components\IPT;C:\Program Files\Intel\Intel(R) Management Engine Components\IPT;C:\Program Files (x86)\NVIDIA Corporation\PhysX\Common;C:\WINDOWS\system32;C:\WINDOWS;C:\WINDOWS\System32\Wbem;C:\WINDOWS\System32\WindowsPowerShell\v1.0\;C:\WINDOWS\System32\OpenSSH\;C:\Software\Git\cmd;C:\Program Files\dotnet\