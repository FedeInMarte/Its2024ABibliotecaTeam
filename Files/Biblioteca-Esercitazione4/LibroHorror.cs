public class LibroHorror: Book{

    public int GradoDiSpavento{ get; set; }
    public LibroHorror(string id, string title, string author, int gradoDiSpavento): base(id, title, author) { 
        this.GradoDiSpavento = gradoDiSpavento;
    }
}
