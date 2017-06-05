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
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.userInputBox = New System.Windows.Forms.TextBox()
        Me.dayOfTheWeekBox = New System.Windows.Forms.TextBox()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clearBtn
        '
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.clearBtn.Location = New System.Drawing.Point(12, 133)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(95, 39)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Cle&ar"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Location = New System.Drawing.Point(113, 133)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(95, 39)
        Me.exitBtn.TabIndex = 3
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'userInputBox
        '
        Me.userInputBox.Location = New System.Drawing.Point(14, 19)
        Me.userInputBox.Name = "userInputBox"
        Me.userInputBox.Size = New System.Drawing.Size(193, 20)
        Me.userInputBox.TabIndex = 0
        Me.userInputBox.Text = "Enter a number"
        '
        'dayOfTheWeekBox
        '
        Me.dayOfTheWeekBox.Location = New System.Drawing.Point(14, 67)
        Me.dayOfTheWeekBox.Name = "dayOfTheWeekBox"
        Me.dayOfTheWeekBox.ReadOnly = True
        Me.dayOfTheWeekBox.Size = New System.Drawing.Size(193, 20)
        Me.dayOfTheWeekBox.TabIndex = 5
        Me.dayOfTheWeekBox.TabStop = False
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(12, 97)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(195, 30)
        Me.calculateBtn.TabIndex = 1
        Me.calculateBtn.Text = "&Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matching Day of the Week"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.exitBtn
        Me.ClientSize = New System.Drawing.Size(219, 201)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.dayOfTheWeekBox)
        Me.Controls.Add(Me.userInputBox)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Day of the Week Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clearBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents userInputBox As TextBox
    Friend WithEvents dayOfTheWeekBox As TextBox
    Friend WithEvents calculateBtn As Button
    Friend WithEvents Label1 As Label
End Class
