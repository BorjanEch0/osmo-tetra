using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SDRSharp.Tetra
{
	[Category("SDRSharp")]
	[Description("Display Panel")]
	[DesignTimeVisible(true)]
	public class Display : UserControl
	{
		// ‌⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮
		private IContainer u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮;

		// ‭‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮
		private Bitmap u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮;

		// ⁯‭‏‍‏‭⁪‪⁭⁫‭⁮⁮⁭‏⁫⁬⁭‮‏‮⁭⁫‮‮⁬‬⁮‮‎‬‬​⁯⁬⁬⁪⁯‏‮‮
		private Graphics u206f‭‏‍‏‭⁪‪⁭⁫‭⁮⁮⁭‏⁫⁬⁭‮‏‮⁭⁫‮‮⁬‬⁮‮‎‬‬​⁯⁬⁬⁪⁯‏‮‮;

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‎‬‌⁮⁬‌​⁯⁯⁯⁮‬⁭‏‬⁮‍⁯‏⁬⁯‍⁫⁭⁭⁬​⁬​‌‭⁯⁫‫‏‏‭⁫‏‪‮
		private void u200e‬‌⁮⁬‌​⁯⁯⁯⁮‬⁭‏‬⁮‍⁯‏⁬⁯‍⁫⁭⁭⁬​⁬​‌‭⁯⁫‫‏‏‭⁫‏‪‮()
		{
			Display.u206b‌⁮⁬‍​⁮‫‌⁯‌‏‭⁪‎⁫‮‪⁯‪⁪⁬‪‍‬‍‭⁭⁫‎⁭‎‎‎⁯​⁪‮⁮⁮‮(this);
		Label0:
			int num = -1309405941;
			while (true)
			{
				int num1 = num ^ -680197911;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						Display.u206e‬‬‪‫⁬​‍‏‍‍​⁬‍‭‎‎‍‏‫⁮⁭‫⁭⁫‪⁪⁫‬⁭‬‏‪‪‫⁫‏‎‏‬‮(this, false);
						return;
					}
					case 2:
					{
						Display.u200c‏‭⁪⁯‌‪⁫⁫‎⁪⁪‪​‌‍‌⁮⁭‫⁪‭‫⁫⁮‍‌‬‮‬‍‭​⁭⁭‮‎⁪‮‍‮(this, new SizeF(6f, 13f));
						Display.u206c‎⁪‫‏‫‏‍‭‫‮⁪⁭‭⁬⁫‮⁪‪‪​​​‬‬⁮‮‮‏‫⁬‫⁪‫‭‭⁪‍⁬⁯‮(this, System.Windows.Forms.AutoScaleMode.Font);
						Display.u200f‮⁬​‮⁭‎⁭​‌‫⁪⁮⁯‍​⁮​‫⁭⁪⁬⁭⁬‌​⁫‫‬‌‮‮⁪⁫‫⁪⁪‎‪‌‮(this, ImageLayout.Zoom);
						this.DoubleBuffered = true;
						Display.u206c⁯⁭‬‬​⁫‬‮⁯‏‌‪‍‫‬⁮⁬‎⁬‮​‪‌‭​‎​‏‏‫​‪⁮‌‍⁪⁭⁭‫‮(this, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1792943409));
						num = -348628400;
						continue;
					}
				}
			}
			Display.u206e‬‬‪‫⁬​‍‏‍‍​⁬‍‭‎‎‍‏‫⁮⁭‫⁭⁫‪⁪⁫‬⁭‬‏‪‪‫⁫‏‎‏‬‮(this, false);
		}

		// ‭​​⁫‮⁫‌‮‎‏‏‮‌‏‬⁫⁯⁪⁫‌⁭⁬‍⁬​‬​⁯‏⁯⁫‎‌⁭⁯‏‮‎‮‌‮
		// privatescope
		internal static void u202d​​⁫‮⁫‌‮‎‏‏‮‌‏‬⁫⁯⁪⁫‌⁭⁬‍⁬​‬​⁯‏⁯⁫‎‌⁭⁯‏‮‎‮‌‮(IDisposable disposable)
		{
			disposable.Dispose();
		}

		// ⁫‌⁮⁬‍​⁮‫‌⁯‌‏‭⁪‎⁫‮‪⁯‪⁪⁬‪‍‬‍‭⁭⁫‎⁭‎‎‎⁯​⁪‮⁮⁮‮
		// privatescope
		internal static void u206b‌⁮⁬‍​⁮‫‌⁯‌‏‭⁪‎⁫‮‪⁯‪⁪⁬‪‍‬‍‭⁭⁫‎⁭‎‎‎⁯​⁪‮⁮⁮‮(Control control)
		{
			control.SuspendLayout();
		}

		// ‌‏‭⁪⁯‌‪⁫⁫‎⁪⁪‪​‌‍‌⁮⁭‫⁪‭‫⁫⁮‍‌‬‮‬‍‭​⁭⁭‮‎⁪‮‍‮
		// privatescope
		internal static void u200c‏‭⁪⁯‌‪⁫⁫‎⁪⁪‪​‌‍‌⁮⁭‫⁪‭‫⁫⁮‍‌‬‮‬‍‭​⁭⁭‮‎⁪‮‍‮(ContainerControl containerControl, SizeF sizeF)
		{
			containerControl.AutoScaleDimensions = sizeF;
		}

		// ⁬‎⁪‫‏‫‏‍‭‫‮⁪⁭‭⁬⁫‮⁪‪‪​​​‬‬⁮‮‮‏‫⁬‫⁪‫‭‭⁪‍⁬⁯‮
		// privatescope
		internal static void u206c‎⁪‫‏‫‏‍‭‫‮⁪⁭‭⁬⁫‮⁪‪‪​​​‬‬⁮‮‮‏‫⁬‫⁪‫‭‭⁪‍⁬⁯‮(ContainerControl containerControl, System.Windows.Forms.AutoScaleMode autoScaleMode)
		{
			containerControl.AutoScaleMode = autoScaleMode;
		}

		// ‏‮⁬​‮⁭‎⁭​‌‫⁪⁮⁯‍​⁮​‫⁭⁪⁬⁭⁬‌​⁫‫‬‌‮‮⁪⁫‫⁪⁪‎‪‌‮
		// privatescope
		internal static void u200f‮⁬​‮⁭‎⁭​‌‫⁪⁮⁯‍​⁮​‫⁭⁪⁬⁭⁬‌​⁫‫‬‌‮‮⁪⁫‫⁪⁪‎‪‌‮(Control control, ImageLayout imageLayout)
		{
			control.BackgroundImageLayout = imageLayout;
		}

		// ⁬⁯⁭‬‬​⁫‬‮⁯‏‌‪‍‫‬⁮⁬‎⁬‮​‪‌‭​‎​‏‏‫​‪⁮‌‍⁪⁭⁭‫‮
		// privatescope
		internal static void u206c⁯⁭‬‬​⁫‬‮⁯‏‌‪‍‫‬⁮⁬‎⁬‮​‪‌‭​‎​‏‏‫​‪⁮‌‍⁪⁭⁭‫‮(Control control, string str)
		{
			control.Name = str;
		}

		// ⁮‬‬‪‫⁬​‍‏‍‍​⁬‍‭‎‎‍‏‫⁮⁭‫⁭⁫‪⁪⁫‬⁭‬‏‪‪‫⁫‏‎‏‬‮
		// privatescope
		internal static void u206e‬‬‪‫⁬​‍‏‍‍​⁬‍‭‎‎‍‏‫⁮⁭‫⁭⁫‪⁪⁫‬⁭‬‏‪‪‫⁫‏‎‏‬‮(Control control, bool flag)
		{
			control.ResumeLayout(flag);
		}

		// ​⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮
		// privatescope
		internal static Rectangle u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(Control control)
		{
			return control.ClientRectangle;
		}

		// ‮‬⁪​⁬‬‭‎⁬​⁫‎‫‌⁬⁪‎‍‎‌⁫‭‪‫‌‎⁯‎‌⁭‏‎‫‌⁯‍⁬‮‮‏‮
		// privatescope
		internal static Bitmap u202e‬⁪​⁬‬‭‎⁬​⁫‎‫‌⁬⁪‎‍‎‌⁫‭‪‫‌‎⁯‎‌⁭‏‎‫‌⁯‍⁬‮‮‏‮(int num, int num, PixelFormat pixelFormat)
		{
			return new Bitmap(num, num, pixelFormat);
		}

		// ⁪‍⁬⁫‬‬‎‏‌‌‭‍​‭‍‍⁯‭⁯‮⁪‌‎‮‪‌‭‭‪​⁪⁬⁯⁮‮​‎‫⁭⁪‮
		// privatescope
		internal static Graphics u206a‍⁬⁫‬‬‎‏‌‌‭‍​‭‍‍⁯‭⁯‮⁪‌‎‮‪‌‭‭‪​⁪⁬⁯⁮‮​‎‫⁭⁪‮(Image image)
		{
			return Graphics.FromImage(image);
		}

		// ⁯⁮⁪‌‌⁪‪​‌⁮‌‫⁬‪‫​‌⁬‎⁭⁪⁫⁬⁮‌⁬⁭‬⁪⁯⁯‫⁭⁫‎‪⁫⁪‌‫‮
		// privatescope
		internal static void u206f⁮⁪‌‌⁪‪​‌⁮‌‫⁬‪‫​‌⁬‎⁭⁪⁫⁬⁮‌⁬⁭‬⁪⁯⁯‫⁭⁫‎‪⁫⁪‌‫‮(Graphics graphic, Color color)
		{
			graphic.Clear(color);
		}

		// ‎⁫‮‬‭‍‎‮⁫‎⁭‫‮‍‮‌‎‪‪‍‫‭⁬‬⁮‮‭⁭‬​⁪‫‎​‪‎⁪‌‌‌‮
		// privatescope
		internal static Pen u200e⁫‮‬‭‍‎‮⁫‎⁭‫‮‍‮‌‎‪‪‍‫‭⁬‬⁮‮‭⁭‬​⁪‫‎​‪‎⁪‌‌‌‮(Color color, float single)
		{
			return new Pen(color, single);
		}

		// ⁫‍‏​‎⁫‫‫⁪‍‌‎‎‮​‬‌‏‌‫⁮⁮‮‫⁬‫‍⁫‬‮⁯‎⁫‬⁭​‌⁯‍‬‮
		// privatescope
		internal static Pen u206b‍‏​‎⁫‫‫⁪‍‌‎‎‮​‬‌‏‌‫⁮⁮‮‫⁬‫‍⁫‬‮⁯‎⁫‬⁭​‌⁯‍‬‮(Color color)
		{
			return new Pen(color);
		}

		// ‬⁮⁫⁫‎‌⁫‎‪‌‬‭‬⁫‎‎​‍​‫‫‭‫‫‬‮‭‍⁬⁫⁭‮‭‭‭‎‪⁮⁮⁭‮
		// privatescope
		internal static System.Drawing.Font u202c⁮⁫⁫‎‌⁫‎‪‌‬‭‬⁫‎‎​‍​‫‫‭‫‫‬‮‭‍⁬⁫⁭‮‭‭‭‎‪⁮⁮⁭‮(string str, float single)
		{
			return new System.Drawing.Font(str, single);
		}

		// ‮⁪⁬‍​‌‎‎‪‎⁪‬‮⁭‎⁬‍‏‏‍‪‏‭‮⁫⁯‏⁫‭‍‭‮⁪‌‏⁮‬‬‍‫‮
		// privatescope
		internal static SolidBrush u202e⁪⁬‍​‌‎‎‪‎⁪‬‮⁭‎⁬‍‏‏‍‪‏‭‮⁫⁯‏⁫‭‍‭‮⁪‌‏⁮‬‬‍‫‮(Color color)
		{
			return new SolidBrush(color);
		}

		// ‮⁬​⁬⁪‎‫⁮‌‍⁬‎‮‏‪⁫‌⁫‍⁪‪​⁪‏⁬‫‎⁭‮⁪‮⁪⁫‮‎‪‫⁬‮‪‮
		// privatescope
		internal static void u202e⁬​⁬⁪‎‫⁮‌‍⁬‎‮‏‪⁫‌⁫‍⁪‪​⁪‏⁬‫‎⁭‮⁪‮⁪⁫‮‎‪‫⁬‮‪‮(Graphics graphic, Pen pen, float single, float single, float single, float single)
		{
			graphic.DrawLine(pen, single, single, single, single);
		}

		// ⁪​⁯‮​‎‮‫⁫‬‮‍⁮⁭⁮⁪‫‍‫‍‍‬⁫⁮‭⁬‪‬⁭‭⁯​‮‭⁮⁫‪‮‭‮‮
		// privatescope
		internal static void u206a​⁯‮​‎‮‫⁫‬‮‍⁮⁭⁮⁪‫‍‫‍‍‬⁫⁮‭⁬‪‬⁭‭⁯​‮‭⁮⁫‪‮‭‮‮(Graphics graphic, CompositingMode compositingMode)
		{
			graphic.CompositingMode = compositingMode;
		}

		// ‍‌‫​‬‏⁫‮‌‍⁯⁮⁬⁬⁫⁮‬⁬‬‏‫‏⁭⁪‮‫‪‮‮⁪‪‍⁮‫⁪⁪‎⁮‬⁬‮
		// privatescope
		internal static void u200d‌‫​‬‏⁫‮‌‍⁯⁮⁬⁬⁫⁮‬⁬‬‏‫‏⁭⁪‮‫‪‮‮⁪‪‍⁮‫⁪⁪‎⁮‬⁬‮(Graphics graphic, CompositingQuality compositingQuality)
		{
			graphic.CompositingQuality = compositingQuality;
		}

		// ‪⁯‌‮⁯‌‫⁪⁯‍‏‪⁬‌⁫⁫‫⁪‏‮⁮‭⁭⁭‪⁫‎​‏‌‭‍‎⁭‌‏⁬⁯‌⁯‮
		// privatescope
		internal static void u202a⁯‌‮⁯‌‫⁪⁯‍‏‪⁬‌⁫⁫‫⁪‏‮⁮‭⁭⁭‪⁫‎​‏‌‭‍‎⁭‌‏⁬⁯‌⁯‮(Graphics graphic, SmoothingMode smoothingMode)
		{
			graphic.SmoothingMode = smoothingMode;
		}

		// ‬‪‬⁬‎‫‍‭‭‎⁭​⁯⁮‏⁪‎‮‫⁪‏‫‏⁯⁬‏‌‭⁪‭⁪⁯‌⁮‪‭‪⁭⁮⁫‮
		// privatescope
		internal static void u202c‪‬⁬‎‫‍‭‭‎⁭​⁯⁮‏⁪‎‮‫⁪‏‫‏⁯⁬‏‌‭⁪‭⁪⁯‌⁮‪‭‪⁭⁮⁫‮(Graphics graphic, PixelOffsetMode pixelOffsetMode)
		{
			graphic.PixelOffsetMode = pixelOffsetMode;
		}

		// ‍‪‬⁮⁮⁮‎⁪⁫‭‮‮⁫‏⁫‬‎‪‫⁯‬‏⁪⁬‫‫⁯‭⁫​‬⁯⁭‫‮‭‪⁬‪‏‮
		// privatescope
		internal static void u200d‪‬⁮⁮⁮‎⁪⁫‭‮‮⁫‏⁫‬‎‪‫⁯‬‏⁪⁬‫‫⁯‭⁫​‬⁯⁭‫‮‭‪⁬‪‏‮(Graphics graphic, InterpolationMode interpolationMode)
		{
			graphic.InterpolationMode = interpolationMode;
		}

		// ‌‭‬‬‬⁮‪⁫⁯​⁫⁬‏‭‫‬⁯‬‍‍⁫‬‮‎‭⁫⁪⁪‪‬‭⁯⁫‫⁪‫‍​⁬⁪‮
		// privatescope
		internal static Graphics u200c‭‬‬‬⁮‪⁫⁯​⁫⁬‏‭‫‬⁯‬‍‍⁫‬‮‎‭⁫⁪⁪‪‬‭⁯⁫‫⁪‫‍​⁬⁪‮(PaintEventArgs paintEventArg)
		{
			return paintEventArg.Graphics;
		}

		// ‌⁮⁭‍‮⁯‏‎⁫‮‭⁮‮‫⁫⁫‍⁫‭‪‭‪‪‌⁪‭‭​‍‭‭‮​⁪⁯‎⁫‌⁬‬‮
		// privatescope
		internal static void u200c⁮⁭‍‮⁯‏‎⁫‮‭⁮‮‫⁫⁫‍⁫‭‪‭‪‪‌⁪‭‭​‍‭‭‮​⁪⁯‎⁫‌⁬‬‮(Graphics graphic, Image image, int num, int num)
		{
			graphic.DrawImageUnscaled(image, num, num);
		}

		// ‪‮⁯‭‬⁪‌‪⁬‬⁭‮⁬​​⁫‬‍⁪⁪⁮⁫​⁯‬‮‌‪⁪⁫‪‫‬⁭⁬⁫⁫‍⁬‎‮
		// privatescope
		internal static void u202a‮⁯‭‬⁪‌‪⁬‬⁭‮⁬​​⁫‬‍⁪⁪⁮⁫​⁯‬‮‌‪⁪⁫‪‫‬⁭⁬⁫⁫‍⁬‎‮(Image image)
		{
			image.Dispose();
		}

		// ⁭​‫⁬‮​⁭‭‬‏‮⁬⁬‬⁫‏​⁪⁭⁬⁯⁯‭⁪⁭‬⁭‫‭⁫⁪‎‪‍‫⁮‍⁭⁪‮
		// privatescope
		internal static void u206d​‫⁬‮​⁭‭‬‏‮⁬⁬‬⁫‏​⁪⁭⁬⁯⁯‭⁪⁭‬⁭‫‭⁫⁪‎‪‍‫⁮‍⁭⁪‮(Graphics graphic)
		{
			graphic.Dispose();
		}

		public Display()
		{
			int width = Display.u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(this).Width;
			Rectangle rectangle = Display.u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(this);
			this.u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮ = Display.u202e‬⁪​⁬‬‭‎⁬​⁫‎‫‌⁬⁪‎‍‎‌⁫‭‪‫‌‎⁯‎‌⁭‏‎‫‌⁯‍⁬‮‮‏‮(width, rectangle.Height, PixelFormat.Format32bppArgb);
			this.u206f‭‏‍‏‭⁪‪⁭⁫‭⁮⁮⁭‏⁫⁬⁭‮‏‮⁭⁫‮‮⁬‬⁮‮‎‬‬​⁯⁬⁬⁪⁯‏‮‮ = Display.u206a‍⁬⁫‬‬‎‏‌‌‭‍​‭‍‍⁯‭⁯‮⁪‌‎‮‪‌‭‭‪​⁪⁬⁯⁮‮​‎‫⁭⁪‮(this.u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮);
			this.u200e‬‌⁮⁬‌​⁯⁯⁯⁮‬⁭‏‬⁮‍⁯‏⁬⁯‍⁫⁭⁭⁬​⁬​‌‭⁯⁫‫‏‏‭⁫‏‪‮();
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.UpdateStyles();
		}

		public static void ConfigureGraphics(Graphics graphics)
		{
			Display.u206a​⁯‮​‎‮‫⁫‬‮‍⁮⁭⁮⁪‫‍‫‍‍‬⁫⁮‭⁬‪‬⁭‭⁯​‮‭⁮⁫‪‮‭‮‮(graphics, CompositingMode.SourceCopy);
			Display.u200d‌‫​‬‏⁫‮‌‍⁯⁮⁬⁬⁫⁮‬⁬‬‏‫‏⁭⁪‮‫‪‮‮⁪‪‍⁮‫⁪⁪‎⁮‬⁬‮(graphics, CompositingQuality.HighSpeed);
		Label1:
			int num = -666617399;
			while (true)
			{
				int num1 = num ^ -1955615317;
				uint num2 = (uint)num1;
				switch (num1 % 4)
				{
					case 0:
					{
						return;
					}
					case 1:
					{
						Display.u200d‪‬⁮⁮⁮‎⁪⁫‭‮‮⁫‏⁫‬‎‪‫⁯‬‏⁪⁬‫‫⁯‭⁫​‬⁯⁭‫‮‭‪⁬‪‏‮(graphics, InterpolationMode.Low);
						num = (int)(num2 * -885512273 ^ -615463424);
						continue;
					}
					case 2:
					{
						Display.u202a⁯‌‮⁯‌‫⁪⁯‍‏‪⁬‌⁫⁫‫⁪‏‮⁮‭⁭⁭‪⁫‎​‏‌‭‍‎⁭‌‏⁬⁯‌⁯‮(graphics, SmoothingMode.None);
						Display.u202c‪‬⁬‎‫‍‭‭‎⁭​⁯⁮‏⁪‎‮‫⁪‏‫‏⁯⁬‏‌‭⁪‭⁪⁯‌⁮‪‭‪⁭⁮⁫‮(graphics, PixelOffsetMode.HighSpeed);
						num = (int)(num2 * 1172674903 ^ -374521040);
						continue;
					}
					case 3:
					{
						goto Label1;
					}
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			int num;
			int num1;
			if (!disposing)
			{
				goto Label0;
			}
		Label1:
			num = -1144794812;
		Label4:
			while (true)
			{
				int num2 = num ^ -1585829917;
				uint num3 = (uint)num2;
				switch (num2 % 5)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						break;
					}
					case 2:
					{
						Display.u202d​​⁫‮⁫‌‮‎‏‏‮‌‏‬⁫⁯⁪⁫‌⁭⁬‍⁬​‬​⁯‏⁯⁫‎‌⁭⁯‏‮‎‮‌‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						num = (int)(num3 * -2050606730 ^ 1552034643);
						continue;
					}
					case 3:
					{
						return;
					}
					case 4:
					{
						num1 = (this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮ == null ? -1490468254 : -1512122883);
						num = (int)(num1 ^ num3 * 767205649);
						continue;
					}
					default:
					{
						return;
					}
				}
			}
		Label0:
			base.Dispose(disposing);
			num = -223463345;
			goto Label4;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Display.ConfigureGraphics(Display.u200c‭‬‬‬⁮‪⁫⁯​⁫⁬‏‭‫‬⁯‬‍‍⁫‬‮‎‭⁫⁪⁪‪‬‭⁯⁫‫⁪‫‍​⁬⁪‮(e));
			Display.u200c⁮⁭‍‮⁯‏‎⁫‮‭⁮‮‫⁫⁫‍⁫‭‪‭‪‪‌⁪‭‭​‍‭‭‮​⁪⁯‎⁫‌⁬‬‮(Display.u200c‭‬‬‬⁮‪⁫⁯​⁫⁬‏‭‫‬⁯‬‍‍⁫‬‮‎‭⁫⁪⁪‪‬‭⁯⁫‫⁪‫‍​⁬⁪‮(e), this.u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮, 0, 0);
		}

		protected override void OnResize(EventArgs e)
		{
			int num;
			int num1;
			base.OnResize(e);
			Rectangle rectangle = Display.u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(this);
		Label1:
			int num2 = -1350717023;
			while (true)
			{
				int num3 = num2 ^ -1971362512;
				uint num4 = (uint)num3;
				switch (num3 % 7)
				{
					case 0:
					{
						rectangle = Display.u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(this);
						num = (rectangle.Height > 0 ? 553375362 : 46268087);
						num2 = (int)(num ^ num4 * -2063478418);
						continue;
					}
					case 1:
					{
						this.u206f‭‏‍‏‭⁪‪⁭⁫‭⁮⁮⁭‏⁫⁬⁭‮‏‮⁭⁫‮‮⁬‬⁮‮‎‬‬​⁯⁬⁬⁪⁯‏‮‮ = Display.u206a‍⁬⁫‬‬‎‏‌‌‭‍​‭‍‍⁯‭⁯‮⁪‌‎‮‪‌‭‭‪​⁪⁬⁯⁮‮​‎‫⁭⁪‮(this.u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮);
						num2 = (int)(num4 * 1876139582 ^ 255913585);
						continue;
					}
					case 2:
					{
						Display.u202a‮⁯‭‬⁪‌‪⁬‬⁭‮⁬​​⁫‬‍⁪⁪⁮⁫​⁯‬‮‌‪⁪⁫‪‫‬⁭⁬⁫⁫‍⁬‎‮(this.u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮);
						Display.u206d​‫⁬‮​⁭‭‬‏‮⁬⁬‬⁫‏​⁪⁭⁬⁯⁯‭⁪⁭‬⁭‫‭⁫⁪‎‪‍‫⁮‍⁭⁪‮(this.u206f‭‏‍‏‭⁪‪⁭⁫‭⁮⁮⁭‏⁫⁬⁭‮‏‮⁭⁫‮‮⁬‬⁮‮‎‬‬​⁯⁬⁬⁪⁯‏‮‮);
						num2 = (int)(num4 * 1382860644 ^ 1923187537);
						continue;
					}
					case 3:
					{
						return;
					}
					case 4:
					{
						goto Label1;
					}
					case 5:
					{
						num1 = (rectangle.Width <= 0 ? 1377713843 : 307619360);
						num2 = (int)(num1 ^ num4 * -605039796);
						continue;
					}
					case 6:
					{
						rectangle = Display.u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(this);
						int width = rectangle.Width;
						rectangle = Display.u200b⁭‌‌‪‫⁬⁫‪​⁪‏‪⁭‬⁬‮‭⁮‭‪⁪​⁬⁬‏⁬‭‫⁫‪⁫⁪⁯‮⁬⁫‎‭‫‮(this);
						this.u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮ = Display.u202e‬⁪​⁬‬‭‎⁬​⁫‎‫‌⁬⁪‎‍‎‌⁫‭‪‫‌‎⁯‎‌⁭‏‎‫‌⁯‍⁬‮‮‏‮(width, rectangle.Height, PixelFormat.Format32bppArgb);
						num2 = (int)(num4 * 2038344624 ^ 545533625);
						continue;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Perform(float* displayInputBuffer, int length)
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.Display::Perform(System.Single*,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void Perform(System.Single*,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}
	}
}