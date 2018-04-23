Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication711
    <ToolboxItem(True)> _
    Public Class CustomRadialMenu
        Inherits RadialMenu

        Private _backButtonImage As Bitmap
        Public Sub New()
            MyBase.New()

        End Sub
        Public Sub New(ByVal manager As BarManager)
            MyBase.New(manager)

        End Sub
        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)

        End Sub
        Protected Overrides Function CreateLayeredWindow() As RadialMenuWindow
            Return New CustomRadialMenuWindow(Me)
        End Function
        Public ReadOnly Property ActualBarLinksHolderEx() As BarLinksHolder
            Get
                Return ActualLinksHolder
            End Get
        End Property

        <System.ComponentModel.DefaultValue(CType(Nothing, Object)), DXCategory(CategoryName.Appearance), Editor("DevExpress.Utils.Design.DXImageEditor, " & AssemblyInfo.SRAssemblyDesign, GetType(UITypeEditor))> _
        Public Property BackButtonImage() As Bitmap
            Get
                Return _backButtonImage
            End Get
            Set(ByVal value As Bitmap)
                If BackButtonImage Is value Then
                    Return
                End If
                _backButtonImage = value
            End Set
        End Property
    End Class
End Namespace
