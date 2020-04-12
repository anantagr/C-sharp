//  Demonstration Code to demonstrate the use Dictionary<,>
//              Premise is to build a tool that can use/report on statistical data that is 
//              of Nominal type with a frequency count
//
//  Author:     Scott D. Thornton - All Rights Reserved
//              Februrary 2019
//
//  Purpose:    Teaching example - SAIT CPRG 200 (Manpower)
//
//  Description:    
//
//                  Expected Behaviour
//                  1) user will add a ice cream flavour into the key field, the number of people that
//                      indicate that that is their favourite and then press the Add button to add to the 
//                      dictionary
//                  2)  the display dictionary button will list the contents in the order that foreach gives 
//                      it back in a multiline text box
//                  3)  the Lookup button will take the contents of the key text field and return the value
//                      associated with that key (assuming it is in the dictionary; does not exist message otherwise
//                  4)  remove key button to remove the key that is given in the key textbox
//                  5)  clear button to empty all entries from a dictionary
//

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DictionaryDemo
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

    }
}
