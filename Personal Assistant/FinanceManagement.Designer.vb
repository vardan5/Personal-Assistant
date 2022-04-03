<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinanceManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.FinManagementL = New System.Windows.Forms.Label()
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddTransactionB = New System.Windows.Forms.Button()
        Me.ViewTransactionB = New System.Windows.Forms.Button()
        Me.ViewAccountsB = New System.Windows.Forms.Button()
        Me.SoonB = New System.Windows.Forms.Button()
        Me.AddTransactionL = New System.Windows.Forms.Label()
        Me.ViewTransactionL = New System.Windows.Forms.Label()
        Me.ViewAccountsL = New System.Windows.Forms.Label()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.AddTransactionPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransactionDateGB = New System.Windows.Forms.GroupBox()
        Me.TransactionDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.AccountGB = New System.Windows.Forms.GroupBox()
        Me.AccountCB = New System.Windows.Forms.ComboBox()
        Me.CatagoryGB = New System.Windows.Forms.GroupBox()
        Me.CatagoryCB = New System.Windows.Forms.ComboBox()
        Me.DescriptionGB = New System.Windows.Forms.GroupBox()
        Me.DescriptionTB = New System.Windows.Forms.TextBox()
        Me.AmountGB = New System.Windows.Forms.GroupBox()
        Me.AmountTB = New System.Windows.Forms.TextBox()
        Me.TransactionTypeGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DebitRB = New System.Windows.Forms.RadioButton()
        Me.CreditRB = New System.Windows.Forms.RadioButton()
        Me.TitlePanel.SuspendLayout()
        Me.BasePanel.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.AddTransactionPanel.SuspendLayout()
        Me.TransactionDateGB.SuspendLayout()
        Me.AccountGB.SuspendLayout()
        Me.CatagoryGB.SuspendLayout()
        Me.DescriptionGB.SuspendLayout()
        Me.AmountGB.SuspendLayout()
        Me.TransactionTypeGB.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.BackColor = System.Drawing.Color.BlueViolet
        Me.TitlePanel.Controls.Add(Me.FinManagementL)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(959, 71)
        Me.TitlePanel.TabIndex = 2
        '
        'FinManagementL
        '
        Me.FinManagementL.AutoSize = True
        Me.FinManagementL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinManagementL.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinManagementL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FinManagementL.Location = New System.Drawing.Point(22, 10)
        Me.FinManagementL.Name = "FinManagementL"
        Me.FinManagementL.Size = New System.Drawing.Size(405, 54)
        Me.FinManagementL.TabIndex = 0
        Me.FinManagementL.Text = "Finance Management"
        '
        'BasePanel
        '
        Me.BasePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BasePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BasePanel.Controls.Add(Me.Splitter1)
        Me.BasePanel.Controls.Add(Me.ButtonPanel)
        Me.BasePanel.Controls.Add(Me.AnimationPanel)
        Me.BasePanel.Location = New System.Drawing.Point(3, 80)
        Me.BasePanel.Name = "BasePanel"
        Me.BasePanel.Size = New System.Drawing.Size(959, 585)
        Me.BasePanel.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.BlueViolet
        Me.Splitter1.Location = New System.Drawing.Point(600, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 585)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(600, 585)
        Me.ButtonPanel.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AddTransactionB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTransactionB, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewAccountsB, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SoonB, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddTransactionL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTransactionL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewAccountsL, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 585)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'AddTransactionB
        '
        Me.AddTransactionB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTransactionB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.AddTransactionB
        Me.AddTransactionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddTransactionB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.AddTransactionB.FlatAppearance.BorderSize = 2
        Me.AddTransactionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.AddTransactionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTransactionB.Location = New System.Drawing.Point(93, 90)
        Me.AddTransactionB.Name = "AddTransactionB"
        Me.AddTransactionB.Size = New System.Drawing.Size(162, 157)
        Me.AddTransactionB.TabIndex = 2
        Me.AddTransactionB.UseVisualStyleBackColor = True
        '
        'ViewTransactionB
        '
        Me.ViewTransactionB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTransactionB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.ViewTransactionB
        Me.ViewTransactionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewTransactionB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.ViewTransactionB.FlatAppearance.BorderSize = 2
        Me.ViewTransactionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.ViewTransactionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionB.Location = New System.Drawing.Point(345, 90)
        Me.ViewTransactionB.Name = "ViewTransactionB"
        Me.ViewTransactionB.Size = New System.Drawing.Size(162, 157)
        Me.ViewTransactionB.TabIndex = 2
        Me.ViewTransactionB.UseVisualStyleBackColor = True
        '
        'ViewAccountsB
        '
        Me.ViewAccountsB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewAccountsB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.ViewAccountsB1
        Me.ViewAccountsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewAccountsB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.ViewAccountsB.FlatAppearance.BorderSize = 2
        Me.ViewAccountsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.ViewAccountsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewAccountsB.Location = New System.Drawing.Point(93, 334)
        Me.ViewAccountsB.Name = "ViewAccountsB"
        Me.ViewAccountsB.Size = New System.Drawing.Size(162, 157)
        Me.ViewAccountsB.TabIndex = 2
        Me.ViewAccountsB.UseVisualStyleBackColor = True
        '
        'SoonB
        '
        Me.SoonB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoonB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.SoonB.FlatAppearance.BorderSize = 2
        Me.SoonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.SoonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoonB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SoonB.ForeColor = System.Drawing.Color.White
        Me.SoonB.Location = New System.Drawing.Point(345, 334)
        Me.SoonB.Name = "SoonB"
        Me.SoonB.Size = New System.Drawing.Size(162, 157)
        Me.SoonB.TabIndex = 2
        Me.SoonB.Text = "COMING SOON"
        Me.SoonB.UseVisualStyleBackColor = True
        '
        'AddTransactionL
        '
        Me.AddTransactionL.AutoSize = True
        Me.AddTransactionL.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddTransactionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTransactionL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddTransactionL.ForeColor = System.Drawing.Color.BlueViolet
        Me.AddTransactionL.Location = New System.Drawing.Point(93, 250)
        Me.AddTransactionL.Name = "AddTransactionL"
        Me.AddTransactionL.Size = New System.Drawing.Size(162, 70)
        Me.AddTransactionL.TabIndex = 3
        Me.AddTransactionL.Text = "Add Transaction"
        Me.AddTransactionL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewTransactionL
        '
        Me.ViewTransactionL.AutoSize = True
        Me.ViewTransactionL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewTransactionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewTransactionL.ForeColor = System.Drawing.Color.BlueViolet
        Me.ViewTransactionL.Location = New System.Drawing.Point(345, 250)
        Me.ViewTransactionL.Name = "ViewTransactionL"
        Me.ViewTransactionL.Size = New System.Drawing.Size(162, 70)
        Me.ViewTransactionL.TabIndex = 4
        Me.ViewTransactionL.Text = "View Transaction"
        Me.ViewTransactionL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewAccountsL
        '
        Me.ViewAccountsL.AutoSize = True
        Me.ViewAccountsL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewAccountsL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewAccountsL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewAccountsL.ForeColor = System.Drawing.Color.BlueViolet
        Me.ViewAccountsL.Location = New System.Drawing.Point(93, 494)
        Me.ViewAccountsL.Name = "ViewAccountsL"
        Me.ViewAccountsL.Size = New System.Drawing.Size(162, 70)
        Me.ViewAccountsL.TabIndex = 5
        Me.ViewAccountsL.Text = "View Accounts"
        Me.ViewAccountsL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnimationPanel
        '
        Me.AnimationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(0, 0)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(959, 585)
        Me.AnimationPanel.TabIndex = 4
        '
        'AddTransactionPanel
        '
        Me.AddTransactionPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTransactionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AddTransactionPanel.Controls.Add(Me.Button1)
        Me.AddTransactionPanel.Controls.Add(Me.TransactionDateGB)
        Me.AddTransactionPanel.Controls.Add(Me.AccountGB)
        Me.AddTransactionPanel.Controls.Add(Me.CatagoryGB)
        Me.AddTransactionPanel.Controls.Add(Me.DescriptionGB)
        Me.AddTransactionPanel.Controls.Add(Me.AmountGB)
        Me.AddTransactionPanel.Controls.Add(Me.TransactionTypeGB)
        Me.AddTransactionPanel.Location = New System.Drawing.Point(3, 80)
        Me.AddTransactionPanel.Name = "AddTransactionPanel"
        Me.AddTransactionPanel.Size = New System.Drawing.Size(959, 585)
        Me.AddTransactionPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.AddTransactionB
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(776, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 132)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransactionDateGB
        '
        Me.TransactionDateGB.Controls.Add(Me.TransactionDatePicker)
        Me.TransactionDateGB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransactionDateGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.TransactionDateGB.Location = New System.Drawing.Point(369, 31)
        Me.TransactionDateGB.Name = "TransactionDateGB"
        Me.TransactionDateGB.Size = New System.Drawing.Size(365, 151)
        Me.TransactionDateGB.TabIndex = 7
        Me.TransactionDateGB.TabStop = False
        Me.TransactionDateGB.Text = "Transaction Date"
        '
        'TransactionDatePicker
        '
        Me.TransactionDatePicker.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TransactionDatePicker.Location = New System.Drawing.Point(32, 68)
        Me.TransactionDatePicker.Name = "TransactionDatePicker"
        Me.TransactionDatePicker.Size = New System.Drawing.Size(296, 43)
        Me.TransactionDatePicker.TabIndex = 8
        '
        'AccountGB
        '
        Me.AccountGB.Controls.Add(Me.AccountCB)
        Me.AccountGB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AccountGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.AccountGB.Location = New System.Drawing.Point(369, 207)
        Me.AccountGB.Name = "AccountGB"
        Me.AccountGB.Size = New System.Drawing.Size(365, 151)
        Me.AccountGB.TabIndex = 5
        Me.AccountGB.TabStop = False
        Me.AccountGB.Text = "Account"
        '
        'AccountCB
        '
        Me.AccountCB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AccountCB.FormattingEnabled = True
        Me.AccountCB.Location = New System.Drawing.Point(26, 68)
        Me.AccountCB.Name = "AccountCB"
        Me.AccountCB.Size = New System.Drawing.Size(302, 45)
        Me.AccountCB.TabIndex = 6
        '
        'CatagoryGB
        '
        Me.CatagoryGB.Controls.Add(Me.CatagoryCB)
        Me.CatagoryGB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CatagoryGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.CatagoryGB.Location = New System.Drawing.Point(24, 396)
        Me.CatagoryGB.Name = "CatagoryGB"
        Me.CatagoryGB.Size = New System.Drawing.Size(321, 151)
        Me.CatagoryGB.TabIndex = 5
        Me.CatagoryGB.TabStop = False
        Me.CatagoryGB.Text = "Catagory"
        '
        'CatagoryCB
        '
        Me.CatagoryCB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatagoryCB.FormattingEnabled = True
        Me.CatagoryCB.Location = New System.Drawing.Point(26, 68)
        Me.CatagoryCB.Name = "CatagoryCB"
        Me.CatagoryCB.Size = New System.Drawing.Size(281, 45)
        Me.CatagoryCB.TabIndex = 6
        '
        'DescriptionGB
        '
        Me.DescriptionGB.Controls.Add(Me.DescriptionTB)
        Me.DescriptionGB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.DescriptionGB.Location = New System.Drawing.Point(369, 396)
        Me.DescriptionGB.Name = "DescriptionGB"
        Me.DescriptionGB.Size = New System.Drawing.Size(365, 151)
        Me.DescriptionGB.TabIndex = 3
        Me.DescriptionGB.TabStop = False
        Me.DescriptionGB.Text = "Description"
        '
        'DescriptionTB
        '
        Me.DescriptionTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionTB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionTB.Location = New System.Drawing.Point(26, 70)
        Me.DescriptionTB.Name = "DescriptionTB"
        Me.DescriptionTB.Size = New System.Drawing.Size(302, 36)
        Me.DescriptionTB.TabIndex = 4
        '
        'AmountGB
        '
        Me.AmountGB.Controls.Add(Me.AmountTB)
        Me.AmountGB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AmountGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.AmountGB.Location = New System.Drawing.Point(22, 207)
        Me.AmountGB.Name = "AmountGB"
        Me.AmountGB.Size = New System.Drawing.Size(323, 151)
        Me.AmountGB.TabIndex = 3
        Me.AmountGB.TabStop = False
        Me.AmountGB.Text = "Amount"
        '
        'AmountTB
        '
        Me.AmountTB.BackColor = System.Drawing.Color.BlueViolet
        Me.AmountTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmountTB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountTB.Location = New System.Drawing.Point(26, 70)
        Me.AmountTB.Name = "AmountTB"
        Me.AmountTB.Size = New System.Drawing.Size(283, 36)
        Me.AmountTB.TabIndex = 4
        '
        'TransactionTypeGB
        '
        Me.TransactionTypeGB.BackColor = System.Drawing.Color.BlueViolet
        Me.TransactionTypeGB.Controls.Add(Me.PictureBox1)
        Me.TransactionTypeGB.Controls.Add(Me.DebitRB)
        Me.TransactionTypeGB.Controls.Add(Me.CreditRB)
        Me.TransactionTypeGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionTypeGB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransactionTypeGB.ForeColor = System.Drawing.Color.Gold
        Me.TransactionTypeGB.Location = New System.Drawing.Point(22, 31)
        Me.TransactionTypeGB.Name = "TransactionTypeGB"
        Me.TransactionTypeGB.Size = New System.Drawing.Size(323, 151)
        Me.TransactionTypeGB.TabIndex = 2
        Me.TransactionTypeGB.TabStop = False
        Me.TransactionTypeGB.Text = "Transaction Type"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(173, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 90)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DebitRB
        '
        Me.DebitRB.AutoSize = True
        Me.DebitRB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DebitRB.ForeColor = System.Drawing.Color.White
        Me.DebitRB.Location = New System.Drawing.Point(26, 94)
        Me.DebitRB.Name = "DebitRB"
        Me.DebitRB.Size = New System.Drawing.Size(105, 42)
        Me.DebitRB.TabIndex = 0
        Me.DebitRB.TabStop = True
        Me.DebitRB.Text = "Debit"
        Me.DebitRB.UseVisualStyleBackColor = True
        '
        'CreditRB
        '
        Me.CreditRB.AutoSize = True
        Me.CreditRB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreditRB.ForeColor = System.Drawing.Color.White
        Me.CreditRB.Location = New System.Drawing.Point(26, 46)
        Me.CreditRB.Name = "CreditRB"
        Me.CreditRB.Size = New System.Drawing.Size(112, 42)
        Me.CreditRB.TabIndex = 0
        Me.CreditRB.TabStop = True
        Me.CreditRB.Text = "Credit"
        Me.CreditRB.UseVisualStyleBackColor = True
        '
        'FinanceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.Controls.Add(Me.AddTransactionPanel)
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.DoubleBuffered = True
        Me.Name = "FinanceManagement"
        Me.Size = New System.Drawing.Size(965, 665)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.BasePanel.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.AddTransactionPanel.ResumeLayout(False)
        Me.TransactionDateGB.ResumeLayout(False)
        Me.AccountGB.ResumeLayout(False)
        Me.CatagoryGB.ResumeLayout(False)
        Me.DescriptionGB.ResumeLayout(False)
        Me.DescriptionGB.PerformLayout()
        Me.AmountGB.ResumeLayout(False)
        Me.AmountGB.PerformLayout()
        Me.TransactionTypeGB.ResumeLayout(False)
        Me.TransactionTypeGB.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents FinManagementL As Label
    Friend WithEvents BasePanel As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AddTransactionB As Button
    Friend WithEvents ViewTransactionB As Button
    Friend WithEvents ViewAccountsB As Button
    Friend WithEvents SoonB As Button
    Friend WithEvents AddTransactionL As Label
    Friend WithEvents ViewTransactionL As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents ViewAccountsL As Label
    Friend WithEvents AddTransactionPanel As Panel
    Friend WithEvents DebitRB As RadioButton
    Friend WithEvents CreditRB As RadioButton
    Friend WithEvents TransactionTypeGB As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TransactionDateGB As GroupBox
    Friend WithEvents TransactionDatePicker As DateTimePicker
    Friend WithEvents AccountGB As GroupBox
    Friend WithEvents AccountCB As ComboBox
    Friend WithEvents CatagoryGB As GroupBox
    Friend WithEvents CatagoryCB As ComboBox
    Friend WithEvents DescriptionGB As GroupBox
    Friend WithEvents DescriptionTB As TextBox
    Friend WithEvents AmountGB As GroupBox
    Friend WithEvents AmountTB As TextBox
End Class
