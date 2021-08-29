using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esport_leauge
{
    class ReadWriteClass
    {
        public static void SetReadonlyControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (RadioButton r in controlCollection.OfType<RadioButton>())
            {
                r.Enabled = false; //RadioButtons do not have readonly property
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Enabled = false;//ComboBoxes do not have readonly property
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = true;
            }
            foreach (DateTimePicker c in controlCollection.OfType<DateTimePicker>())
            {
                c.Enabled = false;
            }
            foreach (NumericUpDown c in controlCollection.OfType<NumericUpDown>())
            {
                c.Enabled = false;
            }

        }


        //make it editable
        public static void SetEditControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (RadioButton r in controlCollection.OfType<RadioButton>())
            {
                r.Enabled = true; 
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Enabled = true;
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = false;
            }
            foreach (DateTimePicker c in controlCollection.OfType<DateTimePicker>())
            {
                c.Enabled = true;
            }
            foreach (NumericUpDown c in controlCollection.OfType<NumericUpDown>())
            {
                c.Enabled = true;
            }

        }
    }
   
   
}
