using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApplication711 {
public class CustomRadialMenuWindow : RadialMenuWindow {
    public CustomRadialMenuWindow(RadialMenu menu)
        : base(menu) {
    }
    protected override RadialMenuPainter CreatePainter() {
        return new CustomRadialMenuPainter(ViewInfo);
    }
    protected override RadialMenuViewInfo CreateViewInfo() {
        return new CustomRadialMenuViewInfo(this);
    }
        
}

class CustomRadialMenuViewInfo : RadialMenuViewInfo {
    public CustomRadialMenuViewInfo(RadialMenuWindow window)
        : base(window) {
    }
    public Rectangle CalcGlyphClientBoundsEx(Rectangle glyphBounds, Image glyph) {
        return CalcGlyphClientBounds(glyphBounds, glyph);
    }
    public new Rectangle GlyphBounds { get { return base.GlyphBounds; } }
}
}
