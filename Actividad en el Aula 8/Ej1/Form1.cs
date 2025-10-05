using Ej1.Models;

namespace Ej1
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();

        }
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        OpenFileDialog ofd = new OpenFileDialog();
        string archivoActual = ""; // Ruta del archivo actualmente abierto

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnExportar_Click(object sender, EventArgs e)
        {
            lbxVeh.Items.Clear();
            SaveFileDialog sfv = new SaveFileDialog();
            sfv.Filter = "Archivos Txt |*.txt|Todos los archivos|*.*";
            if (sfv.ShowDialog() == DialogResult.OK)
            {
                string name = sfv.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("patente;importe");
                    foreach (Vehiculo v in vehiculos)
                    {
                        string cadena = v.Exportar();
                        sw.WriteLine(cadena);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //if (fs != null) { fs.Close(); }
                    if (sw != null) { sw.Close(); }
                }
            }
        }

        private void Listar_Click_1(object sender, EventArgs e)
        {
            lbxVeh.Items.Clear();
            vehiculos.Clear();
            ofd.Filter = "Archivos Txt|*.txt|Todos los archivos|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string name = ofd.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string cabecera = sr.ReadLine();
                    while (sr.EndOfStream == false)
                    {
                        string cadena = sr.ReadLine();
                        Vehiculo vehiculo = new Vehiculo();
                        vehiculo.Importar(cadena);
                        vehiculos.Add(vehiculo);
                    }
                }
                catch (PatenteNoValidaException pexc)
                {
                    MessageBox.Show(pexc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fs != null) { fs.Close(); }
                    if (sr != null) { sr.Close(); }
                }
                if (vehiculos.Count != 0)
                {
                    foreach (Vehiculo v in vehiculos)
                    {
                        lbxVeh.Items.Add(v);
                    }
                }
                archivoActual = name;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = lbxVeh.SelectedItem as Vehiculo;
            if (vehiculo != null)
            {
                Form2 form2 = new Form2(vehiculo.Patente, vehiculo.Importe);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    vehiculo.Patente = form2.tbPatente.Text;
                    vehiculo.Importe = Convert.ToDouble(form2.tbImporte.Text);

                    int index = lbxVeh.SelectedIndex;
                    lbxVeh.Items[index] = vehiculo;
                    FileStream fs = new FileStream(archivoActual, FileMode.Open, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("patente;importe");
                    foreach(Vehiculo v in vehiculos)
                    {
                        sw.WriteLine(v.Exportar());
                    }
                    sw.Close();
                    fs.Close();
                }
                }
                else { MessageBox.Show("Error debe seleccionar un vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }

    


        