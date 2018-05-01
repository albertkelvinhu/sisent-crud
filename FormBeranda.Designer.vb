<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBeranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBeranda))
        Me.Navigation_panel = New System.Windows.Forms.Panel()
        Me.Inventory_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Finance_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ExitButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Beranda_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Header_panel = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.InventoryUC1 = New CRUD.UCInventory()
        Me.UserControl11 = New CRUD.UserControl1()
        Me.UcLogin1 = New CRUD.UCLogin()
        Me.Navigation_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Navigation_panel
        '
        Me.Navigation_panel.BackColor = System.Drawing.Color.Silver
        Me.Navigation_panel.Controls.Add(Me.Inventory_button)
        Me.Navigation_panel.Controls.Add(Me.Finance_button)
        Me.Navigation_panel.Controls.Add(Me.ExitButton)
        Me.Navigation_panel.Controls.Add(Me.Beranda_button)
        Me.Navigation_panel.Controls.Add(Me.Panel1)
        Me.Navigation_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Navigation_panel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Navigation_panel.Location = New System.Drawing.Point(0, 0)
        Me.Navigation_panel.Name = "Navigation_panel"
        Me.Navigation_panel.Size = New System.Drawing.Size(201, 443)
        Me.Navigation_panel.TabIndex = 0
        '
        'Inventory_button
        '
        Me.Inventory_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Inventory_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Inventory_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inventory_button.BorderRadius = 0
        Me.Inventory_button.ButtonText = "Inventory"
        Me.Inventory_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inventory_button.DisabledColor = System.Drawing.Color.Gray
        Me.Inventory_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.Inventory_button.Iconcolor = System.Drawing.Color.Transparent
        Me.Inventory_button.Iconimage = CType(resources.GetObject("Inventory_button.Iconimage"), System.Drawing.Image)
        Me.Inventory_button.Iconimage_right = Nothing
        Me.Inventory_button.Iconimage_right_Selected = Nothing
        Me.Inventory_button.Iconimage_Selected = Nothing
        Me.Inventory_button.IconMarginLeft = 0
        Me.Inventory_button.IconMarginRight = 0
        Me.Inventory_button.IconRightVisible = True
        Me.Inventory_button.IconRightZoom = 0R
        Me.Inventory_button.IconVisible = True
        Me.Inventory_button.IconZoom = 90.0R
        Me.Inventory_button.IsTab = False
        Me.Inventory_button.Location = New System.Drawing.Point(0, 134)
        Me.Inventory_button.Name = "Inventory_button"
        Me.Inventory_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Inventory_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Inventory_button.OnHoverTextColor = System.Drawing.Color.White
        Me.Inventory_button.selected = False
        Me.Inventory_button.Size = New System.Drawing.Size(201, 48)
        Me.Inventory_button.TabIndex = 4
        Me.Inventory_button.Text = "Inventory"
        Me.Inventory_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Inventory_button.Textcolor = System.Drawing.Color.White
        Me.Inventory_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Finance_button
        '
        Me.Finance_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Finance_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Finance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Finance_button.BorderRadius = 0
        Me.Finance_button.ButtonText = "Finance"
        Me.Finance_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Finance_button.DisabledColor = System.Drawing.Color.Gray
        Me.Finance_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.Finance_button.Iconcolor = System.Drawing.Color.Transparent
        Me.Finance_button.Iconimage = CType(resources.GetObject("Finance_button.Iconimage"), System.Drawing.Image)
        Me.Finance_button.Iconimage_right = Nothing
        Me.Finance_button.Iconimage_right_Selected = Nothing
        Me.Finance_button.Iconimage_Selected = Nothing
        Me.Finance_button.IconMarginLeft = 0
        Me.Finance_button.IconMarginRight = 0
        Me.Finance_button.IconRightVisible = True
        Me.Finance_button.IconRightZoom = 0R
        Me.Finance_button.IconVisible = True
        Me.Finance_button.IconZoom = 90.0R
        Me.Finance_button.IsTab = False
        Me.Finance_button.Location = New System.Drawing.Point(0, 86)
        Me.Finance_button.Name = "Finance_button"
        Me.Finance_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Finance_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Finance_button.OnHoverTextColor = System.Drawing.Color.White
        Me.Finance_button.selected = False
        Me.Finance_button.Size = New System.Drawing.Size(201, 48)
        Me.Finance_button.TabIndex = 3
        Me.Finance_button.Text = "Finance"
        Me.Finance_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Finance_button.Textcolor = System.Drawing.Color.White
        Me.Finance_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ExitButton
        '
        Me.ExitButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.BorderRadius = 0
        Me.ExitButton.ButtonText = "Exit"
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.DisabledColor = System.Drawing.Color.Gray
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExitButton.Iconcolor = System.Drawing.Color.Transparent
        Me.ExitButton.Iconimage = CType(resources.GetObject("ExitButton.Iconimage"), System.Drawing.Image)
        Me.ExitButton.Iconimage_right = Nothing
        Me.ExitButton.Iconimage_right_Selected = Nothing
        Me.ExitButton.Iconimage_Selected = Nothing
        Me.ExitButton.IconMarginLeft = 0
        Me.ExitButton.IconMarginRight = 0
        Me.ExitButton.IconRightVisible = True
        Me.ExitButton.IconRightZoom = 0R
        Me.ExitButton.IconVisible = True
        Me.ExitButton.IconZoom = 90.0R
        Me.ExitButton.IsTab = False
        Me.ExitButton.Location = New System.Drawing.Point(0, 395)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ExitButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ExitButton.OnHoverTextColor = System.Drawing.Color.White
        Me.ExitButton.selected = False
        Me.ExitButton.Size = New System.Drawing.Size(201, 48)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitButton.Textcolor = System.Drawing.Color.White
        Me.ExitButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Beranda_button
        '
        Me.Beranda_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Beranda_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Beranda_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Beranda_button.BorderRadius = 0
        Me.Beranda_button.ButtonText = "Beranda"
        Me.Beranda_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Beranda_button.DisabledColor = System.Drawing.Color.Gray
        Me.Beranda_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.Beranda_button.Iconcolor = System.Drawing.Color.Transparent
        Me.Beranda_button.Iconimage = CType(resources.GetObject("Beranda_button.Iconimage"), System.Drawing.Image)
        Me.Beranda_button.Iconimage_right = Nothing
        Me.Beranda_button.Iconimage_right_Selected = Nothing
        Me.Beranda_button.Iconimage_Selected = Nothing
        Me.Beranda_button.IconMarginLeft = 0
        Me.Beranda_button.IconMarginRight = 0
        Me.Beranda_button.IconRightVisible = True
        Me.Beranda_button.IconRightZoom = 0R
        Me.Beranda_button.IconVisible = True
        Me.Beranda_button.IconZoom = 90.0R
        Me.Beranda_button.IsTab = False
        Me.Beranda_button.Location = New System.Drawing.Point(0, 38)
        Me.Beranda_button.Name = "Beranda_button"
        Me.Beranda_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Beranda_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Beranda_button.OnHoverTextColor = System.Drawing.Color.White
        Me.Beranda_button.selected = True
        Me.Beranda_button.Size = New System.Drawing.Size(201, 48)
        Me.Beranda_button.TabIndex = 1
        Me.Beranda_button.Text = "Beranda"
        Me.Beranda_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Beranda_button.Textcolor = System.Drawing.Color.White
        Me.Beranda_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 38)
        Me.Panel1.TabIndex = 0
        '
        'Header_panel
        '
        Me.Header_panel.BackColor = System.Drawing.Color.Salmon
        Me.Header_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_panel.Location = New System.Drawing.Point(201, 0)
        Me.Header_panel.Name = "Header_panel"
        Me.Header_panel.Size = New System.Drawing.Size(577, 38)
        Me.Header_panel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UcLogin1)
        Me.Panel2.Controls.Add(Me.InventoryUC1)
        Me.Panel2.Controls.Add(Me.UserControl11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(201, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 405)
        Me.Panel2.TabIndex = 1
        '
        'InventoryUC1
        '
        Me.InventoryUC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryUC1.Location = New System.Drawing.Point(0, 0)
        Me.InventoryUC1.Name = "InventoryUC1"
        Me.InventoryUC1.Size = New System.Drawing.Size(577, 405)
        Me.InventoryUC1.TabIndex = 1
        Me.InventoryUC1.Visible = False
        '
        'UserControl11
        '
        Me.UserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl11.Location = New System.Drawing.Point(0, 0)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(577, 405)
        Me.UserControl11.TabIndex = 0
        Me.UserControl11.Visible = False
        '
        'UcLogin1
        '
        Me.UcLogin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLogin1.Location = New System.Drawing.Point(0, 0)
        Me.UcLogin1.Name = "UcLogin1"
        Me.UcLogin1.Size = New System.Drawing.Size(577, 405)
        Me.UcLogin1.TabIndex = 2
        '
        'FormBeranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(778, 443)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Header_panel)
        Me.Controls.Add(Me.Navigation_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBeranda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Navigation_panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Navigation_panel As Panel
    Friend WithEvents Header_panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Beranda_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Inventory_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Finance_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents InventoryUC1 As UCInventory
    Friend WithEvents UcLogin1 As UCLogin
End Class
