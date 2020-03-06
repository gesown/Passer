namespace Passer
{
    partial class Passer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MerchSearch = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.tb_Uname = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lb_StoreOptions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merch Name";
            // 
            // tb_MerchSearch
            // 
            this.tb_MerchSearch.Location = new System.Drawing.Point(103, 39);
            this.tb_MerchSearch.Name = "tb_MerchSearch";
            this.tb_MerchSearch.Size = new System.Drawing.Size(132, 20);
            this.tb_MerchSearch.TabIndex = 1;
            this.tb_MerchSearch.TextChanged += new System.EventHandler(this.Tb_MerchSearch_TextChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(22, -4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(219, 37);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Password Recovery";
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.Color.Black;
            this.lbl_uname.Location = new System.Drawing.Point(9, 194);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(77, 16);
            this.lbl_uname.TabIndex = 3;
            this.lbl_uname.Text = "Username: ";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Black;
            this.lbl_pass.Location = new System.Drawing.Point(11, 220);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(74, 16);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password: ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.MintCream;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Location = new System.Drawing.Point(135, 65);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 23);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(85, 219);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(148, 20);
            this.tb_Pass.TabIndex = 7;
            this.tb_Pass.Visible = false;
            // 
            // tb_Uname
            // 
            this.tb_Uname.Location = new System.Drawing.Point(85, 194);
            this.tb_Uname.Name = "tb_Uname";
            this.tb_Uname.Size = new System.Drawing.Size(148, 20);
            this.tb_Uname.TabIndex = 8;
            this.tb_Uname.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.MintCream;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.Location = new System.Drawing.Point(158, 252);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // lb_StoreOptions
            // 
            this.lb_StoreOptions.FormattingEnabled = true;
            this.lb_StoreOptions.Location = new System.Drawing.Point(12, 91);
            this.lb_StoreOptions.Name = "lb_StoreOptions";
            this.lb_StoreOptions.Size = new System.Drawing.Size(221, 95);
            this.lb_StoreOptions.TabIndex = 10;
            this.lb_StoreOptions.SelectedIndexChanged += new System.EventHandler(this.Lb_StoreOptions_SelectedIndexChanged);
            // 
            // Passer
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 287);
            this.Controls.Add(this.lb_StoreOptions);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb_Uname);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_uname);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.tb_MerchSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Passer";
            this.Text = "Passy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MerchSearch;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.TextBox tb_Uname;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox lb_StoreOptions;
    }
}

