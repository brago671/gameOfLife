using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GoL
{
	public static class Variables
	{
		public static readonly int rows = 54;
		public static readonly int columns = 102;

		public static Rectangle[,] cells = new Rectangle[Variables.rows, Variables.columns];
		public static int[,] AmountOfNeighbor = new int[Variables.rows, Variables.columns];


		public static double speedMax = 0.01;
		public static double speedMin = 0.4;
		public static double speedNormal = 0.12;

		public static int iteration = 0;

		public static Brush deadCellColor = Brushes.DimGray;
		public static Brush lifeCellColor = Brushes.White;

		public static DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
	}
}
