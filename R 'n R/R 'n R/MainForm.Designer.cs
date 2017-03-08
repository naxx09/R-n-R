namespace R__n_R
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BooksBtn = new System.Windows.Forms.Button();
            this.MusicBtn = new System.Windows.Forms.Button();
            this.PeriodBtn = new System.Windows.Forms.Button();
            this.CoffeeBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentTxt = new System.Windows.Forms.TextBox();
            this.PromotionTxt = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // BooksBtn
            // 
            this.BooksBtn.Location = new System.Drawing.Point(12, 12);
            this.BooksBtn.Name = "BooksBtn";
            this.BooksBtn.Size = new System.Drawing.Size(75, 23);
            this.BooksBtn.TabIndex = 0;
            this.BooksBtn.Text = "Books";
            this.BooksBtn.UseVisualStyleBackColor = true;
            this.BooksBtn.Click += new System.EventHandler(this.BooksBtn_Click);
            // 
            // MusicBtn
            // 
            this.MusicBtn.Location = new System.Drawing.Point(12, 41);
            this.MusicBtn.Name = "MusicBtn";
            this.MusicBtn.Size = new System.Drawing.Size(75, 23);
            this.MusicBtn.TabIndex = 1;
            this.MusicBtn.Text = "Music";
            this.MusicBtn.UseVisualStyleBackColor = true;
            this.MusicBtn.Click += new System.EventHandler(this.MusicBtn_Click);
            // 
            // PeriodBtn
            // 
            this.PeriodBtn.Location = new System.Drawing.Point(12, 70);
            this.PeriodBtn.Name = "PeriodBtn";
            this.PeriodBtn.Size = new System.Drawing.Size(75, 23);
            this.PeriodBtn.TabIndex = 2;
            this.PeriodBtn.Text = "Periodicals";
            this.PeriodBtn.UseVisualStyleBackColor = true;
            this.PeriodBtn.Click += new System.EventHandler(this.PeriodBtn_Click);
            // 
            // CoffeeBtn
            // 
            this.CoffeeBtn.Location = new System.Drawing.Point(12, 99);
            this.CoffeeBtn.Name = "CoffeeBtn";
            this.CoffeeBtn.Size = new System.Drawing.Size(75, 23);
            this.CoffeeBtn.TabIndex = 3;
            this.CoffeeBtn.Text = "Coffee Bar";
            this.CoffeeBtn.UseVisualStyleBackColor = true;
            this.CoffeeBtn.Click += new System.EventHandler(this.CoffeeBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(12, 209);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintBtn.TabIndex = 4;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 238);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Promotion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Promotion Code";
            // 
            // CurrentTxt
            // 
            this.CurrentTxt.Location = new System.Drawing.Point(282, 38);
            this.CurrentTxt.Name = "CurrentTxt";
            this.CurrentTxt.ReadOnly = true;
            this.CurrentTxt.Size = new System.Drawing.Size(253, 20);
            this.CurrentTxt.TabIndex = 8;
            // 
            // PromotionTxt
            // 
            this.PromotionTxt.Location = new System.Drawing.Point(282, 73);
            this.PromotionTxt.Name = "PromotionTxt";
            this.PromotionTxt.ReadOnly = true;
            this.PromotionTxt.Size = new System.Drawing.Size(160, 20);
            this.PromotionTxt.TabIndex = 9;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 293);
            this.Controls.Add(this.PromotionTxt);
            this.Controls.Add(this.CurrentTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.CoffeeBtn);
            this.Controls.Add(this.PeriodBtn);
            this.Controls.Add(this.MusicBtn);
            this.Controls.Add(this.BooksBtn);
            this.Name = "MainForm";
            this.Text = "R \'n R -- For Reading and Refreshment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BooksBtn;
        private System.Windows.Forms.Button MusicBtn;
        private System.Windows.Forms.Button PeriodBtn;
        private System.Windows.Forms.Button CoffeeBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrentTxt;
        private System.Windows.Forms.TextBox PromotionTxt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

