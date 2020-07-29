namespace GoL
{
	abstract class GridShape
	{
		public void CreateShape()
		{
			ClearTheGrid();

			int CenterX = (Variables.rows / 2);
			int CenterY = (Variables.columns / 2);
			InitializeShape(CenterX, CenterY);
		}

		public abstract void InitializeShape(int centerX, int centerY);
		public static void ClearTheGrid()
		{
			for (int i = 0; i < Variables.rows; i++)
			{
				for (int j = 0; j < Variables.columns; j++)
				{
					Variables.cells[i, j].Fill = Variables.deadCellColor;
				}
			}
			Variables.iteration = 0;
		}
	}
}
