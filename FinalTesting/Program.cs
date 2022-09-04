using Final.core;

SumaStock articulo = new SumaStock();

articulo.CargarArticulo(new List<ItemsArticulo>()
{
    new ItemsArticulo(){

        Nombre ="Ventilador",
        descripcion ="Ventilador 20 ",
        stock =5,
        Precio =2500,
    },
    new ItemsArticulo(){

        Nombre ="lavarropas",
        descripcion ="lavarropa automatico  ",
        stock =10,
        Precio =5800,
    },
    new ItemsArticulo(){

        Nombre ="freezer",
        descripcion ="freezer 20 litros ",
        stock =10,
        Precio =7000,
    },
    new ItemsArticulo(){

        Nombre ="radio",
        descripcion ="radio am fm  ",
        stock =15,
        Precio =6000,
    },


});


Console.WriteLine("El total de stock es :  " + articulo.Obtenertotal());

Console.WriteLine("Los productos de la lista son: " + articulo.mostrarlista());

Console.WriteLine("Los producto es : " + articulo.EncontrarArticulo("Ventilador"));

