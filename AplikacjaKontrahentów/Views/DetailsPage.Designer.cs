namespace AplikacjaKontrahentów.Views
{
    partial class DetailsPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIP = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nazwa kontrahenta";
            // 
            // lblNIP
            // 
            this.lblNIP.AutoSize = true;
            this.lblNIP.Location = new System.Drawing.Point(18, 103);
            this.lblNIP.Name = "lblNIP";
            this.lblNIP.Size = new System.Drawing.Size(25, 13);
            this.lblNIP.TabIndex = 2;
            this.lblNIP.Text = "NIP";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(18, 131);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(85, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Typ kontrahenta";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(52, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Opis firmy";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(18, 229);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(101, 13);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Kontrahent aktywny";
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.Location = new System.Drawing.Point(125, 229);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(15, 14);
            this.ckbActive.TabIndex = 6;
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(352, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(125, 100);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(352, 20);
            this.txtNIP.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(125, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 63);
            this.txtDescription.TabIndex = 10;
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(125, 128);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(352, 21);
            this.cbbType.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 315);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNIP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "DetailsPage";
            this.Text = "DetailsPage";
            this.Load += new System.EventHandler(this.DetailsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIP;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnSave;
    }
}