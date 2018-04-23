using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace ThreadedSkinning {
    public partial class Form2 : XtraForm {
        public Form2() {
            InitializeComponent();
        }

        public void MainLookAndFeel_StyleChanged(object sender, EventArgs e) {
            if(this.InvokeRequired) {
                this.BeginInvoke(new EventHandler(MainLookAndFeel_StyleChanged), sender, e);
                return;
            }

            UserLookAndFeel.Default.Assign((UserLookAndFeel)sender);
        }

    }
}