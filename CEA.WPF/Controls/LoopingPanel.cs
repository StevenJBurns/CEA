// using System;
// using System.Windows;
// using System.Windows.Media;
// using System.Windows.Controls;
// using System.Windows.Controls.Primitives;

namespace SJB.MeritViewer.Controls;
  
/*class CenteredLoopPanel : Panel, IScrollInfo
  {
  #region Constructors

  public CenteredLoopPanel() : base()
    {
    this.IsItemsHost = true;
    SelectedChildIndex = -1;
    }

  #endregion

  #region Fields

  private static Size InfiniteSize = new Size(double.PositiveInfinity, double.PositiveInfinity);

  private const double LineSize = 16;
  private const double WheelSize = LineSize * 3;

  private Size _Extent;
  private Size _Viewport;
  private bool _CanVerticallyScroll;
  private bool _CanHorizontallyScroll;

  private Vector _Offset;
  private ScrollViewer _ScrollOwner;

  private bool isChildClicked;
  private int clickedChildIndex;
  private UIElement clickedChild;

  #endregion

  #region Properties

  public int SelectedChildIndex
    {
    public get;
    private set;
    }

  #endregion

#region Methods

#region Private

private void element_MouseLeftButtonDown(object sender, RoutedEventArgs e)
	{
	if (!isChildClicked)
		{
		isChildClicked = true;
		clickedChildIndex = GetClickedIndex(sender);

		this.InvalidateArrange();
		}
	}

#endregion

#region Override

protected override Size MeasureOverride(Size availableSize)
	{
	Size desiredSize = new Size();
	UIElementCollection children = InternalChildren;
		
	foreach (UIElement child in children)
		{
		child.Measure(availableSize);
		desiredSize.Width += child.DesiredSize.Height;
		desiredSize.Height = System.Math.Max(child.DesiredSize.Height, DesiredSize.Height);
		}

	return desiredSize;
	}

protected override Size ArrangeOverride(Size finalSize)
	{
	UIElementCollection children = InternalChildren;

	if (children == null || children.Count == 0)
		return finalSize;

	foreach (UIElement child in Children)
		{
		if (SelectedChildIndex != -1)
			{
			InternalChildren[SelectedChildIndex].Arrange(
				child.Arrange(new Rect(0, 0, child.DesiredSize.Width, child.DesiredSize.Height));
			);
			}
		}

	return finalSize;
	}

protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
	{
	base.OnVisualChildrenChanged(visualAdded, visualRemoved);

	//For every element added add an event handler to know when it is clicked
	UIElement element = visualAdded as UIElement;
	if (element != null)
		{
		element.AddHandler(UIElement.MouseLeftButtonDownEvent, new RoutedEventHandler(element_MouseLeftButtonDown), true);
		}
	}

#endregion

#endregion

#region IScrollInfo

public bool CanHorizontallyScroll
	{
	get { return _CanHorizontallyScroll; }
	set { _CanHorizontallyScroll = value; }
	}

public bool CanVerticallyScroll
	{
	get { return _CanVerticallyScroll; }
	set { _CanVerticallyScroll = value; }
	}

public double ExtentHeight
	{ get { return _Extent.Height; } }

public double ExtentWidth
	{ get { return _Extent.Width; } }

public double HorizontalOffset
	{ get { return _Offset.X; } }

public double VerticalOffset
	{ get { return _Offset.Y; } }

public double ViewportHeight
{ get { return _Viewport.Height; } }

public double ViewportWidth
{ get { return _Viewport.Width; } }

public void LineDown()
	{ SetVerticalOffset(VerticalOffset + LineSize); }

public void LineLeft()
{ SetHorizontalOffset(HorizontalOffset - LineSize); }

public void LineRight()
	{ SetHorizontalOffset(HorizontalOffset + LineSize); }

public void LineUp()
	{ SetVerticalOffset(VerticalOffset - LineSize); }

public Rect MakeVisible(Visual visual, Rect rectangle)
	{
	throw new NotImplementedException();
	}

public void MouseWheelDown()
	{ SetVerticalOffset(VerticalOffset + WheelSize); }

public void MouseWheelLeft()
	{ SetHorizontalOffset(HorizontalOffset - WheelSize); }

public void MouseWheelRight()
	{ SetHorizontalOffset(HorizontalOffset + WheelSize); }

public void MouseWheelUp()
	{ SetVerticalOffset(VerticalOffset - WheelSize); }

public void PageDown()
	{ SetVerticalOffset(VerticalOffset + ViewportHeight); }

public void PageLeft()
	{ SetHorizontalOffset(HorizontalOffset - ViewportWidth); }

public void PageRight()
	{ SetHorizontalOffset(HorizontalOffset + ViewportWidth); }

public void PageUp()
	{ SetVerticalOffset(VerticalOffset - ViewportHeight); }

public ScrollViewer ScrollOwner
	{
	get { return _ScrollOwner; }
	set { _ScrollOwner = value; }
	}

public void SetHorizontalOffset(double offset)
	{
	throw new NotImplementedException();
	}

public void SetVerticalOffset(double offset)
	{
	throw new NotImplementedException();
	}

#endregion
}
*/