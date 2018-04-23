Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon

Namespace WindowsFormsApplication711
Public Class CustomRadialMenuWindow
    Inherits RadialMenuWindow

    Public Sub New(ByVal menu As RadialMenu)
        MyBase.New(menu)
    End Sub
    Protected Overrides Function CreatePainter() As RadialMenuPainter
        Return New CustomRadialMenuPainter(ViewInfo)
    End Function
    Protected Overrides Function CreateViewInfo() As RadialMenuViewInfo
        Return New CustomRadialMenuViewInfo(Me)
    End Function

End Class

Friend Class CustomRadialMenuViewInfo
    Inherits RadialMenuViewInfo

    Public Sub New(ByVal window As RadialMenuWindow)
        MyBase.New(window)
    End Sub
    Public Function CalcGlyphClientBoundsEx(ByVal glyphBounds As Rectangle, ByVal glyph As Image) As Rectangle
        Return CalcGlyphClientBounds(glyphBounds, glyph)
    End Function
    Public Shadows ReadOnly Property GlyphBounds() As Rectangle
        Get
            Return MyBase.GlyphBounds
        End Get
    End Property
End Class
End Namespace
