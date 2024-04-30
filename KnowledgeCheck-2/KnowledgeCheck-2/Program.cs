using KnowledgeCheck_2;

Console.WriteLine("How many books do you want to add? ");
var numberOfBooks = int.Parse(Console.ReadLine());

var listOfBooks = new List<PrintBook>();
for (int i = 0; i < numberOfBooks; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myBook = new PrintBook();
    Console.WriteLine("\nAdding Book: ");
    Console.WriteLine("\nWhat is the title of this book?");
    myBook.Title = Console.ReadLine();

    Console.WriteLine("Who wrote this book? (Format: last name, first name): ");
    myBook.Author = Console.ReadLine();

    Console.WriteLine("How many pages are in this book?");
    Int32.TryParse(Console.ReadLine(), out int numberOfPages);
    myBook.NumberOfPages = numberOfPages;

    Console.WriteLine("What genre is this book?");
    myBook.Genre = Console.ReadLine();

    Console.WriteLine("Is this book hardback? True/False?");
    Boolean.TryParse(Console.ReadLine(), out bool isHardback);
    myBook.IsHardback = isHardback;

    Console.WriteLine("Where was the book printed?");
    myBook.LocationPrinted = Console.ReadLine();

    listOfBooks.Add(myBook);
}

// Print out the list of records using Console.WriteLine()
foreach (var book in listOfBooks)
{
    Console.WriteLine("\n" + book.ToString());
}
Console.WriteLine("Press any key to exit the program.");
Console.ReadLine();