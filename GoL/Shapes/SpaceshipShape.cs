namespace GoL.ShapeStrategy
{
	class SpaceshipShape : GridShape
	{
		public override void InitializeShape(int centerX, int centerY)
		{
			Variables.cells[centerX, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 1, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 2, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 3, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 4, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 5, centerY - 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 5, centerY - 3].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 3, centerY - 4].Fill = Variables.lifeCellColor;
			Variables.cells[centerX, centerY - 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX, centerY - 2].Fill = Variables.lifeCellColor;
			Variables.cells[centerX + 1, centerY - 3].Fill = Variables.lifeCellColor;
		}
	}
}
