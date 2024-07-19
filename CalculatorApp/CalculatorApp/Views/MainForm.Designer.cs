namespace CalculatorApp.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.mainFormStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msiFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msiEdit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msiEdit_CopyHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguage_English = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguage_Ukrainian = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelimiter = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnClearLast = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormStateBindingSource)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn1.Location = new System.Drawing.Point(6, 498);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 48);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // mainFormStateBindingSource
            // 
            this.mainFormStateBindingSource.DataSource = typeof(CalculatorApp.Views.MainViewState);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn2.Location = new System.Drawing.Point(84, 498);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 48);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnAdd.Location = new System.Drawing.Point(240, 442);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 48);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquals.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnEquals.Location = new System.Drawing.Point(240, 498);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(72, 104);
            this.btnEquals.TabIndex = 18;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn3.Location = new System.Drawing.Point(162, 498);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 48);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn4.Location = new System.Drawing.Point(6, 442);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 48);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn5.Location = new System.Drawing.Point(84, 442);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 48);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn6.Location = new System.Drawing.Point(162, 442);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 48);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn7.Location = new System.Drawing.Point(6, 386);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 48);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn8.Location = new System.Drawing.Point(84, 386);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 48);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn9.Location = new System.Drawing.Point(162, 386);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 48);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtract.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnSubtract.Location = new System.Drawing.Point(240, 386);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(72, 48);
            this.btnSubtract.TabIndex = 15;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiply.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnMultiply.Location = new System.Drawing.Point(162, 330);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(72, 48);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivide.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnDivide.Location = new System.Drawing.Point(240, 330);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(72, 48);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btn0
            // 
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btn0.Location = new System.Drawing.Point(6, 554);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(150, 48);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormStateBindingSource, "Results", true));
            this.txtResult.Location = new System.Drawing.Point(6, 240);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(306, 26);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile,
            this.msiEdit,
            this.msiLanguage,
            this.msiHelp});
            this.msMain.Location = new System.Drawing.Point(3, 4);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1258, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Main Menu Strip";
            // 
            // msiFile
            // 
            this.msiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile_Exit});
            this.msiFile.Name = "msiFile";
            this.msiFile.Size = new System.Drawing.Size(37, 20);
            this.msiFile.Text = "File";
            // 
            // msiFile_Exit
            // 
            this.msiFile_Exit.Name = "msiFile_Exit";
            this.msiFile_Exit.Size = new System.Drawing.Size(93, 22);
            this.msiFile_Exit.Text = "Exit";
            this.msiFile_Exit.Click += new System.EventHandler(this.msiFile_Exit_Click);
            // 
            // msiEdit
            // 
            this.msiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiEdit_Cut,
            this.msiEdit_Copy,
            this.msiEdit_Paste,
            this.msiEdit_Separator1,
            this.msiEdit_Undo,
            this.msiEdit_Redo,
            this.msiEdit_Separator2,
            this.msiEdit_CopyHistory});
            this.msiEdit.Name = "msiEdit";
            this.msiEdit.Size = new System.Drawing.Size(39, 20);
            this.msiEdit.Text = "Edit";
            // 
            // msiEdit_Cut
            // 
            this.msiEdit_Cut.Name = "msiEdit_Cut";
            this.msiEdit_Cut.Size = new System.Drawing.Size(143, 22);
            this.msiEdit_Cut.Text = "Cut";
            // 
            // msiEdit_Copy
            // 
            this.msiEdit_Copy.Name = "msiEdit_Copy";
            this.msiEdit_Copy.Size = new System.Drawing.Size(143, 22);
            this.msiEdit_Copy.Text = "Copy";
            // 
            // msiEdit_Paste
            // 
            this.msiEdit_Paste.Name = "msiEdit_Paste";
            this.msiEdit_Paste.Size = new System.Drawing.Size(143, 22);
            this.msiEdit_Paste.Text = "Paste";
            // 
            // msiEdit_Separator1
            // 
            this.msiEdit_Separator1.Name = "msiEdit_Separator1";
            this.msiEdit_Separator1.Size = new System.Drawing.Size(140, 6);
            // 
            // msiEdit_Undo
            // 
            this.msiEdit_Undo.Name = "msiEdit_Undo";
            this.msiEdit_Undo.Size = new System.Drawing.Size(143, 22);
            this.msiEdit_Undo.Text = "Undo";
            // 
            // msiEdit_Redo
            // 
            this.msiEdit_Redo.Name = "msiEdit_Redo";
            this.msiEdit_Redo.Size = new System.Drawing.Size(143, 22);
            this.msiEdit_Redo.Text = "Redo";
            // 
            // msiEdit_Separator2
            // 
            this.msiEdit_Separator2.Name = "msiEdit_Separator2";
            this.msiEdit_Separator2.Size = new System.Drawing.Size(140, 6);
            // 
            // msiEdit_CopyHistory
            // 
            this.msiEdit_CopyHistory.Name = "msiEdit_CopyHistory";
            this.msiEdit_CopyHistory.Size = new System.Drawing.Size(143, 22);
            this.msiEdit_CopyHistory.Text = "Copy History";
            // 
            // msiLanguage
            // 
            this.msiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiLanguage_English,
            this.msiLanguage_Ukrainian});
            this.msiLanguage.Name = "msiLanguage";
            this.msiLanguage.Size = new System.Drawing.Size(71, 20);
            this.msiLanguage.Text = "Language";
            // 
            // msiLanguage_English
            // 
            this.msiLanguage_English.Name = "msiLanguage_English";
            this.msiLanguage_English.Size = new System.Drawing.Size(124, 22);
            this.msiLanguage_English.Text = "English";
            // 
            // msiLanguage_Ukrainian
            // 
            this.msiLanguage_Ukrainian.Name = "msiLanguage_Ukrainian";
            this.msiLanguage_Ukrainian.Size = new System.Drawing.Size(124, 22);
            this.msiLanguage_Ukrainian.Text = "Ukrainian";
            // 
            // msiHelp
            // 
            this.msiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiHelp_About});
            this.msiHelp.Name = "msiHelp";
            this.msiHelp.Size = new System.Drawing.Size(44, 20);
            this.msiHelp.Text = "Help";
            // 
            // msiHelp_About
            // 
            this.msiHelp_About.Name = "msiHelp_About";
            this.msiHelp_About.Size = new System.Drawing.Size(107, 22);
            this.msiHelp_About.Text = "About";
            // 
            // btnDelimiter
            // 
            this.btnDelimiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelimiter.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnDelimiter.Location = new System.Drawing.Point(162, 554);
            this.btnDelimiter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelimiter.Name = "btnDelimiter";
            this.btnDelimiter.Size = new System.Drawing.Size(72, 48);
            this.btnDelimiter.TabIndex = 3;
            this.btnDelimiter.Text = ".";
            this.btnDelimiter.UseVisualStyleBackColor = true;
            this.btnDelimiter.Click += new System.EventHandler(this.btnDelimiter_Click);
            // 
            // btnCE
            // 
            this.btnCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCE.Location = new System.Drawing.Point(6, 274);
            this.btnCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(72, 48);
            this.btnCE.TabIndex = 22;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnClearLast
            // 
            this.btnClearLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLast.Location = new System.Drawing.Point(240, 274);
            this.btnClearLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearLast.Name = "btnClearLast";
            this.btnClearLast.Size = new System.Drawing.Size(72, 48);
            this.btnClearLast.TabIndex = 21;
            this.btnClearLast.Text = "⬅";
            this.btnClearLast.UseVisualStyleBackColor = true;
            this.btnClearLast.Click += new System.EventHandler(this.btnClearLast_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoot.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnRoot.Location = new System.Drawing.Point(6, 330);
            this.btnRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(72, 48);
            this.btnRoot.TabIndex = 20;
            this.btnRoot.Text = "ⁿ√x";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnPower
            // 
            this.btnPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPower.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnPower.Location = new System.Drawing.Point(84, 330);
            this.btnPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(72, 48);
            this.btnPower.TabIndex = 19;
            this.btnPower.Text = "xⁿ";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.SystemColors.Window;
            this.txtHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHistory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormStateBindingSource, "History", true));
            this.txtHistory.Location = new System.Drawing.Point(6, 32);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(306, 200);
            this.txtHistory.TabIndex = 1;
            this.txtHistory.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnMemory
            // 
            this.btnMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemory.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnMemory.Location = new System.Drawing.Point(84, 274);
            this.btnMemory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(72, 48);
            this.btnMemory.TabIndex = 23;
            this.btnMemory.Text = "M+";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.mainFormStateBindingSource, "ButtonEnabled", true));
            this.btnGroup.Location = new System.Drawing.Point(162, 274);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(72, 48);
            this.btnGroup.TabIndex = 24;
            this.btnGroup.Text = "( )";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnClearLast);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDelimiter);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormStateBindingSource)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msiFile;
        private System.Windows.Forms.ToolStripMenuItem msiFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem msiEdit;
        private System.Windows.Forms.ToolStripMenuItem msiEdit_Cut;
        private System.Windows.Forms.ToolStripMenuItem msiEdit_Copy;
        private System.Windows.Forms.ToolStripMenuItem msiEdit_Paste;
        private System.Windows.Forms.ToolStripMenuItem msiEdit_CopyHistory;
        private System.Windows.Forms.ToolStripMenuItem msiHelp;
        private System.Windows.Forms.Button btnDelimiter;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.ToolStripMenuItem msiHelp_About;
        private System.Windows.Forms.Button btnClearLast;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.BindingSource mainFormStateBindingSource;
        private System.Windows.Forms.ToolStripSeparator msiEdit_Separator1;
        private System.Windows.Forms.ToolStripMenuItem msiLanguage;
        private System.Windows.Forms.ToolStripMenuItem msiLanguage_English;
        private System.Windows.Forms.ToolStripMenuItem msiLanguage_Ukrainian;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.ToolStripMenuItem msiEdit_Undo;
        private System.Windows.Forms.ToolStripMenuItem msiEdit_Redo;
        private System.Windows.Forms.ToolStripSeparator msiEdit_Separator2;
    }
}
