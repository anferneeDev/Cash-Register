<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createAccount
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
        Me.open = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(668, 242)
        Me.open.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(202, 81)
        Me.open.TabIndex = 0
        Me.open.Text = "open"
        Me.open.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSize = True
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.Location = New System.Drawing.Point(-898, 1035)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(648, 408)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(338, 117)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'createAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1298, 1017)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.open)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "createAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents open As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
