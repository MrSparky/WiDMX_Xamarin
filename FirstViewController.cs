using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Jiffy_WiDMX
{
	public partial class FirstViewController : UIViewController
	{
		private UIColor m_BackColor;

		private GradientView Chan1Gradient;
		private GradientView Chan2Gradient;
		private GradientView Chan3Gradient;
		private GradientView MasterGradient;

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public FirstViewController (IntPtr handle) : base (handle)
		{
			this.Title = NSBundle.MainBundle.LocalizedString ("Mixer", "Mixer");
			this.TabBarItem.Image = UIImage.FromBundle ("first");
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			m_BackColor = GetColorFromSliders();

			Chan1Gradient = new GradientView ();
			Chan1Gradient.Frame = this.Chan1Slider.Frame;
			this.View.AddSubview (Chan1Gradient);
			this.View.SendSubviewToBack (Chan1Gradient);

			Chan2Gradient = new GradientView ();
			Chan2Gradient.Frame = this.Chan2Slider.Frame;
			this.View.AddSubview (Chan2Gradient);
			this.View.SendSubviewToBack (Chan2Gradient);

			Chan3Gradient = new GradientView ();
			Chan3Gradient.Frame = this.Chan3Slider.Frame;
			this.View.AddSubview (Chan3Gradient);
			this.View.SendSubviewToBack (Chan3Gradient);

			MasterGradient = new GradientView ();
			MasterGradient.Frame = this.MasterSlider.Frame;
			this.View.AddSubview (MasterGradient);
			this.View.SendSubviewToBack (MasterGradient);

			UpdateChanValues ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			Chan1Gradient.SetNeedsDisplay ();
			Chan2Gradient.SetNeedsDisplay ();
			Chan3Gradient.SetNeedsDisplay ();
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion

		#region Color Helpers

		UIColor GetColorFromSliders()
		{
			return UIColor.FromRGBA(
					Chan1Slider.Value,
					Chan2Slider.Value,
					Chan3Slider.Value,
					MasterSlider.Value);
		}

		void UpdateChanValues()
		{
			float r, g, b, a;

			m_BackColor.GetRGBA (out r, out g, out b, out a);

			Chan1Val.Text = ((int)(r * 255)).ToString ();
			Chan1Gradient.startColor = UIColor.FromRGBA (0f, g, b, a);
			Chan1Gradient.endColor = UIColor.FromRGBA (1f, g, b, a);
			Chan1Gradient.SetNeedsDisplay ();

			Chan2Val.Text = ((int)(g * 255)).ToString ();
			Chan2Gradient.startColor = UIColor.FromRGBA (r, 0f, b, a);
			Chan2Gradient.endColor = UIColor.FromRGBA (r, 1f, b, a);
			Chan2Gradient.SetNeedsDisplay ();

			Chan3Val.Text = ((int)(b * 255)).ToString ();
			Chan3Gradient.startColor = UIColor.FromRGBA (r, g, 0f, a);
			Chan3Gradient.endColor = UIColor.FromRGBA (r, g, 1f, a);
			Chan3Gradient.SetNeedsDisplay ();

			MasterVal.Text = ((int)(a * 255)).ToString ();
			MasterGradient.startColor = UIColor.FromRGBA (0f, 0f, 0f, 1f);
			MasterGradient.endColor = UIColor.FromRGBA (r, g, b, 1f);
			MasterGradient.SetNeedsDisplay ();
		}

		#endregion

		#region Color Controls 

		partial void ModeSelect_Changed (MonoTouch.UIKit.UISegmentedControl sender)
		{
			// TODO - Switch from 3 channel to 2 channel on ModeSelect
		}

		partial void SliderM_Changed (MonoTouch.UIKit.UISlider sender)
		{
			m_BackColor = GetColorFromSliders();
			UpdateChanValues();
			this.View.BackgroundColor = m_BackColor;
		}

		partial void Slider1_Changed (MonoTouch.UIKit.UISlider sender)
		{
			m_BackColor = GetColorFromSliders();
			UpdateChanValues();
			this.View.BackgroundColor = m_BackColor;
		}

		partial void Slider2_Changed (MonoTouch.UIKit.UISlider sender)
		{
			m_BackColor = GetColorFromSliders();
			UpdateChanValues();
			this.View.BackgroundColor = m_BackColor;
		}

		partial void Slider3_Changed (MonoTouch.UIKit.UISlider sender)
		{
			m_BackColor = GetColorFromSliders();
			UpdateChanValues();
			this.View.BackgroundColor = m_BackColor;
		}

		#endregion
	}
}

