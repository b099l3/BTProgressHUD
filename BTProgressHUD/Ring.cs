using System;

#if __UNIFIED__
using UIKit;
#else
using UIKit;
#endif

namespace BigTed
{
	public class Ring
	{
		/// <summary>
		/// Ring color
		/// </summary>
		public UIColor Color = UIColor.White;
		/// <summary>
		/// Background color
		/// </summary>
		public UIColor BackgroundColor = UIColor.DarkGray;
		/// <summary>
		/// Progress update interval in milliseconds
		/// </summary>
		public Double ProgressUpdateInterval = 300;

		public void ResetStyle(bool isWhiteTheme, UIColor colorToUse)
		{
			Color = colorToUse;
			BackgroundColor = isWhiteTheme ? UIColor.White : UIColor.DarkGray;
			ProgressUpdateInterval = 300;


		}
	}
}

