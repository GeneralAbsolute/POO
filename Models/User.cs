namespace POO.Models;

public class user{
    public class Users
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class UserDetails
    {
        public string username { get; set; }=string.Empty;
        public string firstname { get; set; }=string.Empty;
        public string lastname { get; set; }=string.Empty;
        public string dob { get; set; }=string.Empty;
        public string email { get; set; }=string.Empty;
        public string role { get; set; }=string.Empty;
        public string contactno { get; set; }=string.Empty;
        public string gender { get; set; }=string.Empty;
        
        public Result result { get; set; }
    }

    public class Result
    {
        public bool result { get; set; }
        public string message { get; set; }
    }

public user(int id, string nombre, string correo, string password,int comentarios, double votos, int confianza){
    this.id=id;
    this.nombre= nombre;
    this.correo=correo;
    this.password=password;
    this.numero_comentarios=comentarios;
    this.Promedio_votos=votos;
    this.nivel_confianza=confianza;
}

}