namespace age
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_dateDeNaissance = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_dateDeNaissance
            // 
            this.textBox_dateDeNaissance.Location = new System.Drawing.Point(88, 58);
            this.textBox_dateDeNaissance.Name = "textBox_dateDeNaissance";
            this.textBox_dateDeNaissance.Size = new System.Drawing.Size(100, 20);
            this.textBox_dateDeNaissance.TabIndex = 1;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(76, 151);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(32, 13);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "result";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(39, 61);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(32, 13);
            this.label_age.TabIndex = 3;
            this.label_age.Text = "Age :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_dateDeNaissance);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_dateDeNaissance;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_age;
    }
}

