<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.CB2 = New System.Windows.Forms.CheckBox()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.CB4 = New System.Windows.Forms.CheckBox()
        Me.CB5 = New System.Windows.Forms.CheckBox()
        Me.numCoke = New System.Windows.Forms.NumericUpDown()
        Me.lbl = New System.Windows.Forms.Label()
        Me.But = New System.Windows.Forms.Button()
        Me.IstOrders = New System.Windows.Forms.ListBox()
        Me.Num2 = New System.Windows.Forms.NumericUpDown()
        Me.Num3 = New System.Windows.Forms.NumericUpDown()
        Me.Num4 = New System.Windows.Forms.NumericUpDown()
        Me.Num5 = New System.Windows.Forms.NumericUpDown()
        Me.Num8 = New System.Windows.Forms.NumericUpDown()
        Me.Num7 = New System.Windows.Forms.NumericUpDown()
        Me.Num6 = New System.Windows.Forms.NumericUpDown()
        Me.CB8 = New System.Windows.Forms.CheckBox()
        Me.CB7 = New System.Windows.Forms.CheckBox()
        Me.CB6 = New System.Windows.Forms.CheckBox()
        CType(Me.numCoke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.Location = New System.Drawing.Point(163, 41)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(102, 17)
        Me.CB1.TabIndex = 0
        Me.CB1.Text = "CocaCola £2.00"
        Me.CB1.UseVisualStyleBackColor = True
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.Location = New System.Drawing.Point(163, 73)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(82, 17)
        Me.CB2.TabIndex = 1
        Me.CB2.Text = "Prime £2.50"
        Me.CB2.UseVisualStyleBackColor = True
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.Location = New System.Drawing.Point(163, 105)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(83, 17)
        Me.CB3.TabIndex = 2
        Me.CB3.Text = "Sprite £2.50"
        Me.CB3.UseVisualStyleBackColor = True
        '
        'CB4
        '
        Me.CB4.AutoSize = True
        Me.CB4.Location = New System.Drawing.Point(163, 136)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(85, 17)
        Me.CB4.TabIndex = 3
        Me.CB4.Text = "Water £1.00"
        Me.CB4.UseVisualStyleBackColor = True
        '
        'CB5
        '
        Me.CB5.AutoSize = True
        Me.CB5.Location = New System.Drawing.Point(163, 171)
        Me.CB5.Name = "CB5"
        Me.CB5.Size = New System.Drawing.Size(87, 17)
        Me.CB5.TabIndex = 4
        Me.CB5.Text = "Tango £2.50"
        Me.CB5.UseVisualStyleBackColor = True
        '
        'numCoke
        '
        Me.numCoke.Location = New System.Drawing.Point(291, 38)
        Me.numCoke.Name = "numCoke"
        Me.numCoke.Size = New System.Drawing.Size(47, 20)
        Me.numCoke.TabIndex = 5
        Me.numCoke.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(159, 334)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(160, 28)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "Cost of order £ 0"
        '
        'But
        '
        Me.But.Font = New System.Drawing.Font("Myriad Arabic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But.Location = New System.Drawing.Point(163, 365)
        Me.But.Name = "But"
        Me.But.Size = New System.Drawing.Size(143, 46)
        Me.But.TabIndex = 7
        Me.But.Text = "Finish and Pay"
        Me.But.UseVisualStyleBackColor = True
        '
        'IstOrders
        '
        Me.IstOrders.FormattingEnabled = True
        Me.IstOrders.Location = New System.Drawing.Point(400, 41)
        Me.IstOrders.Name = "IstOrders"
        Me.IstOrders.Size = New System.Drawing.Size(142, 290)
        Me.IstOrders.TabIndex = 9
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(291, 70)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(43, 20)
        Me.Num2.TabIndex = 10
        Me.Num2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num3
        '
        Me.Num3.Location = New System.Drawing.Point(291, 102)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(43, 20)
        Me.Num3.TabIndex = 11
        Me.Num3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num4
        '
        Me.Num4.Location = New System.Drawing.Point(291, 135)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(43, 20)
        Me.Num4.TabIndex = 12
        Me.Num4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num5
        '
        Me.Num5.Location = New System.Drawing.Point(291, 168)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(43, 20)
        Me.Num5.TabIndex = 13
        Me.Num5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num8
        '
        Me.Num8.Location = New System.Drawing.Point(291, 275)
        Me.Num8.Name = "Num8"
        Me.Num8.Size = New System.Drawing.Size(43, 20)
        Me.Num8.TabIndex = 19
        Me.Num8.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num7
        '
        Me.Num7.Location = New System.Drawing.Point(291, 238)
        Me.Num7.Name = "Num7"
        Me.Num7.Size = New System.Drawing.Size(43, 20)
        Me.Num7.TabIndex = 18
        Me.Num7.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num6
        '
        Me.Num6.Location = New System.Drawing.Point(291, 204)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(43, 20)
        Me.Num6.TabIndex = 17
        Me.Num6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CB8
        '
        Me.CB8.AutoSize = True
        Me.CB8.Location = New System.Drawing.Point(163, 275)
        Me.CB8.Name = "CB8"
        Me.CB8.Size = New System.Drawing.Size(102, 17)
        Me.CB8.TabIndex = 16
        Me.CB8.Text = "Limonade £1.50"
        Me.CB8.UseVisualStyleBackColor = True
        '
        'CB7
        '
        Me.CB7.AutoSize = True
        Me.CB7.Location = New System.Drawing.Point(163, 238)
        Me.CB7.Name = "CB7"
        Me.CB7.Size = New System.Drawing.Size(110, 17)
        Me.CB7.TabIndex = 15
        Me.CB7.Text = "Apple Juise £3.00"
        Me.CB7.UseVisualStyleBackColor = True
        '
        'CB6
        '
        Me.CB6.AutoSize = True
        Me.CB6.Location = New System.Drawing.Point(163, 204)
        Me.CB6.Name = "CB6"
        Me.CB6.Size = New System.Drawing.Size(83, 17)
        Me.CB6.TabIndex = 14
        Me.CB6.Text = "Fanta £2.50"
        Me.CB6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 450)
        Me.Controls.Add(Me.Num8)
        Me.Controls.Add(Me.Num7)
        Me.Controls.Add(Me.Num6)
        Me.Controls.Add(Me.CB8)
        Me.Controls.Add(Me.CB7)
        Me.Controls.Add(Me.CB6)
        Me.Controls.Add(Me.Num5)
        Me.Controls.Add(Me.Num4)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.IstOrders)
        Me.Controls.Add(Me.But)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.numCoke)
        Me.Controls.Add(Me.CB5)
        Me.Controls.Add(Me.CB4)
        Me.Controls.Add(Me.CB3)
        Me.Controls.Add(Me.CB2)
        Me.Controls.Add(Me.CB1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numCoke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB1 As CheckBox
    Friend WithEvents CB2 As CheckBox
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents CB4 As CheckBox
    Friend WithEvents CB5 As CheckBox
    Friend WithEvents numCoke As NumericUpDown
    Friend WithEvents lbl As Label
    Friend WithEvents But As Button
    Friend WithEvents IstOrders As ListBox
    Friend WithEvents Num2 As NumericUpDown
    Friend WithEvents Num3 As NumericUpDown
    Friend WithEvents Num4 As NumericUpDown
    Friend WithEvents Num5 As NumericUpDown
    Friend WithEvents Num8 As NumericUpDown
    Friend WithEvents Num7 As NumericUpDown
    Friend WithEvents Num6 As NumericUpDown
    Friend WithEvents CB8 As CheckBox
    Friend WithEvents CB7 As CheckBox
    Friend WithEvents CB6 As CheckBox
End Class
