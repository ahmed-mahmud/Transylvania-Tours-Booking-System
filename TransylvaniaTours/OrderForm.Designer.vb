<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnPurchase = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CoachTypeDrop = New System.Windows.Forms.ComboBox()
        Me.TourLengthDrop = New System.Windows.Forms.ComboBox()
        Me.CheckBoxBran = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLiberty = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPeles = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTurda = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnCalculate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.ForeColor = System.Drawing.Color.White
        Me.BtnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCalculate.Location = New System.Drawing.Point(405, 254)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(113, 30)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'BtnPurchase
        '
        Me.BtnPurchase.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnPurchase.Enabled = False
        Me.BtnPurchase.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPurchase.ForeColor = System.Drawing.Color.White
        Me.BtnPurchase.Image = CType(resources.GetObject("BtnPurchase.Image"), System.Drawing.Image)
        Me.BtnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPurchase.Location = New System.Drawing.Point(524, 254)
        Me.BtnPurchase.Name = "BtnPurchase"
        Me.BtnPurchase.Size = New System.Drawing.Size(127, 30)
        Me.BtnPurchase.TabIndex = 1
        Me.BtnPurchase.Text = "Purchase"
        Me.BtnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPurchase.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Coach Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total:"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBoxTotal.Location = New System.Drawing.Point(480, 197)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxTotal.TabIndex = 4
        Me.TextBoxTotal.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tour Length"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Optional Sightseeing"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 143)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CoachTypeDrop
        '
        Me.CoachTypeDrop.FormattingEnabled = True
        Me.CoachTypeDrop.Location = New System.Drawing.Point(43, 65)
        Me.CoachTypeDrop.Name = "CoachTypeDrop"
        Me.CoachTypeDrop.Size = New System.Drawing.Size(250, 21)
        Me.CoachTypeDrop.TabIndex = 8
        Me.CoachTypeDrop.Text = "Select coach type..."
        '
        'TourLengthDrop
        '
        Me.TourLengthDrop.FormattingEnabled = True
        Me.TourLengthDrop.Location = New System.Drawing.Point(43, 139)
        Me.TourLengthDrop.Name = "TourLengthDrop"
        Me.TourLengthDrop.Size = New System.Drawing.Size(250, 21)
        Me.TourLengthDrop.TabIndex = 9
        Me.TourLengthDrop.Text = "Select your tour length..."
        '
        'CheckBoxBran
        '
        Me.CheckBoxBran.AutoSize = True
        Me.CheckBoxBran.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxBran.Location = New System.Drawing.Point(43, 229)
        Me.CheckBoxBran.Name = "CheckBoxBran"
        Me.CheckBoxBran.Size = New System.Drawing.Size(96, 22)
        Me.CheckBoxBran.TabIndex = 10
        Me.CheckBoxBran.Text = "Bran Castle"
        Me.CheckBoxBran.UseVisualStyleBackColor = True
        '
        'CheckBoxLiberty
        '
        Me.CheckBoxLiberty.AutoSize = True
        Me.CheckBoxLiberty.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLiberty.Location = New System.Drawing.Point(156, 229)
        Me.CheckBoxLiberty.Name = "CheckBoxLiberty"
        Me.CheckBoxLiberty.Size = New System.Drawing.Size(137, 22)
        Me.CheckBoxLiberty.TabIndex = 11
        Me.CheckBoxLiberty.Text = "Liberty Sanctuary"
        Me.CheckBoxLiberty.UseVisualStyleBackColor = True
        '
        'CheckBoxPeles
        '
        Me.CheckBoxPeles.AutoSize = True
        Me.CheckBoxPeles.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPeles.Location = New System.Drawing.Point(43, 262)
        Me.CheckBoxPeles.Name = "CheckBoxPeles"
        Me.CheckBoxPeles.Size = New System.Drawing.Size(99, 22)
        Me.CheckBoxPeles.TabIndex = 12
        Me.CheckBoxPeles.Text = "Peles Castle"
        Me.CheckBoxPeles.UseVisualStyleBackColor = True
        '
        'CheckBoxTurda
        '
        Me.CheckBoxTurda.AutoSize = True
        Me.CheckBoxTurda.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTurda.Location = New System.Drawing.Point(156, 262)
        Me.CheckBoxTurda.Name = "CheckBoxTurda"
        Me.CheckBoxTurda.Size = New System.Drawing.Size(126, 22)
        Me.CheckBoxTurda.TabIndex = 13
        Me.CheckBoxTurda.Text = "Turda Salt Mine"
        Me.CheckBoxTurda.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(457, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "€"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 311)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBoxTurda)
        Me.Controls.Add(Me.CheckBoxPeles)
        Me.Controls.Add(Me.CheckBoxLiberty)
        Me.Controls.Add(Me.CheckBoxBran)
        Me.Controls.Add(Me.TourLengthDrop)
        Me.Controls.Add(Me.CoachTypeDrop)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPurchase)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 350)
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transylvania Tours - Order Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents BtnPurchase As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CoachTypeDrop As System.Windows.Forms.ComboBox
    Friend WithEvents TourLengthDrop As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxBran As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLiberty As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPeles As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTurda As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
