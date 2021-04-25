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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Lstcitta = New System.Windows.Forms.ListBox()
        Me.Lstabitanti = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lstcitta
        '
        Me.Lstcitta.FormattingEnabled = True
        Me.Lstcitta.ItemHeight = 30
        Me.Lstcitta.Location = New System.Drawing.Point(12, 12)
        Me.Lstcitta.Name = "Lstcitta"
        Me.Lstcitta.Size = New System.Drawing.Size(156, 304)
        Me.Lstcitta.TabIndex = 0
        '
        'Lstabitanti
        '
        Me.Lstabitanti.Enabled = False
        Me.Lstabitanti.FormattingEnabled = True
        Me.Lstabitanti.ItemHeight = 30
        Me.Lstabitanti.Location = New System.Drawing.Point(174, 12)
        Me.Lstabitanti.Name = "Lstabitanti"
        Me.Lstabitanti.Size = New System.Drawing.Size(156, 304)
        Me.Lstabitanti.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 78)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aggiungi città"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(174, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 78)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Rimuovi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(19, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 78)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Media"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 406)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 78)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Città con più abitanti"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(19, 490)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(304, 78)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Visualizza le città in ordine crescente"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1354, 876)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lstabitanti)
        Me.Controls.Add(Me.Lstcitta)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Città"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lstcitta As ListBox
    Friend WithEvents Lstabitanti As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
