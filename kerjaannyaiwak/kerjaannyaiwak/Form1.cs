using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kerjaannyaiwak
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost; uid=root; pwd=; database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlquery;

        DataTable dtnat = new DataTable();
        DataTable dtteam = new DataTable();
        DataTable dt1 = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlquery = "SELECT n.`nation`, n.`nationality_id` FROM premier_league.nationality n;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtnat);
            cmb_nat.DataSource = dtnat;
            cmb_nat.DisplayMember = "nation";
            cmb_nat.ValueMember = "nationality_id";

            sqlquery = "SELECT t.`team_name`, t.`team_id` FROM premier_league.team t;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            cmb_tea.DataSource = dtteam;
            cmb_tea.DisplayMember = "team_name";
            cmb_tea.ValueMember = "team_id";





        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            sqlConnect.Open();
            sqlquery = $"select concat('A', lpad((count(player_id) + 1), 3, 0)) from player where player_name like '{txt_name.Text.ToUpper()[0]}%';";
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            string newid = sqlCommand.ExecuteScalar().ToString();
            MessageBox.Show(newid);

            // Insert ke database
            sqlquery = $"insert into player values('{newid}', {txt_team.Text}, '{txt_name.Text}', '{cmb_nat.SelectedValue}', '{txt_position.Text}', {txt_height.Text} ,{txt_weight.Text} ,'{dateTimePicker1.Text}','{cmb_tea.SelectedValue}', {1}, {0})";
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            dt1.Rows.Add(sqlquery);



            // Update datatable

        }

        private void cmb_tea_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt1.Clear();
            sqlquery = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name from player p, nationality n, team t where p.nationality_id = n.nationality_id and p.team_id = t.team_id and t.team_name = '" + cmb_tea.Text + "';";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
    }
}
