using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerPartient.Core
{
    public delegate void DisplayPanelHander(Object _child);
    interface IFormPanelChild
    {
        event DisplayPanelHander DisplayPanelEvent;
        void Hide();
        void Show();
        void SettingForm();
    }
}
