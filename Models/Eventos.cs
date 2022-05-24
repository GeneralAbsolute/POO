namespace POO.Models;

public class Evento{
    int id_evento{get;set;}
    int id_user{get;set;}
    string titulo_evento{get;set;}=string.Empty;
    DateOnly fecha_evento{get;set;}
    TimeOnly hora_inicio{get;set;}
    TimeOnly hora_termino{get;set;}
    string ubicacion_evento{get;set;}=string.Empty;
    string detalles_evento{get;set;}=string.Empty;
    string estado_evento{get;set;}=string.Empty;
    string caracter_evento{get;set;}=string.Empty;
    int seguridad_evento {get;set;}
    int precio_evento{get;set;}
    double promedio_eventos{get;set;}

public Evento(){

}


public Evento(int id, int usuario, string titulo, DateOnly fecha, TimeOnly inicio, TimeOnly termino, string ubicacion, string detalles, string estado, string caracter, int seguridad, int precio, double votos){
    this.id_evento=id;
    this.id_user=usuario;
    this.titulo_evento=titulo;
    this.fecha_evento=fecha;
    this.hora_inicio=inicio;
    this.hora_termino=termino;
    this.ubicacion_evento=ubicacion;
    this.detalles_evento=detalles;
    this.estado_evento=estado;
    this.caracter_evento=caracter;
    this.seguridad_evento=seguridad;
    this.precio_evento=precio;
    this.promedio_eventos=votos;
    
}
}