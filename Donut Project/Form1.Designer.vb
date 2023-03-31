<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpDonuts = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.grpCoffee = New System.Windows.Forms.GroupBox()
        Me.radCappucino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpDonuts.SuspendLayout()
        Me.grpCoffee.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDonuts
        '
        Me.grpDonuts.Controls.Add(Me.radFilled)
        Me.grpDonuts.Controls.Add(Me.radChocolate)
        Me.grpDonuts.Controls.Add(Me.radSugar)
        Me.grpDonuts.Controls.Add(Me.radGlazed)
        Me.grpDonuts.Location = New System.Drawing.Point(38, 40)
        Me.grpDonuts.Name = "grpDonuts"
        Me.grpDonuts.Size = New System.Drawing.Size(200, 168)
        Me.grpDonuts.TabIndex = 0
        Me.grpDonuts.TabStop = False
        Me.grpDonuts.Text = "Donuts"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(7, 133)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(103, 20)
        Me.radFilled.TabIndex = 3
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(6, 95)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(131, 20)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "Chocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(7, 57)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(106, 20)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(7, 22)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(113, 20)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'grpCoffee
        '
        Me.grpCoffee.Controls.Add(Me.radCappucino)
        Me.grpCoffee.Controls.Add(Me.radRegular)
        Me.grpCoffee.Controls.Add(Me.radNone)
        Me.grpCoffee.Location = New System.Drawing.Point(38, 230)
        Me.grpCoffee.Name = "grpCoffee"
        Me.grpCoffee.Size = New System.Drawing.Size(200, 122)
        Me.grpCoffee.TabIndex = 4
        Me.grpCoffee.TabStop = False
        Me.grpCoffee.Text = "Coffee"
        '
        'radCappucino
        '
        Me.radCappucino.AutoSize = True
        Me.radCappucino.Location = New System.Drawing.Point(7, 96)
        Me.radCappucino.Name = "radCappucino"
        Me.radCappucino.Size = New System.Drawing.Size(135, 20)
        Me.radCappucino.TabIndex = 2
        Me.radCappucino.TabStop = True
        Me.radCappucino.Text = "Cappucino ($2.75)"
        Me.radCappucino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(7, 57)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(118, 20)
        Me.radRegular.TabIndex = 1
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(7, 22)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(61, 20)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Subtotal: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sales Tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Due:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(115, 32)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(75, 29)
        Me.lblSubtotal.TabIndex = 8
        '
        'lblSales
        '
        Me.lblSales.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSales.Location = New System.Drawing.Point(115, 67)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(75, 29)
        Me.lblSales.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(115, 105)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 29)
        Me.lblTotal.TabIndex = 10
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(324, 264)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(107, 30)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 300)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 28)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblSales)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 170)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 377)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpCoffee)
        Me.Controls.Add(Me.grpDonuts)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.grpDonuts.ResumeLayout(False)
        Me.grpDonuts.PerformLayout()
        Me.grpCoffee.ResumeLayout(False)
        Me.grpCoffee.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDonuts As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents grpCoffee As GroupBox
    Friend WithEvents radCappucino As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
