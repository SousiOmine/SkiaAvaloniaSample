using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SkiaSharp;
using System.Threading;

namespace SkiaAvaloniaSample.Views;

public partial class SkiaView : UserControl
{
	private string text;

	public SkiaView()
    {
        InitializeComponent();
		text = "Hello, World!";
    }

	private void UserControl_Loaded(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		skiaCanvas.InvalidateVisual();
	}


	private void SKCanvasView_PaintSurface(object? sender, Avalonia.Labs.Controls.SKPaintSurfaceEventArgs e)
	{
		SKImageInfo info = e.Info;
		SKSurface surface = e.Surface;
		SKCanvas canvas = surface.Canvas;

		canvas.Clear(SKColors.Blue);

		var skPaint = new SKPaint()
		{
			TextSize = 40,
			TextAlign = SKTextAlign.Center
		};
		skPaint.Color = SKColors.Red;

		canvas.DrawText(text, info.Width / 2, info.Height / 2, skPaint);
	}

	
}