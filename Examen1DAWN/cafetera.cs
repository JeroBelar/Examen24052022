using System;
///<summary>
///El codigo de ha tabulado.
///</summary>
//namespace EDexamenT6a8
///<sumary>
/// Proporciona las propiedades y métodos necesarios Agregar, Actualizar y Eliminar un cliente.
///</sumary>
///<remarks>
///Recuerda utilizar esta clase solo cuando necesite modificar la infomacion de cafetera.
///</remarks>
class cafetera
{
    ///<summary>
    /// He cambiado el nombre del campo de m a marca.
    ///</summary>
    ///<param name="marca"> Valor de tipo string que nos indica la marca de la cafetera</param>
    private string marca;

    ///<summary>
    /// He encapsulado el campo.
    ///</summary>
    ///<value>Modelo especificado </value>

    public string Marca
    {
        get
        {
            return marca;
        }
        set
        {
            marca = value;
        }
    }

    ///<summary>
    /// He cambiado el nombre del campo de r a refrenciaModelo.
    ///</summary>
    ///<param name="refrenciaModelo"> Valor de tipo string que noa indica la la referencia del modelo</param>
    private string refrenciaModelo;
    ///<summary>
    /// He encapsulado el campo.
    ///</summary>
    ///<value>Refrencia de modelo especificado</value>

    public string ReferenciaModelo
    {
        get
        {
            return refrenciaModelo;
        }
        set
        {
            refrenciaModelo = value;
        }
    }

    ///<param name="agua"> Valor de tipo double que nos indica el agua</param>
    private double agua;
    ///<summary>
    /// He encapsulado el campo.
    ///</summary>
    ///<value>Cantidad de agua especificada </value>
    
    public double Agua
    {
        get
        {
            return agua;
        }
        set
        {
            agua = value;
        }
    }

    ///<param name="totaldecapsulas"> Valor de tipo double nos indica el total de capsulas</param>
    private double totaldecapsulas;
    ///<summary>
    /// He encapsulado el campo.
    ///</summary>
    ///<value>Total de capsulas  especificada </value>

    public double Totalcapsulas
    {
        get
        {
            return totaldecapsulas;
        }
        set
        {
            totaldecapsulas = value;
        }
    }

    public cafetera(string marca, string referenciaModelo, double agua, double totaldecapsulas)
    {
        this.Marca = marca; //marca de la máquina cafetera
        this.ReferenciaModelo = referenciaModelo; //referencia del modelo
        this.totaldecapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
        this.agua = agua; //Cantidad de agua en el recipiente. 
    }
   
    ///<summary>
    /// He modificado el nombre del metodo, para que empieze por mayuscula y que las iniciales siguientes sean mayusculas.
    ///<returns>Este metodo devuelve el agua que queda </returns>
    ///</summary>
    public string ConsumoAgua(double numerodecafe) //numero de cafés a hacer
    {
        double constante = 0.1;

        this.Agua = this.Agua - numerodecafe * constante; // Constante de consumo de agua 0.1l por cada unidad de café.
                                                          
        if (this.Agua < 0.1)
        {   
            this.Agua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else
        { 
            return "Quedan" + this.Agua + " centilitros";
        }
    }

    ///<sumary>
    /// He modificado el nombre del metodo, para que empieze por mayuscula y que las iniciales siguientes sean mayusculas.
    ///<returns>Este metodo devuelve el total de capsulas que quedan </returns>
    ///</summary>
    public string ConsumoCapsulas(double numerodecafe) //Hacer un café 
    {
        this.Totaldecapsulas = this.Totaldecapsulas - numerodecafe;
        if (this.Totaldecapsulas < 0)
        {
            this.Totaldecapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else {
            return "Quedan" + this.Totaldecapsulas + "unidades";
        }
    }
    ///<sumary>
    /// He modificado el nombre del metodo, para que empieze por mayuscula y que las iniciales siguientes sean mayusculas.
    ///<returns>Este devuelve el total de capsulas </returns>
    ///</summary>
    ///<remarks> Utilizar este metodo cuando se necesite modificar total de capsulas.</remarks>

    public double ReponerCapsulas(double cantidadcapsulas)
    {
        this.Totaldecapsulas = this.Totaldecapsulas + cantidadcapsulas;
        return this.Totaldecapsulas;
    }

    ///<sumary>
    /// He modificado el nombre del metodo, para que empieze por mayuscula y que las iniciales siguientes sean mayusculas.
    ///<returns>Este  metodo devuelve el deposito de agua</returns>
    ///</summary>
    ///<remarks> Utilizar este metodo cuando se necesite modificar el agua.</remarks>
    public double Llenardeposito(double litros)
    {
        this.Agua = this.Agua + litros;
        return this.Agua;
    }

    ///<summary>
    ///He modificado el nombre del metodo, para que empieze por mayuscula y que las iniciales siguientes sean mayusculas y tambien he borrado los parametros.
    ///<returns>Este meodo nos muestra la especificacion de nuestra cafetera</returns>
    ///</summary>
    
    public void VerEspecificacion()
    {
        Console.Writeline(this.Marca);
        Console.Writeline(this.ReferenciaModelo);
    }
}


class ejemplodemicafetera
{
    ///<summary>Esta clase es para llamar los metodos y campos de nuestras clases</summary>
    static void main()
    {
        cafetera mi_cafetera_ejemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(mi_cafetera_ejemplo.Agua);
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5));
        Console.WriteLine(mi_cafetera_ejemplo.Totaldecapsulas);
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoAgua(5));
        Console.WriteLine(mi_cafetera_ejemplo.Agua);
        mi_cafetera_ejemplo.Llenardeposito(0.5);
        Console.WriteLine(mi_cafetera_ejemplo.Agua);
        mi_cafetera_ejemplo.ReponerCapsulas(3);
        Console.WriteLine(mi_cafetera_ejemplo.Totaldecapsulas);
    }

}