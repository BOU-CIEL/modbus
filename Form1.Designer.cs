namespace TP_Modbus
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
            this.labelAdresseIP = new System.Windows.Forms.Label();
            this.textBoxAdressIP = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.textBoxStatut = new System.Windows.Forms.TextBox();
            this.buttonLireTension = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTension = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAdresseIP
            // 
            this.labelAdresseIP.AutoSize = true;
            this.labelAdresseIP.Location = new System.Drawing.Point(52, 43);
            this.labelAdresseIP.Name = "labelAdresseIP";
            this.labelAdresseIP.Size = new System.Drawing.Size(54, 13);
            this.labelAdresseIP.TabIndex = 0;
            this.labelAdresseIP.Text = "Ip serveur";
            // 
            // textBoxAdressIP
            // 
            this.textBoxAdressIP.Location = new System.Drawing.Point(112, 40);
            this.textBoxAdressIP.Name = "textBoxAdressIP";
            this.textBoxAdressIP.Size = new System.Drawing.Size(144, 20);
            const int V = 1;
            this.textBoxAdressIP.TabIndex = V;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(353, 40);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion.TabIndex = 2;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(450, 40);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(89, 23);
            this.buttonDeconnexion.TabIndex = 3;
            this.buttonDeconnexion.Text = "Deconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxStatut
            // 
            this.textBoxStatut.Location = new System.Drawing.Point(570, 40);
            this.textBoxStatut.Multiline = true;
            this.textBoxStatut.Name = "textBoxStatut";
            this.textBoxStatut.Size = new System.Drawing.Size(197, 389);
            this.textBoxStatut.TabIndex = 4;
            // 
            // buttonLireTension
            // 
            this.buttonLireTension.Location = new System.Drawing.Point(353, 127);
            this.buttonLireTension.Name = "buttonLireTension";
            this.buttonLireTension.Size = new System.Drawing.Size(75, 23);
            this.buttonLireTension.TabIndex = 5;
            this.buttonLireTension.Text = "Lire";
            this.buttonLireTension.UseVisualStyleBackColor = true;
            this.buttonLireTension.Click += new System.EventHandler(this.buttonLireTension_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tension moteur en Volt";
            // 
            // textBoxTension
            // 
            this.textBoxTension.Location = new System.Drawing.Point(450, 129);
            this.textBoxTension.Name = "textBoxTension";
            this.textBoxTension.Size = new System.Drawing.Size(89, 20);
            this.textBoxTension.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLireTension);
            this.Controls.Add(this.textBoxStatut);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxAdressIP);
            this.Controls.Add(this.labelAdresseIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdresseIP;
        private System.Windows.Forms.TextBox textBoxAdressIP;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TextBox textBoxStatut;
        private System.Windows.Forms.Button buttonLireTension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTension;
    }
}

