namespace SnakeAndLadder
{
    partial class Form1
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
            this.lblNumberOfPlayers = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtNumberOfPlayers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(62, 66);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(125, 17);
            this.lblNumberOfPlayers.TabIndex = 0;
            this.lblNumberOfPlayers.Text = "Number of Players";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(62, 156);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(205, 112);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(115, 28);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.StartGame);
            // 
            // txtNumberOfPlayers
            // 
            this.txtNumberOfPlayers.Location = new System.Drawing.Point(205, 66);
            this.txtNumberOfPlayers.Name = "txtNumberOfPlayers";
            this.txtNumberOfPlayers.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfPlayers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 253);
            this.Controls.Add(this.txtNumberOfPlayers);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblNumberOfPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtNumberOfPlayers;
    }
}

