namespace Project4_EfCodeFirstMovie
{
    partial class FrmMovie
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnListFromCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(386, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 36);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(386, 171);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 223);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 36);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(141, 69);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(187, 26);
            this.txtMovieName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Film Adı";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(386, 18);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(103, 36);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(141, 28);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(187, 26);
            this.txtMovieId.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(839, 240);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Film Id";
            // 
            // txtMovieDescription
            // 
            this.txtMovieDescription.Location = new System.Drawing.Point(141, 151);
            this.txtMovieDescription.Name = "txtMovieDescription";
            this.txtMovieDescription.Size = new System.Drawing.Size(187, 26);
            this.txtMovieDescription.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Açıklama:";
            // 
            // txtMovieDuration
            // 
            this.txtMovieDuration.Location = new System.Drawing.Point(141, 110);
            this.txtMovieDuration.Name = "txtMovieDuration";
            this.txtMovieDuration.Size = new System.Drawing.Size(187, 26);
            this.txtMovieDuration.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Film Süresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "İzlenme Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kategorisi";
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(141, 193);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(187, 26);
            this.mskDate.TabIndex = 28;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(141, 228);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(187, 28);
            this.cmbCategory.TabIndex = 29;
            // 
            // btnListFromCategory
            // 
            this.btnListFromCategory.Location = new System.Drawing.Point(386, 278);
            this.btnListFromCategory.Name = "btnListFromCategory";
            this.btnListFromCategory.Size = new System.Drawing.Size(103, 36);
            this.btnListFromCategory.TabIndex = 30;
            this.btnListFromCategory.Text = "Listele2";
            this.btnListFromCategory.UseVisualStyleBackColor = true;
            this.btnListFromCategory.Click += new System.EventHandler(this.btnListFromCategory_Click);
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 630);
            this.Controls.Add(this.btnListFromCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.mskDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMovieDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovieDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMovie";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnListFromCategory;
    }
}