using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistVotoElectronico
{
    class Persona
    {
        private int documento, tipoDocumento, calle, localidad, departamento, altura, presentismo;
        private string nombre, apellido;

        public int pDocumento
            { set { documento = value; } get { return documento; } }
        public int pTipoDocumento
            {set { tipoDocumento= value;} get{ return  tipoDocumento;} }
        public int pCalle
            {set { calle= value;} get{ return  calle;} }
        public int pLocalidad
            {set { localidad= value;} get{ return localidad ;} }
        public int pDepartamento
            {set { departamento = value;} get{ return departamento  ;} }
        public int pAltura
            {set { altura= value;} get{ return  altura;} }
        public int pPresentismo
            {set { presentismo = value;} get{ return presentismo  ;} }
        public string pNombre
            {set { nombre= value;} get{ return  nombre;} }
        public string pApellido
            {set { apellido = value; } get { return apellido; } }

        public Persona()
        {
            documento = tipoDocumento = calle = localidad = departamento = altura = presentismo = 0;
            nombre = apellido = " ";
        }

        public Persona(int documento, int tipoDocumento, int calle, int localidad, int departamento, int altura, int presentismo, string nombre, string apellido)
        { 
            this.documento = documento;
            this.tipoDocumento = tipoDocumento;
            this.calle = calle;
            this.localidad = localidad;
            this.departamento = departamento;
            this.altura = altura;
            this.presentismo = presentismo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    
    }
}
