using System;

namespace Collections
{
    public struct EventRecord
    {
        public   DateTime DateGiven;  // Дата выдачи
        public   DateTime DateReturn; // Дата возврата
        string   ReaderName;          // Имя читателя
        string   ReaderSurname;       // Фамилия читателя
        int      ReaderId;            // Номер читателя
        string   BookTitle;           // Название книги
        string   BookAuthor;          // Автор книги
        int      BookId;              // Номер книги

        public EventRecord(DateTime dateGiven, double daySpan, 
            int readerId, int bookId, List<Reader> readers, 
            List<Book> books)
        {
            var reader = readers[readerId];
            var book   = books[bookId];

            DateGiven       = dateGiven;
            DateReturn      = dateGiven.AddDays(daySpan);
            ReaderName      = reader.Name;
            ReaderSurname   = reader.Surname;
            ReaderId        = readerId;
            BookTitle       = book.Title;
            BookAuthor      = book.Author;
            BookId          = bookId;
        }

        public string PrintReader()
        {
            return ReaderName + " " 
                + ReaderSurname;
        }

        public string PrintBook()
        {
            return BookTitle + "; " 
                + BookAuthor;
        }

        public string PrintStruct()
        {
            return $"\t-- Запись --\n"              +
                   $"Дата выдачи\t{DateGiven}\n"    +
                   $"Дата возврата\t{DateReturn}\n" +
                   $"Читатель\t{PrintReader()}\n"   +
                   $"ID читателя\t{ReaderId}\n"     +
                   $"Книга\t\t{PrintBook()}\n"      +
                   $"ID книги\t{BookId}";
        }
    }

    public struct Reader
    {
        public string Name;
        public string Surname;

        public Reader(string name, string surname)
        {
            Name    = name;
            Surname = surname;
        }

        public string PrintStruct()
        {
            return $"\t-- Читатель --\n" +
                   $"Имя\t{Name}\n"      +
                   $"Фамилия\t{Surname}";
        }
    }

