    internal class LibroHorror: Book{

        internal int GradoDiSpavento{ get; set; }
        internal LibroHorror(string id, string title, string author, int gradoDiSpavento): base(id, title, author) { 
            this.GradoDiSpavento = gradoDiSpavento;
        }
    }
