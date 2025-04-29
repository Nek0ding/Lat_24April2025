<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        ListBox1 = New ListBox()
        label_nama = New Label()
        label_harga = New Label()
        label_total = New Label()
        btn_pilih = New Button()
        btn_exit = New Button()
        Label2 = New Label()
        input_jumlah = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(252, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 25)
        Label1.TabIndex = 0
        Label1.Text = "DAFTAR HARGA BUKU DAN MAJALAH TOKO"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(73, 96)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(219, 304)
        ListBox1.TabIndex = 1
        ' 
        ' label_nama
        ' 
        label_nama.BackColor = SystemColors.ControlDarkDark
        label_nama.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label_nama.ForeColor = SystemColors.ActiveCaption
        label_nama.Location = New Point(319, 96)
        label_nama.Name = "label_nama"
        label_nama.Size = New Size(400, 47)
        label_nama.TabIndex = 2
        ' 
        ' label_harga
        ' 
        label_harga.BackColor = SystemColors.ControlDarkDark
        label_harga.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label_harga.ForeColor = SystemColors.ActiveCaption
        label_harga.Location = New Point(319, 178)
        label_harga.Name = "label_harga"
        label_harga.Size = New Size(400, 45)
        label_harga.TabIndex = 3
        ' 
        ' label_total
        ' 
        label_total.BackColor = SystemColors.ControlDarkDark
        label_total.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label_total.ForeColor = SystemColors.ActiveCaption
        label_total.Location = New Point(319, 259)
        label_total.Name = "label_total"
        label_total.Size = New Size(400, 43)
        label_total.TabIndex = 4
        label_total.Text = "Total Harga :"
        ' 
        ' btn_pilih
        ' 
        btn_pilih.Location = New Point(73, 469)
        btn_pilih.Name = "btn_pilih"
        btn_pilih.Size = New Size(112, 34)
        btn_pilih.TabIndex = 5
        btn_pilih.Text = "Pilih"
        btn_pilih.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.Location = New Point(216, 469)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(112, 34)
        btn_exit.TabIndex = 6
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 418)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 25)
        Label2.TabIndex = 7
        Label2.Text = "Jumlah"
        ' 
        ' input_jumlah
        ' 
        input_jumlah.Location = New Point(178, 418)
        input_jumlah.Name = "input_jumlah"
        input_jumlah.Size = New Size(150, 31)
        input_jumlah.TabIndex = 8
        input_jumlah.Text = "1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 544)
        Controls.Add(input_jumlah)
        Controls.Add(Label2)
        Controls.Add(btn_exit)
        Controls.Add(btn_pilih)
        Controls.Add(label_total)
        Controls.Add(label_harga)
        Controls.Add(label_nama)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents label_nama As Label
    Friend WithEvents label_harga As Label
    Friend WithEvents label_total As Label
    Friend WithEvents btn_pilih As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents input_jumlah As TextBox

End Class
