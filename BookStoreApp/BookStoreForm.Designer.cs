
namespace BookStoreApp
{
    partial class BookStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookStoreForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashBoardButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.magazineButton = new System.Windows.Forms.Button();
            this.musicsButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ordersButton = new System.Windows.Forms.Button();
            this.profilePanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            containsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dashBoardButton);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.magazineButton);
            this.panel1.Controls.Add(this.musicsButton);
            this.panel1.Controls.Add(this.booksButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 675);
            this.panel1.TabIndex = 0;
            // 
            // dashBoardButton
            // 
            this.dashBoardButton.BackColor = System.Drawing.Color.Azure;
            this.dashBoardButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashBoardButton.ForeColor = System.Drawing.Color.Black;
            this.dashBoardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardButton.Image")));
            this.dashBoardButton.Location = new System.Drawing.Point(37, 36);
            this.dashBoardButton.Name = "dashBoardButton";
            this.dashBoardButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dashBoardButton.Size = new System.Drawing.Size(165, 60);
            this.dashBoardButton.TabIndex = 21;
            this.dashBoardButton.Text = "DashBoard";
            this.dashBoardButton.UseVisualStyleBackColor = false;
            this.dashBoardButton.Click += new System.EventHandler(this.dashBoardButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(37, 500);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 74);
            this.button6.TabIndex = 20;
            this.button6.Text = "Card";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(cartButton);
            // 
            // magazineButton
            // 
            this.magazineButton.BackColor = System.Drawing.Color.Thistle;
            this.magazineButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.magazineButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.magazineButton.Image = ((System.Drawing.Image)(resources.GetObject("magazineButton.Image")));
            this.magazineButton.Location = new System.Drawing.Point(37, 348);
            this.magazineButton.Name = "magazineButton";
            this.magazineButton.Size = new System.Drawing.Size(165, 62);
            this.magazineButton.TabIndex = 17;
            this.magazineButton.Text = "Magazines";
            this.magazineButton.UseVisualStyleBackColor = false;
            this.magazineButton.Click += new System.EventHandler(this.magazineButton_Click);
            // 
            // musicsButton
            // 
            this.musicsButton.BackColor = System.Drawing.Color.PowderBlue;
            this.musicsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musicsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.musicsButton.Image = ((System.Drawing.Image)(resources.GetObject("musicsButton.Image")));
            this.musicsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musicsButton.Location = new System.Drawing.Point(37, 241);
            this.musicsButton.Name = "musicsButton";
            this.musicsButton.Size = new System.Drawing.Size(165, 61);
            this.musicsButton.TabIndex = 16;
            this.musicsButton.Text = "  Musics";
            this.musicsButton.UseVisualStyleBackColor = false;
            this.musicsButton.Click += new System.EventHandler(this.musicsButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.booksButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.booksButton.ForeColor = System.Drawing.Color.Black;
            this.booksButton.Image = ((System.Drawing.Image)(resources.GetObject("booksButton.Image")));
            this.booksButton.Location = new System.Drawing.Point(37, 135);
            this.booksButton.Name = "booksButton";
            this.booksButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.booksButton.Size = new System.Drawing.Size(165, 60);
            this.booksButton.TabIndex = 15;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(881, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 45);
            this.button5.TabIndex = 19;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(158, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to Book Store";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ordersButton);
            this.panel2.Controls.Add(this.profilePanel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 100);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(797, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Orders";
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.AliceBlue;
            this.ordersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ordersButton.BackgroundImage")));
            this.ordersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ordersButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ordersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ordersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersButton.Location = new System.Drawing.Point(796, 30);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(49, 45);
            this.ordersButton.TabIndex = 24;
            this.ordersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(ordersButton_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.DarkGray;
            this.profilePanel.Location = new System.Drawing.Point(831, 100);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(200, 243);
            this.profilePanel.TabIndex = 0;
            this.profilePanel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(879, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(961, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "LogOut";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(964, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.logOutButton);
            // 
            // containsPanel
            // 
            containsPanel.AutoSize = true;
            containsPanel.BackColor = System.Drawing.Color.MintCream;
            containsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            containsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            containsPanel.Location = new System.Drawing.Point(246, 100);
            containsPanel.Name = "containsPanel";
            containsPanel.Size = new System.Drawing.Size(1031, 575);
            containsPanel.TabIndex = 2;
            // 
            // BookStoreForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1277, 675);
            this.Controls.Add(containsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookStoreForm";
            this.Text = "BookStoreForm";
            this.Load += new System.EventHandler(this.BookStoreForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button magazineButton;
        private System.Windows.Forms.Button musicsButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox profilePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dashBoardButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ordersButton;
        public static System.Windows.Forms.Panel containsPanel;
    }
}