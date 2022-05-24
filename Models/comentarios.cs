namespace POO.Models;

public class Comentarios{
    int id_coment{get;set;}
    int id_event{get;set;}
    int id_usuario{get;set;}
    string details{get;set;}=string.Empty;
    int votos{get;set;}

public Comentarios(){

}
public Comentarios(int id, int evento_id, int usuario_id, string detalles, int votos){
    this.id_coment=id;
    this.id_event=evento_id;
    this.id_usuario=usuario_id;
    this.details=detalles;
    this.votos=votos;
    
}

}