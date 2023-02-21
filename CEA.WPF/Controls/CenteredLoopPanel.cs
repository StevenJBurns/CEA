using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media;

namespace SJB.MeritViewer.Controls
	{
	class CenteredLoopPanel : Panel
		{
		#region Constructors

		static CenteredLoopPanel()
			{
			OrientationProperty = DependencyProperty.Register("Orientation",
																												typeof(Orientation),
																												typeof(CenteredLoopPanel),
																												new FrameworkPropertyMetadata(Orientation.Vertical, FrameworkPropertyMetadataOptions.AffectsMeasure));

																																

			}

		public CenteredLoopPanel() : base()
			{ 
			}

		#endregion
		
		#region Fields

		UIElement centeredchild;
		int selectedChildIndex;
		
		#endregion
		
		#region Properties

		public static readonly DependencyProperty OrientationProperty;

		public Orientation PanelOrientation
			{
			get {return (Orientation)GetValue(OrientationProperty);}
			set { SetValue(OrientationProperty, value); }
			}
		
		#endregion

		#region Events

		public delegate void OnChildSelectedHandler(object sender);
		public event OnChildSelectedHandler OnChildSelected;

		#endregion

		#region Methods

		private void SelectChild(object sender, MouseEventArgs m)
			{
			int i = 0;

			foreach (UIElement child in InternalChildren)
				{
				if (child == sender)
					{
					selectedChildIndex = i;
					InvalidateArrange();
					}
				else
					i++;
				}
			}

		#endregion

		#region Method Overrides

		protected override void OnInitialized(EventArgs e)
			{
			base.OnInitialized(e);

			foreach (FrameworkElement child in InternalChildren)
				{ child.MouseLeftButtonDown += new MouseButtonEventHandler(SelectChild); }

			selectedChildIndex = 0;
			centeredchild = InternalChildren[selectedChildIndex];
			}

		protected override Size MeasureOverride(Size availableSize)
			{
			if (InternalChildren.Count == 0)
				return new Size(0, 0);
			
			Size desiredsize = availableSize;
			
			foreach (UIElement child in InternalChildren)
				{
				child.Measure(availableSize);

				desiredsize.Width += child.DesiredSize.Width;
				desiredsize.Height = Math.Min(desiredsize.Height, child.DesiredSize.Height);
				}

			return desiredsize;
			}

		protected override Size ArrangeOverride(Size finalSize)
			{
			if (InternalChildren == null || InternalChildren.Count == 0)
				return finalSize;

			int offsetfactor;
			centeredchild = InternalChildren[selectedChildIndex];
			Rect offsetchildrect;
			Rect centeredchildrect = new Rect(new Point((finalSize.Width / 2) - (centeredchild.DesiredSize.Width / 2),
																									(finalSize.Height / 2) - (centeredchild.DesiredSize.Height / 2)),
																				new Point((finalSize.Width / 2) + (centeredchild.DesiredSize.Width / 2),
																									((finalSize.Height / 2) + (centeredchild.DesiredSize.Height / 2))));


			centeredchild.Arrange(centeredchildrect);

			foreach (UIElement child in InternalChildren)
				{
				offsetfactor = (selectedChildIndex + 1) - (InternalChildren.IndexOf(child) + 1);

				if (InternalChildren.IndexOf(child) != selectedChildIndex)
					{
					if (InternalChildren.IndexOf(child) < selectedChildIndex)
						{
						offsetchildrect = new Rect((centeredchildrect.Left - child.DesiredSize.Width) * Math.Abs(offsetfactor),
																				(finalSize.Height / 2) - (child.DesiredSize.Height / 2),
																				child.DesiredSize.Width, child.DesiredSize.Height);
						}
					else
						{
						offsetchildrect = new Rect((centeredchildrect.Right) * Math.Abs(offsetfactor),
																				(finalSize.Height / 2) - (child.DesiredSize.Height / 2),
																				child.DesiredSize.Width, child.DesiredSize.Height);
						}

					child.Arrange(offsetchildrect);
					}
				}

			return finalSize;
			}

		#endregion
		}
	}
