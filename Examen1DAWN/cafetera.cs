
using System;


//namespace EDexamenT6a8

class Cafetera
{


    /// <summary>
    /// se cambia el nombre de m a marca y de r a refModelo para que sea mas claro, tambien se añade un constructor publico global
    /// </summary>
    /// <param name="marca"> valor de tipo string que indica la marca de la cafetera</param>
    /// <param name="refModelo"> variable de tipo string que indica la referencia del modelo</param>
    /// <param name="agua"> variable del tipo double que indica la cantidad de agua</param>
    /// <param name="totaldecapsulas">variable de tipo double que indica el total de capsulas</param>
    private string marca;
    private string refModelo;
    private double agua;
    private double totaldecapsulas;

    public global::System.String Marca { get => marca; set => marca = value; }
    public global::System.String RefModelo { get => refModelo; set => refModelo = value; }
    public global::System.Double Agua { get => agua; set => agua = value; }
    public global::System.Double Totaldecapsulas { get => totaldecapsulas; set => totaldecapsulas = value; }
    /// <summary>
    /// <para>se ha cambiado la tabulacion de else para que sea mas legible y eliminado this extra de tod el programa. El constructor asigna el valor de </para>
    /// <para>la marca, referencia del modelo, agua y total de capsulas a sus atributos. Las funciones se han reecrito con su primera letra en mayuscula</para>
    /// </summary>
    /// <param name="marcaIntroducida"> valor de tipo string que indica la marca de la cafetera</param>
    /// <param name="referenciaIntroducida"> variable de tipo string que indica la referencia del modelo</param>
    /// <param name="agua"> variable del tipo double que indica la cantidad de agua</param>
    /// <param name="totaldecapsulas">variable de tipo double que indica el total de capsulas</param>
    /// <remarks> Se destaca que este constructor es unicamente usado para crear la clase, debe crearse mediante este metodo y se usara unicamente para ello</remarks>

    public Cafetera(string marcaIntroducida, string referenciaIntroducida, double aguaIntroducida, double totaldecapsulasIntroducida)
    {
        marca = marcaIntroducida; //marca de la máquina cafetera
        refModelo = referenciaIntroducida; //referencia del modelo
        totaldecapsulas = totaldecapsulasIntroducida; //Total de cápsulas en la máquina. 
        agua = aguaIntroducida; //Cantidad de agua en el recipiente. 
    }




    /// <summary>
    /// Metodo para obtener el agua restante tras introducir el numero de cafe
    /// </summary>
    /// <param name="numerodecafe">numero de tipo double que indica los cafes a hacer</param>
    /// <returns> devuelve un string con el agua restante o si es necesario revisar el agua</returns>
    public string ConsumoAgua(double numerodecafe) //numero de cafés a hacer
    {
        double constante = 0.1; // se declara una constante de tipo double
        agua = agua - numerodecafe * constante; // se resta 0,1 por el numero de cafe al agua usada. 
        if (agua < 0.1)// si el agua es menor que 0,1 se ejecuta el if
        {   agua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else 
        {
            return "Quedan" + agua + " centilitros";
        }
    }
    /// <summary>
    /// metdo para consumir capsulas
    /// </summary>
    /// <param name="numerodecafe"> numero de tipo double que indica los cafes a hacer</param>
    /// <returns> devuelve un string con el numero de capsulas restantes o si se necesitan mas</returns>
    public string ConsumoCapsulas(double numerodecafe) //Hacer un café 
    {
        totaldecapsulas = totaldecapsulas - numerodecafe; // se  actualiza el total de capsulas
        if (totaldecapsulas < 0) // cuando el numero restante es menor a 0 se ejeuta el if
        {
            totaldecapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else 
        {
            return "Quedan" + totaldecapsulas + "unidades";
        }
    }
    /// <summary>
    /// Metodo para añadir capsulas a la cafetera. Se elimina el tipo double ya que no es necesario un return
    /// </summary>
    /// <param name="cantidadcapsulas"> variable de tipo double con la cantidad de capsulas a añadir</param>
    /// <returns>devuelve el total de capsulas tras añadir la cantidad introducida</returns>
    public void ReponerCapsulas(double cantidadcapsulas)
    {
        totaldecapsulas = totaldecapsulas + cantidadcapsulas; // añade la cantidad de capsulas a el total
    }
    /// <summary>
    /// Metodo para añadir agua a la cafetera.  Se elimina el tipo double ya que no es necesario un return
    /// </summary>
    /// <param name="litros"> variable de tipo double con la cantidad de agua a añadir</param>
    /// <returns>devuelve el total de litros de agua tras añadir la cantidad introducida</returns>
    public void LlenarDeposito(double litros)
    {
        agua = agua + litros; // añade la cantidad de litros al agua total
    }

    /// <summary>
    /// Metodo para actualizar la marca y la referencia de la cafetera
    /// </summary>
    /// <param name="refernciaIntroducida">variable de tipo string que indica que tipo de referencia de modelo es la cafetera</param>
    /// <param name="marcaIntroducida">variable de tipo string que indica que tipo de marca es la cafetera<</param>
    public void VerEspecificacion(string refernciaIntroducida, string marcaIntroducida)
    {
        marca = marcaIntroducida; // actualiza la marca
        refModelo = refernciaIntroducida; // actualiza la referencia del modelo
    }

}


class ejemplodemicafetera
{

    static void main()
    {

        // Se crea una cafetera con su constructor
        Cafetera mi_cafetera_ejemplo = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);
        
        Console.WriteLine(mi_cafetera_ejemplo.agua); // muestra por pantalla el agua a de la cafetera
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5)); // muestra por pantalla una string con el numero de capsulas consumir 5
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas); // muestra el total de capsulas
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoAgua(5)); // muestra por pantalla uan string con la cantidad de agua  tras consumir 5l
        Console.WriteLine(mi_cafetera_ejemplo.agua); // muestra los litros tpotales
        mi_cafetera_ejemplo.LlenarDeposito(0.5); // añade medio litro
        Console.WriteLine(mi_cafetera_ejemplo.agua); // muestra el agua total
        mi_cafetera_ejemplo.ReponerCapsulas(3); // añade 3 capsulas
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas); // muetsra el total de capsulas


    }

}