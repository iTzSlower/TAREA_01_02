using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class Program : MonoBehaviour
{
    

    private void Start()
    {
        Objects Objeto01 = new Objects();
        Objeto01.name = "Manzana";
        Objeto01.cantidad = 2;

        Objects Objeto02 = new Objects();
        Objeto02.name = "Carne";
        Objeto02.cantidad = 5;

        Objects Objeto03 = new Objects();
        Objeto03.name = "Pera";
        Objeto03.cantidad = 1;

        Objects[] lista = new Objects[3];
        lista[0] = Objeto01;
        lista[1] = Objeto02;
        lista[2] = Objeto03;

        Debug.Log("==Lista de objetos==");

        RESET();

        void RESET()
        {
            foreach (Objects ob in lista)
            {
                Debug.Log(" nombre: " + ob.name + " || cantidad: " + ob.cantidad);
            }
        }


        Debug.Log("nombre del objeto que quieras cambiar su cantidad: ");

        while (true)
        {
            string str = Console.ReadLine();
            string[] cmd = str.Split(' ');

            switch (cmd[0])
            {
                case "Manzana":
                    Console.Clear();
                    Debug.Log("ingrese nueva cantidad");
                    string respuesta01 = Console.ReadLine();
                    int valor01 = int.Parse(respuesta01);
                    Objeto01.cantidad = valor01;
                    Console.Clear();
                    RESET();
                    break;


                case "Carne":
                    Console.Clear();
                    Debug.Log("ingrese nueva cantidad");
                    string respuesta02 = Console.ReadLine();
                    int valor02 = int.Parse(respuesta02);
                    Objeto01.cantidad = valor02;
                    Console.Clear();
                    RESET();
                    break;

                case "Pera":
                    Console.Clear();
                    Debug.Log("ingrese nueva cantidad");
                    string respuesta03 = Console.ReadLine();
                    int valor03 = int.Parse(respuesta03);
                    Objeto01.cantidad = valor03;
                    Console.Clear();
                    RESET();
                    break;

                default:
                    Debug.Log("invalid command");
                    break;
            }
        }
    }
}
