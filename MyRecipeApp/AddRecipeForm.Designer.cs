﻿namespace MyRecipeApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeaderForAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameHeader
            // 
            this.labelNameHeader.AutoSize = true;
            this.labelNameHeader.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameHeader.Location = new System.Drawing.Point(39, 122);
            this.labelNameHeader.Name = "labelNameHeader";
            this.labelNameHeader.Size = new System.Drawing.Size(167, 45);
            this.labelNameHeader.TabIndex = 0;
            this.labelNameHeader.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(223, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(544, 45);
            this.textBoxName.TabIndex = 1;
            // 
            // labelIngredientsHeader
            // 
            this.labelIngredientsHeader.AutoSize = true;
            this.labelIngredientsHeader.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIngredientsHeader.Location = new System.Drawing.Point(12, 208);
            this.labelIngredientsHeader.Name = "labelIngredientsHeader";
            this.labelIngredientsHeader.Size = new System.Drawing.Size(205, 40);
            this.labelIngredientsHeader.TabIndex = 2;
            this.labelIngredientsHeader.Text = "Ингредиенты";
            // 
            // labelInstructionHeader
            // 
            this.labelInstructionHeader.AutoSize = true;
            this.labelInstructionHeader.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructionHeader.Location = new System.Drawing.Point(25, 296);
            this.labelInstructionHeader.Name = "labelInstructionHeader";
            this.labelInstructionHeader.Size = new System.Drawing.Size(181, 40);
            this.labelInstructionHeader.TabIndex = 3;
            this.labelInstructionHeader.Text = "Инструкция";
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIngredients.Location = new System.Drawing.Point(223, 208);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(544, 45);
            this.textBoxIngredients.TabIndex = 4;
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstructions.Location = new System.Drawing.Point(223, 296);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.Size = new System.Drawing.Size(544, 45);
            this.textBoxInstructions.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(32, 384);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(314, 55);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(453, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(314, 55);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(713, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "©SomiSoya";
            // 
            // labelHeaderForAdd
            // 
            this.labelHeaderForAdd.AutoSize = true;
            this.labelHeaderForAdd.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderForAdd.Location = new System.Drawing.Point(88, 38);
            this.labelHeaderForAdd.Name = "labelHeaderForAdd";
            this.labelHeaderForAdd.Size = new System.Drawing.Size(631, 51);
            this.labelHeaderForAdd.TabIndex = 9;
            this.labelHeaderForAdd.Text = "Введите информацию о рецепте";
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.labelHeaderForAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxInstructions);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.labelInstructionHeader);
            this.Controls.Add(this.labelIngredientsHeader);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового рецепта";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeaderForAdd;
    }
}