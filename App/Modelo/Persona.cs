using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Persona
    {
        string id;
        string nombre;
        string direccion;
        string telefono;
        string email;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
      

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Persona(string id, string nombre, string direccion, string telefono, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;


        }


        public override string ToString()
        {
            return ToString() +
                    "Nombre: " + this.nombre +
                    "\nId: " + this.id + '\n' +
                        "\nId: " + this.telefono + '\n' +
                        "\nId: " + this.email +
                        "\nId: " + this.direccion;
                        
            //ibrateamoerelosmeirsadasdudd
        }
  


    }
}
