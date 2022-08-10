<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Btnrm = New System.Windows.Forms.Button()
        Me.Btnup = New System.Windows.Forms.Button()
        Me.Btnad = New System.Windows.Forms.Button()
        Me.Btnnx = New System.Windows.Forms.Button()
        Me.Btnpr = New System.Windows.Forms.Button()
        Me.Btncn = New System.Windows.Forms.Button()
        Me.Btncl = New System.Windows.Forms.Button()
        Me.Datetime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(226, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Members"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DOB"
        '
        'Txtid
        '
        Me.Txtid.Location = New System.Drawing.Point(181, 66)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(277, 20)
        Me.Txtid.TabIndex = 7
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(181, 97)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(277, 20)
        Me.Txtname.TabIndex = 8
        '
        'Txtusername
        '
        Me.Txtusername.Location = New System.Drawing.Point(181, 125)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(277, 20)
        Me.Txtusername.TabIndex = 9
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(181, 156)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Size = New System.Drawing.Size(277, 20)
        Me.Txtpassword.TabIndex = 10
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnbk.Location = New System.Drawing.Point(465, 287)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(121, 23)
        Me.Btnbk.TabIndex = 23
        Me.Btnbk.Text = "Back"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'Btnrm
        '
        Me.Btnrm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnrm.Location = New System.Drawing.Point(322, 287)
        Me.Btnrm.Name = "Btnrm"
        Me.Btnrm.Size = New System.Drawing.Size(121, 23)
        Me.Btnrm.TabIndex = 22
        Me.Btnrm.Text = "Remove"
        Me.Btnrm.UseVisualStyleBackColor = False
        '
        'Btnup
        '
        Me.Btnup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnup.Location = New System.Drawing.Point(173, 287)
        Me.Btnup.Name = "Btnup"
        Me.Btnup.Size = New System.Drawing.Size(121, 23)
        Me.Btnup.TabIndex = 21
        Me.Btnup.Text = "Update"
        Me.Btnup.UseVisualStyleBackColor = False
        '
        'Btnad
        '
        Me.Btnad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnad.Location = New System.Drawing.Point(26, 287)
        Me.Btnad.Name = "Btnad"
        Me.Btnad.Size = New System.Drawing.Size(121, 23)
        Me.Btnad.TabIndex = 20
        Me.Btnad.Text = "Add"
        Me.Btnad.UseVisualStyleBackColor = False
        '
        'Btnnx
        '
        Me.Btnnx.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnnx.Location = New System.Drawing.Point(512, 168)
        Me.Btnnx.Name = "Btnnx"
        Me.Btnnx.Size = New System.Drawing.Size(83, 23)
        Me.Btnnx.TabIndex = 27
        Me.Btnnx.Text = "Next"
        Me.Btnnx.UseVisualStyleBackColor = False
        '
        'Btnpr
        '
        Me.Btnpr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnpr.Location = New System.Drawing.Point(512, 118)
        Me.Btnpr.Name = "Btnpr"
        Me.Btnpr.Size = New System.Drawing.Size(83, 23)
        Me.Btnpr.TabIndex = 26
        Me.Btnpr.Text = "Previous"
        Me.Btnpr.UseVisualStyleBackColor = False
        '
        'Btncn
        '
        Me.Btncn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btncn.Location = New System.Drawing.Point(512, 67)
        Me.Btncn.Name = "Btncn"
        Me.Btncn.Size = New System.Drawing.Size(83, 23)
        Me.Btncn.TabIndex = 25
        Me.Btncn.Text = "Change"
        Me.Btncn.UseVisualStyleBackColor = False
        '
        'Btncl
        '
        Me.Btncl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btncl.Location = New System.Drawing.Point(512, 213)
        Me.Btncl.Name = "Btncl"
        Me.Btncl.Size = New System.Drawing.Size(83, 23)
        Me.Btncl.TabIndex = 24
        Me.Btncl.Text = "Clear"
        Me.Btncl.UseVisualStyleBackColor = False
        '
        'Datetime
        '
        Me.Datetime.Location = New System.Drawing.Point(181, 183)
        Me.Datetime.Name = "Datetime"
        Me.Datetime.Size = New System.Drawing.Size(277, 20)
        Me.Datetime.TabIndex = 28
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 340)
        Me.Controls.Add(Me.Datetime)
        Me.Controls.Add(Me.Btnnx)
        Me.Controls.Add(Me.Btnpr)
        Me.Controls.Add(Me.Btncn)
        Me.Controls.Add(Me.Btncl)
        Me.Controls.Add(Me.Btnbk)
        Me.Controls.Add(Me.Btnrm)
        Me.Controls.Add(Me.Btnup)
        Me.Controls.Add(Me.Btnad)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Txtusername)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Manage Members"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtid As TextBox
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Btnbk As Button
    Friend WithEvents Btnrm As Button
    Friend WithEvents Btnup As Button
    Friend WithEvents Btnad As Button
    Friend WithEvents Btnnx As Button
    Friend WithEvents Btnpr As Button
    Friend WithEvents Btncn As Button
    Friend WithEvents Btncl As Button
    Friend WithEvents Datetime As DateTimePicker
End Class
