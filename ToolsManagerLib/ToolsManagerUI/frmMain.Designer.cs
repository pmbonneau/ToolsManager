namespace ToolsManagerUI
{
    partial class frmMain
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
            this.btnRunXPwnTools = new System.Windows.Forms.Button();
            this.btnRestoreDevice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunXPwnTools
            // 
            this.btnRunXPwnTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunXPwnTools.Location = new System.Drawing.Point(12, 12);
            this.btnRunXPwnTools.Name = "btnRunXPwnTools";
            this.btnRunXPwnTools.Size = new System.Drawing.Size(153, 46);
            this.btnRunXPwnTools.TabIndex = 0;
            this.btnRunXPwnTools.Text = "Run XPwnTools";
            this.btnRunXPwnTools.UseVisualStyleBackColor = true;
            this.btnRunXPwnTools.Click += new System.EventHandler(this.btnRunXPwnTools_Click);
            // 
            // btnRestoreDevice
            // 
            this.btnRestoreDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDevice.Location = new System.Drawing.Point(12, 74);
            this.btnRestoreDevice.Name = "btnRestoreDevice";
            this.btnRestoreDevice.Size = new System.Drawing.Size(153, 46);
            this.btnRestoreDevice.TabIndex = 1;
            this.btnRestoreDevice.Text = "Restore Device";
            this.btnRestoreDevice.UseVisualStyleBackColor = true;
            this.btnRestoreDevice.Click += new System.EventHandler(this.btnRestoreDevice_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.btnRestoreDevice);
            this.Controls.Add(this.btnRunXPwnTools);
            this.Name = "frmMain";
            this.Text = "ToolsManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunXPwnTools;
        private System.Windows.Forms.Button btnRestoreDevice;
    }
}

