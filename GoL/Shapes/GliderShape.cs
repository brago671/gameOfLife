namespace GoL.ShapeStrategy
{
	class GliderShape : GridShape
	{
		public override void InitializeShape(int centerX, int centerY)
		{
			Variables.cells[centerX, centerY].Fill = Variables.lifeCellColor;
			Variables.cells[centerX, centerY + 1].Fill = Variables.lifeCellColor;
			Variables.cells[centerX, centerY + 2].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 1, centerY + 2].Fill = Variables.lifeCellColor;
			Variables.cells[centerX - 2, centerY + 1].Fill = Variables.lifeCellColor;
		}
	}
}
