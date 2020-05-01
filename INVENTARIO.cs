using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_I
{
    class INVENTARIO
    {
        static USUARIOS USER = new USUARIOS();
        static INVENTARIO RES = new INVENTARIO();

        public string BUSCAR;
        public int X, PRODUCTO = 1, DATOS = 1, Z, x, y;

        public int[,] INGRESAR;
        public string[,] NOMBRE, CANTIDAD, PRECIO;

        public void INA()
        {
            Console.WriteLine("INVENTARIO ADMIN");
            char OP = 'S';
            INGRESAR = new int[PRODUCTO, DATOS];
            NOMBRE = new string[PRODUCTO, DATOS];
            CANTIDAD = new string[PRODUCTO, DATOS];
            PRECIO = new string[PRODUCTO, DATOS];

            while (OP != 'N')
            {

                Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. AGREGAR PRODUCTO \n 2. BUSCAR PRODUCTO \n 3. ACTUALIZAR PRODUCTO \n 4. ELIMINAR PRODUCTO \n 5. SALIR");
                X = int.Parse(Console.ReadLine());

                if (X == 1)
                {
                    Console.Clear();
                    for (x = 0; x < DATOS; x++)
                    {
                        for (y = 0; y < PRODUCTO; y++)
                        {
                            Console.Clear();
                            Console.WriteLine("INGRESE NOMBRE:");
                            NOMBRE[x, y] = Console.ReadLine();

                            Console.WriteLine("INGRESE CANTIDAD:");
                            CANTIDAD[x, y] = Console.ReadLine();

                            Console.WriteLine("INGRESE PRECIO:");
                            PRECIO[x, y] = Console.ReadLine();
                        }
                    }
                }
                if (X == 2)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE NOMBRE DEL PRODUCTO: ");
                    BUSCAR = Console.ReadLine();

                    for (x = 0; x < DATOS; x++)
                    {
                        for (y = 0; y < PRODUCTO; y++)
                        {
                            if (BUSCAR == NOMBRE[x, y])
                            {
                                Console.Clear();
                                Console.WriteLine("NOMBRE: " + NOMBRE[x, y]);

                                Console.WriteLine("UNIDADES: " + CANTIDAD[x, y]);

                                Console.WriteLine("PRECIO: " + PRECIO[x, y]);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("PRODUCTO NO REGISTRADO");
                            }
                        }
                    }
                }
                if (X == 3)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE NOMBRE DEL PRODUCTO: ");
                    BUSCAR = Console.ReadLine();
                    for (x = 0; x < DATOS; x++)
                    {
                        for (y = 0; y < PRODUCTO; y++)
                        {
                            if (BUSCAR == NOMBRE[x, y])
                            {
                                Console.Clear();
                                NOMBRE[x, y] = "";

                                CANTIDAD[x, y] = "";

                                PRECIO[x, y] = "";

                                Console.WriteLine("INGRESE NOMBRE:");
                                NOMBRE[x, y] = Console.ReadLine();

                                Console.WriteLine("INGRESE CANTIDAD:");
                                CANTIDAD[x, y] = Console.ReadLine();

                                Console.WriteLine("INGRESE PRECIO:");
                                PRECIO[x, y] = Console.ReadLine();
                            }
                        }
                    }
                }
                if (X == 4)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE NOMBRE DEL PRODUCTO: ");
                    BUSCAR = Console.ReadLine();
                    for (x = 0; x < DATOS; x++)
                    {
                        for (y = 0; y < PRODUCTO; y++)
                        {
                            if (BUSCAR == NOMBRE[x, y])
                            {
                                NOMBRE[x, y] = "";

                                CANTIDAD[x, y] = "";

                                PRECIO[x, y] = "";

                            }
                        }
                    }
                }
                if (X == 5)
                {
                    Console.Clear();
                    Console.WriteLine("DESEA HACER OTRA TRANSACCIÓN? [S/N]");
                    OP = char.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("DESEA IR AL INICIO? \n 1. SI \n 2. NO");
                    Z = int.Parse(Console.ReadLine());
                    if (Z == 1)
                    {
                        USER.USE();
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
        public void INT()
        {
            Console.WriteLine("INVENTARIO TRABAJADORES");
            char OP = 'S';

            while (OP != 'N')
            {
                Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. AGREGAR PRODUCTO \n 2. BUSCAR PRODUCTO \n 3. SALIR");

                X = int.Parse(Console.ReadLine());

                if (X == 1)
                {
                    for (x = 0; x < DATOS; x++)
                    {
                        for (y = 0; y < PRODUCTO; y++)
                        {
                            Console.Clear();
                            Console.WriteLine("INGRESE NOMBRE:");
                            NOMBRE[x, y] = Console.ReadLine();

                            Console.WriteLine("INGRESE CANTIDAD:");
                            CANTIDAD[x, y] = Console.ReadLine();

                            Console.WriteLine("INGRESE PRECIO:");
                            PRECIO[x, y] = Console.ReadLine();
                        }
                    }
                }
                if (X == 2)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE NOMBRE DEL PRODUCTO: ");
                    BUSCAR = Console.ReadLine();

                    for (x = 0; x < DATOS; x++)
                    {
                        for (y = 0; y < PRODUCTO; y++)
                        {
                            if (BUSCAR == NOMBRE[x, y])
                            {
                                Console.Clear();
                                Console.WriteLine("NOMBRE: " + NOMBRE[x, y]);

                                Console.WriteLine("UNIDADES: " + CANTIDAD[x, y]);

                                Console.WriteLine("PRECIO: " + PRECIO[x, y]);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("PRODUCTO NO REGISTRADO");
                            }
                        }
                    }
                }
                if (X == 3)
                {
                    Console.Clear();
                    Console.WriteLine("DESEA HACER OTRA TRANSACCIÓN? [S/N]");
                    OP = char.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("DESEA IR AL INICIO? \n 1. SI \n 2. NO");
                    Z = int.Parse(Console.ReadLine());
                    if (Z == 1)
                    {
                        USER.USE();
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}