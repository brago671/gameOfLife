namespace GoL.Shapes
{
	class ParadiseShape : GridShape
	{
		public override void InitializeShape(int centerX, int centerY)
		{
			for (int i = 0; i < Variables.rows; i = i + 3)
			{
				for (int j = 0; j < Variables.columns; j = j + 3)
				{
					Variables.cells[i, j].Fill = Variables.lifeCellColor;
					Variables.cells[i, j + 1].Fill = Variables.lifeCellColor;
					Variables.cells[i + 1, j + 1].Fill = Variables.lifeCellColor;
					Variables.cells[i + 1, j].Fill = Variables.lifeCellColor;
				}
			}
		}
	}
}
