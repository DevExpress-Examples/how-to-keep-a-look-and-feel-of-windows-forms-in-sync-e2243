using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace ThreadedSkinning {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

            comboBoxEdit1.EditValue = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
            foreach(DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins) {
                comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
            }
        }
        private void comboBoxEdit1_SelectedValueChanged(object sender, EventArgs e) {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = comboBoxEdit1.Text;
        }

        private class ShowFormThreadData {
            public DevExpress.LookAndFeel.UserLookAndFeel mainLookAndFeel;
            // TODO add more fields to pass data to a new thread
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Thread thread = new Thread(new ParameterizedThreadStart(myThread_OpenForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            ShowFormThreadData data = new ShowFormThreadData();
            data.mainLookAndFeel = DevExpress.LookAndFeel.UserLookAndFeel.Default;
            thread.Start(data);
        }

        public static void myThread_OpenForm(object data) {
            ShowFormThreadData td = data as ShowFormThreadData;

            // this thread 
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.Assign(td.mainLookAndFeel);
            
            Form2 form2 = new Form2();
            td.mainLookAndFeel.StyleChanged += new EventHandler(form2.MainLookAndFeel_StyleChanged);
            form2.ShowDialog();
        }
    }
}