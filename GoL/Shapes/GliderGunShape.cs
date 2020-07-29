namespace GoL.Shapes
{
	class GliderGunShape : GridShape
	{
		public override void InitializeShape(int centerX, int centerY)
		{
			centerX += (Variables.rows / 6);
			centerY += (Variables.columns / 7);

			//big shape 
			Variables.cells[centerX - 1, centerY + 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 1, centerY + 2].Fill = Variables.lifeCellColor;

			Variables.cells[centerX, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 1, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY + 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY + 2].Fill = Variables.lifeCellColor;

			Variables.cells[centerX - 1, centerY + 4].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 1, centerY + 5].Fill = Variables.lifeCellColor;
			Variables.cells[centerX, centerY + 6].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 1, centerY + 7].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY + 6].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 3, centerY + 5].Fill = Variables.lifeCellColor;

			//rectangle to the left of big shape
			Variables.cells[centerX + 1, centerY + 10].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 1, centerY + 11].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY + 10].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY + 11].Fill = Variables.lifeCellColor;

			//smaller shape under the big shape
			Variables.cells[centerX + 7, centerY + 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 7, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 8, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 9, centerY + 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 9, centerY + 2].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 9, centerY + 3].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 10, centerY + 3].Fill = Variables.lifeCellColor;

			//bottom rectangle in left top group
			Variables.cells[centerX - 6, centerY - 16].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 6, centerY - 17].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 7, centerY - 16].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 7, centerY - 17].Fill = Variables.lifeCellColor;

			///right rectangle in left top group
			Variables.cells[centerX - 9, centerY - 13].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 10, centerY - 13].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 10, centerY - 14].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 9, centerY - 14].Fill = Variables.lifeCellColor;

			///left rectangle in left top group
			Variables.cells[centerX - 9, centerY - 20].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 10, centerY - 20].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 10, centerY - 21].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 9, centerY - 21].Fill = Variables.lifeCellColor;
		}
	}
}
