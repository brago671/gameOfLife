using GoL.Shapes;
using GoL.ShapeStrategy;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GoL
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public object ShapeEnum { get; private set; }

		public MainWindow()
		{
			InitializeComponent();
			SliderInitialize(SpeedSlider, Variables.speedMin, Variables.speedMax, Variables.speedNormal);
			ComboBoxInitialize(ComboBoxShapes);
			DispetcherTimerInitialize(Variables.dispatcherTimer, DispatcherTimer_Tick,
				TimeSpan.FromSeconds(Variables.speedNormal));
		}

		private  void SliderInitialize( Slider slider, double max, double min, double def)
		{
			slider.Maximum = max;
			slider.Minimum = min;
			slider.Value = def;
		}

		private  void ComboBoxInitialize( ComboBox comboBox)
		{
			comboBox.Items.Add(ShapesEnum.Random);
			comboBox.Items.Add(ShapesEnum.Glider);
			comboBox.Items.Add(ShapesEnum.LightweightSpaceship);
			comboBox.Items.Add(ShapesEnum.SimkinGliderGun);
			comboBox.Items.Add(ShapesEnum.Paradise);
		}

		private  void DispetcherTimerInitialize(DispatcherTimer timer, EventHandler tickEvent, TimeSpan time)
		{
			timer.Tick += tickEvent;
			Variables.dispatcherTimer.Interval = time;
		}

		private void Grid_Loaded(object sender, RoutedEventArgs e)
		{
			InitializeCanvas();
		}

		private void InitializeCanvas()
		{
			for (int i = 0; i < Variables.rows; i++)
			{
				for (int j = 0; j < Variables.columns; j++)
				{
					Rectangle cell = new Rectangle();
					cell.Height = MainCanvas.ActualHeight / Variables.rows;
					cell.Width = MainCanvas.ActualWidth / Variables.columns;
					cell.Fill = Variables.deadCellColor;
					MainCanvas.Children.Add(cell);
					Canvas.SetLeft(cell, j * cell.Width);
					Canvas.SetTop(cell, i * cell.Height);
					cell.MouseDown += Cell_MouseDown;
					Variables.cells[i, j] = cell;
				}
			}
		}

		private void Cell_MouseDown(object sender, MouseButtonEventArgs e)
		{
			((Rectangle)sender).Fill =
				(((Rectangle)sender).Fill == Variables.deadCellColor) ?
				Variables.lifeCellColor : Variables.deadCellColor;
		}

		private void DispatcherTimer_Tick(object sender, EventArgs e)
		{
			MakeNewIteration();
		}

		private void ButtonNext_Click(object sender, RoutedEventArgs e)
		{
			MakeNewIteration();
		}

		private void ButtonStartStop_Click(object sender, RoutedEventArgs e)
		{
			if (Variables.dispatcherTimer.IsEnabled)
			{
				Variables.dispatcherTimer.Stop();
				StartStopButton.Content = "Start";
				NextButton.IsEnabled = true;
			}
			else
			{
				Variables.dispatcherTimer.Start();
				StartStopButton.Content = "Stop";
				NextButton.IsEnabled = false;
			}
		}

		private void ButtonClear_Click(object sender, RoutedEventArgs e)
		{
			GridShape shape = new EmptyShape();
			shape.CreateShape();
			ResetIterations();
		}

		private void ComboBoxShapes_Selected(object sender, SelectionChangedEventArgs e)
		{
			GridShape shape = (ComboBoxShapes.SelectedIndex) switch
			{
				(int)ShapesEnum.Random => new RandomShape(),
				(int)ShapesEnum.Glider => new GliderShape(),
				(int)ShapesEnum.LightweightSpaceship => new SpaceshipShape(),
				(int)ShapesEnum.SimkinGliderGun => new GliderGunShape(),
				(int)ShapesEnum.Paradise => new ParadiseShape(),
				_ => throw new Exception(StringConstants.UnsupportedShapeMessage)
			};
			shape.CreateShape();
			ResetIterations();
		}

		private void SpeedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Variables.speedNormal = Convert.ToDouble(SpeedSlider.Value);
			Variables.dispatcherTimer.Interval = TimeSpan.FromSeconds(Variables.speedNormal);
		}

		private void ButtonAquaColor_Click(object sender, RoutedEventArgs e)
		{
			ChangeColorOfAliveCell(Brushes.Aqua);
		}

		private void ButtonWhiteColor_Click(object sender, RoutedEventArgs e)
		{
			ChangeColorOfAliveCell(Brushes.White);
		}

		private void ButtonHotPinkColor_Click(object sender, RoutedEventArgs e)
		{
			ChangeColorOfAliveCell(Brushes.HotPink);
		}

		private void ButtonKhakiColor_Click(object sender, RoutedEventArgs e)
		{
			ChangeColorOfAliveCell(Brushes.Khaki);
		}

		private void ButtonGreenYellowColor_Click(object sender, RoutedEventArgs e)
		{
			ChangeColorOfAliveCell(Brushes.GreenYellow);
		}

		private void ChangeColorOfAliveCell(Brush color)
		{
			Logic.RefreshGrid(color);
			Variables.lifeCellColor = color;
		}

		private void MakeNewIteration()
		{
			Logic.CalculateNewGrid();
			Variables.iteration++;
			IterationTextBlock.Text = $"Iteration\n{Variables.iteration}";
		}

		public void ResetIterations()
		{
			Variables.iteration = 0;
			IterationTextBlock.Text = $"Iteration\n{Variables.iteration}";
		}
	}
}
