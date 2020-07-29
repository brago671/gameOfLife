using System;

namespace GoL.ShapeStrategy
{
	class RandomShape : GridShape
	{
		public override void InitializeShape(int centerX, int centerY)
		{
			Random randomizer = new Random();

			for (int i = 0; i < Variables.rows; i++)
			{
				for (int j = 0; j < Variables.columns; j++)
				{
					Variables.cells[i, j].Fill = (randomizer.Next(2) == 1) ? Variables.lifeCellColor : Variables.deadCellColor;
				}
			}
		}
	}
}
