<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtbid = New System.Windows.Forms.TextBox()
        Me.Txtbname = New System.Windows.Forms.TextBox()
        Me.Txtpri = New System.Windows.Forms.TextBox()
        Me.Txtqunt = New System.Windows.Forms.TextBox()
        Me.Cmbcat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btnupdt = New System.Windows.Forms.Button()
        Me.Btnrmv = New System.Windows.Forms.Button()
        Me.Btnclr = New System.Windows.Forms.Button()
        Me.Btnchng = New System.Windows.Forms.Button()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Btnprv = New System.Windows.Forms.Button()
        Me.Btnnxt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quntity"
        '
        'Txtbid
        '
        Me.Txtbid.Location = New System.Drawing.Point(179, 67)
        Me.Txtbid.Name = "Txtbid"
        Me.Txtbid.Size = New System.Drawing.Size(270, 20)
        Me.Txtbid.TabIndex = 8
        '
        'Txtbname
        '
        Me.Txtbname.Location = New System.Drawing.Point(179, 98)
        Me.Txtbname.Name = "Txtbname"
        Me.Txtbname.Size = New System.Drawing.Size(270, 20)
        Me.Txtbname.TabIndex = 9
        '
        'Txtpri
        '
        Me.Txtpri.Location = New System.Drawing.Point(179, 175)
        Me.Txtpri.Name = "Txtpri"
        Me.Txtpri.Size = New System.Drawing.Size(270, 20)
        Me.Txtpri.TabIndex = 10
        '
        'Txtqunt
        '
        Me.Txtqunt.Location = New System.Drawing.Point(179, 210)
        Me.Txtqunt.Name = "Txtqunt"
        Me.Txtqunt.Size = New System.Drawing.Size(270, 20)
        Me.Txtqunt.TabIndex = 11
        '
        'Cmbcat
        '
        Me.Cmbcat.FormattingEnabled = True
        Me.Cmbcat.Items.AddRange(New Object() {"Secret", "Science", "Horror", "Love", "IQ"})
        Me.Cmbcat.Location = New System.Drawing.Point(179, 135)
        Me.Cmbcat.Name = "Cmbcat"
        Me.Cmbcat.Size = New System.Drawing.Size(270, 21)
        Me.Cmbcat.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Location = New System.Drawing.Point(228, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Book Registration"
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnadd.Location = New System.Drawing.Point(32, 290)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(121, 23)
        Me.Btnadd.TabIndex = 14
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Btnupdt
        '
        Me.Btnupdt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnupdt.Location = New System.Drawing.Point(179, 290)
        Me.Btnupdt.Name = "Btnupdt"
        Me.Btnupdt.Size = New System.Drawing.Size(121, 23)
        Me.Btnupdt.TabIndex = 15
        Me.Btnupdt.Text = "Update"
        Me.Btnupdt.UseVisualStyleBackColor = False
        '
        'Btnrmv
        '
        Me.Btnrmv.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnrmv.Location = New System.Drawing.Point(328, 290)
        Me.Btnrmv.Name = "Btnrmv"
        Me.Btnrmv.Size = New System.Drawing.Size(121, 23)
        Me.Btnrmv.TabIndex = 16
        Me.Btnrmv.Text = "Remove"
        Me.Btnrmv.UseVisualStyleBackColor = False
        '
        'Btnclr
        '
        Me.Btnclr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnclr.Location = New System.Drawing.Point(509, 213)
        Me.Btnclr.Name = "Btnclr"
        Me.Btnclr.Size = New System.Drawing.Size(83, 23)
        Me.Btnclr.TabIndex = 17
        Me.Btnclr.Text = "Clear"
        Me.Btnclr.UseVisualStyleBackColor = False
        '
        'Btnchng
        '
        Me.Btnchng.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnchng.Location = New System.Drawing.Point(509, 67)
        Me.Btnchng.Name = "Btnchng"
        Me.Btnchng.Size = New System.Drawing.Size(83, 23)
        Me.Btnchng.TabIndex = 18
        Me.Btnchng.Text = "Change"
        Me.Btnchng.UseVisualStyleBackColor = False
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnbk.Location = New System.Drawing.Point(471, 290)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(121, 23)
        Me.Btnbk.TabIndex = 19
        Me.Btnbk.Text = "Back"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'Btnprv
        '
        Me.Btnprv.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnprv.Location = New System.Drawing.Point(509, 118)
        Me.Btnprv.Name = "Btnprv"
        Me.Btnprv.Size = New System.Drawing.Size(83, 23)
        Me.Btnprv.TabIndex = 20
        Me.Btnprv.Text = "Previous"
        Me.Btnprv.UseVisualStyleBackColor = False
        '
        'Btnnxt
        '
        Me.Btnnxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnnxt.Location = New System.Drawing.Point(509, 168)
        Me.Btnnxt.Name = "Btnnxt"
        Me.Btnnxt.Size = New System.Drawing.Size(83, 23)
        Me.Btnnxt.TabIndex = 21
        Me.Btnnxt.Text = "Next"
        Me.Btnnxt.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 348)
        Me.Controls.Add(Me.Btnnxt)
        Me.Controls.Add(Me.Btnprv)
        Me.Controls.Add(Me.Btnbk)
        Me.Controls.Add(Me.Btnchng)
        Me.Controls.Add(Me.Btnclr)
        Me.Controls.Add(Me.Btnrmv)
        Me.Controls.Add(Me.Btnupdt)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cmbcat)
        Me.Controls.Add(Me.Txtqunt)
        Me.Controls.Add(Me.Txtpri)
        Me.Controls.Add(Me.Txtbname)
        Me.Controls.Add(Me.Txtbid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Book Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtbid As TextBox
    Friend WithEvents Txtbname As TextBox
    Friend WithEvents Txtpri As TextBox
    Friend WithEvents Txtqunt As TextBox
    Friend WithEvents Cmbcat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btnadd As Button
    Friend WithEvents Btnupdt As Button
    Friend WithEvents Btnrmv As Button
    Friend WithEvents Btnclr As Button
    Friend WithEvents Btnchng As Button
    Friend WithEvents Btnbk As Button
    Friend WithEvents Btnprv As Button
    Friend WithEvents Btnnxt As Button
End Class
