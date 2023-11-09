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
        Me.ComboBoxCarBrand = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCarModel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxCarbrand = New System.Windows.Forms.PictureBox()
        Me.ButtonCompute = New System.Windows.Forms.Button()
        Me.TextBoxTotalprice = New System.Windows.Forms.TextBox()
        Me.TextBoxYearstopay = New System.Windows.Forms.TextBox()
        Me.TextBoxAnnualinterest = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxMonthlydues = New System.Windows.Forms.TextBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBoxCar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxCarbrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCarBrand
        '
        Me.ComboBoxCarBrand.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxCarBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarBrand.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCarBrand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxCarBrand.FormattingEnabled = True
        Me.ComboBoxCarBrand.Location = New System.Drawing.Point(32, 44)
        Me.ComboBoxCarBrand.Name = "ComboBoxCarBrand"
        Me.ComboBoxCarBrand.Size = New System.Drawing.Size(180, 30)
        Me.ComboBoxCarBrand.TabIndex = 0
        '
        'ComboBoxCarModel
        '
        Me.ComboBoxCarModel.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarModel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCarModel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxCarModel.FormattingEnabled = True
        Me.ComboBoxCarModel.Location = New System.Drawing.Point(32, 114)
        Me.ComboBoxCarModel.Name = "ComboBoxCarModel"
        Me.ComboBoxCarModel.Size = New System.Drawing.Size(180, 30)
        Me.ComboBoxCarModel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(34, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Car Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(34, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Car Model"
        '
        'PictureBoxCarbrand
        '
        Me.PictureBoxCarbrand.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxCarbrand.Location = New System.Drawing.Point(425, 44)
        Me.PictureBoxCarbrand.Name = "PictureBoxCarbrand"
        Me.PictureBoxCarbrand.Size = New System.Drawing.Size(146, 100)
        Me.PictureBoxCarbrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCarbrand.TabIndex = 4
        Me.PictureBoxCarbrand.TabStop = False
        '
        'ButtonCompute
        '
        Me.ButtonCompute.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCompute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCompute.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonCompute.Location = New System.Drawing.Point(238, 44)
        Me.ButtonCompute.Name = "ButtonCompute"
        Me.ButtonCompute.Size = New System.Drawing.Size(151, 30)
        Me.ButtonCompute.TabIndex = 5
        Me.ButtonCompute.Text = "COMPUTE"
        Me.ButtonCompute.UseVisualStyleBackColor = False
        '
        'TextBoxTotalprice
        '
        Me.TextBoxTotalprice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTotalprice.Enabled = False
        Me.TextBoxTotalprice.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalprice.Location = New System.Drawing.Point(212, 349)
        Me.TextBoxTotalprice.Name = "TextBoxTotalprice"
        Me.TextBoxTotalprice.Size = New System.Drawing.Size(174, 25)
        Me.TextBoxTotalprice.TabIndex = 6
        '
        'TextBoxYearstopay
        '
        Me.TextBoxYearstopay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxYearstopay.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxYearstopay.Location = New System.Drawing.Point(212, 201)
        Me.TextBoxYearstopay.Name = "TextBoxYearstopay"
        Me.TextBoxYearstopay.Size = New System.Drawing.Size(120, 25)
        Me.TextBoxYearstopay.TabIndex = 7
        Me.TextBoxYearstopay.Text = "Input Year"
        '
        'TextBoxAnnualinterest
        '
        Me.TextBoxAnnualinterest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxAnnualinterest.Enabled = False
        Me.TextBoxAnnualinterest.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAnnualinterest.Location = New System.Drawing.Point(212, 300)
        Me.TextBoxAnnualinterest.Name = "TextBoxAnnualinterest"
        Me.TextBoxAnnualinterest.Size = New System.Drawing.Size(104, 25)
        Me.TextBoxAnnualinterest.TabIndex = 8
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPrice.Enabled = False
        Me.TextBoxPrice.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrice.Location = New System.Drawing.Point(212, 250)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(174, 25)
        Me.TextBoxPrice.TabIndex = 9
        '
        'TextBoxMonthlydues
        '
        Me.TextBoxMonthlydues.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMonthlydues.Enabled = False
        Me.TextBoxMonthlydues.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMonthlydues.Location = New System.Drawing.Point(212, 400)
        Me.TextBoxMonthlydues.Name = "TextBoxMonthlydues"
        Me.TextBoxMonthlydues.Size = New System.Drawing.Size(174, 25)
        Me.TextBoxMonthlydues.TabIndex = 10
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Transparent
        Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReset.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.ForeColor = System.Drawing.Color.Black
        Me.ButtonReset.Location = New System.Drawing.Point(238, 114)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(151, 30)
        Me.ButtonReset.TabIndex = 11
        Me.ButtonReset.Text = "RESET"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(138, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(25, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Enter Year's Pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(36, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Annual Interest:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(84, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(52, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Monthly Dues:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(322, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "%"
        '
        'PictureBoxCar
        '
        Me.PictureBoxCar.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxCar.Location = New System.Drawing.Point(425, 200)
        Me.PictureBoxCar.Name = "PictureBoxCar"
        Me.PictureBoxCar.Size = New System.Drawing.Size(320, 174)
        Me.PictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCar.TabIndex = 18
        Me.PictureBoxCar.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Midterm_Program.My.Resources.Resources.anime_car_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PictureBoxCar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.TextBoxMonthlydues)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxAnnualinterest)
        Me.Controls.Add(Me.TextBoxYearstopay)
        Me.Controls.Add(Me.TextBoxTotalprice)
        Me.Controls.Add(Me.ButtonCompute)
        Me.Controls.Add(Me.PictureBoxCarbrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxCarModel)
        Me.Controls.Add(Me.ComboBoxCarBrand)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automotive Transaction"
        CType(Me.PictureBoxCarbrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCarBrand As ComboBox
    Friend WithEvents ComboBoxCarModel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxCarbrand As PictureBox
    Friend WithEvents ButtonCompute As Button
    Friend WithEvents TextBoxTotalprice As TextBox
    Friend WithEvents TextBoxYearstopay As TextBox
    Friend WithEvents TextBoxAnnualinterest As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxMonthlydues As TextBox
    Friend WithEvents ButtonReset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBoxCar As PictureBox
End Class
