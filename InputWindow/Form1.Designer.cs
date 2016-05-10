namespace InputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.EntryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberEntries = new System.Windows.Forms.NumericUpDown();
            this.PlaceEntry = new System.Windows.Forms.Button();
            this.WinnerButton = new System.Windows.Forms.Button();
            this.InputError = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Name";
            // 
            // EntryName
            // 
            this.EntryName.Location = new System.Drawing.Point(15, 37);
            this.EntryName.Name = "EntryName";
            this.EntryName.Size = new System.Drawing.Size(206, 20);
            this.EntryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Entries";
            // 
            // NumberEntries
            // 
            this.NumberEntries.Location = new System.Drawing.Point(135, 83);
            this.NumberEntries.Name = "NumberEntries";
            this.NumberEntries.Size = new System.Drawing.Size(50, 20);
            this.NumberEntries.TabIndex = 3;
            // 
            // PlaceEntry
            // 
            this.PlaceEntry.Location = new System.Drawing.Point(15, 128);
            this.PlaceEntry.Name = "PlaceEntry";
            this.PlaceEntry.Size = new System.Drawing.Size(75, 23);
            this.PlaceEntry.TabIndex = 4;
            this.PlaceEntry.Text = "Enter Raffle";
            this.PlaceEntry.UseVisualStyleBackColor = true;
            this.PlaceEntry.Click += new System.EventHandler(this.AddToRaffle);
            // 
            // WinnerButton
            // 
            this.WinnerButton.Location = new System.Drawing.Point(15, 221);
            this.WinnerButton.Name = "WinnerButton";
            this.WinnerButton.Size = new System.Drawing.Size(206, 23);
            this.WinnerButton.TabIndex = 5;
            this.WinnerButton.Text = "Pull Winner";
            this.WinnerButton.UseVisualStyleBackColor = true;
            this.WinnerButton.Visible = false;
            this.WinnerButton.Click += new System.EventHandler(this.PickWinner);
            // 
            // InputError
            // 
            this.InputError.AutoSize = true;
            this.InputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputError.ForeColor = System.Drawing.Color.Red;
            this.InputError.Location = new System.Drawing.Point(122, 128);
            this.InputError.Name = "InputError";
            this.InputError.Size = new System.Drawing.Size(88, 20);
            this.InputError.TabIndex = 6;
            this.InputError.Text = "Incomplete";
            this.InputError.Visible = false;
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.Location = new System.Drawing.Point(67, 168);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(68, 13);
            this.Winner.TabIndex = 7;
            this.Winner.Text = "Winner is: ya";
            this.Winner.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 252);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.InputError);
            this.Controls.Add(this.WinnerButton);
            this.Controls.Add(this.PlaceEntry);
            this.Controls.Add(this.NumberEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntryName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Raffle";
            ((System.ComponentModel.ISupportInitialize)(this.NumberEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberEntries;
        private System.Windows.Forms.Button PlaceEntry;
        private System.Windows.Forms.Button WinnerButton;
        private System.Windows.Forms.Label InputError;
        private System.Windows.Forms.Label Winner;
    }
}

