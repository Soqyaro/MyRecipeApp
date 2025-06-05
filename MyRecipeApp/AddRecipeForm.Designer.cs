namespace MyRecipeApp
{
    partial class AddRecipeForm
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
            this.labelNameHeader = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIngredientsHeader = new System.Windows.Forms.Label();
            this.labelInstructionHeader = new System.Windows.Forms.Label();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.textBoxInstructions = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameHeader
            // 
            this.labelNameHeader.AutoSize = true;
            this.labelNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameHeader.Location = new System.Drawing.Point(53, 29);
            this.labelNameHeader.Name = "labelNameHeader";
            this.labelNameHeader.Size = new System.Drawing.Size(137, 31);
            this.labelNameHeader.TabIndex = 0;
            this.labelNameHeader.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(59, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelIngredientsHeader
            // 
            this.labelIngredientsHeader.AutoSize = true;
            this.labelIngredientsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIngredientsHeader.Location = new System.Drawing.Point(307, 29);
            this.labelIngredientsHeader.Name = "labelIngredientsHeader";
            this.labelIngredientsHeader.Size = new System.Drawing.Size(181, 31);
            this.labelIngredientsHeader.TabIndex = 2;
            this.labelIngredientsHeader.Text = "Ингредиенты";
            // 
            // labelInstructionHeader
            // 
            this.labelInstructionHeader.AutoSize = true;
            this.labelInstructionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructionHeader.Location = new System.Drawing.Point(591, 29);
            this.labelInstructionHeader.Name = "labelInstructionHeader";
            this.labelInstructionHeader.Size = new System.Drawing.Size(164, 31);
            this.labelInstructionHeader.TabIndex = 3;
            this.labelInstructionHeader.Text = "Инструкция";
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(313, 96);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(175, 20);
            this.textBoxIngredients.TabIndex = 4;
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Location = new System.Drawing.Point(597, 96);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.Size = new System.Drawing.Size(158, 20);
            this.textBoxInstructions.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(139, 363);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(219, 51);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(451, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(219, 51);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxInstructions);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.labelInstructionHeader);
            this.Controls.Add(this.labelIngredientsHeader);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameHeader);
            this.Name = "AddRecipeForm";
            this.Text = "AddRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameHeader;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIngredientsHeader;
        private System.Windows.Forms.Label labelInstructionHeader;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.TextBox textBoxInstructions;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}