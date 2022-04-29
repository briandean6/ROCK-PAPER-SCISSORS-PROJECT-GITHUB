<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.picComp = New System.Windows.Forms.PictureBox()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        CType(Me.picComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(222, 52)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(92, 17)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "COMPUTER"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(318, 503)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(91, 17)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Press button"
        '
        'picComp
        '
        Me.picComp.Location = New System.Drawing.Point(222, 73)
        Me.picComp.Margin = New System.Windows.Forms.Padding(4)
        Me.picComp.Name = "picComp"
        Me.picComp.Size = New System.Drawing.Size(253, 216)
        Me.picComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComp.TabIndex = 2
        Me.picComp.TabStop = False
        '
        'picRock
        '
        Me.picRock.Image = CType(resources.GetObject("picRock.Image"), System.Drawing.Image)
        Me.picRock.Location = New System.Drawing.Point(96, 339)
        Me.picRock.Margin = New System.Windows.Forms.Padding(4)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(170, 110)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRock.TabIndex = 3
        Me.picRock.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = CType(resources.GetObject("picPaper.Image"), System.Drawing.Image)
        Me.picPaper.Location = New System.Drawing.Point(452, 339)
        Me.picPaper.Margin = New System.Windows.Forms.Padding(4)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(170, 110)
        Me.picPaper.TabIndex = 4
        Me.picPaper.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = CType(resources.GetObject("picScissors.Image"), System.Drawing.Image)
        Me.picScissors.Location = New System.Drawing.Point(274, 339)
        Me.picScissors.Margin = New System.Windows.Forms.Padding(4)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(170, 110)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScissors.TabIndex = 5
        Me.picScissors.TabStop = False
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(132, 456)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(98, 44)
        Me.btnRock.TabIndex = 6
        Me.btnRock.Text = "1"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.Location = New System.Drawing.Point(311, 456)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(98, 44)
        Me.btnScissors.TabIndex = 7
        Me.btnScissors.Text = "2"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Location = New System.Drawing.Point(490, 456)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(98, 44)
        Me.btnPaper.TabIndex = 8
        Me.btnPaper.Text = "3"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SCORE: "
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPoints.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPoints.Location = New System.Drawing.Point(152, 9)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(2, 31)
        Me.lblPoints.TabIndex = 10
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(299, 296)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(122, 36)
        Me.btnPlayAgain.TabIndex = 11
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 526)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picRock)
        Me.Controls.Add(Me.picComp)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lbl1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        CType(Me.picComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents picComp As PictureBox
    Friend WithEvents picRock As PictureBox
    Friend WithEvents picPaper As PictureBox
    Friend WithEvents picScissors As PictureBox
    Friend WithEvents btnRock As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents btnPaper As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnPlayAgain As Button
End Class
