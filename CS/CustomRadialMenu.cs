using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication711 {
    [ToolboxItem(true)]
    public class CustomRadialMenu : RadialMenu {
        Bitmap _backButtonImage;
        public CustomRadialMenu()
            : base() {

        }
        public CustomRadialMenu(BarManager manager)
            : base(manager) {

        }
        public CustomRadialMenu(IContainer container)
            : base(container) {

        }
        protected override RadialMenuWindow CreateLayeredWindow() {
            return new CustomRadialMenuWindow(this);
        }
        public BarLinksHolder ActualBarLinksHolderEx { get { return ActualLinksHolder; } }

        [DefaultValue(null), DXCategory(CategoryName.Appearance), Editor("DevExpress.Utils.Design.DXImageEditor, " + AssemblyInfo.SRAssemblyDesign, typeof(UITypeEditor))]
        public Bitmap BackButtonImage {
            get {
                return _backButtonImage;
            }
            set {
                if (BackButtonImage == value)
                    return;
                _backButtonImage = value;
            }
        }
    }
}
