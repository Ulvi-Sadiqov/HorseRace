namespace Game2
{
	partial class form
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_finish_line = new System.Windows.Forms.Label();
			this.game_timer = new System.Windows.Forms.Timer(this.components);
			this.game_start = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lbl_about = new System.Windows.Forms.Label();
			this.pc_bx_3 = new System.Windows.Forms.PictureBox();
			this.pc_bx_2 = new System.Windows.Forms.PictureBox();
			this.pc_bx_1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pc_bx_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pc_bx_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pc_bx_1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-1, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(765, 27);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(-1, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(765, 27);
			this.label2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(-1, 326);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(765, 27);
			this.label3.TabIndex = 2;
			// 
			// lbl_finish_line
			// 
			this.lbl_finish_line.BackColor = System.Drawing.Color.White;
			this.lbl_finish_line.Location = new System.Drawing.Point(763, -1);
			this.lbl_finish_line.Name = "lbl_finish_line";
			this.lbl_finish_line.Size = new System.Drawing.Size(38, 406);
			this.lbl_finish_line.TabIndex = 3;
			// 
			// game_timer
			// 
			this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
			// 
			// game_start
			// 
			this.game_start.BackColor = System.Drawing.Color.DodgerBlue;
			this.game_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.game_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.game_start.Location = new System.Drawing.Point(12, 360);
			this.game_start.Name = "game_start";
			this.game_start.Size = new System.Drawing.Size(104, 35);
			this.game_start.TabIndex = 7;
			this.game_start.Text = "Start";
			this.game_start.UseVisualStyleBackColor = false;
			this.game_start.Click += new System.EventHandler(this.game_start_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DodgerBlue;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(141, 360);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 35);
			this.button2.TabIndex = 8;
			this.button2.Text = "Restart";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lbl_about
			// 
			this.lbl_about.AutoSize = true;
			this.lbl_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_about.Location = new System.Drawing.Point(279, 368);
			this.lbl_about.Name = "lbl_about";
			this.lbl_about.Size = new System.Drawing.Size(0, 20);
			this.lbl_about.TabIndex = 9;
			// 
			// pc_bx_3
			// 
			this.pc_bx_3.Image = global::Game2.Properties.Resources.horse2;
			this.pc_bx_3.Location = new System.Drawing.Point(12, 241);
			this.pc_bx_3.Name = "pc_bx_3";
			this.pc_bx_3.Size = new System.Drawing.Size(112, 82);
			this.pc_bx_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pc_bx_3.TabIndex = 6;
			this.pc_bx_3.TabStop = false;
			// 
			// pc_bx_2
			// 
			this.pc_bx_2.Image = global::Game2.Properties.Resources.horse;
			this.pc_bx_2.Location = new System.Drawing.Point(12, 121);
			this.pc_bx_2.Name = "pc_bx_2";
			this.pc_bx_2.Size = new System.Drawing.Size(112, 87);
			this.pc_bx_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pc_bx_2.TabIndex = 5;
			this.pc_bx_2.TabStop = false;
			// 
			// pc_bx_1
			// 
			this.pc_bx_1.Image = global::Game2.Properties.Resources.horse3;
			this.pc_bx_1.Location = new System.Drawing.Point(12, 3);
			this.pc_bx_1.Name = "pc_bx_1";
			this.pc_bx_1.Size = new System.Drawing.Size(112, 85);
			this.pc_bx_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pc_bx_1.TabIndex = 4;
			this.pc_bx_1.TabStop = false;
			// 
			// form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 404);
			this.Controls.Add(this.lbl_about);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.game_start);
			this.Controls.Add(this.pc_bx_3);
			this.Controls.Add(this.pc_bx_2);
			this.Controls.Add(this.pc_bx_1);
			this.Controls.Add(this.lbl_finish_line);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "form";
			this.Text = "Horse Race 2";
			((System.ComponentModel.ISupportInitialize)(this.pc_bx_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pc_bx_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pc_bx_1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_finish_line;
		private System.Windows.Forms.PictureBox pc_bx_1;
		private System.Windows.Forms.PictureBox pc_bx_2;
		private System.Windows.Forms.PictureBox pc_bx_3;
		private System.Windows.Forms.Timer game_timer;
		private System.Windows.Forms.Button game_start;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lbl_about;
	}
}

