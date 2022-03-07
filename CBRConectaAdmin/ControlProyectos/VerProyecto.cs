using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CBRConectaAdmin.Clases;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CBRConectaAdmin.ControlProyectos
{
    public partial class VerProyecto : Form
    {
        private dynamic jsonGot, jsonGotDocuments;
        private int stateLocal, proyectoSelected = 0;
        private Requests req = new Requests();
        public VerProyecto(int state, dynamic json)
        {
            InitializeComponent();
            //Obtiene el json como texto plano 
            dynamic jsonBody = json;
            //Almacena el tipo de obras que debe cargar 1=activa, 2=finalizada
            stateLocal = state;
            //Decifica el json
            jsonGot = JValue.Parse(jsonBody);
            //Carga los proyectos al MaterialListView
            _ = cargarProyectosAsync();
        }

        private async Task cargarProyectosAsync()
        {
            gridView.Rows.Clear();
            string palabraClave = (stateLocal == 1) ? "Activa" : "Finalizada";
            foreach (var obra in jsonGot)
            {
                if (obra.estatus == palabraClave)
                {
                    string aname = "Sin asignar";
                    try
                    {
                        dynamic asignado = JValue.Parse(await req.userInObra(obra.id));
                        int i = 0;
                        foreach (var empleado in asignado)
                        {
                            aname = (i < 1) ? empleado.nombre + " " + empleado.apellido : aname + ", " + empleado.nombre + " " + empleado.apellido;
                            i++;
                        }
                    }
                    catch (Exception) { }
                    string[] datos = { obra.id, obra.nombre, aname, obra.fechaInicio };
                    gridView.Rows.Add(datos);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            _ = buscarAsync();
        }

        private async Task buscarAsync()
        {
            ObrasModel mod = new ObrasModel();
            if (txtBuscar.Text != "")
            {
                gridView.Rows.Clear();
                string palabraClave = (stateLocal == 1) ? "Activa" : "Finalizada";
                foreach (var obra in jsonGot)
                {
                    mod.nombre = obra.nombre;
                    mod.destajo = obra.destajo;
                    mod.fechaInicio = obra.fechaInicio;
                    if (obra.estatus == palabraClave &&(mod.nombre.Contains(txtBuscar.Text)
                            || mod.destajo.Contains(txtBuscar.Text) || mod.fechaInicio.Contains(txtBuscar.Text)))
                    {
                        string aname = "Sin asignar";
                        try
                        {
                            dynamic asignado = JValue.Parse(await req.userInObra(obra.id));//Optimizar esta linea de código
                            int i = 0;
                            foreach (var empleado in asignado)
                            {
                                aname = (i < 1) ? empleado.nombre + " " + empleado.apellido : aname + "," + empleado.nombre + " " + empleado.apellido;
                                i++;
                            }
                        }
                        catch (Exception) { }
                        string[] datos = { obra.id, obra.nombre, aname, obra.fechaInicio };
                        gridView.Rows.Add(datos);
                    }
                }
            }
            else
            {
                cargarProyectosAsync();
            }
        }

        private async Task filesPerProjectAsync(int idSelected)
        {
            cmbDocumento.Items.Clear();
            jsonGotDocuments = JValue.Parse(await req.obtenerDocsPerObra(idSelected));
            JToken jTokenjgd = jsonGotDocuments;
            if (jTokenjgd.Count() > 0)
            {
                cmbDocumento.Items.Clear();
                cmbDocumento.Hint = "Seleccione un documento";
                foreach (var documento in jsonGotDocuments)
                {
                    cmbDocumento.Items.Add(documento.id + "| " + documento.nombre);
                }
                cmbDocumento.Enabled = true;
            }
            else
            {
                cmbDocumento.Hint = "Sin archivos disponibles para este proyecto";
                cmbDocumento.Enabled = false;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (var obra in ((IEnumerable<dynamic>)jsonGot).Where(obra => obra.id == proyectoSelected))
            {
                if (MessageBox.Show("Se marcará como 'Finalizada' la obra: '" + obra.nombre + "'. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("En proceso de finalización");
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            _ = asignarEmpleado();
        }

        private async Task cargarCMBTrabajadorAsync()
        {
            Requests req = new Requests();
            dynamic data = await req.obtenerEmpleados();
            dynamic jsonGot = JValue.Parse(data);
            cmbEmpleado.Items.Clear();
            foreach (var user in jsonGot)
            {
                cmbEmpleado.Items.Add(user.id + "| " + user.nombre);
            }
        }

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = obtenerArchivo();
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelected = int.Parse(gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString());
            cmbDocumento.Enabled = true;
            proyectoSelected = idSelected;
            axAcroPDF1.Visible = false;
            if (stateLocal == 1)
            {
                btnFinalizar.Enabled = true;
                btnFinalizar.Visible = true;
                btnFinalizar.DrawShadows = true;
                _ = cargarCMBTrabajadorAsync();
                cmbEmpleado.Visible = true;
                btnAsignar.Visible = true;
                btnAsignar.DrawShadows = true;
                btnFinalizar.Visible = true;
                btnFinalizar.DrawShadows = true;
                btnLiberarColado.Visible = true;
                btnLiberarColado.DrawShadows = true;
            }
            _ = filesPerProjectAsync(idSelected);
        }

        private async Task obtenerArchivo()
        {
            Requests req = new Requests();
            string cadena = cmbDocumento.SelectedItem.ToString();
            string[] parts = cadena.Split('|');
            int idObra = int.Parse(parts[0]);
            byte[] pdf = await req.obtenerPDFPerObra(idObra);
            if (pdf != null)
            {
                string filename = Application.StartupPath + @"\temp\" + Guid.NewGuid().ToString().Substring(0, 10);
                System.IO.File.WriteAllBytes(filename, pdf);
                axAcroPDF1.src = filename;
                axAcroPDF1.Visible = true;
            }
            else
            {
                axAcroPDF1.Visible = false;
            }
            Console.WriteLine("\u002C");
        }

        private async Task asignarEmpleado()
        {
            Requests req = new Requests();
            string cadena = cmbEmpleado.SelectedItem.ToString();
            string[] parts = cadena.Split('|');
            int idUsr = int.Parse(parts[0]);
            string result = await req.asignarTrabajador(idUsr.ToString(), proyectoSelected.ToString());
            Console.WriteLine(result);
            if (result == "1")
            {
                MessageBox.Show("Empleado agregado con éxito", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProyectosAsync();
            }
            else
            {
                MessageBox.Show("El emlpeado seleccionado ya está asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
