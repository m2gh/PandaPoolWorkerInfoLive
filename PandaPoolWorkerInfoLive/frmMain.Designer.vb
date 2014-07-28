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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtUserAddress = New System.Windows.Forms.TextBox()
        Me.lstvUserInfo = New System.Windows.Forms.ListView()
        Me.chdrWorkers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdrDifficulty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdrHashrate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTmp = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbX11 = New System.Windows.Forms.RadioButton()
        Me.rdbScrypt = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkbAutoupdate = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalKHS = New System.Windows.Forms.Label()
        Me.lnklblPandapool = New System.Windows.Forms.LinkLabel()
        Me.lnklblBitcointalk = New System.Windows.Forms.LinkLabel()
        Me.lblDetail = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUserAddress
        '
        Me.txtUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtUserAddress.Location = New System.Drawing.Point(131, 44)
        Me.txtUserAddress.Name = "txtUserAddress"
        Me.txtUserAddress.Size = New System.Drawing.Size(299, 22)
        Me.txtUserAddress.TabIndex = 0
        '
        'lstvUserInfo
        '
        Me.lstvUserInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstvUserInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdrWorkers, Me.chdrDifficulty, Me.chdrHashrate})
        Me.lstvUserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstvUserInfo.Location = New System.Drawing.Point(12, 118)
        Me.lstvUserInfo.MultiSelect = False
        Me.lstvUserInfo.Name = "lstvUserInfo"
        Me.lstvUserInfo.ShowGroups = False
        Me.lstvUserInfo.Size = New System.Drawing.Size(418, 140)
        Me.lstvUserInfo.TabIndex = 1
        Me.lstvUserInfo.UseCompatibleStateImageBehavior = False
        Me.lstvUserInfo.View = System.Windows.Forms.View.Details
        '
        'chdrWorkers
        '
        Me.chdrWorkers.Text = "Workers"
        Me.chdrWorkers.Width = 190
        '
        'chdrDifficulty
        '
        Me.chdrDifficulty.Text = "Difficulty"
        Me.chdrDifficulty.Width = 110
        '
        'chdrHashrate
        '
        Me.chdrHashrate.Text = "Hashrate"
        Me.chdrHashrate.Width = 110
        '
        'txtTmp
        '
        Me.txtTmp.Enabled = False
        Me.txtTmp.Location = New System.Drawing.Point(12, 328)
        Me.txtTmp.Multiline = True
        Me.txtTmp.Name = "txtTmp"
        Me.txtTmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTmp.Size = New System.Drawing.Size(779, 272)
        Me.txtTmp.TabIndex = 2
        Me.txtTmp.Text = "{""result"":{""workers"":[[""dad1"",""1510"",""10547""],[""dad2"",""1902"",""10779""],[""mom1"",""91" & _
    "6"",""14967""],[""mom2"",""2085"",""15559""],[""mom3"",""2422"",""13732""]]}}"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbX11)
        Me.GroupBox1.Controls.Add(Me.rdbScrypt)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 36)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pool"
        '
        'rdbX11
        '
        Me.rdbX11.AutoSize = True
        Me.rdbX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rdbX11.Location = New System.Drawing.Point(67, 13)
        Me.rdbX11.Name = "rdbX11"
        Me.rdbX11.Size = New System.Drawing.Size(46, 20)
        Me.rdbX11.TabIndex = 1
        Me.rdbX11.Text = "x11"
        Me.rdbX11.UseVisualStyleBackColor = True
        '
        'rdbScrypt
        '
        Me.rdbScrypt.AutoSize = True
        Me.rdbScrypt.Checked = True
        Me.rdbScrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rdbScrypt.Location = New System.Drawing.Point(6, 13)
        Me.rdbScrypt.Name = "rdbScrypt"
        Me.rdbScrypt.Size = New System.Drawing.Size(64, 20)
        Me.rdbScrypt.TabIndex = 0
        Me.rdbScrypt.TabStop = True
        Me.rdbScrypt.Text = "Scrypt"
        Me.rdbScrypt.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkbAutoupdate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 37)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autoupdate"
        '
        'chkbAutoupdate
        '
        Me.chkbAutoupdate.AutoSize = True
        Me.chkbAutoupdate.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkbAutoupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkbAutoupdate.Location = New System.Drawing.Point(6, 14)
        Me.chkbAutoupdate.Name = "chkbAutoupdate"
        Me.chkbAutoupdate.Size = New System.Drawing.Size(82, 20)
        Me.chkbAutoupdate.TabIndex = 0
        Me.chkbAutoupdate.Text = "Disabled"
        Me.chkbAutoupdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(442, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.DonateToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ExitToolStripMenuItem.Text = "Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'lblTotalKHS
        '
        Me.lblTotalKHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTotalKHS.Location = New System.Drawing.Point(134, 80)
        Me.lblTotalKHS.Name = "lblTotalKHS"
        Me.lblTotalKHS.Size = New System.Drawing.Size(269, 29)
        Me.lblTotalKHS.TabIndex = 6
        '
        'lnklblPandapool
        '
        Me.lnklblPandapool.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnklblPandapool.AutoSize = True
        Me.lnklblPandapool.Location = New System.Drawing.Point(310, 260)
        Me.lnklblPandapool.Name = "lnklblPandapool"
        Me.lnklblPandapool.Size = New System.Drawing.Size(101, 13)
        Me.lnklblPandapool.TabIndex = 7
        Me.lnklblPandapool.TabStop = True
        Me.lnklblPandapool.Text = "multi.pandapool.info"
        '
        'lnklblBitcointalk
        '
        Me.lnklblBitcointalk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnklblBitcointalk.AutoSize = True
        Me.lnklblBitcointalk.Location = New System.Drawing.Point(12, 260)
        Me.lnklblBitcointalk.Name = "lnklblBitcointalk"
        Me.lnklblBitcointalk.Size = New System.Drawing.Size(142, 13)
        Me.lnklblBitcointalk.TabIndex = 8
        Me.lnklblBitcointalk.TabStop = True
        Me.lnklblBitcointalk.Text = "Pandacoin on bitcointalk.org"
        '
        'lblDetail
        '
        Me.lblDetail.Location = New System.Drawing.Point(406, 89)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(24, 24)
        Me.lblDetail.TabIndex = 9
        Me.lblDetail.Text = "˄"
        Me.lblDetail.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 278)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.lnklblBitcointalk)
        Me.Controls.Add(Me.lnklblPandapool)
        Me.Controls.Add(Me.lblTotalKHS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTmp)
        Me.Controls.Add(Me.lstvUserInfo)
        Me.Controls.Add(Me.txtUserAddress)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserAddress As System.Windows.Forms.TextBox
    Friend WithEvents lstvUserInfo As System.Windows.Forms.ListView
    Friend WithEvents chdrWorkers As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdrDifficulty As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdrHashrate As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTmp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbX11 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbScrypt As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkbAutoupdate As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTotalKHS As System.Windows.Forms.Label
    Friend WithEvents lnklblPandapool As System.Windows.Forms.LinkLabel
    Friend WithEvents lnklblBitcointalk As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDetail As System.Windows.Forms.Button

End Class
