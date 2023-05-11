using C9_Baklanov;

IDBItemDAL<Book> dbBook = new DBItemDAL<Book>();

dbBook.AddItem(new Book("b1", 200, 400));
dbBook.AddItem(new Book("b2", 300, 500));
dbBook.AddItem(new Book("b3", 400, 600));
dbBook.AddItem(new Book("b4", 500, 700));
dbBook.AddItem(new Book("b5", 1000, 800));

BookServiceBLL bookServiceBLL = new BookServiceBLL(dbBook);
BookServicePL bookServicePL = new BookServicePL(bookServiceBLL);
IMenu librarianMenu = new LibrarianMenu(bookServicePL);
StrategyMenu strategyLibrarianMenu = new StrategyMenu(librarianMenu);
IMenu mainMenu = new MainMenu(strategyLibrarianMenu);
StrategyMenu strategyMainMenu = new StrategyMenu(mainMenu);
strategyMainMenu.Run();