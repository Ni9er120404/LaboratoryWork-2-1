namespace LaboratoryWork_2_1
{
	internal class Program
	{
		private static void Main()
		{

			Album album = new(100);

			foreach (KeyValuePair<string, int> info in album.Info)
			{
				Console.WriteLine($"{info}");
			}

			Console.WriteLine(album.Count);
		}
	}
}