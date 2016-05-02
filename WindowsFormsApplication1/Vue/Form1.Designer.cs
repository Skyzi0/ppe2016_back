namespace WindowsFormsApplication1
{
    partial class FormAccueil
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(136, 242);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(169, 65);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Liste des tournois";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(313, 242);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(169, 65);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Créer un tournoi";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application Tournament Maker";
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(489, 242);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(169, 65);
            this.buttonStock.TabIndex = 3;
            this.buttonStock.Text = "Gestion des Stocks";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quitter l\'Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCheck);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAccueil";
            this.Text = "Tournament Maker - Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button button1;
    }
}

