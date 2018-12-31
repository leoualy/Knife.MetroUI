using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Knife.MetroUI
{
    public class MetroMessageBox:BaseMetroDialog
    {
        static MetroMessageBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroMessageBox), new FrameworkPropertyMetadata(typeof(MetroMessageBox)));
        }
        private static MetroMessageBox mInstance = null;

        public static void ShowDialog(MetroWindow mainWindow,string content)
        {
            if (mInstance == null)
            {
                mInstance = new MetroMessageBox();
            }
            mInstance.IsModality = true;
            mInstance.MsgContent = content;
            mainWindow.Dialog = mInstance;
        }
        public static void Show(MetroWindow mainWindow,string content)
        {
            if (mInstance == null)
            {
                mInstance = new MetroMessageBox();
            }
            mInstance.IsModality = false;
            mInstance.MsgContent = content;
            mainWindow.Dialog = mInstance;
        }



        public double DialogWidth
        {
            get { return (double)GetValue(DialogWidthProperty); }
            set { SetValue(DialogWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DialogWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DialogWidthProperty =
            DependencyProperty.Register("DialogWidth", typeof(double), typeof(MetroMessageBox), new PropertyMetadata(500.0));



        public double DialogHeight
        {
            get { return (double)GetValue(DialogHeightProperty); }
            set { SetValue(DialogHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DialogHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DialogHeightProperty =
            DependencyProperty.Register("DialogHeight", typeof(double), typeof(MetroMessageBox), new PropertyMetadata(200.0));





        public string MsgContent
        {
            get { return (string)GetValue(MsgContentProperty); }
            set { SetValue(MsgContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MsgContentProperty =
            DependencyProperty.Register("MsgContent", typeof(string), typeof(MetroMessageBox), new PropertyMetadata(""));


    }
}
