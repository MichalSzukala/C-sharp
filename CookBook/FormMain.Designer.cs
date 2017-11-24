namespace CookBook
{
    partial class FormMain
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
            this.groupBoxAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.textBoxRecipe = new System.Windows.Forms.TextBox();
            this.buttonAddIngrediens = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxNameOfRecipe = new System.Windows.Forms.TextBox();
            this.labelNameOfRecipe = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNoOFIngred = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUnselect = new System.Windows.Forms.Button();
            this.groupBoxAddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddNewRecipe
            // 
            this.groupBoxAddNewRecipe.Controls.Add(this.textBoxRecipe);
            this.groupBoxAddNewRecipe.Controls.Add(this.buttonAddIngrediens);
            this.groupBoxAddNewRecipe.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddNewRecipe.Controls.Add(this.labelCategory);
            this.groupBoxAddNewRecipe.Controls.Add(this.textBoxNameOfRecipe);
            this.groupBoxAddNewRecipe.Controls.Add(this.labelNameOfRecipe);
            this.groupBoxAddNewRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddNewRecipe.Location = new System.Drawing.Point(20, 30);
            this.groupBoxAddNewRecipe.Name = "groupBoxAddNewRecipe";
            this.groupBoxAddNewRecipe.Size = new System.Drawing.Size(462, 398);
            this.groupBoxAddNewRecipe.TabIndex = 0;
            this.groupBoxAddNewRecipe.TabStop = false;
            this.groupBoxAddNewRecipe.Text = "Add new recipe";
            // 
            // textBoxRecipe
            // 
            this.textBoxRecipe.Location = new System.Drawing.Point(17, 127);
            this.textBoxRecipe.Multiline = true;
            this.textBoxRecipe.Name = "textBoxRecipe";
            this.textBoxRecipe.Size = new System.Drawing.Size(426, 256);
            this.textBoxRecipe.TabIndex = 5;
            // 
            // buttonAddIngrediens
            // 
            this.buttonAddIngrediens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIngrediens.Location = new System.Drawing.Point(315, 78);
            this.buttonAddIngrediens.Name = "buttonAddIngrediens";
            this.buttonAddIngrediens.Size = new System.Drawing.Size(128, 32);
            this.buttonAddIngrediens.TabIndex = 4;
            this.buttonAddIngrediens.Text = " Add ingrediens";
            this.buttonAddIngrediens.UseVisualStyleBackColor = true;
            this.buttonAddIngrediens.Click += new System.EventHandler(this.buttonAddIngrediens_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Meat",
            "Vegeterian",
            "Fish",
            "SeaFood"});
            this.comboBoxCategory.Location = new System.Drawing.Point(142, 84);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(116, 26);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(14, 92);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(68, 18);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category";
            // 
            // textBoxNameOfRecipe
            // 
            this.textBoxNameOfRecipe.Location = new System.Drawing.Point(142, 31);
            this.textBoxNameOfRecipe.Name = "textBoxNameOfRecipe";
            this.textBoxNameOfRecipe.Size = new System.Drawing.Size(301, 24);
            this.textBoxNameOfRecipe.TabIndex = 1;
            // 
            // labelNameOfRecipe
            // 
            this.labelNameOfRecipe.AutoSize = true;
            this.labelNameOfRecipe.Location = new System.Drawing.Point(14, 37);
            this.labelNameOfRecipe.Name = "labelNameOfRecipe";
            this.labelNameOfRecipe.Size = new System.Drawing.Size(109, 18);
            this.labelNameOfRecipe.TabIndex = 0;
            this.labelNameOfRecipe.Text = "Name of recipe";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(497, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelNoOFIngred
            // 
            this.labelNoOFIngred.AutoSize = true;
            this.labelNoOFIngred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOFIngred.Location = new System.Drawing.Point(665, 45);
            this.labelNoOFIngred.Name = "labelNoOFIngred";
            this.labelNoOFIngred.Size = new System.Drawing.Size(116, 18);
            this.labelNoOFIngred.TabIndex = 2;
            this.labelNoOFIngred.Text = "No of ingrediens";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(870, 45);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(68, 18);
            this.labelCat.TabIndex = 3;
            this.labelCat.Text = "Category";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(1027, 45);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 18);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 17;
            this.listBoxRecipes.Location = new System.Drawing.Point(488, 82);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(671, 327);
            this.listBoxRecipes.TabIndex = 5;
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipes_SelectedIndexChanged);
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRecipe.Location = new System.Drawing.Point(112, 452);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(256, 36);
            this.buttonAddRecipe.TabIndex = 6;
            this.buttonAddRecipe.Text = "Add recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(609, 452);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(212, 36);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(893, 452);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(190, 36);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUnselect
            // 
            this.buttonUnselect.Location = new System.Drawing.Point(1170, 206);
            this.buttonUnselect.Name = "buttonUnselect";
            this.buttonUnselect.Size = new System.Drawing.Size(85, 26);
            this.buttonUnselect.TabIndex = 9;
            this.buttonUnselect.Text = "Unselect";
            this.buttonUnselect.UseVisualStyleBackColor = true;
            this.buttonUnselect.Click += new System.EventHandler(this.buttonUnselect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 522);
            this.Controls.Add(this.buttonUnselect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelNoOFIngred);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxAddNewRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Cook Book";
            this.groupBoxAddNewRecipe.ResumeLayout(false);
            this.groupBoxAddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNewRecipe;
        private System.Windows.Forms.TextBox textBoxRecipe;
        private System.Windows.Forms.Button buttonAddIngrediens;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxNameOfRecipe;
        private System.Windows.Forms.Label labelNameOfRecipe;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNoOFIngred;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUnselect;
    }
}

