Page side1 = new Page(MyNotes.OurBoolPage);
Page side2 = new Page(MyNotes.OurIntPage);
Page side3 = new Page(MyNotes.OurFloatPage);
Page side4 = new Page(MyNotes.OurStringPage);



Chapter kapitel1 = new Chapter("Variabler");
kapitel1.Pages.Add(side1);
kapitel1.Pages.Add(side2);
kapitel1.Pages.Add(side3);
kapitel1.Pages.Add(side4);

Book mybook = new Book("Notes");
mybook.Chapters.Add(kapitel1);

mybook.Start();



