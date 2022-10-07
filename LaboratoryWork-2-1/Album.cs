namespace LaboratoryWork_2_1
{
	internal class Album
	{
		private readonly Stamp[] Stamps;

		private readonly List<Stamp> Stampss = new();

		public int Count { get; private set; }

		public Dictionary<string, int> Info { get; private set; } = new();

		public Album(int number)
		{

			Stamps = new Stamp[(int)Math.Pow(number, 2)];
			for (int i = 0; i < Stamps.Length; i++)
			{
				Stamps[i] = new Stamp();
			}

			Random(Stamps);
			SearchForDuplicates(Stamps);
			Console.WriteLine(Stampss.Count);
			SearchNumberDuplicates(Stampss!);
		}

		private static void Random(Stamp[] stamps)
		{
			Random random = new(DateTime.Now.Millisecond);
			for (int i = 0; (int)i < stamps.Length; i++)
			{
				stamps[i].Description = $"{random.Next(1, stamps.Length)}";
			}
		}

		private void SearchNumberDuplicates(List<Stamp> stamps)
		{
			int count = 0;
			for (int i = 0; i < stamps.Count; i++)
			{
				for (int j = 1; j < Stamps!.Length; j++)
				{
					if (stamps[i].Description == Stamps[j].Description)
					{
						count++;
					}
				}
				if (stamps[i].Description != null)
				{
					Info.Add(stamps[i].Description, count);
					Count += count;
					count = 0;
				}
			}
		}

		private void SearchForDuplicates(Stamp[] stamps)
		{
			int n = stamps.Length;
			for (int i = 0; i < n; i++)
			{
				bool isDuplicate = false;
				for (int j = 0; j < i; j++)
				{
					if (stamps[i].Description == stamps[j].Description)
					{
						isDuplicate = true;
						break;
					}
				}

				if (!isDuplicate)
				{
					Stampss.Add(stamps[i]);
				}
			}
		}
	}
}