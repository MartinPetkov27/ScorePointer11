
namespace ScorePointer1
{
    partial class Form2
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
            this.lblMssEnterGameName = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.btInitializeGame = new System.Windows.Forms.Button();
            this.lblMssAddPlayer = new System.Windows.Forms.Label();
            this.lblMssWriteName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtChangedName = new System.Windows.Forms.TextBox();
            this.lblMssStaringPoints = new System.Windows.Forms.Label();
            this.txtStartingPoints = new System.Windows.Forms.TextBox();
            this.btAddPlayer = new System.Windows.Forms.Button();
            this.lsbPlayers = new System.Windows.Forms.ListBox();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMssEnterGameName
            // 
            this.lblMssEnterGameName.AutoSize = true;
            this.lblMssEnterGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMssEnterGameName.Location = new System.Drawing.Point(328, 68);
            this.lblMssEnterGameName.Name = "lblMssEnterGameName";
            this.lblMssEnterGameName.Size = new System.Drawing.Size(105, 21);
            this.lblMssEnterGameName.TabIndex = 0;
            this.lblMssEnterGameName.Text = "Game name:";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(328, 92);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(105, 23);
            this.txtGameName.TabIndex = 1;
            // 
            // btInitializeGame
            // 
            this.btInitializeGame.BackColor = System.Drawing.Color.Black;
            this.btInitializeGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInitializeGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInitializeGame.Location = new System.Drawing.Point(439, 92);
            this.btInitializeGame.Name = "btInitializeGame";
            this.btInitializeGame.Size = new System.Drawing.Size(23, 23);
            this.btInitializeGame.TabIndex = 2;
            this.btInitializeGame.Text = "+";
            this.btInitializeGame.UseVisualStyleBackColor = false;
            this.btInitializeGame.Click += new System.EventHandler(this.btInitializeGame_Click);
            // 
            // lblMssAddPlayer
            // 
            this.lblMssAddPlayer.AutoSize = true;
            this.lblMssAddPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMssAddPlayer.Location = new System.Drawing.Point(328, 149);
            this.lblMssAddPlayer.Name = "lblMssAddPlayer";
            this.lblMssAddPlayer.Size = new System.Drawing.Size(100, 21);
            this.lblMssAddPlayer.TabIndex = 3;
            this.lblMssAddPlayer.Text = "Add players";
            this.lblMssAddPlayer.Visible = false;
            // 
            // lblMssWriteName
            // 
            this.lblMssWriteName.AutoSize = true;
            this.lblMssWriteName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMssWriteName.Location = new System.Drawing.Point(210, 205);
            this.lblMssWriteName.Name = "lblMssWriteName";
            this.lblMssWriteName.Size = new System.Drawing.Size(43, 15);
            this.lblMssWriteName.TabIndex = 4;
            this.lblMssWriteName.Text = "Name:";
            this.lblMssWriteName.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Custom",
            "Mr.White",
            "Skyler White",
            "Jesse Pinkman",
            "Hank Schrader",
            "Marie Schrader",
            "Walter White Jr.",
            "Gus Fring",
            "Saul Goodman",
            "Mike Ehrmantraut",
            "Todd",
            "Steven Gomez",
            "Bogdan",
            "Tuco Salamanca",
            "Hector Salamanca",
            "Don Eladio",
            "Jane Margolis",
            "Victor",
            "Gretchen Schwartz",
            "Elliott Schwartz"});
            this.comboBox1.Location = new System.Drawing.Point(268, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtChangedName
            // 
            this.txtChangedName.Location = new System.Drawing.Point(268, 230);
            this.txtChangedName.Name = "txtChangedName";
            this.txtChangedName.Size = new System.Drawing.Size(121, 23);
            this.txtChangedName.TabIndex = 6;
            this.txtChangedName.Visible = false;
            // 
            // lblMssStaringPoints
            // 
            this.lblMssStaringPoints.AutoSize = true;
            this.lblMssStaringPoints.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMssStaringPoints.Location = new System.Drawing.Point(407, 204);
            this.lblMssStaringPoints.Name = "lblMssStaringPoints";
            this.lblMssStaringPoints.Size = new System.Drawing.Size(44, 15);
            this.lblMssStaringPoints.TabIndex = 7;
            this.lblMssStaringPoints.Text = "Points:";
            this.lblMssStaringPoints.Visible = false;
            // 
            // txtStartingPoints
            // 
            this.txtStartingPoints.Location = new System.Drawing.Point(457, 201);
            this.txtStartingPoints.Name = "txtStartingPoints";
            this.txtStartingPoints.Size = new System.Drawing.Size(121, 23);
            this.txtStartingPoints.TabIndex = 8;
            this.txtStartingPoints.Visible = false;
            // 
            // btAddPlayer
            // 
            this.btAddPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAddPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAddPlayer.Location = new System.Drawing.Point(594, 201);
            this.btAddPlayer.Name = "btAddPlayer";
            this.btAddPlayer.Size = new System.Drawing.Size(23, 23);
            this.btAddPlayer.TabIndex = 9;
            this.btAddPlayer.Text = "+";
            this.btAddPlayer.UseVisualStyleBackColor = false;
            this.btAddPlayer.Visible = false;
            this.btAddPlayer.Click += new System.EventHandler(this.btAddPlayer_Click);
            // 
            // lsbPlayers
            // 
            this.lsbPlayers.FormattingEnabled = true;
            this.lsbPlayers.ItemHeight = 15;
            this.lsbPlayers.Location = new System.Drawing.Point(210, 284);
            this.lsbPlayers.Name = "lsbPlayers";
            this.lsbPlayers.Size = new System.Drawing.Size(368, 79);
            this.lsbPlayers.TabIndex = 10;
            this.lsbPlayers.Visible = false;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStart.Location = new System.Drawing.Point(287, 369);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(185, 39);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Visible = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lsbPlayers);
            this.Controls.Add(this.btAddPlayer);
            this.Controls.Add(this.txtStartingPoints);
            this.Controls.Add(this.lblMssStaringPoints);
            this.Controls.Add(this.txtChangedName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMssWriteName);
            this.Controls.Add(this.lblMssAddPlayer);
            this.Controls.Add(this.btInitializeGame);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.lblMssEnterGameName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMssEnterGameName;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Button btInitializeGame;
        private System.Windows.Forms.Label lblMssAddPlayer;
        private System.Windows.Forms.Label lblMssWriteName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtChangedName;
        private System.Windows.Forms.Label lblMssStaringPoints;
        private System.Windows.Forms.TextBox txtStartingPoints;
        private System.Windows.Forms.Button btAddPlayer;
        private System.Windows.Forms.ListBox lsbPlayers;
        private System.Windows.Forms.Button btStart;
    }
}