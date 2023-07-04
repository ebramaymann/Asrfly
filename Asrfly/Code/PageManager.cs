using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Asrfly.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            //Load old page 
            var OldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (OldPage != null)
            {
                main.panelContainer.Controls.Remove(OldPage); //Remove old page  
                OldPage.Dispose();
            }
            //Load new page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);


        }
    }
}
