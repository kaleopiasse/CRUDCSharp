namespace projetoLp3
{
    partial class HomeView
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
            this.flwButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVoluntario = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.flwButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwButtons
            // 
            this.flwButtons.Controls.Add(this.btnVoluntario);
            this.flwButtons.Location = new System.Drawing.Point(12, 12);
            this.flwButtons.Name = "flwButtons";
            this.flwButtons.Size = new System.Drawing.Size(98, 537);
            this.flwButtons.TabIndex = 0;
            // 
            // btnVoluntario
            // 
            this.btnVoluntario.Location = new System.Drawing.Point(3, 3);
            this.btnVoluntario.Name = "btnVoluntario";
            this.btnVoluntario.Size = new System.Drawing.Size(83, 52);
            this.btnVoluntario.TabIndex = 0;
            this.btnVoluntario.Text = "Voluntário";
            this.btnVoluntario.UseVisualStyleBackColor = true;
            this.btnVoluntario.Click += new System.EventHandler(this.btnVoluntario_Click);
            // 
            // pnHome
            // 
            this.pnHome.Location = new System.Drawing.Point(123, 13);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(649, 536);
            this.pnHome.TabIndex = 1;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.flwButtons);
            this.Name = "HomeView";
            this.Text = "Home";
            this.flwButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwButtons;
        private System.Windows.Forms.Button btnVoluntario;
        private System.Windows.Forms.Panel pnHome;
    }
}