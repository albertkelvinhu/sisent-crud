﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCInventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCInventory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.InventoryCheck_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Manage_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 41)
        Me.Panel1.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(14, 13)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(104, 13)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "BunifuCustomLabel1"
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(3, 47)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(240, 150)
        Me.BunifuCustomDataGrid1.TabIndex = 1
        '
        'InventoryCheck_btn
        '
        Me.InventoryCheck_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.InventoryCheck_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.InventoryCheck_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InventoryCheck_btn.BorderRadius = 0
        Me.InventoryCheck_btn.ButtonText = "Inventory Check"
        Me.InventoryCheck_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventoryCheck_btn.DisabledColor = System.Drawing.Color.Gray
        Me.InventoryCheck_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.InventoryCheck_btn.Iconimage = CType(resources.GetObject("InventoryCheck_btn.Iconimage"), System.Drawing.Image)
        Me.InventoryCheck_btn.Iconimage_right = Nothing
        Me.InventoryCheck_btn.Iconimage_right_Selected = Nothing
        Me.InventoryCheck_btn.Iconimage_Selected = Nothing
        Me.InventoryCheck_btn.IconMarginLeft = 0
        Me.InventoryCheck_btn.IconMarginRight = 0
        Me.InventoryCheck_btn.IconRightVisible = True
        Me.InventoryCheck_btn.IconRightZoom = 0R
        Me.InventoryCheck_btn.IconVisible = True
        Me.InventoryCheck_btn.IconZoom = 90.0R
        Me.InventoryCheck_btn.IsTab = False
        Me.InventoryCheck_btn.Location = New System.Drawing.Point(3, 231)
        Me.InventoryCheck_btn.Name = "InventoryCheck_btn"
        Me.InventoryCheck_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.InventoryCheck_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InventoryCheck_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.InventoryCheck_btn.selected = False
        Me.InventoryCheck_btn.Size = New System.Drawing.Size(172, 48)
        Me.InventoryCheck_btn.TabIndex = 2
        Me.InventoryCheck_btn.Text = "Inventory Check"
        Me.InventoryCheck_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InventoryCheck_btn.Textcolor = System.Drawing.Color.White
        Me.InventoryCheck_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Manage_btn
        '
        Me.Manage_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Manage_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Manage_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Manage_btn.BorderRadius = 0
        Me.Manage_btn.ButtonText = "Manage"
        Me.Manage_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Manage_btn.DisabledColor = System.Drawing.Color.Gray
        Me.Manage_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.Manage_btn.Iconimage = CType(resources.GetObject("Manage_btn.Iconimage"), System.Drawing.Image)
        Me.Manage_btn.Iconimage_right = Nothing
        Me.Manage_btn.Iconimage_right_Selected = Nothing
        Me.Manage_btn.Iconimage_Selected = Nothing
        Me.Manage_btn.IconMarginLeft = 0
        Me.Manage_btn.IconMarginRight = 0
        Me.Manage_btn.IconRightVisible = True
        Me.Manage_btn.IconRightZoom = 0R
        Me.Manage_btn.IconVisible = True
        Me.Manage_btn.IconZoom = 90.0R
        Me.Manage_btn.IsTab = False
        Me.Manage_btn.Location = New System.Drawing.Point(3, 285)
        Me.Manage_btn.Name = "Manage_btn"
        Me.Manage_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Manage_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Manage_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.Manage_btn.selected = False
        Me.Manage_btn.Size = New System.Drawing.Size(172, 48)
        Me.Manage_btn.TabIndex = 3
        Me.Manage_btn.Text = "Manage"
        Me.Manage_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Manage_btn.Textcolor = System.Drawing.Color.White
        Me.Manage_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.InventoryCheck_btn)
        Me.Panel2.Controls.Add(Me.Manage_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(399, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 364)
        Me.Panel2.TabIndex = 4
        '
        'InventoryUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InventoryUC"
        Me.Size = New System.Drawing.Size(577, 405)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents InventoryCheck_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Manage_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
End Class