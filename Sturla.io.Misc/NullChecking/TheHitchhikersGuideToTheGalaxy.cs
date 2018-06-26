namespace Sturla.io.Misc
{
	public class TheHitchhikersGuideToTheGalaxy
	{
		public void WithoutTypePattern()
		{
			var useDeepThought = false;
			var answer = CalculateTheAnswerToTheUltimateQuestion(useDeepThought);

			// Verbose null checking. Of course we could do if(answer != null) 
			// but I think that is not as to the point as the second method below.
			if (answer == null)
			{
				System.Console.WriteLine($"Sorry the answer could´t be calculated. Return value was null");
			}
			else
			{
				System.Console.WriteLine($"The answer is {answer}");
			}
		}

		public void WithTypePattern()
		{
			var useDeepThought = false;
			if (CalculateTheAnswerToTheUltimateQuestion(useDeepThought) is int answer)
			{
				//If result from method is int (not null) we go in here with some value in answer
				System.Console.WriteLine($"The answer is {answer}");
			}
			else 
			{
				System.Console.WriteLine($"Sorry the answer could´t be calculated. Return value was null");
			}
		}

		private int? CalculateTheAnswerToTheUltimateQuestion(bool useDeepThought)
		{
			if (useDeepThought)
				return 42;
			else
				return null;
		}
	}
}
