using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_I
{
    class CREACION
    {
        static USUARIOS USER = new USUARIOS();

        public string BUSCAR;
        public int X, USUARIO = 1, DATOS = 1, Z, x, y, C;

        public int[,] INGRESAR;
        public string[,] NOMBRE, CONTRASEÑA;

        public void CREAR()
        {
            char OP = 'S';
            while (OP != 'N')
            {
                Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. CREAR USUARIO \n 2. BUSCAR USUARIO \n 3. MODIFICAR USUARIO \n 4.ELIMINAR USUARIO \n 5.SALIR");
                X = int.Parse(Console.ReadLine());

                if (X == 1)
                {
                    Console.Clear();
                    Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. ADMINISTRADOR \n 2. TRABAJADOR");
                    C = int.Parse(Console.ReadLine());
                    if (C == 1)
                    {
                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                Console.Clear();
                                Console.WriteLine("INGRESE NOMBRE: ");
                                USER.USER = Console.ReadLine();

                                Console.WriteLine("INGRESE CONTRASEÑA: ");
                                USER.PASS = Console.ReadLine();
                            }
                        }
                    }
                    if (C == 2)
                    {
                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                Console.Clear();
                                Console.WriteLine("INGRESE NOMBRE: ");
                                USER.US = Console.ReadLine();

                                Console.WriteLine("INGRESE CONTRASEÑA: ");
                                USER.CON = Console.ReadLine();

                            }
                        }
                    }
                }
                if (X == 2)
                {
                    Console.Clear();
                    Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. ADMINISTRADOR \n 2. TRABAJADOR");
                    C = int.Parse(Console.ReadLine());
                    if (C == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("INGRESE NOMBRE DEL USUARIO: ");
                        BUSCAR = Console.ReadLine();

                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                if (BUSCAR == USER.USER)
                                {
                                    Console.Clear();
                                    Console.WriteLine("NOMBRE: " + USER.USER);

                                    Console.WriteLine("CONTRASEÑA: " + USER.PASS);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("USUARIO NO REGISTRADO");
                                }
                            }
                        }
                    }
                    if (C == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("INGRESE NOMBRE DEL USUARIO: ");
                        BUSCAR = Console.ReadLine();

                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                if (BUSCAR == USER.US)
                                {
                                    Console.Clear();
                                    Console.WriteLine("NOMBRE: " + USER.US);

                                    Console.WriteLine("CONTRASEÑA: " + USER.CON);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("USUARIO NO REGISTRADO");
                                }
                            }
                        }
                    }
                }
                if (X == 3)
                {
                    Console.Clear();
                    Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. ADMINISTRADOR \n 2. TRABAJADOR");
                    C = int.Parse(Console.ReadLine());
                    if (C == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("INGRESE NOMBRE DEL USUARIO: ");
                        BUSCAR = Console.ReadLine();
                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                if (BUSCAR == USER.USER)
                                {
                                    Console.Clear();
                                    USER.USER = "";

                                    USER.PASS = "";


                                    Console.WriteLine("INGRESE NOMBRE:");
                                    USER.USER = Console.ReadLine();

                                    Console.WriteLine("INGRESE CONTRASEÑA:");
                                    USER.PASS = Console.ReadLine();
                                }
                            }
                        }
                    }
                    if (C == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("INGRESE NOMBRE DEL USUARIO: ");
                        BUSCAR = Console.ReadLine();
                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                if (BUSCAR == USER.US)
                                {
                                    Console.Clear();
                                    USER.US = "";

                                    USER.CON = "";


                                    Console.WriteLine("INGRESE NOMBRE:");
                                    USER.US = Console.ReadLine();

                                    Console.WriteLine("INGRESE CONTRASEÑA:");
                                    USER.CON = Console.ReadLine();
                                }
                            }
                        }
                    }

                }
                if (X == 4)
                {
                    Console.Clear();
                    Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. ADMINISTRADOR \n 2. TRABAJADOR");
                    C = int.Parse(Console.ReadLine());
                    if (C == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("INGRESE NOMBRE DEL USUARIO: ");
                        BUSCAR = Console.ReadLine();
                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                if (BUSCAR == USER.USER)
                                {
                                    USER.USER = "";

                                    USER.PASS = "";

                                }
                            }
                        }
                    }
                    if (C == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("INGRESE NOMBRE DEL USUARIO: ");
                        BUSCAR = Console.ReadLine();
                        for (x = 0; x < DATOS; x++)
                        {
                            for (y = 0; y < USUARIO; y++)
                            {
                                if (BUSCAR == USER.US)
                                {
                                    USER.US = "";

                                    USER.CON
                                        = "";

                                }
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
                        Console.Clear();
                        Console.WriteLine("TENGA UN BUEN DIA");
                        Console.ReadKey();
                    }
                }

            }
            Console.ReadKey();
        }
    }
}