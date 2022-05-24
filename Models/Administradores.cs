namespace POO.Models;

public class Administradores{

int id_admin{get;set;}
string nombre{get;set;}=string.Empty;
string password{get;set;}=string.Empty;
string correo{get;set;}=string.Empty;

public Administradores(){

}

public Administradores(string nombre, string password, string correo){
    this.nombre=nombre;
    this.password=password;
    this.correo=correo;
    
}

}