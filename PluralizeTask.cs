namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			int ending = (count % 100) > 19 ? count % 10 : count % 100;
      switch (ending)
      {
				case 1:
					return "рубль";
				case 2:
				case 3:
				case 4:
					return "рубля";
        default:
					return "рублей";
      }
    }
	}
}