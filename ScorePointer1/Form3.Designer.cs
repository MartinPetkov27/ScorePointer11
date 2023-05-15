
namespace ScorePointer1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.lbGameNameStart = new System.Windows.Forms.Label();
            this.lbPlayersInGame = new System.Windows.Forms.ListBox();
            this.lbMssControls = new System.Windows.Forms.Label();
            this.dmPoints = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btEnd = new System.Windows.Forms.Button();
            this.txtSlectedPoints = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbGameNameStart
            // 
            this.lbGameNameStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGameNameStart.AutoSize = true;
            this.lbGameNameStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGameNameStart.Location = new System.Drawing.Point(347, 43);
            this.lbGameNameStart.Name = "lbGameNameStart";
            this.lbGameNameStart.Size = new System.Drawing.Size(83, 32);
            this.lbGameNameStart.TabIndex = 0;
            this.lbGameNameStart.Text = "label1";
            this.lbGameNameStart.Click += new System.EventHandler(this.lbGameNameStart_Click);
            // 
            // lbPlayersInGame
            // 
            this.lbPlayersInGame.FormattingEnabled = true;
            this.lbPlayersInGame.ItemHeight = 15;
            this.lbPlayersInGame.Location = new System.Drawing.Point(70, 105);
            this.lbPlayersInGame.Name = "lbPlayersInGame";
            this.lbPlayersInGame.Size = new System.Drawing.Size(360, 289);
            this.lbPlayersInGame.TabIndex = 1;
            this.lbPlayersInGame.SelectedIndexChanged += new System.EventHandler(this.lbPlayersInGame_SelectedIndexChanged);
            // 
            // lbMssControls
            // 
            this.lbMssControls.AutoSize = true;
            this.lbMssControls.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMssControls.Location = new System.Drawing.Point(566, 105);
            this.lbMssControls.Name = "lbMssControls";
            this.lbMssControls.Size = new System.Drawing.Size(106, 30);
            this.lbMssControls.TabIndex = 2;
            this.lbMssControls.Text = "Controls:";
            // 
            // dmPoints
            // 
            this.dmPoints.Location = new System.Drawing.Point(566, 167);
            this.dmPoints.Name = "dmPoints";
            this.dmPoints.Size = new System.Drawing.Size(106, 23);
            this.dmPoints.TabIndex = 3;
            this.dmPoints.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(672, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.EnabledChanged += new System.EventHandler(this.lbPlayersInGame_SelectedIndexChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMinus
            // 
            this.btMinus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btMinus.Enabled = false;
            this.btMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btMinus.Location = new System.Drawing.Point(537, 138);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(23, 23);
            this.btMinus.TabIndex = 5;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = false;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEnd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEnd.Location = new System.Drawing.Point(537, 355);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(164, 39);
            this.btEnd.TabIndex = 6;
            this.btEnd.Text = "End Game";
            this.btEnd.UseVisualStyleBackColor = false;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // txtSlectedPoints
            // 
            this.txtSlectedPoints.Location = new System.Drawing.Point(566, 138);
            this.txtSlectedPoints.Name = "txtSlectedPoints";
            this.txtSlectedPoints.Size = new System.Drawing.Size(100, 23);
            this.txtSlectedPoints.TabIndex = 7;
            this.txtSlectedPoints.Text = "1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.btEnd_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSlectedPoints);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dmPoints);
            this.Controls.Add(this.lbMssControls);
            this.Controls.Add(this.lbPlayersInGame);
            this.Controls.Add(this.lbGameNameStart);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGameNameStart;
        private System.Windows.Forms.ListBox lbPlayersInGame;
        private System.Windows.Forms.Label lbMssControls;
        private System.Windows.Forms.DomainUpDown dmPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.TextBox txtSlectedPoints;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}