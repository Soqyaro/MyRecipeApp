namespace MyRecipeApp
{
    partial class TheReference
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
            this.buttonChoice = new System.Windows.Forms.Button();
            this.radioButtonOguzok = new System.Windows.Forms.RadioButton();
            this.radioButtonFreak = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChoice
            // 
            this.buttonChoice.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChoice.Location = new System.Drawing.Point(221, 388);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(321, 50);
            this.buttonChoice.TabIndex = 0;
            this.buttonChoice.Text = "Ответить";
            this.buttonChoice.UseVisualStyleBackColor = true;
            this.buttonChoice.Click += new System.EventHandler(this.buttonChoice_Click);
            // 
            // radioButtonOguzok
            // 
            this.radioButtonOguzok.AutoSize = true;
            this.radioButtonOguzok.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonOguzok.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOguzok.ForeColor = System.Drawing.Color.Black;
            this.radioButtonOguzok.Location = new System.Drawing.Point(221, 329);
            this.radioButtonOguzok.Name = "radioButtonOguzok";
            this.radioButtonOguzok.Size = new System.Drawing.Size(93, 53);
            this.radioButtonOguzok.TabIndex = 1;
            this.radioButtonOguzok.TabStop = true;
            this.radioButtonOguzok.Text = "ДА";
            this.radioButtonOguzok.UseVisualStyleBackColor = false;
            // 
            // radioButtonFreak
            // 
            this.radioButtonFreak.AutoSize = true;
            this.radioButtonFreak.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonFreak.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFreak.Location = new System.Drawing.Point(429, 329);
            this.radioButtonFreak.Name = "radioButtonFreak";
            this.radioButtonFreak.Size = new System.Drawing.Size(113, 53);
            this.radioButtonFreak.TabIndex = 2;
            this.radioButtonFreak.TabStop = true;
            this.radioButtonFreak.Text = "НЕТ";
            this.radioButtonFreak.UseVisualStyleBackColor = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(265, 275);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(229, 51);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "Ты огузок?";
            // 
            // TheReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyRecipeApp.Properties.Resources.oguzok3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.radioButtonFreak);
            this.Controls.Add(this.radioButtonOguzok);
            this.Controls.Add(this.buttonChoice);
            this.Name = "TheReference";
            this.Text = "У каждой стороны есть две медали";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheReference_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoice;
        private System.Windows.Forms.RadioButton radioButtonOguzok;
        private System.Windows.Forms.RadioButton radioButtonFreak;
        private System.Windows.Forms.Label labelQuestion;
    }
}