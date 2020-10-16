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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.קובץToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.יציאהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרותToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.יוצרהתוכנהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CpsTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioGold2Cps = New System.Windows.Forms.RadioButton()
        Me.RadioCps2Gold = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.קובץToolStripMenuItem, Me.הגדרותToolStripMenuItem, Me.יוצרהתוכנהToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(302, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'קובץToolStripMenuItem
        '
        Me.קובץToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.יציאהToolStripMenuItem})
        Me.קובץToolStripMenuItem.Name = "קובץToolStripMenuItem"
        Me.קובץToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.קובץToolStripMenuItem.Text = "קובץ"
        '
        'יציאהToolStripMenuItem
        '
        Me.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem"
        Me.יציאהToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.יציאהToolStripMenuItem.Text = "יציאה"
        '
        'הגדרותToolStripMenuItem
        '
        Me.הגדרותToolStripMenuItem.Name = "הגדרותToolStripMenuItem"
        Me.הגדרותToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.הגדרותToolStripMenuItem.Text = "הגדרות"
        '
        'יוצרהתוכנהToolStripMenuItem
        '
        Me.יוצרהתוכנהToolStripMenuItem.Name = "יוצרהתוכנהToolStripMenuItem"
        Me.יוצרהתוכנהToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.יוצרהתוכנהToolStripMenuItem.Text = "יוצר התוכנה"
        '
        'GoldTxt
        '
        Me.GoldTxt.Location = New System.Drawing.Point(12, 50)
        Me.GoldTxt.Name = "GoldTxt"
        Me.GoldTxt.Size = New System.Drawing.Size(127, 20)
        Me.GoldTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "כמות Cps:"
        '
        'CpsTxt
        '
        Me.CpsTxt.Location = New System.Drawing.Point(164, 50)
        Me.CpsTxt.Name = "CpsTxt"
        Me.CpsTxt.Size = New System.Drawing.Size(127, 20)
        Me.CpsTxt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "כמות זהב:"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "חשב לי"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(12, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(124, 98)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "שווה לי לקנות?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioGold2Cps
        '
        Me.RadioGold2Cps.AutoSize = True
        Me.RadioGold2Cps.Location = New System.Drawing.Point(202, 150)
        Me.RadioGold2Cps.Name = "RadioGold2Cps"
        Me.RadioGold2Cps.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioGold2Cps.Size = New System.Drawing.Size(75, 17)
        Me.RadioGold2Cps.TabIndex = 8
        Me.RadioGold2Cps.TabStop = True
        Me.RadioGold2Cps.Text = "זהב ל-Cps"
        Me.RadioGold2Cps.UseVisualStyleBackColor = True
        '
        'RadioCps2Gold
        '
        Me.RadioCps2Gold.AutoSize = True
        Me.RadioCps2Gold.Location = New System.Drawing.Point(202, 173)
        Me.RadioCps2Gold.Name = "RadioCps2Gold"
        Me.RadioCps2Gold.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioCps2Gold.Size = New System.Drawing.Size(75, 17)
        Me.RadioCps2Gold.TabIndex = 9
        Me.RadioCps2Gold.TabStop = True
        Me.RadioCps2Gold.Text = "Cps ל-זהב"
        Me.RadioCps2Gold.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 202)
        Me.Controls.Add(Me.RadioCps2Gold)
        Me.Controls.Add(Me.RadioGold2Cps)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CpsTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoldTxt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Conquer Gold <-> Cps Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents קובץToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents יציאהToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents הגדרותToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents יוצרהתוכנהToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoldTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CpsTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioGold2Cps As RadioButton
    Friend WithEvents RadioCps2Gold As RadioButton
End Class
