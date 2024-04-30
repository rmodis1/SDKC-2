using System;
namespace KnowledgeCheck_2
{
	public class PrintBook: Book
	{
		public bool IsHardback { get; set; }
		public string LocationPrinted { get; set; }

		public PrintBook()
		{
		}

        public override string ToString()
        {
			return $"{Title}\nAuthor: {Author}\n" +
				$"Place of Publication: {LocationPrinted}\n" +
				$"Page Count: {NumberOfPages}\n" +
				$"Genre: {Genre}\n" +
				$"Hardback: {IsHardback}";
        }
    }
}

