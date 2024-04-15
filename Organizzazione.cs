
class Organizzazione : IUtente {
    private String RagioneSociale_i;
    private String Org_id;

    private int annoIscrizione;

    public Organizzazione (String IDOrganizzazione, String RagioneSociale){
        this.RagioneSociale_i = RagioneSociale;
        this.Org_id = IDOrganizzazione;
        
    }

    public int AnnoIscrizione { get => this.annoIscrizione; set {this.annoIscrizione = value;}}

    public String RagioneSociale {get => this.RagioneSociale_i; set {this.RagioneSociale_i = value;}}

    public string Id { get => this.Org_id; set => this.Org_id = value;}

    public string Denominazione { get=> $"{this.Id} {this.RagioneSociale_i}";}

}


