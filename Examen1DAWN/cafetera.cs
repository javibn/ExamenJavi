
using System;

/// <summary>
/// Tabulacion correcta de todo el código para que sea mas legible
/// </summary>

//namespace EDexamenT6a8

/// <summary>
/// Cambio a notacion PasCal del nombre de la clase.
/// </summary>
class Cafetera
{
    /// <summary>
    /// Cambio de nombre de los campos m, r y agua para que sea mas entendible.
    /// <para>Proporciona los campos, propiedades y métodos necesarios para la ultilización de la clase: ConsumoAgua, ConsumoCapsulas,
    /// ReponerCapsulas, LlenarDeposito y VerEspecificacion.</para>
    /// <param name="marca">Especifica el nombre la marca de la cafetera</param>
    /// <param name="refrenciaModelo">Especifica el modelo de la cafetera</param>
    /// <param name="volumen">Especifica la capacidad de la cafetera</param>
    /// <param name="totalcapsulas">Especifica el total de capsulas que tiene la cafetera</param>
    /// </summary>
    private string marca;
    private string referenciaModelo;
    private double volumen;
    private double totalDeCapsulas;

    /// <summary>
    /// Encapsulamiento de los campos públicos y conversion de estos a privados.
    /// Las propiedades ya se crearon con la nomenclatura PasCal.
    /// </summary>
    public global::System.String Marca { get => marca; set => marca = value; }
    public global::System.String ReferenciaModelo { get => referenciaModelo; set => referenciaModelo = value; }
    public global::System.Double Volumen { get => volumen; set => volumen = value; }
    public global::System.Double TotalDeCapsulas { get => totalDeCapsulas; set => totalDeCapsulas = value; }

    /// <summary>
    /// Cambio de nombre de los parametros del constructor.
    /// Cambio nomenclatura del parametro totalDeCapsulas.
    /// Constructor, funcion para poder crear un objeto cafetera.
    /// <remarks>No se podra crear una cafetera sin conocer todos sus parametros</remarks>
    /// <param name="marca">Especifica el nombre la marca de la cafetera</param>
    /// <param name="refrenciaModelo">Especifica el modelo de la cafetera</param>
    /// <param name="volumen">Especifica la capacidad de la cafetera</param>
    /// <param name="totalcapsulas">Especifica el total de capsulas que tiene la cafetera</param>
    /// </summary>
    public Cafetera(string marca, string referenciaModelo, double volumen, double totalDeCapsulas)
    {
        this.Marca = marca; //marca de la máquina cafetera
        this.ReferenciaModelo = referenciaModelo; //referencia del modelo
        this.TotalDeCapsulas = totalDeCapsulas; //Total de cápsulas en la máquina. 
        this.Volumen = volumen; //Cantidad de agua en el recipiente. 
    }
    /// <summary>
    /// Cambio de nombre de la variable constante en el metodo ConsumoAgua
    /// Nomenclatura PasCal para el nombre del método.
    /// Cambio nomenclatura parametro numeroDeCafe a caMel
    /// Metodo que pasandole un numero de cafes a hacer, te devuelve si la cafetera puede o no hacer esa cantidad de cafes
    /// </summary>
    /// <param name="numeroDeCafe">cantidad de cafes que se prueba</param>
    /// <returns>string con el texto de si se pueden realizar los cafes o no</returns>
    public string ConsumoAgua(double numeroDeCafe) //numero de cafés a hacer
    {
        double consumoConstante = 0.1;
        this.Volumen = this.Volumen - numeroDeCafe * consumoConstante; // Constante de consumo de agua 0.1l por cada unidad de café. 
        if (this.Volumen < 0.1)
        {
            this.Volumen = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else { return "Quedan" + this.Volumen + " centilitros"; }
    }
    /// <summary>
    /// Nomenclatura PasCal para el nombre del método.
    /// Cambio nomenclatura parametro numeroDeCafe a caMel
    /// Metodo que pasandole un numero de cafes a hacer, te devuelve si la cafetera puede o no hacer esa cantidad de cafes
    /// </summary>
    /// <param name="numeroDeCafe">cantidad de cafes que se prueba</param>
    /// <returns>string con el texto de si hay suficientes capsulas o no</returns>
    public string ConsumoCapsulas(double numeroDeCafe) //Hacer un café 
    {
        this.TotalDeCapsulas = this.TotalDeCapsulas - numerodecafe;
        if (this.TotalDeCapsulas < 0)
        {
            this.TotalDeCapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else
        {
            return "Quedan" + this.TotalDeCapsulas + "unidades";
        }
    }
    /// <summary>
    /// Nomenclatura PasCal para el nombre del método
    /// Cambio nomenclatura parametro cantidadCapsulas a caMel
    /// Método que aumenta el numero de la cantidad de capsulas que tiene la cafetera.
    /// </summary>
    /// <param name="cantidadCapsulas">cantidad de capsulas que se añaden a la cafetera</param>
    /// <returns>cantidad total de capsulas de la cafetera despues de añadir las nuevas</returns>
    public double ReponerCapsulas(double cantidadCapsulas)
    {
        this.TotalDeCapsulas = this.TotalDeCapsulas + cantidadCapsulas;
        return this.TotalDeCapsulas;
    }
    /// <summary>
    /// Nomenclatura PasCal para el nombre del método
    /// Método que llena el deposito de agua de la cafetera.
    /// </summary>
    /// <param name="litros">cantidad de agua que se le añade a la cafetera</param>
    /// <returns>devuelve el total de litros de agua que tiene la cafetera despues de añadir</returns>
    public double LlenarDeposito(double litros)
    {
        this.Volumen = this.Volumen + litros;
        return this.Volumen;
    }

    /// <summary>
    /// Cambio de nombre de los parametros del método VerEspecificaciones
    /// Nomenclatura PasCal para el nombre del método
    /// Cambio nomenclatura parametro referenciaModelo a caMel
    /// Métod que busca devolver las especificaciones de la cafetera pero en su lugar recibe dos parametros
    /// y le cambia la propiedad a la cafetera
    /// </summary>
    /// <param name="referenciaModelo">modelo de la cafetera</param>
    /// <param name="marca">marca de la cafetera</param>
    public void VerEspecificacion(string referenciaModelo, string marca)
    {
        this.Marca = marca;
        this.ReferenciaModelo = referenciaModelo;
    }

}
