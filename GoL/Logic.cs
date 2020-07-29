using System.Windows.Media;

namespace GoL
{
	public static class Logic
	{
		public static void CalculateNewGrid()
		{
			MakeNeighborArray(ref Variables.AmountOfNeighbor, Variables.rows, Variables.columns);
			for (int i = 0; i < Variables.rows; i++)
			{
				for (int j = 0; j < Variables.columns; j++)
				{
					if(Variables.cells[i, j].Fill == Variables.deadCellColor && Variables.AmountOfNeighbor[i,j] == 3)
                    {
						Variables.cells[i, j].Fill = Variables.lifeCellColor;
					}
					else if(Variables.cells[i, j].Fill == Variables.lifeCellColor 
						&& (Variables.AmountOfNeighbor[i, j] > 3 || Variables.AmountOfNeighbor[i, j] < 2))
                    {
						Variables.cells[i, j].Fill = Variables.deadCellColor;
					}
				}
			}
		}

		private static void MakeNeighborArray(ref int[,] NeighborArray, int rows, int columns)
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					NeighborArray[i, j] = CalculateAmountOfNeighbor(i, j, rows, columns);
				}
			}
		}

		private static int CalculateAmountOfNeighbor(int x, int y, int rows, int columns)
		{
			int amountOfNeigbors = 0;
			for (int i = -1; i < 2; ++i)
			{
				for (int j = -1; j < 2; ++j)
				{
					int row = (x + i + rows) % rows;
					int column = (y + j + columns) % columns;
					amountOfNeigbors = Variables.cells[row, column].Fill == Variables.lifeCellColor ?
					amountOfNeigbors += 1 : amountOfNeigbors;
				}
			}
			amountOfNeigbors = Variables.cells[x, y].Fill == Variables.lifeCellColor ?
				amountOfNeigbors -= 1 : amountOfNeigbors;

			return amountOfNeigbors;
		}

		public static void RefreshGrid(Brush color)
		{
			for (int i = 0; i < Variables.rows; i++)
			{
				for (int j = 0; j < Variables.columns; j++)
				{
					Variables.cells[i, j].Fill = Variables.cells[i, j].Fill == Variables.deadCellColor ?
						Variables.deadCellColor : color;
				}
			}
		}
	}
}
