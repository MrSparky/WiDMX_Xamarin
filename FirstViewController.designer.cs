// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Jiffy_WiDMX
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		MonoTouch.UIKit.UISlider Chan1Slider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Chan1Val { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider Chan2Slider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Chan2Val { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider Chan3Slider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Chan3Val { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider MasterSlider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField MasterVal { get; set; }

		[Action ("ModeSelect_Changed:")]
		partial void ModeSelect_Changed (MonoTouch.UIKit.UISegmentedControl sender);

		[Action ("Slider1_Changed:")]
		partial void Slider1_Changed (MonoTouch.UIKit.UISlider sender);

		[Action ("Slider2_Changed:")]
		partial void Slider2_Changed (MonoTouch.UIKit.UISlider sender);

		[Action ("Slider3_Changed:")]
		partial void Slider3_Changed (MonoTouch.UIKit.UISlider sender);

		[Action ("SliderM_Changed:")]
		partial void SliderM_Changed (MonoTouch.UIKit.UISlider sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Chan1Slider != null) {
				Chan1Slider.Dispose ();
				Chan1Slider = null;
			}

			if (Chan1Val != null) {
				Chan1Val.Dispose ();
				Chan1Val = null;
			}

			if (Chan2Slider != null) {
				Chan2Slider.Dispose ();
				Chan2Slider = null;
			}

			if (Chan2Val != null) {
				Chan2Val.Dispose ();
				Chan2Val = null;
			}

			if (Chan3Slider != null) {
				Chan3Slider.Dispose ();
				Chan3Slider = null;
			}

			if (Chan3Val != null) {
				Chan3Val.Dispose ();
				Chan3Val = null;
			}

			if (MasterSlider != null) {
				MasterSlider.Dispose ();
				MasterSlider = null;
			}

			if (MasterVal != null) {
				MasterVal.Dispose ();
				MasterVal = null;
			}
		}
	}
}
