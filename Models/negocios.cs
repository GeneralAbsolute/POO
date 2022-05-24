
namespace POO.Models;

public class negocios{
    int id_negocio{get;set;}
    int id_user{get;set;}
    string nombre_negocio{get;set;}=string.Empty;
    string ubicacion_negocio{get;set;}=string.Empty;
    string detalles_negocio{get;set;}=string.Empty;
    int confianza_negocio{get;set;}
    int calificacion_negocio {get;set;}

    public negocios(){

    }

    public negocios(int id, int user, string nombre, string ubicacion, string detalles, int confianza, int calificacion){
        this.id_negocio=id;
        this.id_user=user;
        this.nombre_negocio=nombre;
        this.ubicacion_negocio=ubicacion;
        this.detalles_negocio=detalles;
        this.confianza_negocio=confianza;
        this.calificacion_negocio=calificacion;
    }

}