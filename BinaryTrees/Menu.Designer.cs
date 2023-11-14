namespace BinaryTrees
{
    partial class Menu
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
            this.btnScenario1 = new System.Windows.Forms.Button();
            this.btnScenario2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScenario1
            // 
            this.btnScenario1.Location = new System.Drawing.Point(108, 53);
            this.btnScenario1.Name = "btnScenario1";
            this.btnScenario1.Size = new System.Drawing.Size(75, 23);
            this.btnScenario1.TabIndex = 0;
            this.btnScenario1.Text = "Escenario 1";
            this.btnScenario1.UseVisualStyleBackColor = true;
            this.btnScenario1.Click += new System.EventHandler(this.btnScenario1_Click);
            // 
            // btnScenario2
            // 
            this.btnScenario2.Location = new System.Drawing.Point(108, 92);
            this.btnScenario2.Name = "btnScenario2";
            this.btnScenario2.Size = new System.Drawing.Size(75, 23);
            this.btnScenario2.TabIndex = 1;
            this.btnScenario2.Text = "Escenario 2";
            this.btnScenario2.UseVisualStyleBackColor = true;
            this.btnScenario2.Click += new System.EventHandler(this.btnScenario2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(186, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 207);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnScenario2);
            this.Controls.Add(this.btnScenario1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScenario1;
        private System.Windows.Forms.Button btnScenario2;
        private System.Windows.Forms.Button button3;
    }
}