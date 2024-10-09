<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTicket
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
        picTicket = New PictureBox()
        lblHeading = New Label()
        lblNumberOfFare = New Label()
        lblTicketCost = New Label()
        lblCost = New Label()
        txtFare = New TextBox()
        btnDisplayCost = New Button()
        btnClear = New Button()
        grpTicketType = New GroupBox()
        radZone5 = New RadioButton()
        radZone6 = New RadioButton()
        radZone3 = New RadioButton()
        CType(picTicket, ComponentModel.ISupportInitialize).BeginInit()
        grpTicketType.SuspendLayout()
        SuspendLayout()
        ' 
        ' picTicket
        ' 
        picTicket.Dock = DockStyle.Top
        picTicket.Image = My.Resources.Resources.tickets
        picTicket.Location = New Point(0, 0)
        picTicket.Margin = New Padding(3, 4, 3, 4)
        picTicket.Name = "picTicket"
        picTicket.Size = New Size(723, 216)
        picTicket.SizeMode = PictureBoxSizeMode.StretchImage
        picTicket.TabIndex = 0
        picTicket.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.OrangeRed
        lblHeading.Location = New Point(248, 244)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(227, 25)
        lblHeading.TabIndex = 1
        lblHeading.Text = "London Tube Tickets"
        ' 
        ' lblNumberOfFare
        ' 
        lblNumberOfFare.AutoSize = True
        lblNumberOfFare.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumberOfFare.ForeColor = Color.OrangeRed
        lblNumberOfFare.Location = New Point(214, 305)
        lblNumberOfFare.Name = "lblNumberOfFare"
        lblNumberOfFare.Size = New Size(251, 23)
        lblNumberOfFare.TabIndex = 2
        lblNumberOfFare.Text = "Number of single-fare ticket:"
        ' 
        ' lblTicketCost
        ' 
        lblTicketCost.AutoSize = True
        lblTicketCost.Font = New Font("Tahoma", 14.25F)
        lblTicketCost.ForeColor = Color.OrangeRed
        lblTicketCost.Location = New Point(274, 473)
        lblTicketCost.Name = "lblTicketCost"
        lblTicketCost.Size = New Size(107, 23)
        lblTicketCost.TabIndex = 3
        lblTicketCost.Text = "Ticket Cost:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 14.25F)
        lblCost.ForeColor = Color.Black
        lblCost.Location = New Point(399, 473)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(45, 23)
        lblCost.TabIndex = 4
        lblCost.Text = "Cost"
        ' 
        ' txtFare
        ' 
        txtFare.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFare.Location = New Point(470, 302)
        txtFare.Margin = New Padding(3, 4, 3, 4)
        txtFare.Name = "txtFare"
        txtFare.Size = New Size(39, 30)
        txtFare.TabIndex = 5
        txtFare.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnDisplayCost
        ' 
        btnDisplayCost.BackColor = Color.LightGray
        btnDisplayCost.Location = New Point(226, 510)
        btnDisplayCost.Margin = New Padding(3, 4, 3, 4)
        btnDisplayCost.Name = "btnDisplayCost"
        btnDisplayCost.Size = New Size(99, 28)
        btnDisplayCost.TabIndex = 6
        btnDisplayCost.Text = "Display Cost"
        btnDisplayCost.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Location = New Point(399, 510)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(99, 28)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' grpTicketType
        ' 
        grpTicketType.BackColor = Color.OrangeRed
        grpTicketType.Controls.Add(radZone5)
        grpTicketType.Controls.Add(radZone6)
        grpTicketType.Controls.Add(radZone3)
        grpTicketType.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpTicketType.ForeColor = Color.Silver
        grpTicketType.Location = New Point(275, 353)
        grpTicketType.Name = "grpTicketType"
        grpTicketType.Size = New Size(200, 117)
        grpTicketType.TabIndex = 8
        grpTicketType.TabStop = False
        grpTicketType.Text = "Tickets Type"
        ' 
        ' radZone5
        ' 
        radZone5.AutoSize = True
        radZone5.Location = New Point(6, 53)
        radZone5.Name = "radZone5"
        radZone5.Size = New Size(150, 22)
        radZone5.TabIndex = 2
        radZone5.Text = "Zone 1-5 : $6.51"
        radZone5.UseVisualStyleBackColor = True
        ' 
        ' radZone6
        ' 
        radZone6.AutoSize = True
        radZone6.Location = New Point(6, 81)
        radZone6.Name = "radZone6"
        radZone6.Size = New Size(150, 22)
        radZone6.TabIndex = 1
        radZone6.Text = "Zone 1-6 : $6.62"
        radZone6.UseVisualStyleBackColor = True
        ' 
        ' radZone3
        ' 
        radZone3.AutoSize = True
        radZone3.Checked = True
        radZone3.Location = New Point(6, 25)
        radZone3.Name = "radZone3"
        radZone3.Size = New Size(150, 22)
        radZone3.TabIndex = 0
        radZone3.TabStop = True
        radZone3.Text = "Zone 1-3 : $5.40"
        radZone3.UseVisualStyleBackColor = True
        ' 
        ' frmTicket
        ' 
        AcceptButton = btnDisplayCost
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        CancelButton = btnClear
        ClientSize = New Size(723, 577)
        Controls.Add(grpTicketType)
        Controls.Add(btnClear)
        Controls.Add(btnDisplayCost)
        Controls.Add(txtFare)
        Controls.Add(lblCost)
        Controls.Add(lblTicketCost)
        Controls.Add(lblNumberOfFare)
        Controls.Add(lblHeading)
        Controls.Add(picTicket)
        Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmTicket"
        Text = "London Tube Tickets"
        CType(picTicket, ComponentModel.ISupportInitialize).EndInit()
        grpTicketType.ResumeLayout(False)
        grpTicketType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picTicket As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumberOfFare As Label
    Friend WithEvents lblTicketCost As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtFare As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpTicketType As GroupBox
    Friend WithEvents radZone5 As RadioButton
    Friend WithEvents radZone6 As RadioButton
    Friend WithEvents radZone3 As RadioButton

End Class
