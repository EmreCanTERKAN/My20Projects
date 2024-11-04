namespace Project2_EntityFrameworkDbFirtProduct
{
    partial class Form1
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
            label1 = new Label();
            btnList = new Button();
            txtCategoryId = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtCategoryName = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            btnPatch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Kategori ID:";
            // 
            // btnList
            // 
            btnList.Location = new Point(187, 130);
            btnList.Name = "btnList";
            btnList.Size = new Size(150, 34);
            btnList.TabIndex = 1;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(187, 31);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(150, 31);
            txtCategoryId.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(376, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(400, 265);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 4;
            label2.Text = "Kategori Adı:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(187, 81);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(150, 31);
            txtCategoryName.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(187, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(187, 262);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPatch
            // 
            btnPatch.Location = new Point(187, 222);
            btnPatch.Name = "btnPatch";
            btnPatch.Size = new Size(150, 34);
            btnPatch.TabIndex = 8;
            btnPatch.Text = "Güncelle";
            btnPatch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPatch);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtCategoryId);
            Controls.Add(btnList);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori İşlemleri";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnList;
        private TextBox txtCategoryId;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtCategoryName;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnPatch;
    }
}
