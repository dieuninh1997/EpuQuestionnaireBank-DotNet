namespace GUI
{
    partial class FormQuiz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuiz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nbQuizTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nbMulti = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nbSingle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuizName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuizID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteMore = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvQuiz = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMinus = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createRandomExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuViewExam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteExam = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuizTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSingle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuiz)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cmbTeacher);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nbQuizTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nbMulti);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nbSingle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSubject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuizName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuizID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(269, 179);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(207, 21);
            this.cmbTeacher.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Teacher ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Minutes";
            // 
            // nbQuizTime
            // 
            this.nbQuizTime.Location = new System.Drawing.Point(269, 132);
            this.nbQuizTime.Name = "nbQuizTime";
            this.nbQuizTime.Size = new System.Drawing.Size(120, 20);
            this.nbQuizTime.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quiz Time";
            // 
            // nbMulti
            // 
            this.nbMulti.Location = new System.Drawing.Point(269, 83);
            this.nbMulti.Name = "nbMulti";
            this.nbMulti.Size = new System.Drawing.Size(120, 20);
            this.nbMulti.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Multi Question";
            // 
            // nbSingle
            // 
            this.nbSingle.Location = new System.Drawing.Point(269, 33);
            this.nbSingle.Name = "nbSingle";
            this.nbSingle.Size = new System.Drawing.Size(120, 20);
            this.nbSingle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Single Question";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(23, 179);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(207, 21);
            this.cmbSubject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject ID";
            // 
            // txtQuizName
            // 
            this.txtQuizName.Location = new System.Drawing.Point(23, 83);
            this.txtQuizName.Multiline = true;
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(207, 64);
            this.txtQuizName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quiz Name";
            // 
            // txtQuizID
            // 
            this.txtQuizID.Location = new System.Drawing.Point(23, 32);
            this.txtQuizID.Name = "txtQuizID";
            this.txtQuizID.Size = new System.Drawing.Size(207, 20);
            this.txtQuizID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(516, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(85, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Key Word";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnDeleteMore);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Location = new System.Drawing.Point(515, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 114);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controller";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(289, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(169, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 39);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteMore
            // 
            this.btnDeleteMore.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteMore.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMore.Image")));
            this.btnDeleteMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMore.Location = new System.Drawing.Point(29, 65);
            this.btnDeleteMore.Name = "btnDeleteMore";
            this.btnDeleteMore.Size = new System.Drawing.Size(114, 39);
            this.btnDeleteMore.TabIndex = 3;
            this.btnDeleteMore.Text = "Delete Selected";
            this.btnDeleteMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMore.UseVisualStyleBackColor = false;
            this.btnDeleteMore.Click += new System.EventHandler(this.btnDeleteMore_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(289, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(169, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 39);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Update";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(29, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 39);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back Home";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvQuiz
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvQuiz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvQuiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuiz.Location = new System.Drawing.Point(12, 295);
            this.dgvQuiz.Name = "dgvQuiz";
            this.dgvQuiz.Size = new System.Drawing.Size(461, 224);
            this.dgvQuiz.TabIndex = 4;
            this.dgvQuiz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuiz_CellClick);
            this.dgvQuiz.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuiz_CellMouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbMinus);
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 37);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbMinus
            // 
            this.lbMinus.Image = ((System.Drawing.Image)(resources.GetObject("lbMinus.Image")));
            this.lbMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMinus.Location = new System.Drawing.Point(857, 5);
            this.lbMinus.Name = "lbMinus";
            this.lbMinus.Size = new System.Drawing.Size(29, 26);
            this.lbMinus.TabIndex = 2;
            this.lbMinus.Click += new System.EventHandler(this.lbMinus_Click);
            // 
            // lbExit
            // 
            this.lbExit.Image = ((System.Drawing.Image)(resources.GetObject("lbExit.Image")));
            this.lbExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExit.Location = new System.Drawing.Point(892, 5);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(40, 26);
            this.lbExit.TabIndex = 1;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Questionnaire Bank - Quiz Manager";
            // 
            // dgvExam
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvExam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Location = new System.Drawing.Point(479, 295);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.Size = new System.Drawing.Size(444, 224);
            this.dgvExam.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Quiz List";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(646, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Exam List (Auto Generate)";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(180, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 35);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Find";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRandomExamToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // createRandomExamToolStripMenuItem
            // 
            this.createRandomExamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createRandomExamToolStripMenuItem.Image")));
            this.createRandomExamToolStripMenuItem.Name = "createRandomExamToolStripMenuItem";
            this.createRandomExamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createRandomExamToolStripMenuItem.Text = "Create random Exam";
            this.createRandomExamToolStripMenuItem.Click += new System.EventHandler(this.createRandomExamToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editToolStripMenuItem.Text = "Edit this item";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteToolStripMenuItem.Text = "Delete this item";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewExam,
            this.mnuDeleteExam});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 48);
            // 
            // mnuViewExam
            // 
            this.mnuViewExam.Image = ((System.Drawing.Image)(resources.GetObject("mnuViewExam.Image")));
            this.mnuViewExam.Name = "mnuViewExam";
            this.mnuViewExam.Size = new System.Drawing.Size(152, 22);
            this.mnuViewExam.Text = "View Exam";
            this.mnuViewExam.Click += new System.EventHandler(this.mnuViewExam_Click);
            // 
            // mnuDeleteExam
            // 
            this.mnuDeleteExam.Image = ((System.Drawing.Image)(resources.GetObject("mnuDeleteExam.Image")));
            this.mnuDeleteExam.Name = "mnuDeleteExam";
            this.mnuDeleteExam.Size = new System.Drawing.Size(152, 22);
            this.mnuDeleteExam.Text = "Delete Exam";
            this.mnuDeleteExam.Click += new System.EventHandler(this.mnuDeleteExam_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(935, 531);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvExam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQuiz);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuiz";
            this.Text = "Questionnaire Bank - Student Manager";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuizTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSingle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuiz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuizName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuizID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteMore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvQuiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMinus;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nbQuizTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbMulti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbSingle;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createRandomExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuViewExam;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteExam;
    }
}