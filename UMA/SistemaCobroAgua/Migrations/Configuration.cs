namespace SistemaCobroAgua.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //librerias
    using SistemaCobroAgua.Modelos;
    internal sealed class Configuration : DbMigrationsConfiguration<SistemaCobroAgua.DAL.CobroAguaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SistemaCobroAgua.DAL.CobroAguaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var clientes = new List<Cliente>
            {
            new Cliente{Nombre="Carson",Apellido="Alexander", Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-5"},
            new Cliente{Nombre="Meredith",Apellido="Alonso", Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Nahuizalco",DUI="0467111-4"},
            new Cliente{Nombre="Arturo",Apellido="Anand",Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Nahuilingo",DUI="0467111-5"},
            new Cliente{Nombre="Gytis",Apellido="Barzdukas",Direccion = "Colonia Ish , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-2"},
            new Cliente{Nombre="Yan",Apellido="Li",Direccion = "Colonia Norte , Pasaje 3, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonzacate",DUI="0467111-1"},
            new Cliente{Nombre="Peggy",Apellido="Justice",Direccion = "Colonia Ish , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-1"},
            new Cliente{Nombre="Laura",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Nino",Apellido="Olivetto",Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-5"},
            new Cliente{Nombre="Lupe",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Maritza",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Cesar",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Rodrigo",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Fulano",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Solano",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Mengano",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Laura",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Siempre",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Rosa",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Rosibel",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Juan",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Aura",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Mauricio",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Pablo",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Pedro",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Laura",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Pepe",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Roberto",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Rigoberto",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Josh",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Tutu",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Josue",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Lupe",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Jimenez",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Luis",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Lorena",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Stefanie",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Estafany",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Yajira",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Yuri",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Suis",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Susana",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Susi",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Lupe",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Saul",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Victor",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Zacapa",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Luis",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Laura",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Laura Segundo",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Tercero",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Cuarto",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},
            new Cliente{Nombre="Laura",Apellido="Norman",Direccion = "Colonia Sensunapan , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="0467111-4"},

            };

            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();



            var servicios = new List<Servicio>
            {
            new Servicio{NombreDeServicio="Costos de Produccion",Precio=0.83,COD=1},
            new Servicio{NombreDeServicio="Cobro Por Servicio",Precio=0.4200,COD=15},
            new Servicio{NombreDeServicio="Servicio de Alcantarillados",Precio=0.83,COD=01},
            new Servicio{NombreDeServicio="Subsidio de Mes de Enero",Precio=0.40,COD=200},
            new Servicio{NombreDeServicio="Subsidio de Mes de Febrero",Precio=0.40,COD=201},
            new Servicio{NombreDeServicio="Subsidio de Mes de Marzo",Precio=0.40,COD=202},
            new Servicio{NombreDeServicio="Subsidio de Mes de Abril",Precio=0.40,COD=203},
            new Servicio{NombreDeServicio="Subsidio de Mes de Mayo",Precio=0.40,COD=204},
            new Servicio{NombreDeServicio="Subsidio de Mes de Junio",Precio=0.40,COD=205},
            new Servicio{NombreDeServicio="Subsidio de Mes de Julio",Precio=0.40,COD=206},
            new Servicio{NombreDeServicio="Subsidio de Mes de Agosto",Precio=0.40,COD=207},
            new Servicio{NombreDeServicio="Subsidio de Mes de Septiembre",Precio=0.40,COD=208},
            new Servicio{NombreDeServicio="Subsidio de Mes de Octubre",Precio=0.40,COD=209},
            new Servicio{NombreDeServicio="Subsidio de Mes de Noviembre",Precio=0.40,COD=210},
            new Servicio{NombreDeServicio="Subsidio de Mes de Diciembre",Precio=0.40,COD=211},

            };
            servicios.ForEach(s => context.Servicios.Add(s));
            context.SaveChanges();


            var tafiraResidenciales = new List<TarifaResidencial>
            {
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="De 0 a 10 m3",TarifaAcueductoPrecioPorM3=2.29,TarifasAlcantarillado=0.10},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 11 m3 hasta 20 m3",TarifaAcueductoPrecioPorM3=0.210,TarifasAlcantarillado=0.10},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="21 m3",TarifaAcueductoPrecioPorM3=0.250,TarifasAlcantarillado=1.80},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="22 m3",TarifaAcueductoPrecioPorM3=0.280,TarifasAlcantarillado=1.80},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="23 m3",TarifaAcueductoPrecioPorM3=0.310,TarifasAlcantarillado=1.80},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="24 m3",TarifaAcueductoPrecioPorM3=0.340,TarifasAlcantarillado=1.80},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="De 25 m3 hasta 30 m3",TarifaAcueductoPrecioPorM3=0.370,TarifasAlcantarillado=1.80},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="31 m3",TarifaAcueductoPrecioPorM3=0.420,TarifasAlcantarillado=3.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="32 m3",TarifaAcueductoPrecioPorM3=0.480,TarifasAlcantarillado=3.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="33 m3",TarifaAcueductoPrecioPorM3=0.540,TarifasAlcantarillado=3.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="34 m3",TarifaAcueductoPrecioPorM3=0.640,TarifasAlcantarillado=3.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="De 35 m3 hasta 40 m3",TarifaAcueductoPrecioPorM3=0.760,TarifasAlcantarillado=3.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="41 m3",TarifaAcueductoPrecioPorM3=0.900,TarifasAlcantarillado=4.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="42 m3",TarifaAcueductoPrecioPorM3=1.050,TarifasAlcantarillado=4.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="43 m3",TarifaAcueductoPrecioPorM3=1.200,TarifasAlcantarillado=4.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="44 m3",TarifaAcueductoPrecioPorM3=1.400,TarifasAlcantarillado=4.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="De 45 m3 hasta 50 m3",TarifaAcueductoPrecioPorM3=1.650,TarifasAlcantarillado=4.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 51 m3 hasta 60 m3",TarifaAcueductoPrecioPorM3=1.900,TarifasAlcantarillado=7.50},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 61 m3 hasta 70 m3",TarifaAcueductoPrecioPorM3=2.200,TarifasAlcantarillado=7.50},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 71 m3 hasta 90 m3",TarifaAcueductoPrecioPorM3=2.500,TarifasAlcantarillado=7.50},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 91 m3 hasta 100 m3",TarifaAcueductoPrecioPorM3=2.900,TarifasAlcantarillado=7.50},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 101 m3 hasta 500 m3",TarifaAcueductoPrecioPorM3=3.400,TarifasAlcantarillado=10.00},
            new TarifaResidencial{RangosDeConsumoEnMetrosCubicos="Mayor de 501 m3",TarifaAcueductoPrecioPorM3=3.900,TarifasAlcantarillado=20.00},

            };
            tafiraResidenciales.ForEach(s => context.TarifaResidencials.Add(s));
            context.SaveChanges();



            var tarifaEstablecimientos = new List<TarifaDeEstablecimiento>
            {
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 0 hasta 5 m3",TarifaAcueductoM3=3.76,TarifaAlcantarillado=0.100},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 6 hasta 20 m3",TarifaAcueductoM3=0.900,TarifaAlcantarillado=5.00},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 21 hasta 30 m3",TarifaAcueductoM3=1.200,TarifaAlcantarillado=5.00},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 31 hasta 50 m3",TarifaAcueductoM3=1.500,TarifaAlcantarillado=7.50},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 51 hasta 60 m3",TarifaAcueductoM3=1.875,TarifaAlcantarillado=7.50},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 61 hasta 90 m3",TarifaAcueductoM3=2.344,TarifaAlcantarillado=7.50},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 91 hasta 100 m3",TarifaAcueductoM3=2.930,TarifaAlcantarillado=7.50},
            new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 101 hasta 500 m3",TarifaAcueductoM3=3.662,TarifaAlcantarillado=10.00},
             new TarifaDeEstablecimiento{RangosDeConsumoEnMetrosCubicos="De 501 en adelante",TarifaAcueductoM3=4.578,TarifaAlcantarillado=20.00},

            };
            tarifaEstablecimientos.ForEach(s => context.TarifaDeEstablecimientos.Add(s));
            context.SaveChanges();



            var cabezeraFacturas = new List<CabezeraFactura>
            {
            new CabezeraFactura{NumeroDeCuenta="06166790",NumeroDeFactura="19NDS000F20",NRC="31980-9",NIT="7869-238912-005-9", Giro="EVACUACION DE AGUAS RESIDUALES ALCANTARILLADO",Fecha=DateTime.Parse("2020-02-01"),ClienteID=1},
            new CabezeraFactura{NumeroDeCuenta="06166790",NumeroDeFactura="19NDS000F21",NRC="31980-1",NIT="7869-238912-001-9", Giro="CAPTACION TRATAMIENTO Y SUMINISTRO DE AGUA",Fecha=DateTime.Parse("2020-02-06"),ClienteID=3},
            new CabezeraFactura{NumeroDeCuenta="00000001",NumeroDeFactura="19NDS000F22",NRC="31980-2",NIT="7869-238912-002-9", Giro="EVACUACION DE AGUAS RESIDUALES ALCANTARILLADO",Fecha=DateTime.Parse("2020-02-02"),ClienteID=4},
            new CabezeraFactura{NumeroDeCuenta="00000002",NumeroDeFactura="19NDS000F23",NRC="31980-3",NIT="7869-238912-003-9", Giro="CAPTACION TRATAMIENTO Y SUMINISTRO DE AGUA",Fecha=DateTime.Parse("2020-02-03"),ClienteID=2},
            new CabezeraFactura{NumeroDeCuenta="00000003",NumeroDeFactura="19NDS000F24",NRC="31980-4",NIT="7869-238912-004-9", Giro="CAPTACION TRATAMIENTO Y SUMINISTRO DE AGUA",Fecha=DateTime.Parse("2020-02-04"),ClienteID=5},
            new CabezeraFactura{NumeroDeCuenta="00000004",NumeroDeFactura="19NDS000F25",NRC="31980-5",NIT="7869-238912-005-9", Giro="CAPTACION TRATAMIENTO Y SUMINISTRO DE AGUA",Fecha=DateTime.Parse("2020-02-05"),ClienteID=6},
            new CabezeraFactura{NumeroDeCuenta="00000005",NumeroDeFactura="19NDS000F26",NRC="31980-6",NIT="7869-238912-006-9", Giro="EVACUACION DE AGUAS RESIDUALES ALCANTARILLADO",Fecha=DateTime.Parse("2020-02-06"),ClienteID=2},
            new CabezeraFactura{NumeroDeCuenta="00000006",NumeroDeFactura="19NDS000F27",NRC="31980-7",NIT="7869-238912-006-9", Giro="CAPTACION TRATAMIENTO Y SUMINISTRO DE AGUA",Fecha=DateTime.Parse("2020-02-05"),ClienteID=3},
            new CabezeraFactura{NumeroDeCuenta="00000007",NumeroDeFactura="19NDS000F28",NRC="31980-8",NIT="7869-238912-007-9", Giro="EVACUACION DE AGUAS RESIDUALES ALCANTARILLADO",Fecha=DateTime.Parse("2020-02-02"),ClienteID=2},
            new CabezeraFactura{NumeroDeCuenta="00000008",NumeroDeFactura="19NDS000F29",NRC="31981-9",NIT="7869-238912-018-9", Giro="EVACUACION DE AGUAS RESIDUALES ALCANTARILLADO",Fecha=DateTime.Parse("2020-02-02"),ClienteID=2},

            };
            cabezeraFacturas.ForEach(s => context.CabezeraFacturas.Add(s));
            context.SaveChanges();





            var subCabezeraFacturas = new List<SubCabezeraFactura>
            {
            new SubCabezeraFactura{CabezeraFacturaID=1,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=2,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=3,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=4,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=5,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=6,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=7,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            new SubCabezeraFactura{CabezeraFacturaID=8,FacturadoDesde=DateTime.Parse("2020-02-01"),FacturadoHasta=DateTime.Parse("2020-03-02"),DiasFacturados=DateTime.Parse("2020-03-02"),MesFacturado=DateTime.Parse("2020-03-02"),Region="OCCIDENTE",Grupo="60",Ruta="056", FechaEmision=DateTime.Parse("2020-03-05")},
            };
            subCabezeraFacturas.ForEach(s => context.SubCabezeraFacturas.Add(s));
            context.SaveChanges();

            var usuarios = new List<Usuario>
            {
            new Usuario{Nombre="Administrador",Apellido="Administrador", Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="00000000-0", Email="admin@admin.com", Password="admin1234"},
            new Usuario{Nombre="Author",Apellido="Author", Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="00000000-0", Email="author@author.com", Password="author1234"},
            new Usuario{Nombre="Moderator",Apellido="Moderator", Direccion = "Colonia Norte , Pasaje 4, Casa #4 , Poli. 10, Sonsonate, Sonsonate", Departamento="Sonsonate", Municipio="Sonsonate",DUI="00000000-0", Email="moderator@moderator.com", Password="moderator1234"}
            };
            usuarios.ForEach(s => context.Usuarios.Add(s));
            context.SaveChanges();
        }
    }
}
