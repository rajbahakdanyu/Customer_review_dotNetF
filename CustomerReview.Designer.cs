namespace Customer_review_dotNetF
{
    partial class CustomerReview
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
            this.nameLb = new System.Windows.Forms.Label();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.serviceCombo = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.emailLb = new System.Windows.Forms.Label();
            this.mobileLb = new System.Windows.Forms.Label();
            this.serviceLb = new System.Windows.Forms.Label();
            this.foodLb = new System.Windows.Forms.Label();
            this.foodCombo = new System.Windows.Forms.ComboBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.enviromentLb = new System.Windows.Forms.Label();
            this.enviromentCombo = new System.Windows.Forms.ComboBox();
            this.suggestLb = new System.Windows.Forms.Label();
            this.suggestTxt = new System.Windows.Forms.TextBox();
            this.gridReview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(13, 13);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(45, 17);
            this.nameLb.TabIndex = 0;
            this.nameLb.Text = "Name";
            // 
            // mobileTxt
            // 
            this.mobileTxt.Location = new System.Drawing.Point(161, 99);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(163, 22);
            this.mobileTxt.TabIndex = 1;
            // 
            // serviceCombo
            // 
            this.serviceCombo.DisplayMember = "(none)";
            this.serviceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceCombo.FormattingEnabled = true;
            this.serviceCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.serviceCombo.Location = new System.Drawing.Point(161, 141);
            this.serviceCombo.Name = "serviceCombo";
            this.serviceCombo.Size = new System.Drawing.Size(163, 24);
            this.serviceCombo.TabIndex = 2;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(19, 416);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(137, 44);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(16, 60);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(42, 17);
            this.emailLb.TabIndex = 4;
            this.emailLb.Text = "Email";
            // 
            // mobileLb
            // 
            this.mobileLb.AutoSize = true;
            this.mobileLb.Location = new System.Drawing.Point(16, 102);
            this.mobileLb.Name = "mobileLb";
            this.mobileLb.Size = new System.Drawing.Size(49, 17);
            this.mobileLb.TabIndex = 5;
            this.mobileLb.Text = "Mobile";
            // 
            // serviceLb
            // 
            this.serviceLb.AutoSize = true;
            this.serviceLb.Location = new System.Drawing.Point(16, 144);
            this.serviceLb.Name = "serviceLb";
            this.serviceLb.Size = new System.Drawing.Size(100, 17);
            this.serviceLb.TabIndex = 6;
            this.serviceLb.Text = "Service Rating";
            // 
            // foodLb
            // 
            this.foodLb.AutoSize = true;
            this.foodLb.Location = new System.Drawing.Point(16, 183);
            this.foodLb.Name = "foodLb";
            this.foodLb.Size = new System.Drawing.Size(85, 17);
            this.foodLb.TabIndex = 7;
            this.foodLb.Text = "Food Rating";
            // 
            // foodCombo
            // 
            this.foodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodCombo.FormattingEnabled = true;
            this.foodCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.foodCombo.Location = new System.Drawing.Point(161, 180);
            this.foodCombo.Name = "foodCombo";
            this.foodCombo.Size = new System.Drawing.Size(163, 24);
            this.foodCombo.TabIndex = 8;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(161, 57);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(163, 22);
            this.emailTxt.TabIndex = 9;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(161, 10);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(163, 22);
            this.nameTxt.TabIndex = 10;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(183, 416);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(141, 44);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // enviromentLb
            // 
            this.enviromentLb.AutoSize = true;
            this.enviromentLb.Location = new System.Drawing.Point(16, 229);
            this.enviromentLb.Name = "enviromentLb";
            this.enviromentLb.Size = new System.Drawing.Size(124, 17);
            this.enviromentLb.TabIndex = 12;
            this.enviromentLb.Text = "Enviroment Rating";
            // 
            // enviromentCombo
            // 
            this.enviromentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enviromentCombo.FormattingEnabled = true;
            this.enviromentCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.enviromentCombo.Location = new System.Drawing.Point(161, 226);
            this.enviromentCombo.Name = "enviromentCombo";
            this.enviromentCombo.Size = new System.Drawing.Size(163, 24);
            this.enviromentCombo.TabIndex = 13;
            // 
            // suggestLb
            // 
            this.suggestLb.AutoSize = true;
            this.suggestLb.Location = new System.Drawing.Point(16, 269);
            this.suggestLb.Name = "suggestLb";
            this.suggestLb.Size = new System.Drawing.Size(86, 17);
            this.suggestLb.TabIndex = 14;
            this.suggestLb.Text = "Suggestions";
            // 
            // suggestTxt
            // 
            this.suggestTxt.Location = new System.Drawing.Point(161, 266);
            this.suggestTxt.Multiline = true;
            this.suggestTxt.Name = "suggestTxt";
            this.suggestTxt.Size = new System.Drawing.Size(163, 126);
            this.suggestTxt.TabIndex = 15;
            // 
            // gridReview
            // 
            this.gridReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReview.Location = new System.Drawing.Point(365, 10);
            this.gridReview.Name = "gridReview";
            this.gridReview.RowHeadersWidth = 51;
            this.gridReview.RowTemplate.Height = 24;
            this.gridReview.Size = new System.Drawing.Size(413, 240);
            this.gridReview.TabIndex = 16;
            // 
            // CustomerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 474);
            this.Controls.Add(this.gridReview);
            this.Controls.Add(this.suggestTxt);
            this.Controls.Add(this.suggestLb);
            this.Controls.Add(this.enviromentCombo);
            this.Controls.Add(this.enviromentLb);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.foodCombo);
            this.Controls.Add(this.foodLb);
            this.Controls.Add(this.serviceLb);
            this.Controls.Add(this.mobileLb);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.serviceCombo);
            this.Controls.Add(this.mobileTxt);
            this.Controls.Add(this.nameLb);
            this.Name = "CustomerReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerReview";
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.ComboBox serviceCombo;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.Label mobileLb;
        private System.Windows.Forms.Label serviceLb;
        private System.Windows.Forms.Label foodLb;
        private System.Windows.Forms.ComboBox foodCombo;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label enviromentLb;
        private System.Windows.Forms.ComboBox enviromentCombo;
        private System.Windows.Forms.Label suggestLb;
        private System.Windows.Forms.TextBox suggestTxt;
        private System.Windows.Forms.DataGridView gridReview;
    }
}