using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Ekrpat.Styles
{
    public class CardWindow : Window
    {
        public CardWindow()
        {
            this.Style = (Style)FindResource("CardWindowStyle");
        }

        public override void OnApplyTemplate()
        {
            Button btnClose = GetTemplateChild("btnClose") as Button;
            if(btnClose != null)
                btnClose.Click += CloseWindow;
            base.OnApplyTemplate();
        }

        void FadeClose()
        {
            var anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(.2));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromSeconds(.1);
            time.Tick += (send, eA) =>
            {
                time.Stop();
                this.FadeClose();
            };
            time.Start();
        }
    }
}
