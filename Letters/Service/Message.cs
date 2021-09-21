using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Letters.Service
{
    public static class Message
    {
        public static void Show(string message)
        {
            MessageBox.Show(message, "Уведомление");
        }
        public static void Show(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }
    }
}
