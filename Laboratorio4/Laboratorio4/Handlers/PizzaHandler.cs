using Laboratorio4.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Laboratorio4.Handlers
{
    public class PizzaHandler
    {
        private SqlConnection conexion;
        private string rutaConexion;
        public PizzaHandler()
        {
            rutaConexion =
           ConfigurationManager.ConnectionStrings["PizzaConnection"].ToString();
            conexion = new SqlConnection(rutaConexion);
        }
        private DataTable crearTablaConsulta(string consulta)
        {
            SqlCommand comandoParaConsulta = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptadorParaTabla = new
           SqlDataAdapter(comandoParaConsulta);
            DataTable consultaFormatoTabla = new DataTable();
            conexion.Open();
            adaptadorParaTabla.Fill(consultaFormatoTabla);
            conexion.Close();
            return consultaFormatoTabla;
        }
        public List<PizzaModel> obtenerTodoslasPizzas()
        {
            List<PizzaModel> pizza = new List<PizzaModel>();
            string consulta = "SELECT * FROM Pizza ";
            DataTable tablaResultado = crearTablaConsulta(consulta);
            foreach (DataRow columna in tablaResultado.Rows)
            {
                pizza.Add(
                new PizzaModel
                {
                    queso = Convert.ToString(columna["queso"]),
                    tipoPizza = Convert.ToString(columna["tipoPizza"]),
                    id = Convert.ToInt32(columna["pizzaId"]),
                    tamano = Convert.ToString(columna["tamano"]),
                    carne = Convert.ToInt32(columna["carne"]),
                    chile = Convert.ToInt32(columna["chile"]),
                    otros = Convert.ToInt32(columna["otros"]),
                    hongos = Convert.ToInt32(columna["hongos"]),
                    pollo = Convert.ToInt32(columna["pollo"]),
                });
            }
            return pizza;
        }

        public bool crearPizza(PizzaModel pizza)
        {
            string consulta = "INSERT INTO Pizza (tipoPizza, tamano, queso, carne, pollo, hongos, chile, otros) " +
            "VALUES (@tipoPizza,@tamano,@queso,@carne,@pollo,@hongos,@chile,@otros) ";
            SqlCommand comandoParaConsulta = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptadorParaTabla = new SqlDataAdapter(comandoParaConsulta);
            comandoParaConsulta.Parameters.AddWithValue("@tipoPizza", pizza.tipoPizza);
            comandoParaConsulta.Parameters.AddWithValue("@tamano", pizza.tamano);
            comandoParaConsulta.Parameters.AddWithValue("@queso", pizza.queso);
            comandoParaConsulta.Parameters.AddWithValue("@carne", pizza.carne);
            comandoParaConsulta.Parameters.AddWithValue("@pollo", pizza.pollo);
            comandoParaConsulta.Parameters.AddWithValue("@hongos", pizza.hongos);
            comandoParaConsulta.Parameters.AddWithValue("@chile", pizza.chile);
            comandoParaConsulta.Parameters.AddWithValue("@otros", pizza.otros);
            conexion.Open();
            bool exito = comandoParaConsulta.ExecuteNonQuery() >= 1; // indica que se agregO una tupla (cuando es mayor o igual que 1)
            conexion.Close();
            return exito;
        }
    }
}