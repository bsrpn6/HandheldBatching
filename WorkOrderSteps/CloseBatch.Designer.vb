﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseBatch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoBtn = New System.Windows.Forms.Button()
        Me.YesBtn = New System.Windows.Forms.Button()
        Me.WorkOrderNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RecipeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BatchSizeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecipeDescTxtBox = New System.Windows.Forms.TextBox()
        Me.BatchStartTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 57)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Would you like to mark " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the following work " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "order as complete?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoBtn
        '
        Me.NoBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBtn.Location = New System.Drawing.Point(115, 252)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(75, 25)
        Me.NoBtn.TabIndex = 49
        Me.NoBtn.Text = "No"
        Me.NoBtn.UseVisualStyleBackColor = False
        '
        'YesBtn
        '
        Me.YesBtn.BackColor = System.Drawing.SystemColors.Control
        Me.YesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesBtn.Location = New System.Drawing.Point(35, 252)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(75, 25)
        Me.YesBtn.TabIndex = 48
        Me.YesBtn.Text = "Yes"
        Me.YesBtn.UseVisualStyleBackColor = False
        '
        'WorkOrderNumberTxtBox
        '
        Me.WorkOrderNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderNumberTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderNumberTxtBox.Location = New System.Drawing.Point(120, 104)
        Me.WorkOrderNumberTxtBox.Name = "WorkOrderNumberTxtBox"
        Me.WorkOrderNumberTxtBox.ReadOnly = True
        Me.WorkOrderNumberTxtBox.Size = New System.Drawing.Size(95, 19)
        Me.WorkOrderNumberTxtBox.TabIndex = 51
        Me.WorkOrderNumberTxtBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Work Order:"
        '
        'RecipeTxtBox
        '
        Me.RecipeTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeTxtBox.Location = New System.Drawing.Point(86, 123)
        Me.RecipeTxtBox.Name = "RecipeTxtBox"
        Me.RecipeTxtBox.ReadOnly = True
        Me.RecipeTxtBox.Size = New System.Drawing.Size(129, 19)
        Me.RecipeTxtBox.TabIndex = 53
        Me.RecipeTxtBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Recipe:"
        '
        'BatchSizeTxtBox
        '
        Me.BatchSizeTxtBox.BackColor = System.Drawing.Color.Black
        Me.BatchSizeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BatchSizeTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSizeTxtBox.ForeColor = System.Drawing.Color.White
        Me.BatchSizeTxtBox.Location = New System.Drawing.Point(66, 161)
        Me.BatchSizeTxtBox.Name = "BatchSizeTxtBox"
        Me.BatchSizeTxtBox.ReadOnly = True
        Me.BatchSizeTxtBox.Size = New System.Drawing.Size(149, 19)
        Me.BatchSizeTxtBox.TabIndex = 57
        Me.BatchSizeTxtBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Size:"
        '
        'RecipeDescTxtBox
        '
        Me.RecipeDescTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeDescTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeDescTxtBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeDescTxtBox.ForeColor = System.Drawing.Color.Yellow
        Me.RecipeDescTxtBox.Location = New System.Drawing.Point(3, 144)
        Me.RecipeDescTxtBox.Name = "RecipeDescTxtBox"
        Me.RecipeDescTxtBox.ReadOnly = True
        Me.RecipeDescTxtBox.Size = New System.Drawing.Size(218, 15)
        Me.RecipeDescTxtBox.TabIndex = 58
        Me.RecipeDescTxtBox.TabStop = False
        Me.RecipeDescTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BatchStartTxtBox
        '
        Me.BatchStartTxtBox.BackColor = System.Drawing.Color.Black
        Me.BatchStartTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BatchStartTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchStartTxtBox.ForeColor = System.Drawing.Color.White
        Me.BatchStartTxtBox.Location = New System.Drawing.Point(66, 180)
        Me.BatchStartTxtBox.Name = "BatchStartTxtBox"
        Me.BatchStartTxtBox.ReadOnly = True
        Me.BatchStartTxtBox.Size = New System.Drawing.Size(149, 19)
        Me.BatchStartTxtBox.TabIndex = 60
        Me.BatchStartTxtBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Start:"
        '
        'CloseBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.BatchStartTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RecipeDescTxtBox)
        Me.Controls.Add(Me.BatchSizeTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RecipeTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WorkOrderNumberTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CloseBatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NoBtn As System.Windows.Forms.Button
    Friend WithEvents YesBtn As System.Windows.Forms.Button
    Friend WithEvents WorkOrderNumberTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RecipeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BatchSizeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RecipeDescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents BatchStartTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
