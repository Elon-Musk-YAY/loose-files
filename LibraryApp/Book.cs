using System;

namespace LibApp {
    class Book {
        public string title;
        public string author;
        public int pages;
        public bool availible;
        public int id;
        public Book (string title, string author, int pages, bool availible, int id) {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.availible = availible;
            this.id = id;
        } 
    } 
}