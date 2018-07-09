using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis.UserControls
{
	public partial class MyPreloader : UserControl
	{
		int dir = 1;
		int curColorIndex = 0;

		List<Color> colors = new List<Color>();
		public MyPreloader()
		{
			InitializeComponent();

			colors.Add(Color.FromArgb(79, 189, 166));
			colors.Add(Color.FromArgb(0, 169, 148));
			colors.Add(Color.FromArgb(0, 174, 239));
			colors.Add(Color.FromArgb(0, 124, 176));
			colors.Add(Color.FromArgb(2, 32, 95));
			colors.Add(Color.FromArgb(74, 0, 85));
			colors.Add(Color.FromArgb(101, 0, 82));
			colors.Add(Color.FromArgb(240, 78, 36));
			colors.Add(Color.FromArgb(245, 129, 31));
			colors.Add(Color.FromArgb(255, 212, 0));
			colors.Add(Color.FromArgb(250, 166, 26));
			colors.Add(Color.FromArgb(237, 24, 76));
			colors.Add(Color.FromArgb(236, 18, 95));
			colors.Add(Color.FromArgb(187, 0, 95));
			colors.Add(Color.FromArgb(165, 0, 112));
			colors.Add(Color.FromArgb(180, 30, 141));
			colors.Add(Color.FromArgb(112, 43, 144));
			colors.Add(Color.FromArgb(111, 97, 170));
			colors.Add(Color.FromArgb(149, 124, 184));


			circle.ProgressColor = colors[curColorIndex];
		}
		private void MyPreloader_Load(object sender, EventArgs e)
		{
			
		}

		private void timCircle_Tick(object sender, EventArgs e)
		{
			if (circle.Value == 90)
			{
				dir = -1;
				circle.animationIterval = 4;
				SwitchColor();
			}
			else if(circle.Value == 10)
			{
				dir = 1;
				circle.animationIterval = 2;
				SwitchColor();
			}

			circle.Value += dir;
		}

		void SwitchColor()
		{
			bunifuColorTransition1.Color1 = colors[curColorIndex];

			if (curColorIndex < colors.Count-1)
			{
				curColorIndex++;
			}
			else
			{
				curColorIndex = 0;
			}

			bunifuColorTransition1.Color2 = colors[curColorIndex];

			timColor.Start();
		}

		private void timColor_Tick(object sender, EventArgs e)
		{
			if (bunifuColorTransition1.ProgessValue < 100)
			{
				bunifuColorTransition1.ProgessValue++;
				circle.ProgressColor = bunifuColorTransition1.Value;
			}
			else { bunifuColorTransition1.ProgessValue = 0; timColor.Stop(); }
		}
	}
}
