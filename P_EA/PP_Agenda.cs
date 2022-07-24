using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_EA;
using N_EA;

namespace P_EA
{
    public partial class DiaryA : Form
    {
        private string IDPeople;
        private bool Edit = false;

        E_Agenda objEntindad =  new E_Agenda();
        N_Agenda objNeg = new N_Agenda();

        public DiaryA()
        {
            InitializeComponent();
        }


    

        ////////////////////////////////////////////////////////Save/////////////////////////////////////////////////////////////////////////////////

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
                if (Edit == false)
                {
                    try
                    {
                        
                        objEntindad.Nombre = NameBox.Text.ToUpper();
                        objEntindad.Apellido = LNamebox.Text.ToUpper();
                        objEntindad.Genero = Genderbox.Text.ToUpper();
                        objEntindad.Correo = MailBox.Text.ToUpper();

                        objNeg.InsertAppl(objEntindad);

                        MessageBox.Show("Registro guardado.");
                        limpiar();
                        Buscar("");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar el registro." + ex);
                        limpiar();
                        Buscar("");

                }
            }
                if (Edit == true)
                {
                try
                {
                    objEntindad.ID = (int)DataGrid1.CurrentRow.Cells[0].Value;
                    objEntindad.Nombre = NameBox.Text.ToUpper();
                    objEntindad.Apellido = LNamebox.Text.ToUpper();
                    objEntindad.Genero = Genderbox.Text.ToUpper();
                    objEntindad.Correo = MailBox.Text.ToUpper();

                    objNeg.UpdateAppl(objEntindad);

                    MessageBox.Show("Registro editado exitosamente.");
                    objNeg.Showlist();
                        limpiar();
                        Edit = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro." + ex);
                    }
                }

            
        }

        public void limpiar()
        {
            NameBox.Text = "";
            LNamebox.Text = "";
            MailBox.Text = "";
            Genderbox.SelectedIndex = 0;

        }

        ////////////////////////////////////////////////////////Read/////////////////////////////////////////////////////////////////////////////////

        public void Buscar(string buscar)
        {
            N_Agenda objNegocio = new N_Agenda();
            DataGrid1.DataSource = objNegocio.ListarAgenda(buscar);
        }

        ////////////////////////////////////////////////////////Delete/////////////////////////////////////////////////////////////////////////////////


        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (DataGrid1.SelectedRows.Count > 0) 
            { 
                objEntindad.ID = Convert.ToInt32(DataGrid1.CurrentRow.Cells[0].Value.ToString());
                objNeg.DeleteAppl(objEntindad);
                MessageBox.Show("Registro eliminado");
                objNeg.Showlist();
            } }


        ////////////////////////////////////////////////////////Editar/////////////////////////////////////////////////////////////////////////////////


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DataGrid1.SelectedRows.Count > 0)
            {

                Edit = true;
                 
                NameBox.Text = DataGrid1.CurrentRow.Cells[1].Value.ToString();
                LNamebox.Text = DataGrid1.CurrentRow.Cells[2].Value.ToString();
                Genderbox.Text = DataGrid1.CurrentRow.Cells[3].Value.ToString();
                MailBox.Text = DataGrid1.CurrentRow.Cells[4].Value.ToString();

            }
            else
            {

                MessageBox.Show("Selecciona una fila");
            }
        }

        ////////////////////////////////////////////////////////Components/////////////////////////////////////////////////////////////////////////////////


        private void Createbtn_Click(object sender, EventArgs e)
        {
            NameBox.Select();
        }

        //private void IdBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Buscar(guna2TextBox1.Text);

        }

        private void DiaryA_Load(object sender, EventArgs e)
        {

            objNeg.Showlist();
        }


        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
        }



        private void DataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
