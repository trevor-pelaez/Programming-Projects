<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCampusMusicCafePerformance
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.lblEventInformation = New System.Windows.Forms.Label()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(144, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(513, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Campus Music Cafe Open Mic Night"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(170, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 159)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(342, 275)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(106, 29)
        Me.btnDate.TabIndex = 2
        Me.btnDate.Text = "View Details"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'lblEventInformation
        '
        Me.lblEventInformation.AutoSize = True
        Me.lblEventInformation.Location = New System.Drawing.Point(271, 349)
        Me.lblEventInformation.Name = "lblEventInformation"
        Me.lblEventInformation.Size = New System.Drawing.Size(0, 20)
        Me.lblEventInformation.TabIndex = 3
        '
        'btnExitWindow
        '
        Me.btnExitWindow.Location = New System.Drawing.Point(342, 474)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(106, 29)
        Me.btnExitWindow.TabIndex = 5
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = True
        '
        'lblFooter
        '
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Location = New System.Drawing.Point(37, 515)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(96, 20)
        Me.lblFooter.TabIndex = 6
        Me.lblFooter.Text = "Trevor Pelaez"
        '
        'frmCampusMusicCafePerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.lblFooter)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.lblEventInformation)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCampusMusicCafePerformance"
        Me.Text = "Campus Music Cafe Performance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDate As Button
    Friend WithEvents lblEventInformation As Label
    Friend WithEvents btnExitWindow As Button
    Friend WithEvents lblFooter As Label
End Class
