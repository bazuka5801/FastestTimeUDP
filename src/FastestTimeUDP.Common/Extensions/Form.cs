using System;
using System.Windows.Forms;

namespace FastestTimeUDP.Common.Extensions
{
    public static class FormEx
    {
        public static void RunInUI(this Form form, Action action)
        {
            if (form.InvokeRequired)
            {
                form.Invoke((Action) (() => RunInUI(form, action)));
                return;
            }
            
            action.Invoke();
        }
    }
}