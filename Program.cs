using System;
using System.Globalization;
using System.Linq;

namespace RepasoStringParaExamen
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su primer apellido:");
            string primerApellido = Console.ReadLine();

            Console.WriteLine("Ingrese su segundo apellido:");
            string segundoApellido = Console.ReadLine();

            int comparar = nombre.CompareTo(primerApellido);
            int comparar2= nombre.CompareTo(segundoApellido);
            if(comparar == 0)
            {
                Console.WriteLine("El nombre y el primer apellidos son iguales");
            }
            else
            {
                Console.WriteLine("El nombre y el primer apellido son distintos");
            }
            if(comparar2== 0)
            {
                Console.WriteLine("El nombre y el segundo apellido son iguales");

            }
            else
            {
                Console.WriteLine("El nombre y el segundo apellido son distintos");
            }
            Console.WriteLine("CONCATENACION");
            string nombreCompleto = nombre + " " + primerApellido + " " + segundoApellido;
            Console.WriteLine(nombreCompleto);
            string combinacion = string.Concat(primerApellido,segundoApellido, nombre);
            Console.WriteLine(combinacion);
            string[] nombreCompleto1 = { nombre, primerApellido, segundoApellido };
            Console.WriteLine(string.Concat(nombreCompleto1));
           Array.Sort(nombreCompleto1);
            Console.WriteLine(string.Concat(nombreCompleto1));
            //Dividir un texto por un carácter
            Console.WriteLine(" DIVIDIR TEXTO POR UN CARACTER SPLIT");
            char caracterSeparacion = ',';
            string[] textoSeparado = nombreCompleto.Split(caracterSeparacion);
            foreach (string trozo in textoSeparado)
            {
                Console.WriteLine(trozo);
            }
            Console.WriteLine("CONTAR OCURRENCIAS DE UN CARACTER EN UNA FRASE");
            char caracter = 'e';
            int freq = nombreCompleto.Count(f => (f == caracter));
            Console.WriteLine(freq);

            Console.WriteLine("MEDIR LA LONGITUD DE UNA CADENA");
            string frase = " jaqueline romero torres";
            int longitud = frase.Length;
            Console.WriteLine(longitud);

            Console.WriteLine("ELIMINAR PARTE DE LA CADENA");
            string text = "Hello, World!";
            string newText = text.Substring(7, 5);
            Console.WriteLine("La cadena original es: " + text);
            Console.WriteLine("La nueva cadena es: " + newText);

            Console.WriteLine("ELIMINAR PARTE DE LA CADENA");
            string texto1 = "Hello, World!";
            string textoNuevo = texto1.Replace('o', 'O');
            Console.WriteLine("La cadena original es: " + texto1);
            Console.WriteLine("La nueva cadena es: " + textoNuevo);

            /**
            Console.WriteLine("METODO BURBUJA");
            public void ordenarporFecha(List<ActividadDto> listaActividades)
            {
                if (listaActividades.Count >= 3)
                {
                    for (int i = 0; i < listaActividades.Count - 1; i++)
                    {
                        for (int j = 0; j < listaActividades.Count - 1 - i; j++)
                        {
                            if (listaActividades[j].DuracionMinutos < listaActividades[j + i].DuracionMinutos)
                            {
                                ActividadDto actAux = listaActividades[j];
                                listaActividades[j] = listaActividades[j + i];
                                listaActividades[j + 1] = actAux;

                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Necesita introducir mas clientes a la lista");
                }
            }


            Console.WriteLine("Array palabras desordenado: ");
            for (int i = 0; i < palabras.Length; i++)
            { Console.WriteLine(" Palabras[" + i + "] = " + palabras[i]); }

            String aux;
            for (int i = 1; i <= palabras.Length; i++)
            {
                for (int j = 0; j < palabras.Length - i; j++)
                {
                    if (palabras[j].CompareTo(palabras[j + 1]) > 0)
                    {
                        aux = palabras[j];
                        palabras[j] = palabras[j + 1];
                        palabras[j + 1] = aux;
                    }
                }
            }
                **/

              Console.WriteLine("CONVERTIR TEXTO A MAYUSCULAS");
            string texto2 = "Hello, World!";
            string nuevoTexto2 = texto2.ToUpper(); //ToLower
            Console.WriteLine("La cadena original es: " + texto2);
            Console.WriteLine("La nueva cadena es: " + nuevoTexto2);

            Console.WriteLine("INDEX OF");
            string str = "Ice cream";

            // returns index of substring cream
            int result = str.IndexOf("cream");

            Console.WriteLine(result);

            Console.WriteLine("ARRAY SORT");
            List<int> numeros = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

            numeros.Sort(); // Ordenar en orden ascendente

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Reverse(); // Ordenar en orden descendente

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


            Console.WriteLine("CALCULAR EDAD EN AÑOS MESES Y DIAS");
            Console.WriteLine("Introduzca su fecha de nacimiento en formato YYYY-MM-dd");
            DateTime fechaNacimiento=Convert.ToDateTime(Console.ReadLine());
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual-fechaNacimiento;
            int edadAnio = diferencia.Days / 365;
            int edadMes = (diferencia.Days % 365) / 30;
            int edadDia = (diferencia.Days % 365) % 30;
            Console.WriteLine("Su edad en años es " + edadAnio + ",su edad en meses es " + edadMes + "meses y su edad en dias es de " + edadDia + "dias");
            
            Console.WriteLine("PROPIEDADES DE DATETIME");
            DateTime fechaHoy = DateTime.Now;

            int dia = fechaActual.Day;
            int mes = fechaActual.Month;
            int anio = fechaActual.Year;
            int hora = fechaActual.Hour;
            int minutos = fechaActual.Minute;
            int segundos = fechaActual.Second;
            DayOfWeek diaSemana = fechaActual.DayOfWeek;
            int diaDelAnio = fechaActual.DayOfYear;

            Console.WriteLine("AÑADIR DIAS, MESES AÑOS");
            DateTime fechaAhora = DateTime.Now;
            Console.WriteLine("Introduzca el numero de dias que desee añadir");
            int numDias = Convert.ToInt32(Console.ReadLine());
            DateTime fechaSuma = fechaAhora.AddDays(numDias);
            DateTime fechaResta= fechaAhora.AddDays(-numDias);
            Console.WriteLine(fechaSuma.ToString());
            DateTime fecha2 = fechaSuma.AddMonths(-24).AddYears(new Random().Next(0, 5));
            Console.WriteLine(fecha2.ToString());

            if (fecha2 > fechaSuma)
            {
                Console.WriteLine("El hoy es más grande");
            }
            else
            {
                Console.WriteLine("Hoy no es más grande");
            }
            string fecha;
            Console.WriteLine("Introduzca una fecha en formato dd/mm/yyyy hh:mm:ss");
            fecha = Console.ReadLine();
            DateTime fecha1 = Convert.ToDateTime(fecha);

            Console.WriteLine("Introduzca otra fecha en formato dd/mm/yyyy");
            fecha = Console.ReadLine();
            DateTime fecha3 = Convert.ToDateTime(fecha);

            TimeSpan difFechas = fecha2 - fecha1;

            int dias = difFechas.Days;
            int horas = (int)difFechas.TotalHours;
            int mints = (int)difFechas.TotalMinutes;
            int segs = (int)difFechas.TotalSeconds;

            Console.WriteLine("FECHA CULTURA ESPECIFICA");
            DateTime fechaInicial = DateTime.Now;
            Console.WriteLine(fechaInicial);
            CultureInfo culturaEspana=new CultureInfo("es-ES");
            string fechFormateada= fechaInicial.ToString(culturaEspana);
            Console.WriteLine(fechFormateada);

            String fechaformatoAmericano = "29 Jan 2024 15:15:15";
            Console.WriteLine(fechaformatoAmericano.ToString());//se imprime como se ha pasado
            CultureInfo fechaformatoEspañol = new CultureInfo("es-SP");// se crea instancia de fecha a la que se quiere apsar
            DateTime fechaAmericanoAEspana = Convert.ToDateTime(fechaformatoAmericano, fechaformatoEspañol);
            Console.WriteLine(fechaAmericanoAEspana.ToString());

            //Fecha hoy como propiedad
            DateTime fechaHoyPropiedad = DateTime.Today;
            Console.WriteLine(fechaHoyPropiedad.ToString());
            DateTime fechaHoyPropiedad2 = DateTime.Now;
            Console.WriteLine(fechaHoyPropiedad2.ToString());

            //Formato con toString
            /*Además de lo visto anteriormente con los formatos definidos
             * dentro de la localización/cultura especificada
             * podemos definir nuestro propio formato con especificaciones
             * en el string*/
            DateTime fecha4 = new DateTime(1989, 11, 2, 11, 15, 16, 123);
            fecha4.ToString("yy - MM - ddThh:mm: ss.ms");
            // resultado: 1989-01-11T11:15:16.123

            //Dentro de los métodos del DateTime, hay algunos de formato
            DateTime fecha5 = new DateTime(1989, 11, 2, 11, 15, 16);
            fecha3.ToString(); // resultado: 02/11/1989 11:15:16
            fecha3.ToShortDateString(); //resultado: 02/11/1989
            fecha3.ToLongDateString(); //Resultado: Jueves 2 octubre 1989
            fecha3.ToShortTimeString(); //resultado: 11:15
        }
    }
}



