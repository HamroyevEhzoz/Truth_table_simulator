namespace RostlikJadvaliWinform
{
    partial class TruthTableForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruthTableForm));
            this.kupaytmaButton = new System.Windows.Forms.Button();
            this.qushishButton = new System.Windows.Forms.Button();
            this.inkorButton = new System.Windows.Forms.Button();
            this.tablePictureBox = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.resulTextBox = new System.Windows.Forms.TextBox();
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.kupaytmaCButton = new System.Windows.Forms.Button();
            this.inkorCbutton = new System.Windows.Forms.Button();
            this.qoshishCbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // kupaytmaButton
            // 
            this.kupaytmaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kupaytmaButton.AutoSize = true;
            this.kupaytmaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kupaytmaButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kupaytmaButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kupaytmaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kupaytmaButton.Location = new System.Drawing.Point(8, 666);
            this.kupaytmaButton.Name = "kupaytmaButton";
            this.kupaytmaButton.Size = new System.Drawing.Size(309, 40);
            this.kupaytmaButton.TabIndex = 0;
            this.kupaytmaButton.Text = "Mantiqiy kupaytirish Jadvali";
            this.kupaytmaButton.UseVisualStyleBackColor = false;
            this.kupaytmaButton.Click += new System.EventHandler(this.kupaytmaButton_Click);
            // 
            // qushishButton
            // 
            this.qushishButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qushishButton.AutoSize = true;
            this.qushishButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.qushishButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.qushishButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qushishButton.Location = new System.Drawing.Point(8, 727);
            this.qushishButton.Name = "qushishButton";
            this.qushishButton.Size = new System.Drawing.Size(309, 40);
            this.qushishButton.TabIndex = 1;
            this.qushishButton.Text = "Mantiqiy qo\'shish jadvali";
            this.qushishButton.UseVisualStyleBackColor = false;
            this.qushishButton.Click += new System.EventHandler(this.qushishButton_Click);
            // 
            // inkorButton
            // 
            this.inkorButton.AutoSize = true;
            this.inkorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inkorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inkorButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inkorButton.Location = new System.Drawing.Point(340, 727);
            this.inkorButton.Name = "inkorButton";
            this.inkorButton.Size = new System.Drawing.Size(309, 40);
            this.inkorButton.TabIndex = 2;
            this.inkorButton.Text = "Mantiqiy inkor jadvali";
            this.inkorButton.UseVisualStyleBackColor = false;
            this.inkorButton.Click += new System.EventHandler(this.inkorButton_Click);
            // 
            // tablePictureBox
            // 
            this.tablePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tablePictureBox.Image")));
            this.tablePictureBox.Location = new System.Drawing.Point(12, 12);
            this.tablePictureBox.Name = "tablePictureBox";
            this.tablePictureBox.Size = new System.Drawing.Size(640, 451);
            this.tablePictureBox.TabIndex = 3;
            this.tablePictureBox.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(246, 475);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(403, 27);
            this.aTextBox.TabIndex = 4;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(246, 508);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(403, 27);
            this.bTextBox.TabIndex = 5;
            // 
            // resulTextBox
            // 
            this.resulTextBox.Location = new System.Drawing.Point(246, 541);
            this.resulTextBox.Name = "resulTextBox";
            this.resulTextBox.Size = new System.Drawing.Size(403, 27);
            this.resulTextBox.TabIndex = 6;
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alabel.Location = new System.Drawing.Point(61, 474);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(108, 25);
            this.Alabel.TabIndex = 7;
            this.Alabel.Text = "A mulohaza";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Blabel.Location = new System.Drawing.Point(61, 507);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(112, 25);
            this.Blabel.TabIndex = 8;
            this.Blabel.Text = "B mulohaza";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 536);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(228, 25);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Commanda boyicha Natija";
            // 
            // kupaytmaCButton
            // 
            this.kupaytmaCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kupaytmaCButton.AutoSize = true;
            this.kupaytmaCButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kupaytmaCButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kupaytmaCButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kupaytmaCButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kupaytmaCButton.Location = new System.Drawing.Point(8, 608);
            this.kupaytmaCButton.Name = "kupaytmaCButton";
            this.kupaytmaCButton.Size = new System.Drawing.Size(309, 40);
            this.kupaytmaCButton.TabIndex = 10;
            this.kupaytmaCButton.Text = "Mantiqiy kupaytirish(A^B)";
            this.kupaytmaCButton.UseVisualStyleBackColor = false;
            this.kupaytmaCButton.Click += new System.EventHandler(this.kupaytmaCButton_Click);
            // 
            // inkorCbutton
            // 
            this.inkorCbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inkorCbutton.AutoSize = true;
            this.inkorCbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inkorCbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inkorCbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inkorCbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inkorCbutton.Location = new System.Drawing.Point(340, 666);
            this.inkorCbutton.Name = "inkorCbutton";
            this.inkorCbutton.Size = new System.Drawing.Size(309, 40);
            this.inkorCbutton.TabIndex = 11;
            this.inkorCbutton.Text = "Mantiqiy inkor(!A)";
            this.inkorCbutton.UseVisualStyleBackColor = false;
            this.inkorCbutton.Click += new System.EventHandler(this.inkorCbutton_Click);
            // 
            // qoshishCbutton
            // 
            this.qoshishCbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qoshishCbutton.AutoSize = true;
            this.qoshishCbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.qoshishCbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.qoshishCbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qoshishCbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qoshishCbutton.Location = new System.Drawing.Point(340, 608);
            this.qoshishCbutton.Name = "qoshishCbutton";
            this.qoshishCbutton.Size = new System.Drawing.Size(309, 40);
            this.qoshishCbutton.TabIndex = 12;
            this.qoshishCbutton.Text = "Mantiqiy qoshish(A+B)";
            this.qoshishCbutton.UseVisualStyleBackColor = false;
            this.qoshishCbutton.Click += new System.EventHandler(this.qoshishCbutton_Click);
            // 
            // TruthTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(661, 779);
            this.Controls.Add(this.qoshishCbutton);
            this.Controls.Add(this.inkorCbutton);
            this.Controls.Add(this.kupaytmaCButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Alabel);
            this.Controls.Add(this.resulTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.tablePictureBox);
            this.Controls.Add(this.inkorButton);
            this.Controls.Add(this.qushishButton);
            this.Controls.Add(this.kupaytmaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TruthTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rostlik Jadvali";
            ((System.ComponentModel.ISupportInitialize)(this.tablePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button kupaytmaButton;
        private Button qushishButton;
        private Button inkorButton;
        private PictureBox tablePictureBox;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox bTextBox;
        private TextBox aTextBox;
        private Label resultLabel;
        private Label Blabel;
        private Label Alabel;
        private TextBox resulTextBox;
        private Button qoshishCbutton;
        private Button inkorCbutton;
        private Button kupaytmaCButton;
    }
}