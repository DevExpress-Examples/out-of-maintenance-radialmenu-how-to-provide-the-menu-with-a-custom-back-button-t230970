using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication711 {
public class CustomRadialMenuPainter : RadialMenuPainter {
    public CustomRadialMenuPainter(RadialMenuViewInfo viewInfo)
        : base(viewInfo) {
    }
    protected override void DrawGlyph(RadialMenuGraphicsInfoArgs e) {
        CustomRadialMenuViewInfo viewInfo = (CustomRadialMenuViewInfo)e.ViewInfo;
        if (viewInfo.GlyphBounds != Rectangle.Empty && e.DrawOptions.AllowDrawGlyph) DrawGlyphCore(e, viewInfo);
    }
    protected override void DrawGlyphSelection(RadialMenuGraphicsInfoArgs e) {
        // empty
    }

    void DrawGlyphCore(RadialMenuGraphicsInfoArgs e, CustomRadialMenuViewInfo viewInfo) {
        Image glyph = GetActualGlyph(e);

        if ((e.ViewInfo.Menu as CustomRadialMenu).ActualBarLinksHolderEx != e.ViewInfo.Menu)
            DrawColoredGlyph(e, (viewInfo.Menu as CustomRadialMenu).BackButtonImage);
        else
            e.Graphics.DrawImage(glyph, viewInfo.CalcGlyphClientBoundsEx(viewInfo.GlyphBounds, glyph));
        SmoothingMode mode = e.Graphics.SmoothingMode;
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        try {
            //e.Graphics.DrawEllipse(e.Cache.GetPen(Color.Red, 2), viewInfo.GlyphBounds);
            DrawGlyphSelection(e);
        }
        finally {
            e.Graphics.SmoothingMode = mode;
        }
    }
}
}
