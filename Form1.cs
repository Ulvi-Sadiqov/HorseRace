using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
	public partial class form : Form
	{
		public form()
		{
			InitializeComponent();
		}
		Random random = new Random();
		
		private void game_start_Click(object sender, EventArgs e)
		{
			game_timer.Enabled = true;
			
		}

		private void game_timer_Tick(object sender, EventArgs e)
		{
			int FirstHorseWidth = pc_bx_1.Width;
			int SecondHorseWidth = pc_bx_2.Width;
			int ThirdHorseWidth = pc_bx_3.Width;


			pc_bx_1.Left = pc_bx_1.Left + random.Next(5, 15);
			pc_bx_2.Left = pc_bx_2.Left + random.Next(5, 15);
			pc_bx_3.Left = pc_bx_3.Left + random.Next(5, 15);

			int finish = lbl_finish_line.Left;

			if (FirstHorseWidth + pc_bx_1.Left >= finish)
			{
				game_timer.Enabled = false;
				MessageBox.Show("Birinci at qalib geldi.");

			}
			if (SecondHorseWidth + pc_bx_2.Left >= finish)
			{
				game_timer.Enabled = false;
				MessageBox.Show("Ikinci at qalib geldi");

				
			}
			if (ThirdHorseWidth + pc_bx_3.Left >= finish)
			{
				game_timer.Enabled = false;
				MessageBox.Show("Ucuncu at qalib geldi");
				
			}




			if (pc_bx_1.Left > pc_bx_2.Left && pc_bx_1.Left > pc_bx_3.Left)
			{
				lbl_about.Text = "1 ci at ondedir.";
			}
			if (pc_bx_2.Left > pc_bx_1.Left && pc_bx_2.Left > pc_bx_3.Left)
			{
				lbl_about.Text = "2 ci at ondedir.";

			}
			if (pc_bx_3.Left > pc_bx_2.Left && pc_bx_3.Left > pc_bx_1.Left)
			{
				lbl_about.Text = "3 ci at ondedir.";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pc_bx_1.Left = 0;
			pc_bx_2.Left = 0;
			pc_bx_3.Left = 0;

			lbl_about.Text = "";
		}
	}
}
