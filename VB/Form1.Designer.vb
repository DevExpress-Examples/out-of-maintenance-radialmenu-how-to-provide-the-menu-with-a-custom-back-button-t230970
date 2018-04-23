Namespace WindowsFormsApplication711
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.customRadialMenu1 = New WindowsFormsApplication711.CustomRadialMenu(Me.components)
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.customRadialMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customRadialMenu1
            ' 
            Me.customRadialMenu1.BackButtonImage = My.Resources.reset_32x32
            Me.customRadialMenu1.Glyph = My.Resources.show_32x32
            Me.customRadialMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
            Me.customRadialMenu1.Manager = Me.barManager1
            Me.customRadialMenu1.Name = "customRadialMenu1"
            ' 
            ' barSubItem1
            ' 
            Me.customRadialMenu1.SetAutoSize(Me.barSubItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default)
            Me.barSubItem1.Caption = "barSubItem1"
            Me.barSubItem1.Id = 0
            Me.customRadialMenu1.SetItemAutoSize(Me.barSubItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default)
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3) _
            })
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barButtonItem1
            ' 
            Me.customRadialMenu1.SetAutoSize(Me.barButtonItem1, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default)
            Me.barButtonItem1.Caption = "Cut"
            Me.barButtonItem1.Glyph = My.Resources.splitappointment_32x32
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.customRadialMenu1.SetAutoSize(Me.barButtonItem2, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default)
            Me.barButtonItem2.Caption = "Paste"
            Me.barButtonItem2.Glyph = My.Resources.paste_16x16
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.LargeGlyph = My.Resources.paste_32x32
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3})
            Me.barManager1.MaxItemId = 4
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(790, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 455)
            Me.barDockControlBottom.Size = New System.Drawing.Size(790, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 455)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(790, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 455)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(312, 402)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(163, 13)
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "Click on form to show Radial Menu"
            ' 
            ' barButtonItem3
            ' 
            Me.customRadialMenu1.SetAutoSize(Me.barButtonItem3, DevExpress.XtraBars.Ribbon.RadialMenuContainerItemAutoSize.Default)
            Me.barButtonItem3.Caption = "Copy"
            Me.barButtonItem3.Glyph = My.Resources.copy_16x16
            Me.barButtonItem3.Id = 3
            Me.barButtonItem3.LargeGlyph = My.Resources.copy_32x32
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(790, 455)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.customRadialMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private customRadialMenu1 As CustomRadialMenu
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barSubItem1 As DevExpress.XtraBars.BarSubItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

    End Class
End Namespace

