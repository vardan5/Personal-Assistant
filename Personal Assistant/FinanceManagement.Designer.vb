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
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.HomeTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.AddTransactionB = New System.Windows.Forms.Button()
        Me.ViewTransactionB = New System.Windows.Forms.Button()
        Me.ViewAccountsB = New System.Windows.Forms.Button()
        Me.SoonB = New System.Windows.Forms.Button()
        Me.AddTransactionL = New System.Windows.Forms.Label()
        Me.ViewTransactionL = New System.Windows.Forms.Label()
        Me.ViewAccountsL = New System.Windows.Forms.Label()
        Me.AddTransactionTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransactionDateGB = New System.Windows.Forms.GroupBox()
        Me.TransactionDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.TransactionTypeGB = New System.Windows.Forms.GroupBox()
        Me.DebitRB = New System.Windows.Forms.RadioButton()
        Me.CreditRB = New System.Windows.Forms.RadioButton()
        Me.AccountGB = New System.Windows.Forms.GroupBox()
        Me.AccountCB = New System.Windows.Forms.ComboBox()
        Me.DescriptionGB = New System.Windows.Forms.GroupBox()
        Me.DescriptionTB = New System.Windows.Forms.TextBox()
        Me.AmountGB = New System.Windows.Forms.GroupBox()
        Me.AmountTB = New System.Windows.Forms.TextBox()
        Me.CatagoryGB = New System.Windows.Forms.GroupBox()
        Me.CatagoryCB = New System.Windows.Forms.ComboBox()
        Me.CancelTransactionB = New System.Windows.Forms.Button()
        Me.HorizondalSplitPanel = New System.Windows.Forms.Panel()
        Me.HButtonPanel = New System.Windows.Forms.Panel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.DataPanel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TitlePanel.SuspendLayout()
        Me.BasePanel.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.HomeTableLayout.SuspendLayout()
        Me.AddTransactionTableLayout.SuspendLayout()
        Me.TransactionDateGB.SuspendLayout()
        Me.TransactionTypeGB.SuspendLayout()
        Me.AccountGB.SuspendLayout()
        Me.DescriptionGB.SuspendLayout()
        Me.AmountGB.SuspendLayout()
        Me.CatagoryGB.SuspendLayout()
        Me.HorizondalSplitPanel.SuspendLayout()
        Me.HButtonPanel.SuspendLayout()
        Me.DataPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TitlePanel.Size = New System.Drawing.Size(900, 71)
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
        Me.BasePanel.Controls.Add(Me.AnimationPanel)
        Me.BasePanel.Controls.Add(Me.Splitter1)
        Me.BasePanel.Controls.Add(Me.ButtonPanel)
        Me.BasePanel.Location = New System.Drawing.Point(3, 80)
        Me.BasePanel.Name = "BasePanel"
        Me.BasePanel.Size = New System.Drawing.Size(900, 585)
        Me.BasePanel.TabIndex = 3
        '
        'AnimationPanel
        '
        Me.AnimationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(658, 0)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(242, 585)
        Me.AnimationPanel.TabIndex = 4
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.BlueViolet
        Me.Splitter1.Location = New System.Drawing.Point(650, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 585)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.HomeTableLayout)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonPanel.MinimumSize = New System.Drawing.Size(650, 0)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(650, 585)
        Me.ButtonPanel.TabIndex = 4
        '
        'HomeTableLayout
        '
        Me.HomeTableLayout.ColumnCount = 5
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.HomeTableLayout.Controls.Add(Me.AddTransactionB, 1, 1)
        Me.HomeTableLayout.Controls.Add(Me.ViewTransactionB, 3, 1)
        Me.HomeTableLayout.Controls.Add(Me.ViewAccountsB, 1, 3)
        Me.HomeTableLayout.Controls.Add(Me.SoonB, 3, 3)
        Me.HomeTableLayout.Controls.Add(Me.AddTransactionL, 1, 2)
        Me.HomeTableLayout.Controls.Add(Me.ViewTransactionL, 3, 2)
        Me.HomeTableLayout.Controls.Add(Me.ViewAccountsL, 1, 4)
        Me.HomeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.HomeTableLayout.Name = "HomeTableLayout"
        Me.HomeTableLayout.RowCount = 5
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.HomeTableLayout.Size = New System.Drawing.Size(650, 585)
        Me.HomeTableLayout.TabIndex = 1
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
        Me.AddTransactionB.Location = New System.Drawing.Point(100, 90)
        Me.AddTransactionB.Name = "AddTransactionB"
        Me.AddTransactionB.Size = New System.Drawing.Size(176, 157)
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
        Me.ViewTransactionB.Location = New System.Drawing.Point(373, 90)
        Me.ViewTransactionB.Name = "ViewTransactionB"
        Me.ViewTransactionB.Size = New System.Drawing.Size(176, 157)
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
        Me.ViewAccountsB.Location = New System.Drawing.Point(100, 334)
        Me.ViewAccountsB.Name = "ViewAccountsB"
        Me.ViewAccountsB.Size = New System.Drawing.Size(176, 157)
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
        Me.SoonB.Location = New System.Drawing.Point(373, 334)
        Me.SoonB.Name = "SoonB"
        Me.SoonB.Size = New System.Drawing.Size(176, 157)
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
        Me.AddTransactionL.Location = New System.Drawing.Point(100, 250)
        Me.AddTransactionL.Name = "AddTransactionL"
        Me.AddTransactionL.Size = New System.Drawing.Size(176, 70)
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
        Me.ViewTransactionL.Location = New System.Drawing.Point(373, 250)
        Me.ViewTransactionL.Name = "ViewTransactionL"
        Me.ViewTransactionL.Size = New System.Drawing.Size(176, 70)
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
        Me.ViewAccountsL.Location = New System.Drawing.Point(100, 494)
        Me.ViewAccountsL.Name = "ViewAccountsL"
        Me.ViewAccountsL.Size = New System.Drawing.Size(176, 70)
        Me.ViewAccountsL.TabIndex = 5
        Me.ViewAccountsL.Text = "View Accounts"
        Me.ViewAccountsL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddTransactionTableLayout
        '
        Me.AddTransactionTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddTransactionTableLayout.ColumnCount = 7
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.0!))
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0!))
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.AddTransactionTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.AddTransactionTableLayout.Controls.Add(Me.Button1, 5, 1)
        Me.AddTransactionTableLayout.Controls.Add(Me.TransactionDateGB, 3, 1)
        Me.AddTransactionTableLayout.Controls.Add(Me.TransactionTypeGB, 1, 1)
        Me.AddTransactionTableLayout.Controls.Add(Me.AccountGB, 3, 3)
        Me.AddTransactionTableLayout.Controls.Add(Me.DescriptionGB, 3, 5)
        Me.AddTransactionTableLayout.Controls.Add(Me.AmountGB, 1, 3)
        Me.AddTransactionTableLayout.Controls.Add(Me.CatagoryGB, 1, 5)
        Me.AddTransactionTableLayout.Controls.Add(Me.CancelTransactionB, 5, 5)
        Me.AddTransactionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddTransactionTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.AddTransactionTableLayout.Name = "AddTransactionTableLayout"
        Me.AddTransactionTableLayout.RowCount = 7
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.AddTransactionTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.AddTransactionTableLayout.Size = New System.Drawing.Size(900, 340)
        Me.AddTransactionTableLayout.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.AddTransactionB
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(714, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 92)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransactionDateGB
        '
        Me.TransactionDateGB.Controls.Add(Me.TransactionDatePicker)
        Me.TransactionDateGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDateGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionDateGB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransactionDateGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.TransactionDateGB.Location = New System.Drawing.Point(336, 14)
        Me.TransactionDateGB.Name = "TransactionDateGB"
        Me.TransactionDateGB.Size = New System.Drawing.Size(345, 92)
        Me.TransactionDateGB.TabIndex = 7
        Me.TransactionDateGB.TabStop = False
        Me.TransactionDateGB.Text = "Transaction Date"
        '
        'TransactionDatePicker
        '
        Me.TransactionDatePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransactionDatePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TransactionDatePicker.Location = New System.Drawing.Point(26, 40)
        Me.TransactionDatePicker.Name = "TransactionDatePicker"
        Me.TransactionDatePicker.Size = New System.Drawing.Size(211, 34)
        Me.TransactionDatePicker.TabIndex = 8
        '
        'TransactionTypeGB
        '
        Me.TransactionTypeGB.Controls.Add(Me.DebitRB)
        Me.TransactionTypeGB.Controls.Add(Me.CreditRB)
        Me.TransactionTypeGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionTypeGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionTypeGB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransactionTypeGB.ForeColor = System.Drawing.Color.Gold
        Me.TransactionTypeGB.Location = New System.Drawing.Point(30, 14)
        Me.TransactionTypeGB.Name = "TransactionTypeGB"
        Me.TransactionTypeGB.Size = New System.Drawing.Size(273, 92)
        Me.TransactionTypeGB.TabIndex = 2
        Me.TransactionTypeGB.TabStop = False
        Me.TransactionTypeGB.Text = "Transaction Type"
        '
        'DebitRB
        '
        Me.DebitRB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DebitRB.AutoSize = True
        Me.DebitRB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DebitRB.ForeColor = System.Drawing.Color.White
        Me.DebitRB.Location = New System.Drawing.Point(136, 38)
        Me.DebitRB.Name = "DebitRB"
        Me.DebitRB.Size = New System.Drawing.Size(81, 32)
        Me.DebitRB.TabIndex = 0
        Me.DebitRB.TabStop = True
        Me.DebitRB.Text = "Debit"
        Me.DebitRB.UseVisualStyleBackColor = True
        '
        'CreditRB
        '
        Me.CreditRB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CreditRB.AutoSize = True
        Me.CreditRB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreditRB.ForeColor = System.Drawing.Color.White
        Me.CreditRB.Location = New System.Drawing.Point(26, 38)
        Me.CreditRB.Name = "CreditRB"
        Me.CreditRB.Size = New System.Drawing.Size(86, 32)
        Me.CreditRB.TabIndex = 0
        Me.CreditRB.TabStop = True
        Me.CreditRB.Text = "Credit"
        Me.CreditRB.UseVisualStyleBackColor = True
        '
        'AccountGB
        '
        Me.AccountGB.Controls.Add(Me.AccountCB)
        Me.AccountGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountGB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AccountGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.AccountGB.Location = New System.Drawing.Point(336, 122)
        Me.AccountGB.Name = "AccountGB"
        Me.AccountGB.Size = New System.Drawing.Size(345, 92)
        Me.AccountGB.TabIndex = 5
        Me.AccountGB.TabStop = False
        Me.AccountGB.Text = "Account"
        '
        'AccountCB
        '
        Me.AccountCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountCB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AccountCB.FormattingEnabled = True
        Me.AccountCB.Location = New System.Drawing.Point(26, 39)
        Me.AccountCB.Name = "AccountCB"
        Me.AccountCB.Size = New System.Drawing.Size(211, 36)
        Me.AccountCB.TabIndex = 6
        '
        'DescriptionGB
        '
        Me.DescriptionGB.Controls.Add(Me.DescriptionTB)
        Me.DescriptionGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionGB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.DescriptionGB.Location = New System.Drawing.Point(336, 230)
        Me.DescriptionGB.Name = "DescriptionGB"
        Me.DescriptionGB.Size = New System.Drawing.Size(345, 92)
        Me.DescriptionGB.TabIndex = 3
        Me.DescriptionGB.TabStop = False
        Me.DescriptionGB.Text = "Description"
        '
        'DescriptionTB
        '
        Me.DescriptionTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionTB.Location = New System.Drawing.Point(26, 48)
        Me.DescriptionTB.Name = "DescriptionTB"
        Me.DescriptionTB.Size = New System.Drawing.Size(211, 27)
        Me.DescriptionTB.TabIndex = 4
        '
        'AmountGB
        '
        Me.AmountGB.Controls.Add(Me.AmountTB)
        Me.AmountGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmountGB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AmountGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.AmountGB.Location = New System.Drawing.Point(30, 122)
        Me.AmountGB.Name = "AmountGB"
        Me.AmountGB.Size = New System.Drawing.Size(273, 92)
        Me.AmountGB.TabIndex = 3
        Me.AmountGB.TabStop = False
        Me.AmountGB.Text = "Amount"
        '
        'AmountTB
        '
        Me.AmountTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmountTB.BackColor = System.Drawing.Color.BlueViolet
        Me.AmountTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmountTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountTB.Location = New System.Drawing.Point(26, 39)
        Me.AmountTB.Name = "AmountTB"
        Me.AmountTB.Size = New System.Drawing.Size(220, 27)
        Me.AmountTB.TabIndex = 4
        '
        'CatagoryGB
        '
        Me.CatagoryGB.Controls.Add(Me.CatagoryCB)
        Me.CatagoryGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatagoryGB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CatagoryGB.ForeColor = System.Drawing.Color.BlueViolet
        Me.CatagoryGB.Location = New System.Drawing.Point(30, 230)
        Me.CatagoryGB.Name = "CatagoryGB"
        Me.CatagoryGB.Size = New System.Drawing.Size(273, 92)
        Me.CatagoryGB.TabIndex = 5
        Me.CatagoryGB.TabStop = False
        Me.CatagoryGB.Text = "Catagory"
        '
        'CatagoryCB
        '
        Me.CatagoryCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CatagoryCB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatagoryCB.FormattingEnabled = True
        Me.CatagoryCB.Location = New System.Drawing.Point(26, 40)
        Me.CatagoryCB.Name = "CatagoryCB"
        Me.CatagoryCB.Size = New System.Drawing.Size(220, 36)
        Me.CatagoryCB.TabIndex = 6
        '
        'CancelTransactionB
        '
        Me.CancelTransactionB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.CancelTransaction
        Me.CancelTransactionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelTransactionB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelTransactionB.FlatAppearance.BorderSize = 0
        Me.CancelTransactionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.CancelTransactionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelTransactionB.Location = New System.Drawing.Point(714, 230)
        Me.CancelTransactionB.Name = "CancelTransactionB"
        Me.CancelTransactionB.Size = New System.Drawing.Size(156, 92)
        Me.CancelTransactionB.TabIndex = 9
        Me.CancelTransactionB.UseVisualStyleBackColor = True
        '
        'HorizondalSplitPanel
        '
        Me.HorizondalSplitPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HorizondalSplitPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HorizondalSplitPanel.Controls.Add(Me.HButtonPanel)
        Me.HorizondalSplitPanel.Controls.Add(Me.Splitter2)
        Me.HorizondalSplitPanel.Controls.Add(Me.DataPanel)
        Me.HorizondalSplitPanel.Enabled = False
        Me.HorizondalSplitPanel.Location = New System.Drawing.Point(3, 80)
        Me.HorizondalSplitPanel.Name = "HorizondalSplitPanel"
        Me.HorizondalSplitPanel.Size = New System.Drawing.Size(900, 585)
        Me.HorizondalSplitPanel.TabIndex = 0
        Me.HorizondalSplitPanel.Visible = False
        '
        'HButtonPanel
        '
        Me.HButtonPanel.Controls.Add(Me.AddTransactionTableLayout)
        Me.HButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HButtonPanel.Location = New System.Drawing.Point(0, 0)
        Me.HButtonPanel.Name = "HButtonPanel"
        Me.HButtonPanel.Size = New System.Drawing.Size(900, 340)
        Me.HButtonPanel.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.Color.BlueViolet
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 340)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(900, 10)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'DataPanel
        '
        Me.DataPanel.Controls.Add(Me.DataGridView1)
        Me.DataPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataPanel.Location = New System.Drawing.Point(0, 350)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.Size = New System.Drawing.Size(900, 235)
        Me.DataPanel.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(894, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'FinanceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.Controls.Add(Me.HorizondalSplitPanel)
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.DoubleBuffered = True
        Me.Name = "FinanceManagement"
        Me.Size = New System.Drawing.Size(906, 665)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.BasePanel.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.HomeTableLayout.ResumeLayout(False)
        Me.HomeTableLayout.PerformLayout()
        Me.AddTransactionTableLayout.ResumeLayout(False)
        Me.TransactionDateGB.ResumeLayout(False)
        Me.TransactionTypeGB.ResumeLayout(False)
        Me.TransactionTypeGB.PerformLayout()
        Me.AccountGB.ResumeLayout(False)
        Me.DescriptionGB.ResumeLayout(False)
        Me.DescriptionGB.PerformLayout()
        Me.AmountGB.ResumeLayout(False)
        Me.AmountGB.PerformLayout()
        Me.CatagoryGB.ResumeLayout(False)
        Me.HorizondalSplitPanel.ResumeLayout(False)
        Me.HButtonPanel.ResumeLayout(False)
        Me.DataPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents FinManagementL As Label
    Friend WithEvents BasePanel As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents HomeTableLayout As TableLayoutPanel
    Friend WithEvents AddTransactionB As Button
    Friend WithEvents ViewTransactionB As Button
    Friend WithEvents ViewAccountsB As Button
    Friend WithEvents SoonB As Button
    Friend WithEvents AddTransactionL As Label
    Friend WithEvents ViewTransactionL As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents ViewAccountsL As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AccountGB As GroupBox
    Friend WithEvents AccountCB As ComboBox
    Friend WithEvents CatagoryGB As GroupBox
    Friend WithEvents CatagoryCB As ComboBox
    Friend WithEvents DescriptionGB As GroupBox
    Friend WithEvents DescriptionTB As TextBox
    Friend WithEvents AmountGB As GroupBox
    Friend WithEvents AmountTB As TextBox
    Friend WithEvents AddTransactionTableLayout As TableLayoutPanel
    Friend WithEvents TransactionDateGB As GroupBox
    Friend WithEvents TransactionDatePicker As DateTimePicker
    Friend WithEvents TransactionTypeGB As GroupBox
    Friend WithEvents DebitRB As RadioButton
    Friend WithEvents CreditRB As RadioButton
    Friend WithEvents HorizondalSplitPanel As Panel
    Friend WithEvents HButtonPanel As Panel
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents DataPanel As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CancelTransactionB As Button
End Class
