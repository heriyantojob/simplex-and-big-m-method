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
        Me.Label1 = New System.Windows.Forms.Label
        Me.setbanyak = New System.Windows.Forms.Button
        Me.x1 = New System.Windows.Forms.NumericUpDown
        Me.x2 = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.solusi = New System.Windows.Forms.NumericUpDown
        Me.tambah = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.data = New System.Windows.Forms.NumericUpDown
        Me.hitung = New System.Windows.Forms.Button
        Me.L = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.samadengan = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.JumlahX = New System.Windows.Forms.NumericUpDown
        Me.Button1 = New System.Windows.Forms.Button
        Me.syarat = New System.Windows.Forms.NumericUpDown
        Me.Xn = New System.Windows.Forms.NumericUpDown
        Me.tes = New System.Windows.Forms.Label
        Me.comboXN = New System.Windows.Forms.NumericUpDown
        Me.variable = New System.Windows.Forms.RichTextBox
        Me.nddd = New System.Windows.Forms.Label
        Me.tampilhasil = New System.Windows.Forms.WebBrowser
        Me.reset = New System.Windows.Forms.Button
        CType(Me.x1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JumlahX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.syarat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboXN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jumlah syarat"
        '
        'setbanyak
        '
        Me.setbanyak.Location = New System.Drawing.Point(532, 19)
        Me.setbanyak.Name = "setbanyak"
        Me.setbanyak.Size = New System.Drawing.Size(75, 23)
        Me.setbanyak.TabIndex = 2
        Me.setbanyak.Text = "set"
        Me.setbanyak.UseVisualStyleBackColor = True
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(86, 104)
        Me.x1.Name = "x1"
        Me.x1.ReadOnly = True
        Me.x1.Size = New System.Drawing.Size(63, 22)
        Me.x1.TabIndex = 3
        Me.x1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(239, 102)
        Me.x2.Name = "x2"
        Me.x2.ReadOnly = True
        Me.x2.Size = New System.Drawing.Size(63, 22)
        Me.x2.TabIndex = 4
        Me.x2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "x0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "x1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(558, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "solusi"
        '
        'solusi
        '
        Me.solusi.Enabled = False
        Me.solusi.Location = New System.Drawing.Point(623, 106)
        Me.solusi.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.solusi.Name = "solusi"
        Me.solusi.Size = New System.Drawing.Size(63, 22)
        Me.solusi.TabIndex = 8
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(710, 104)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(75, 23)
        Me.tambah.TabIndex = 9
        Me.tambah.Text = "tambah nilai"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "data ke-"
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(278, 47)
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Size = New System.Drawing.Size(63, 22)
        Me.data.TabIndex = 11
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(476, 146)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(75, 23)
        Me.hitung.TabIndex = 12
        Me.hitung.Text = "hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(71, 9)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(59, 17)
        Me.L.TabIndex = 13
        Me.L.Text = "Jumlahx"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "xn"
        '
        'samadengan
        '
        Me.samadengan.FormattingEnabled = True
        Me.samadengan.Location = New System.Drawing.Point(394, 104)
        Me.samadengan.Name = "samadengan"
        Me.samadengan.Size = New System.Drawing.Size(121, 24)
        Me.samadengan.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "=/=</>="
        '
        'JumlahX
        '
        Me.JumlahX.Location = New System.Drawing.Point(149, 7)
        Me.JumlahX.Name = "JumlahX"
        Me.JumlahX.Size = New System.Drawing.Size(63, 22)
        Me.JumlahX.TabIndex = 20
        Me.JumlahX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "tambah x ke-n"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'syarat
        '
        Me.syarat.Location = New System.Drawing.Point(452, 21)
        Me.syarat.Name = "syarat"
        Me.syarat.Size = New System.Drawing.Size(63, 22)
        Me.syarat.TabIndex = 0
        Me.syarat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Xn
        '
        Me.Xn.Location = New System.Drawing.Point(240, 157)
        Me.Xn.Name = "Xn"
        Me.Xn.Size = New System.Drawing.Size(63, 22)
        Me.Xn.TabIndex = 22
        Me.Xn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tes
        '
        Me.tes.AutoSize = True
        Me.tes.Location = New System.Drawing.Point(582, 152)
        Me.tes.Name = "tes"
        Me.tes.Size = New System.Drawing.Size(51, 17)
        Me.tes.TabIndex = 23
        Me.tes.Text = "Label6"
        '
        'comboXN
        '
        Me.comboXN.Location = New System.Drawing.Point(86, 152)
        Me.comboXN.Name = "comboXN"
        Me.comboXN.Size = New System.Drawing.Size(63, 22)
        Me.comboXN.TabIndex = 24
        Me.comboXN.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'variable
        '
        Me.variable.Location = New System.Drawing.Point(28, 448)
        Me.variable.Name = "variable"
        Me.variable.Size = New System.Drawing.Size(726, 94)
        Me.variable.TabIndex = 25
        Me.variable.Text = ""
        '
        'nddd
        '
        Me.nddd.AutoSize = True
        Me.nddd.Location = New System.Drawing.Point(183, 157)
        Me.nddd.Name = "nddd"
        Me.nddd.Size = New System.Drawing.Size(51, 17)
        Me.nddd.TabIndex = 26
        Me.nddd.Text = "nilai xn"
        '
        'tampilhasil
        '
        Me.tampilhasil.Location = New System.Drawing.Point(48, 181)
        Me.tampilhasil.MinimumSize = New System.Drawing.Size(20, 20)
        Me.tampilhasil.Name = "tampilhasil"
        Me.tampilhasil.Size = New System.Drawing.Size(726, 246)
        Me.tampilhasil.TabIndex = 27
        Me.tampilhasil.Url = New System.Uri("", System.UriKind.Relative)
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(684, 152)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 28
        Me.reset.Text = "reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 582)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.tampilhasil)
        Me.Controls.Add(Me.nddd)
        Me.Controls.Add(Me.variable)
        Me.Controls.Add(Me.comboXN)
        Me.Controls.Add(Me.tes)
        Me.Controls.Add(Me.Xn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.JumlahX)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.samadengan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.solusi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.setbanyak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.syarat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.x1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.solusi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JumlahX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.syarat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboXN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents setbanyak As System.Windows.Forms.Button
    Friend WithEvents x1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents x2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents solusi As System.Windows.Forms.NumericUpDown
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.NumericUpDown
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents L As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents samadengan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents JumlahX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents syarat As System.Windows.Forms.NumericUpDown
    Friend WithEvents Xn As System.Windows.Forms.NumericUpDown
    Friend WithEvents tes As System.Windows.Forms.Label
    Friend WithEvents comboXN As System.Windows.Forms.NumericUpDown
    Friend WithEvents variable As System.Windows.Forms.RichTextBox
    Friend WithEvents nddd As System.Windows.Forms.Label
    Friend WithEvents tampilhasil As System.Windows.Forms.WebBrowser
    Friend WithEvents reset As System.Windows.Forms.Button

End Class
