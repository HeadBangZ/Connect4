namespace connect4
{
	partial class Connect4
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
			this.Frame = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Frame
			// 
			this.Frame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Frame.Location = new System.Drawing.Point(0, 0);
			this.Frame.Name = "Frame";
			this.Frame.Size = new System.Drawing.Size(700, 600);
			this.Frame.TabIndex = 0;
			this.Frame.Paint += new System.Windows.Forms.PaintEventHandler(this.Frame_Paint);
			this.Frame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frame_MouseClick);
			// 
			// Connect4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 600);
			this.Controls.Add(this.Frame);
			this.MaximumSize = new System.Drawing.Size(716, 639);
			this.MinimumSize = new System.Drawing.Size(716, 639);
			this.Name = "Connect4";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Frame;
	}
}