    public struct Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title  = title;
            Author = author;
        }
        public string PrintStruct()
        {
            return $"\t-- Книга --\n"     +
                   $"Название\t{Title}\n" +
                   $"Автор\t{Author}";
        }
    }

    class Program
    {
        public static void EventMgmt(List<EventRecord> eventRecords,
            List<Reader> readers, List<Book> books)
        {
            EventRecord eventRecord;
            int id;

            Prompt:
            Console.Clear();
            Console.WriteLine("\t-- Управление записями --\n" +
                "1. Добавить запись\n"                        +
                "2. Удалить запись\n"                         +
                "3. Вывести задолжников\n"                    +
                "4. Вывести все записи\n"                     +
                "5. Обратно в меню");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Введите ID читателя");
                    int readerId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ID книги");
                    int bookId = int.Parse(Console.ReadLine());

                    if (readers.Count - 1 < readerId ||
                        books.Count - 1 < bookId)
                    {
                        Console.WriteLine("Такого читателя и/или " +
                            "книги не существует");
                        Thread.Sleep(2000);
                        goto Prompt;
                    }

                    Console.WriteLine("Введите промежуток времени (дни)");
                    double daySpan = double.Parse(Console.ReadLine());

                    eventRecords.Add(new EventRecord(DateTime.Now, 
                        daySpan, readerId, bookId, readers, books));
                    eventRecord = eventRecords.Last();

                    Console.WriteLine($"Запись №"       +
                        $"{eventRecords.Count - 1} "    +
                        $"добавлена\n"                  +
                        $"{eventRecord.PrintReader()} " +
                        $"{eventRecord.PrintBook()}");

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Введите номер записи");
                    id = int.Parse(Console.ReadLine());
                    if (eventRecords.Count - 1 < id)
                    {
                        Console.WriteLine("Такой записи нет");
                        Thread.Sleep(2000);
                        goto Prompt;
                    }

                    eventRecords.RemoveAt(id);
                    Console.WriteLine($"Запись №{id}" +
                        $" была удалена.");

                    goto Prompt;
                case ConsoleKey.D3:
                    Console.Clear();
                    foreach (EventRecord value in eventRecords)
                    {
                        if (value.DateReturn < DateTime.Now)
                        {
                            Console.WriteLine($"\t-- Задолжник --\n" +
                                $"Имя\t{value.PrintReader()}"        +
                                $"Книга\t{value.PrintBook()}");
                        }
                    }

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D4:
                    Console.Clear();

                    id = 0;
                    foreach (EventRecord value in eventRecords)
                    {
                        Console.WriteLine(value.PrintStruct() + 
                            $"\nID записи\t{id}");
                        id++;
                    }

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D5:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Такого пункта меню нет!");
                    Thread.Sleep(2000);
                    goto Prompt;
            }
        }

        public static void ReaderMgmt(List<Reader> readers)
        {
            Reader reader;
            int id;

            Prompt:
            Console.Clear();
            Console.WriteLine("\t-- Управление читателями --\n" +
                "1. Добавить читателя\n"                        +
                "2. Удалить читателя\n"                         +
                "3. Редактировать читателя\n"                   +
                "4. Найти ID читателя\n"                        +
                "5. Вывести список читателей\n"                 +
                "6. Обратно в меню");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Введите имя читателя");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите фамилию читателя");
                    string surname = Console.ReadLine();

                    readers.Add(new Reader(name, surname));

                    Console.WriteLine($"Читатель {name} {surname} " +
                        $"с ID {readers.Count - 1} добавлен.");

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Введите ID читателя");
                    id = int.Parse(Console.ReadLine());
                    if (readers.Count - 1 < id)
                    {
                        Console.WriteLine("Такого ID нет");
                        Thread.Sleep(2000);
                        goto Prompt;
                    }

                    reader = readers[id];
                    Console.WriteLine($"Читатель {reader.Name} " +
                        $"{reader.Surname} с ID {id} была удален.");

                    readers.RemoveAt(id);
                    goto Prompt;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("Введите ID читателя");

                    id = int.Parse(Console.ReadLine());
                    if (readers.Count - 1 < id)
                    {
                        Console.WriteLine("Такого ID нет");
                        Thread.Sleep(2000);
                        goto Prompt;
                    }

                    reader = readers[id];

                    Console.Clear();
                    Console.WriteLine(reader.Name);
                    reader.Name = Console.ReadLine();

                    Console.WriteLine(reader.Surname);
                    reader.Surname = Console.ReadLine();

                    readers[id] = reader;

                    goto Prompt;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("Введите имя читателя");
                    string searchName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию читателя");
                    string searchSurname = Console.ReadLine();

                    id = 0;
                    foreach (Reader value in readers)
                    {
                        if (value.Name == searchName)
                        {
                            if (value.Surname == searchSurname)
                            {
                                Console.Clear();
                                Console.WriteLine($"{searchName} " +
                                    $"{searchSurname} имеет ID "   +
                                    $"{id}");
                                Console.Write("Нажмите любую кнопку...");
                                Console.ReadKey();
                            }
                            else
                            {
                                id++;
                                Console.WriteLine("...");
                            }
                        }
                        else
                        {
                            id++;
                            Console.WriteLine("...");
                        }
                    }
                    goto Prompt;
                case ConsoleKey.D5:
                    Console.Clear();

                    id = 0;
                    foreach (Reader value in readers)
                    {
                        Console.WriteLine(value.PrintStruct() + 
                            $"\nID\t{id}");
                        id++;
                    }

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D6:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Такого пункта меню нет!");
                    Thread.Sleep(2000);
                    goto Prompt;
            }
        }

        public static void BookMgmt(List<Book> books)
        {
            Book book;
            int id;

            Prompt:
            Console.Clear();
            Console.WriteLine("\t-- Управление книгами --\n" +
                "1. Добавить книгу\n"                        +
                "2. Удалить книгу\n"                         +
                "3. Редактировать книгу\n"                   +
                "4. Найти ID книги\n"                        +
                "5. Вывести список книг\n"                   +
                "6. Обратно в меню");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Введите название книги");
                    string title = Console.ReadLine();
                    Console.WriteLine("Введите автора книги");
                    string author = Console.ReadLine();

                    books.Add(new Book(title, author));

                    Console.WriteLine($"Книга {title} {author} " +
                        $"с ID {books.Count - 1} добавлена.");

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Введите ID книги");
                    id = int.Parse(Console.ReadLine());
                    if (books.Count - 1 < id)
                    {
                        Console.WriteLine("Такого ID нет");
                        Thread.Sleep(2000);
                        goto Prompt;
                    }

                    book = books[id];
                    Console.WriteLine($"Книга {book.Title} " +
                        $"{book.Author} с ID {id} была удалена.");

                    books.RemoveAt(id);
                    goto Prompt;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("Введите ID книги");

                    id = int.Parse(Console.ReadLine());
                    if (books.Count - 1 < id)
                    {
                        Console.WriteLine("Такого ID нет");
                        Thread.Sleep(2000);
                        goto Prompt;
                    }

                    book = books[id];

                    Console.Clear();
                    Console.WriteLine(book.Title);
                    book.Title = Console.ReadLine();

                    Console.WriteLine(book.Author);
                    book.Author = Console.ReadLine();

                    books[id] = book;

                    goto Prompt;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("Введите название книги");
                    string searchTitle = Console.ReadLine();
                    Console.WriteLine("Введите автора книги");
                    string searchAuthor = Console.ReadLine();

                    id = 0;
                    foreach (Book value in books)
                    {
                        if (value.Title == searchTitle)
                        {
                            if (value.Author == searchAuthor)
                            {
                                Console.Clear();
                                Console.WriteLine($"{searchTitle} " +
                                    $"{searchAuthor} имеет ID "     +
                                    $"{id}");
                                Console.Write("Нажмите любую кнопку...");
                                Console.ReadKey();
                            }
                            else
                            {
                                id++;
                                Console.WriteLine("...");
                            }
                        }
                        else
                        {
                            id++;
                            Console.WriteLine("...");
                        }
                    }
                    goto Prompt;
                case ConsoleKey.D5:
                    Console.Clear();

                    id = 0;
                    foreach (Book value in books)
                    {
                        Console.WriteLine(value.PrintStruct() + $"\nID\t{id}");
                        id++;
                    }

                    Console.Write("Нажмите любую кнопку...");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D6:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Такого пункта меню нет!");
                    Thread.Sleep(2000);
                    goto Prompt;
            }
        }

        static void Main()
        {
            List<EventRecord> eventRecords = new();
            List<Reader>      readers      = new();
            List<Book>        books        = new();

            Prompt:
            Console.Clear();
            Console.WriteLine("\t-- Меню --\n" +
                "1. Управление записями\n"     +
                "2. Управление читателями\n"   +
                "3. Управление книгами\n"      +
                "4. Выход из программы");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    EventMgmt(eventRecords,
                        readers, books);
                    goto Prompt;
                case ConsoleKey.D2:
                    ReaderMgmt(readers);
                    goto Prompt;
                case ConsoleKey.D3:
                    BookMgmt(books);
                    goto Prompt;
                case ConsoleKey.D4:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Такого пункта меню нет!");
                    Thread.Sleep(2000);
                    goto Prompt;
            }
        }
    }
}