Imports System

Namespace CustomAlertBoxDemo
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            button1 = New System.Windows.Forms.Button()
            button2 = New System.Windows.Forms.Button()
            button3 = New System.Windows.Forms.Button()
            button4 = New System.Windows.Forms.Button()
            label1 = New System.Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' button1
            ' 
            button1.BackColor = Drawing.Color.SeaGreen
            button1.FlatAppearance.BorderSize = 0
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            button1.ForeColor = Drawing.Color.White
            button1.Location = New Drawing.Point(169, 101)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(204, 58)
            button1.TabIndex = 0
            button1.Text = "Success"
            button1.UseVisualStyleBackColor = False
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.BackColor = Drawing.Color.OrangeRed
            button2.FlatAppearance.BorderSize = 0
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            button2.ForeColor = Drawing.Color.White
            button2.Location = New Drawing.Point(169, 165)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(204, 58)
            button2.TabIndex = 0
            button2.Text = "Warning"
            button2.UseVisualStyleBackColor = False
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' button3
            ' 
            button3.BackColor = Drawing.Color.DarkRed
            button3.FlatAppearance.BorderSize = 0
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            button3.ForeColor = Drawing.Color.White
            button3.Location = New Drawing.Point(169, 229)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(204, 58)
            button3.TabIndex = 0
            button3.Text = "Error"
            button3.UseVisualStyleBackColor = False
            AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
            ' 
            ' button4
            ' 
            button4.BackColor = Drawing.Color.RoyalBlue
            button4.FlatAppearance.BorderSize = 0
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            button4.ForeColor = Drawing.Color.White
            button4.Location = New Drawing.Point(169, 293)
            button4.Name = "button4"
            button4.Size = New Drawing.Size(204, 58)
            button4.TabIndex = 0
            button4.Text = "info"
            button4.UseVisualStyleBackColor = False
            AddHandler button4.Click, New EventHandler(AddressOf button4_Click)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(180, 35)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(174, 25)
            label1.TabIndex = 1
            label1.Text = "C# Ui Academy"
            ' 
            ' Form1
            ' 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            ClientSize = New Drawing.Size(555, 413)
            Controls.Add(label1)
            Controls.Add(button4)
            Controls.Add(button3)
            Controls.Add(button2)
            Controls.Add(button1)
            Name = "Form1"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Form1"
            ResumeLayout(False)
            PerformLayout()
        End Sub

        ' TODO ERROR: Skipped EndRegionDirectiveTrivia 
        Private button1 As System.Windows.Forms.Button
        Private button2 As System.Windows.Forms.Button
        Private button3 As System.Windows.Forms.Button
        Private button4 As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace
