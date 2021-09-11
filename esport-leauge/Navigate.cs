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
      //navigate prev btn
        public static void prev(CurrencyManager currencyManager)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        //navigate next btn
        public static void next(CurrencyManager currencyManager)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
        //navigate btn add
        public static void addBtn(Panel pnlList, Panel pnlAdd, GroupBox grpBox, Button update, Button delete, Button save, Button cancel)
        {   
            //panel for handling list of data from db
            pnlList.Hide();
           
            //panel for handling new add data
            pnlAdd.Visible = true;
            pnlAdd.Top = grpBox.Top;
            pnlAdd.Left = grpBox.Left;

            //groupbox for handling readonly data
            grpBox.Visible = false;
            //buttons
            update.Enabled = false;
            delete.Enabled = false;
        }

        //navigate btn update
        public static void updateBtn(Panel pnl, Button add, Button delete, Button save, Button cancel)
        {
            pnl.Hide();
            add.Enabled = false;
            delete.Enabled = false;
            save.Visible = true;
            cancel.Visible = true;
        }
        //navigate btn save (while saving new data)
        public static void btnSave(Panel pnlList, Panel pnlAdd, GroupBox grpBox, Button update, Button delete, Button save, Button cancel)
        {
            pnlList.Show();
            pnlAdd.Visible = false;
            grpBox.Visible = true;
            //buttons
            update.Enabled = true;
            delete.Enabled = true;
            save.Visible = false;
            cancel.Visible = false;
        }
        //navigate btn save changes(while updating existing data)
        public static void btnSaveChanges(Panel pnlList, Panel pnlAdd, GroupBox grpBox,Button add, Button update, Button delete, Button save, Button cancel)
        {
            pnlList.Show();
            pnlAdd.Visible = false;
            grpBox.Visible = true;
            //buttons
            add.Enabled = true;
            update.Enabled = true;
            delete.Enabled = true;
            save.Visible = false;
            cancel.Visible = false;
        }


        //cancel add

        public static void btnCancelAdd(Panel pnlList, Panel pnlAdd, GroupBox grpBox, Button update, Button delete)
        {
            pnlList.Show();
            pnlAdd.Visible = false;
            grpBox.Visible = true;
            //buttons
            update.Enabled = true;
            delete.Enabled = true;
        }


        //cancel update
        public static void btnCancelUpdate(Panel pnlList, Button add, Button delete, Button saveChanges, Button cancelUpdate)
        {
            pnlList.Show();
           
            //buttons
            add.Enabled = true;
            delete.Enabled = true;
            saveChanges.Visible = false;
            cancelUpdate.Visible = false;
        }
       
    }
}
