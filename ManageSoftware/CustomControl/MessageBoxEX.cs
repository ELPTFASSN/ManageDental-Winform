using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageSoftware.CustomControl
{
    class MessageBoxEX
    {
        public MessageBoxEX() { }
        public static DialogResult DialogMessageBox(String title, String message, String details)
        {
            var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
            var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
            var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

            dialog.Text = title;
            dialogType.GetProperty("Details").SetValue(dialog, details, null);
            dialogType.GetProperty("Message").SetValue(dialog, message, null);

            return dialog.ShowDialog();
        }
    }
}
