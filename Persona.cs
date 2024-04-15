
class Persona : IUtente
{

    private string user_id = "";
    private int annoIscrizione = 0;
    private String nome;
    private String cognome;
    
    public Persona(String id, String nome, String cognome)
    {
        this.user_id = id;
        this.nome = nome;
        this.cognome = cognome;
    }


    public String Nome
    {
        get => this.nome; 
        set { this.nome = value; }

    }
    public string Cognome
    {
        get => this.cognome; 
        set { this.cognome = value; }
    }

    public string Denominazione { get => $"{this.user_id} {this.nome} {this.cognome}";  }

    public string Id { get => this.user_id; set  {this.user_id = value; } }
    public int AnnoIscrizione { get => this.annoIscrizione; set {this.annoIscrizione = value;} }
}
