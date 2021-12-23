
namespace GUI
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.textBoxE2 = new System.Windows.Forms.TextBox();
            this.textBoxE1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.cmdProd = new System.Windows.Forms.Button();
            this.cmdMod = new System.Windows.Forms.Button();
            this.cmdDiff = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdPuissance = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRes);
            this.groupBox1.Controls.Add(this.textBoxE2);
            this.groupBox1.Controls.Add(this.textBoxE1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les termes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(139, 158);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(176, 34);
            this.textBoxRes.TabIndex = 5;
            // 
            // textBoxE2
            // 
            this.textBoxE2.Location = new System.Drawing.Point(139, 99);
            this.textBoxE2.Multiline = true;
            this.textBoxE2.Name = "textBoxE2";
            this.textBoxE2.Size = new System.Drawing.Size(176, 34);
            this.textBoxE2.TabIndex = 4;
            // 
            // textBoxE1
            // 
            this.textBoxE1.Location = new System.Drawing.Point(139, 39);
            this.textBoxE1.Multiline = true;
            this.textBoxE1.Name = "textBoxE1";
            this.textBoxE1.Size = new System.Drawing.Size(176, 34);
            this.textBoxE1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Résultat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Element 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Element 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDiv);
            this.groupBox2.Controls.Add(this.cmdProd);
            this.groupBox2.Controls.Add(this.cmdMod);
            this.groupBox2.Controls.Add(this.cmdDiff);
            this.groupBox2.Controls.Add(this.cmdAdd);
            this.groupBox2.Location = new System.Drawing.Point(453, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les Opérations";
            // 
            // cmdDiv
            // 
            this.cmdDiv.Location = new System.Drawing.Point(205, 146);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(80, 60);
            this.cmdDiv.TabIndex = 4;
            this.cmdDiv.Text = "/";
            this.cmdDiv.UseVisualStyleBackColor = true;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // cmdProd
            // 
            this.cmdProd.Location = new System.Drawing.Point(16, 146);
            this.cmdProd.Name = "cmdProd";
            this.cmdProd.Size = new System.Drawing.Size(80, 60);
            this.cmdProd.TabIndex = 3;
            this.cmdProd.Text = "*";
            this.cmdProd.UseVisualStyleBackColor = true;
            this.cmdProd.Click += new System.EventHandler(this.cmdProd_Click);
            // 
            // cmdMod
            // 
            this.cmdMod.Location = new System.Drawing.Point(108, 87);
            this.cmdMod.Name = "cmdMod";
            this.cmdMod.Size = new System.Drawing.Size(80, 60);
            this.cmdMod.TabIndex = 2;
            this.cmdMod.Text = "%";
            this.cmdMod.UseVisualStyleBackColor = true;
            this.cmdMod.Click += new System.EventHandler(this.cmdMod_Click);
            // 
            // cmdDiff
            // 
            this.cmdDiff.Location = new System.Drawing.Point(205, 26);
            this.cmdDiff.Name = "cmdDiff";
            this.cmdDiff.Size = new System.Drawing.Size(80, 60);
            this.cmdDiff.TabIndex = 1;
            this.cmdDiff.Text = "-";
            this.cmdDiff.UseVisualStyleBackColor = true;
            this.cmdDiff.Click += new System.EventHandler(this.cmdDiff_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(16, 26);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(80, 60);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdQuitter);
            this.groupBox3.Controls.Add(this.cmdPuissance);
            this.groupBox3.Controls.Add(this.cmdReset);
            this.groupBox3.Location = new System.Drawing.Point(28, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les actions";
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(533, 37);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(153, 54);
            this.cmdQuitter.TabIndex = 2;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdPuissance
            // 
            this.cmdPuissance.Location = new System.Drawing.Point(286, 37);
            this.cmdPuissance.Name = "cmdPuissance";
            this.cmdPuissance.Size = new System.Drawing.Size(153, 54);
            this.cmdPuissance.TabIndex = 1;
            this.cmdPuissance.Text = "Puissance";
            this.cmdPuissance.UseVisualStyleBackColor = true;
            this.cmdPuissance.Click += new System.EventHandler(this.cmdPuissance_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(52, 37);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(153, 54);
            this.cmdReset.TabIndex = 0;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma première calculatrice GK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdDiff;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdProd;
        private System.Windows.Forms.Button cmdMod;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.TextBox textBoxE2;
        private System.Windows.Forms.TextBox textBoxE1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdPuissance;
        private System.Windows.Forms.Button cmdReset;
    }
}

