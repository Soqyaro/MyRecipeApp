namespace MyRecipeApp
{
    partial class Mainrec
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelHeaderText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 20;
            this.listBoxRecipes.Location = new System.Drawing.Point(12, 66);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(776, 284);
            this.listBoxRecipes.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(441, 368);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(347, 32);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = " Добавить рецепт";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(441, 406);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(347, 32);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Удаление выделенного рецепта";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 368);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(347, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранение рецептов";
            this.buttonSave.UseVisualStyleBackColor = true;
            
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 406);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(347, 32);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Загрузка рецептов из файла";
            this.buttonLoad.UseVisualStyleBackColor = true;
           
            // 
            // labelHeaderText
            // 
            this.labelHeaderText.AutoSize = true;
            this.labelHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderText.Location = new System.Drawing.Point(275, 20);
            this.labelHeaderText.Name = "labelHeaderText";
            this.labelHeaderText.Size = new System.Drawing.Size(247, 33);
            this.labelHeaderText.TabIndex = 5;
            this.labelHeaderText.Text = "Список рецептов";
            // 
            // Mainrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHeaderText);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxRecipes);
            this.Name = "Mainrec";
            this.Text = "Мейнрес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelHeaderText;
    }
}

