using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Admin_Tareas
{

    /*ADMINISTRADOR DE TAREAS EN C#, DESARROLLADOR: GRUPO 3 SO1 [Diego, Nayre, Santiago, Carlos Castillo], FUE POSIBLE GRACIAS A LA LIBRERÍA System.Diagnostics y la clase Process, link de consulta: https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process?view=net-5.0, SOFTWARE TOTALMENTE NUESTRO CON AYUDA DE OTROS SOFTWARES EN CUANTO A FUNCIONES*/

    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
            Listar_Procesos();
            double suma_ram = 0;

            for (int i = 0; i < Lista_Procesos.Rows.Count; i++)
            {
                suma_ram += Convert.ToDouble(Lista_Procesos[2, i].Value);
            }

            lblRAM.Text = suma_ram.ToString() + " MB";
        }

        //NAYRE, SANTIAGO

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            Process proceso = Process.GetProcessById(index_proceso);

            try
            {
                proceso.Kill();
                Listar_Procesos();
            }
            catch (Exception ex)
            {
                Listar_Procesos();
            }

        }

        int index_proceso = 0;
        private void BtnNuevoProceso_Click(object sender, EventArgs e)
        {
            String proceso_ejecutar = Microsoft.VisualBasic.Interaction.InputBox("Proceso a ejecutar", "WIN+R");

            try
            {
                Process.Start(proceso_ejecutar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //OBTENEMOS LOS PROCESOS [DIEGO]
        private void Listar_Procesos()
        {
            
             Lista_Procesos.Rows.Clear();

             Process[] lista_Procesos = Process.GetProcesses();

             foreach (Process proceso in lista_Procesos)
             {
                 Lista_Procesos.Rows.Add(proceso.Id, proceso.ProcessName, darFormato     ((proceso.PrivateMemorySize64 / 1024).ToString()));
              }
  
        }

        private void Lista_Procesos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //index_proceso = Convert.ToInt16(Lista_Procesos[e.ColumnIndex, e.RowIndex].Value);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Listar_Procesos();

            double suma_ram = 0;

            for (int i = 0; i < Lista_Procesos.Rows.Count; i++)
            {
                suma_ram += Convert.ToDouble(Lista_Procesos[2, i].Value);
            }

            lblRAM.Text = suma_ram.ToString() + " MB";
        }

        /*FUNCIÓN QUE FUE EXTRAÍDA DE UN PROGRAMA EXTERNO EN GITHUB, ENLACE PARA CONSULTA:      https://github.com/19AlexOrtegaRosas97/Administrador-de-tareas [CARLOS CASTILLO]*/

        private string darFormato(string mb)
        {
            string mbFinal = "";
            if (mb.Length <= 4)
            {
                int x = 0;
                foreach (char a in mb)
                {
                    if (x == 1)
                    {
                        mbFinal = mbFinal + "." + a;
                    }
                    else
                    {
                        if (x == (mb.Length - 1))
                        {
                            mbFinal = mbFinal + a;
                            Console.WriteLine(mbFinal);
                            return mbFinal;
                        }
                        else
                        {
                            mbFinal = mbFinal + a;
                        }

                    }
                    x++;
                }
            }

            if (mb.Length > 4)
            {
                int x = 0;
                foreach (char a in mb)
                {
                    if (x == 2)
                    {
                        mbFinal = mbFinal + "." + a;
                    }
                    else
                    {
                        if (x == (mb.Length - 1))
                        {
                            mbFinal = mbFinal + a;
                            Console.WriteLine(mbFinal);
                            return mbFinal;
                        }
                        else
                        {
                            mbFinal = mbFinal + a;
                        }
                    }
                    x++;
                }
            }
            return "00.00";
        }

        /*FILTRO DE PROCESOS, Encargado: [Diego]*/

     

        /*private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Lista_Procesos.DataSource;

            bs.Filter = "nombreProceso like '%" + TxtBuscar.Text + "%'";
            Lista_Procesos.DataSource = bs;

            if (TxtBuscar.Text == "")
            {

                DataTable tabla_relleno = new DataTable();
                tabla_relleno.Columns.Add("idProceso");
                tabla_relleno.Columns.Add("nombreProceso");
                tabla_relleno.Columns.Add("MemoriaRAM");

                Process[] lista_Procesos = Process.GetProcesses();

                foreach (Process proceso in lista_Procesos)
                {
                    tabla_relleno.Rows.Add(proceso.Id, proceso.ProcessName, darFormato((proceso.PrivateMemorySize64 / 1024).ToString()));
                }
                Lista_Procesos.DataSource = tabla_relleno;
            }

        }*/


        private void Lista_Procesos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index_proceso = Convert.ToInt16(Lista_Procesos[0, e.RowIndex].Value);
            }
        }
    }
}
