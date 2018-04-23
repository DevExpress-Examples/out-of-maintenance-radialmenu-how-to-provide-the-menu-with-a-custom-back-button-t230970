Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports System.Runtime.InteropServices

Namespace WindowsFormsApplication711
Public Class CustomRadialMenuPainter
    Inherits RadialMenuPainter

    Public Sub New(ByVal viewInfo As RadialMenuViewInfo)
        MyBase.New(viewInfo)
    End Sub
    Protected Overrides Sub DrawGlyph(ByVal e As RadialMenuGraphicsInfoArgs)
        Dim viewInfo As CustomRadialMenuViewInfo = CType(e.ViewInfo, CustomRadialMenuViewInfo)
        If viewInfo.GlyphBounds <> Rectangle.Empty AndAlso e.DrawOptions.AllowDrawGlyph Then
            DrawGlyphCore(e, viewInfo)
        End If
    End Sub
    Protected Overrides Sub DrawGlyphSelection(ByVal e As RadialMenuGraphicsInfoArgs)
        ' empty
    End Sub

    Private Sub DrawGlyphCore(ByVal e As RadialMenuGraphicsInfoArgs, ByVal viewInfo As CustomRadialMenuViewInfo)
        Dim glyph As Image = GetActualGlyph(e)

        If (TryCast(e.ViewInfo.Menu, CustomRadialMenu)).ActualBarLinksHolderEx IsNot e.ViewInfo.Menu Then
            DrawColoredGlyph(e, (TryCast(viewInfo.Menu, CustomRadialMenu)).BackButtonImage)
        Else
            e.Graphics.DrawImage(glyph, viewInfo.CalcGlyphClientBoundsEx(viewInfo.GlyphBounds, glyph))
        End If
        Dim mode As SmoothingMode = e.Graphics.SmoothingMode
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        Try
            'e.Graphics.DrawEllipse(e.Cache.GetPen(Color.Red, 2), viewInfo.GlyphBounds);
            DrawGlyphSelection(e)
        Finally
            e.Graphics.SmoothingMode = mode
        End Try
    End Sub
End Class
End Namespace
