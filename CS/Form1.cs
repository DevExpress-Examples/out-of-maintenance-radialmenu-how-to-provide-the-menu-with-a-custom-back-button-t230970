using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApplication711 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            customRadialMenu1.ShowPopup(this.PointToScreen(e.Location));
        }
    }
}
