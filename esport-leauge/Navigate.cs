using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esport_leauge
{
    class Navigate
    {
      
        public static void prev(CurrencyManager currencyManager)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        public static void next(CurrencyManager currencyManager)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
        public static void addBtn(Panel pnl, Button update, Button delete, Button save, Button cancel)
        {
            pnl.Hide();
            update.Enabled = false;
            delete.Enabled = false;
            save.Visible = true;
            cancel.Visible = true;
        }
        public static void updateBtn(Panel pnl, Button add, Button delete, Button save, Button cancel)
        {
            pnl.Hide();
            add.Enabled = false;
            delete.Enabled = false;
            save.Visible = true;
            cancel.Visible = true;
        }
        public static void saveBtn(Panel pnl, Button add, Button update, Button delete, Button save, Button cancel)
        {
            pnl.Show();
            add.Enabled = true;
            update.Enabled = true;
            delete.Enabled = true;
            save.Visible = false;
            cancel.Visible = false;


        }
        public static void cancelBtn(Panel pnl, Button add, Button update, Button delete, Button save, Button cancel)
        {
            pnl.Show();
            add.Enabled = true;
            update.Enabled = true;
            delete.Enabled = true;
            save.Visible = false;
            cancel.Visible = false;

        }
    }
}
