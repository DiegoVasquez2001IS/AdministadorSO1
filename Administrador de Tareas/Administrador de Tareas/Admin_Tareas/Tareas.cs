using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void BtnDetener_Click(object sender, EventArgs e)
        {

        }

        int index_proceso = 0;
        private void BtnNuevoProceso_Click(object sender, EventArgs e)
        {
            MessageBox.Show(index_proceso.ToString());
        }

        //OBTENEMOS LOS PROCESOS [DIEGO]
        private void Listar_Procesos()
        {
            if (Lista_Procesos.Rows.Count >= 0)
            {
                Process[] lista_Procesos = Process.GetProcesses();

                foreach (Process proceso in lista_Procesos)
                {
                    Lista_Procesos.Rows.Add(proceso.Id, proceso.ProcessName, darFormato((proceso.PrivateMemorySize64 / 1024).ToString()));
                }
            }
            else
            {
                Lista_Procesos.Rows.Clear();

                Process[] lista_Procesos = Process.GetProcesses();

                foreach (Process proceso in lista_Procesos)
                {
                    Lista_Procesos.Rows.Add(proceso.Id, proceso.ProcessName, darFormato     ((proceso.PrivateMemorySize64 / 1024).ToString()));
                }
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

        /*FILTRO DE PROCESOS, VÍDEO DE AYUDA:https://www.youtube.com/watch?v=XjNldd9ta90&ab_channel=Tasar%C4%B1mKodlama [SANTIAGO, NAYRE]*/

        DataTable tabla_procesos;

        private void llenado_tabla()
        {
            tabla_procesos = new DataTable();

            tabla_procesos.Columns.Add("id", typeof(int));
            tabla_procesos.Columns.Add("nombre", typeof(string));
            tabla_procesos.Columns.Add("memoria", typeof(double));

            foreach (DataGridViewRow row_data in Lista_Procesos.Rows)
            {
                DataRow dr = tabla_procesos.NewRow();
                dr["id"] = row_data.Cells[0].Value;
                dr["nombre"] = row_data.Cells[1].Value;
                dr["memoria"] = row_data.Cells[2].Value;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenado_tabla();

            DataView dtv = tabla_procesos.DefaultView;
            dtv.RowFilter = "nombre LIKE '%" + TxtBuscar.Text + "%'";
            Lista_Procesos.DataSource = dtv;
        }

        private void Tareas_Load(object sender, EventArgs e)
        {

        }

        
    }
}
