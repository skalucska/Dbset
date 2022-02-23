using GestionEmploye.DataAccess;
using GestionEmploye.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.WinForms
{
    public partial class MainForm : Form
    {
        private MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new EmployeDataProvider());
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_estPiloteDeLigne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            var emCourant = bs_employes.Current as EmployeViewModel;
            emCourant.Sauvegarder();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Charger();

            tb_prenom.DataBindings.Add("Text", bs_employes, "Prenom", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_nom.DataBindings.Add("Text", bs_employes, "Nom", false, DataSourceUpdateMode.OnPropertyChanged);
            dtp_dateEmbauche.DataBindings.Add("Value", bs_employes, "DateEmbaucheWpf");

            cb_role.DataSource = _viewModel.Roles;
            cb_role.DisplayMember = "Nom";
            cb_role.ValueMember = "IdRole";
            cb_role.DataBindings.Add("SelectedValue", bs_employes, "RoleId");
            check_estPiloteDeLigne.DataBindings.Add("Checked", bs_employes, "EstPiloteDeLigne");
        }

        private void button_refresh_clik(object sender, EventArgs e)
        {
            Charger();
            bs_employes.ResetBindings(false);
        }

        private void Charger()
        {
            _viewModel.Charger();
            bs_employes.DataSource = _viewModel.Employes;
            listBox_employes.DataSource = bs_employes;
            listBox_employes.DisplayMember = "Nom";
        }
    }
}
