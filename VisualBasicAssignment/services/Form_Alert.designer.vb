Imports System
Imports System.ComponentModel

Namespace CustomAlertBoxDemo
    Public Partial Class Form_Alert
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname>true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso TypeOf components Is Object Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        ' TODO ERROR: Skipped RegionDirectiveTrivia 
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Alert))
            Me.lblMsg = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblMsg
            '
            Me.lblMsg.AutoSize = True
            Me.lblMsg.ForeColor = System.Drawing.Color.White
            Me.lblMsg.Location = New System.Drawing.Point(65, 22)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New System.Drawing.Size(96, 17)
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "Message Text"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(12, 13)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(41, 39)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 2
            Me.pictureBox1.TabStop = False
            '
            'pictureBox2
            '
            Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
            Me.pictureBox2.Location = New System.Drawing.Point(298, 22)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(26, 30)
            Me.pictureBox2.TabIndex = 3
            Me.pictureBox2.TabStop = False
            '
            'Form_Alert
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.BackColor = System.Drawing.SystemColors.Highlight
            Me.ClientSize = New System.Drawing.Size(347, 74)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.lblMsg)
            Me.Name = "Form_Alert"
            Me.Text = "Form_Alert"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        ' TODO ERROR: Skipped EndRegionDirectiveTrivia 
        Private lblMsg As System.Windows.Forms.Label
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Friend timer1 As System.Windows.Forms.Timer
        Private pictureBox2 As System.Windows.Forms.PictureBox
    End Class
End Namespace
