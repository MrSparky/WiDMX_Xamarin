using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Jiffy_WiDMX
{
	public class GradientView : UIView
	{
		public UIColor startColor;
		public UIColor endColor;

		public GradientView ()
		{
			startColor = UIColor.White;
			endColor = UIColor.White;
		}

		public override void Draw (System.Drawing.RectangleF rect)
		{
			base.Draw (rect);

			using(MonoTouch.CoreGraphics.CGContext gfx = UIGraphics.GetCurrentContext())
			{
				using(MonoTouch.CoreGraphics.CGColorSpace rgb = 
					MonoTouch.CoreGraphics.CGColorSpace.CreateDeviceRGB())
				{
					MonoTouch.CoreGraphics.CGGradient gradient = 
						new MonoTouch.CoreGraphics.CGGradient (rgb, 
							new MonoTouch.CoreGraphics.CGColor[] {
								startColor.CGColor,
								endColor.CGColor
							});

					gfx.DrawLinearGradient (gradient, 
						new System.Drawing.PointF (rect.Left, rect.Top),
						new System.Drawing.PointF (rect.Right, rect.Top),
						MonoTouch.CoreGraphics.CGGradientDrawingOptions.DrawsBeforeStartLocation);
				}
			}
		}
	}
}

