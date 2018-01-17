namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.slideMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameProj = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.container = new System.Windows.Forms.Panel();
            this.menu_Report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_Tools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_Help = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_Quiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMinus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.ucHome1 = new GUI.Home.ucHome();
            this.panel1.SuspendLayout();
            this.slideMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 49);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(44, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Questionnaire Bank";
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.White;
            this.slideMenu.Controls.Add(this.menu_Report);
            this.slideMenu.Controls.Add(this.menu_Tools);
            this.slideMenu.Controls.Add(this.menu_Help);
            this.slideMenu.Controls.Add(this.menu_Quiz);
            this.slideMenu.Controls.Add(this.menu_Home);
            this.slideMenu.Controls.Add(this.panel3);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Location = new System.Drawing.Point(0, 49);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(257, 610);
            this.slideMenu.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.nameProj);
            this.panel3.Controls.Add(this.logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 195);
            this.panel3.TabIndex = 0;
            // 
            // nameProj
            // 
            this.nameProj.AutoSize = true;
            this.nameProj.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProj.ForeColor = System.Drawing.Color.Silver;
            this.nameProj.Location = new System.Drawing.Point(38, 118);
            this.nameProj.Name = "nameProj";
            this.nameProj.Size = new System.Drawing.Size(177, 25);
            this.nameProj.TabIndex = 1;
            this.nameProj.Text = "Questionnaire Bank";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // container
            // 
            this.container.Controls.Add(this.ucHome1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(257, 49);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1014, 610);
            this.container.TabIndex = 2;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // menu_Report
            // 
            this.menu_Report.Activecolor = System.Drawing.Color.Gainsboro;
            this.menu_Report.BackColor = System.Drawing.Color.White;
            this.menu_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_Report.BorderRadius = 0;
            this.menu_Report.ButtonText = "      Report";
            this.menu_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_Report.DisabledColor = System.Drawing.Color.Gray;
            this.menu_Report.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_Report.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_Report.Iconimage")));
            this.menu_Report.Iconimage_right = null;
            this.menu_Report.Iconimage_right_Selected = null;
            this.menu_Report.Iconimage_Selected = null;
            this.menu_Report.IconMarginLeft = 30;
            this.menu_Report.IconMarginRight = 0;
            this.menu_Report.IconRightVisible = true;
            this.menu_Report.IconRightZoom = 0D;
            this.menu_Report.IconVisible = true;
            this.menu_Report.IconZoom = 45D;
            this.menu_Report.IsTab = true;
            this.menu_Report.Location = new System.Drawing.Point(0, 363);
            this.menu_Report.Name = "menu_Report";
            this.menu_Report.Normalcolor = System.Drawing.Color.White;
            this.menu_Report.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu_Report.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Report.selected = false;
            this.menu_Report.Size = new System.Drawing.Size(257, 48);
            this.menu_Report.TabIndex = 5;
            this.menu_Report.Text = "      Report";
            this.menu_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Report.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Report.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Report.Click += new System.EventHandler(this.menu_Report_Click);
            // 
            // menu_Tools
            // 
            this.menu_Tools.Activecolor = System.Drawing.Color.Gainsboro;
            this.menu_Tools.BackColor = System.Drawing.Color.White;
            this.menu_Tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_Tools.BorderRadius = 0;
            this.menu_Tools.ButtonText = "      Tools";
            this.menu_Tools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_Tools.DisabledColor = System.Drawing.Color.Gray;
            this.menu_Tools.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_Tools.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_Tools.Iconimage")));
            this.menu_Tools.Iconimage_right = null;
            this.menu_Tools.Iconimage_right_Selected = null;
            this.menu_Tools.Iconimage_Selected = null;
            this.menu_Tools.IconMarginLeft = 30;
            this.menu_Tools.IconMarginRight = 0;
            this.menu_Tools.IconRightVisible = true;
            this.menu_Tools.IconRightZoom = 0D;
            this.menu_Tools.IconVisible = true;
            this.menu_Tools.IconZoom = 45D;
            this.menu_Tools.IsTab = true;
            this.menu_Tools.Location = new System.Drawing.Point(0, 309);
            this.menu_Tools.Name = "menu_Tools";
            this.menu_Tools.Normalcolor = System.Drawing.Color.White;
            this.menu_Tools.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu_Tools.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Tools.selected = false;
            this.menu_Tools.Size = new System.Drawing.Size(257, 48);
            this.menu_Tools.TabIndex = 4;
            this.menu_Tools.Text = "      Tools";
            this.menu_Tools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Tools.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Tools.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Tools.Click += new System.EventHandler(this.menu_Tools_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.Activecolor = System.Drawing.Color.Gainsboro;
            this.menu_Help.BackColor = System.Drawing.Color.White;
            this.menu_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_Help.BorderRadius = 0;
            this.menu_Help.ButtonText = "      Help";
            this.menu_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_Help.DisabledColor = System.Drawing.Color.Gray;
            this.menu_Help.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_Help.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_Help.Iconimage")));
            this.menu_Help.Iconimage_right = null;
            this.menu_Help.Iconimage_right_Selected = null;
            this.menu_Help.Iconimage_Selected = null;
            this.menu_Help.IconMarginLeft = 30;
            this.menu_Help.IconMarginRight = 0;
            this.menu_Help.IconRightVisible = true;
            this.menu_Help.IconRightZoom = 0D;
            this.menu_Help.IconVisible = true;
            this.menu_Help.IconZoom = 45D;
            this.menu_Help.IsTab = true;
            this.menu_Help.Location = new System.Drawing.Point(0, 417);
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Normalcolor = System.Drawing.Color.White;
            this.menu_Help.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu_Help.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Help.selected = false;
            this.menu_Help.Size = new System.Drawing.Size(257, 48);
            this.menu_Help.TabIndex = 3;
            this.menu_Help.Text = "      Help";
            this.menu_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Help.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Help.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Help.Click += new System.EventHandler(this.menu_Help_Click);
            // 
            // menu_Quiz
            // 
            this.menu_Quiz.Activecolor = System.Drawing.Color.Gainsboro;
            this.menu_Quiz.BackColor = System.Drawing.Color.White;
            this.menu_Quiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_Quiz.BorderRadius = 0;
            this.menu_Quiz.ButtonText = "      Quiz ";
            this.menu_Quiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_Quiz.DisabledColor = System.Drawing.Color.Gray;
            this.menu_Quiz.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_Quiz.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_Quiz.Iconimage")));
            this.menu_Quiz.Iconimage_right = null;
            this.menu_Quiz.Iconimage_right_Selected = null;
            this.menu_Quiz.Iconimage_Selected = null;
            this.menu_Quiz.IconMarginLeft = 30;
            this.menu_Quiz.IconMarginRight = 0;
            this.menu_Quiz.IconRightVisible = true;
            this.menu_Quiz.IconRightZoom = 0D;
            this.menu_Quiz.IconVisible = true;
            this.menu_Quiz.IconZoom = 45D;
            this.menu_Quiz.IsTab = true;
            this.menu_Quiz.Location = new System.Drawing.Point(0, 255);
            this.menu_Quiz.Name = "menu_Quiz";
            this.menu_Quiz.Normalcolor = System.Drawing.Color.White;
            this.menu_Quiz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu_Quiz.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Quiz.selected = false;
            this.menu_Quiz.Size = new System.Drawing.Size(257, 48);
            this.menu_Quiz.TabIndex = 2;
            this.menu_Quiz.Text = "      Quiz ";
            this.menu_Quiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Quiz.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Quiz.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Quiz.Click += new System.EventHandler(this.menu_Quiz_Click);
            // 
            // menu_Home
            // 
            this.menu_Home.Activecolor = System.Drawing.Color.Gainsboro;
            this.menu_Home.BackColor = System.Drawing.Color.Gainsboro;
            this.menu_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_Home.BorderRadius = 0;
            this.menu_Home.ButtonText = "      Home";
            this.menu_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_Home.DisabledColor = System.Drawing.Color.Gray;
            this.menu_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_Home.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_Home.Iconimage")));
            this.menu_Home.Iconimage_right = null;
            this.menu_Home.Iconimage_right_Selected = null;
            this.menu_Home.Iconimage_Selected = null;
            this.menu_Home.IconMarginLeft = 30;
            this.menu_Home.IconMarginRight = 0;
            this.menu_Home.IconRightVisible = true;
            this.menu_Home.IconRightZoom = 0D;
            this.menu_Home.IconVisible = true;
            this.menu_Home.IconZoom = 45D;
            this.menu_Home.IsTab = true;
            this.menu_Home.Location = new System.Drawing.Point(0, 201);
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.Normalcolor = System.Drawing.Color.White;
            this.menu_Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu_Home.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Home.selected = true;
            this.menu_Home.Size = new System.Drawing.Size(257, 48);
            this.menu_Home.TabIndex = 1;
            this.menu_Home.Text = "      Home";
            this.menu_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Home.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.menu_Home.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Home.Click += new System.EventHandler(this.menu_Home_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(90, 44);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(67, 71);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.ImageActive = null;
            this.btnMinus.Location = new System.Drawing.Point(1201, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(26, 43);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinus.TabIndex = 5;
            this.btnMinus.TabStop = false;
            this.btnMinus.Zoom = 10;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1233, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 26);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(26, 26);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1014, 610);
            this.ucHome1.TabIndex = 0;
            this.ucHome1.Load += new System.EventHandler(this.ucHome1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 659);
            this.Controls.Add(this.container);
            this.Controls.Add(this.slideMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.slideMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel slideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton menu_Home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton menu_Tools;
        private Bunifu.Framework.UI.BunifuFlatButton menu_Help;
        private Bunifu.Framework.UI.BunifuFlatButton menu_Quiz;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton menu_Report;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label nameProj;
        private Bunifu.Framework.UI.BunifuImageButton btnMinus;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel container;
        private Home.ucHome ucHome1;
    }
}