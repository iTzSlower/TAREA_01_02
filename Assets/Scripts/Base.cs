using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    //ESTO ES SOLO UNA PRUEBA
    public List<string> NombreDelProducto = new List<string>();
    public List<int> CantidadDelProducto = new List<int>();

    void Start()
    {
        Debug.Log("Lista de Productos");
        for (int i = 0; i < NombreDelProducto.Count; i++)
        {
            Debug.Log("Producto N°" + i + ": " + NombreDelProducto[i] + " || cantidad :" + CantidadDelProducto[i]);
        }
    }

}
