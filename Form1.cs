using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_AD_Week_14
{
    public partial class PraktikumADWeek13 : Form
    {
        public PraktikumADWeek13()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL
        public int counter2 = 0;
        
        DataTable team = new DataTable();
        DataTable topScorer = new DataTable();
        DataTable worstDiscipline = new DataTable();
        DataTable lastMatch = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name as `Team Name`, concat(m.manager_name, ', ', n.nation) as `Manager Name`, concat(t.home_stadium,', ', t.city, ' (', t.capacity, ')') as `Stadium`, t.team_id from team t, manager m, dmatch dm, nationality n where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(team);

            sqlQuery = "select p.player_name as Player, goal.Goal + penalty.Penalty as Goal, penalty.Penalty as Penalty from player p, (select d.player_id as id, sum(if(d.type = 'GO', 1, 0)) as Goal from dmatch d group by 1) goal, (select d.player_id as id, sum(if(d.type = 'GP', 1, 0)) as Penalty from dmatch d group by 1) penalty where p.player_id = goal.id and goal.id = penalty.id and p.team_id = 'A001' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(topScorer);

            sqlQuery = "select p.player_name as `Player`, Kuning.poin + Merah.poin as `Point`, Kuning.Yellow as `Yellow Card`, Merah.Red as `Red Card` from player p, (select dm.player_id as `ID`, sum(if(dm.type = 'CY', 1, 0)) as Yellow, sum(if(dm.type='CY', 1, 0)) as poin from dmatch dm group by 1) `Kuning`, (select dm.player_id as `ID`, sum(if(dm.type = 'CR', 1, 0)) as Red, sum(if(dm.type = 'CR', 3, 0)) as poin from dmatch dm group by 1) `Merah` where p.player_id = Kuning.ID and Kuning.ID = Merah.ID and p.team_id = 'A001' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(worstDiscipline);

            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = 'A001' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = 'A001' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(lastMatch);
            dgvDetail.DataSource = lastMatch;
            dgvDetail.Columns.RemoveAt(0);
            Data(counter2);
        }

        private void Data(int counter1)
        {
            lblNamaTeam.Text = team.Rows[counter1][0].ToString();
            lblNamaManager.Text = team.Rows[counter1][1].ToString();
            lblNamaStadium.Text = team.Rows[counter1][2].ToString();
            topScorer = new DataTable();
            sqlQuery = "select p.player_name as Player, goal.Goal + penalty.Penalty as Goal, penalty.Penalty as Penalty from player p, (select d.player_id as id, sum(if(d.type = 'GO', 1, 0)) as Goal from dmatch d group by 1) goal, (select d.player_id as id, sum(if(d.type = 'GP', 1, 0)) as Penalty from dmatch d group by 1) penalty where p.player_id = goal.id and goal.id = penalty.id and p.team_id = '"+ team.Rows[counter1][3].ToString() +"' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(topScorer);
            lblTopScorer.Text = topScorer.Rows[0][0].ToString() + " " + topScorer.Rows[0][1].ToString() + " (" + topScorer.Rows[0][2].ToString() + ")";
            worstDiscipline = new DataTable();
            sqlQuery = "select p.player_name as `Player`, Kuning.poin + Merah.poin as `Point`, Kuning.Yellow as `Yellow Card`, Merah.Red as `Red Card` from player p, (select dm.player_id as `ID`, sum(if(dm.type = 'CY', 1, 0)) as Yellow, sum(if(dm.type='CY', 1, 0)) as poin from dmatch dm group by 1) `Kuning`, (select dm.player_id as `ID`, sum(if(dm.type = 'CR', 1, 0)) as Red, sum(if(dm.type = 'CR', 3, 0)) as poin from dmatch dm group by 1) `Merah` where p.player_id = Kuning.ID and Kuning.ID = Merah.ID and p.team_id = '"+ team.Rows[counter1][3].ToString() +"' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(worstDiscipline);
            lblWorstDiscipline.Text = worstDiscipline.Rows[0][0] + ", " + worstDiscipline.Rows[0][2] + " Yellow Card and " + worstDiscipline.Rows[0][3] + " Red Card";
            lastMatch = new DataTable();
            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = '" + team.Rows[counter1][3].ToString() + "' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = '" + team.Rows[counter1][3].ToString() + "' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(lastMatch);
            dgvDetail.DataSource = lastMatch;
            dgvDetail.Columns.RemoveAt(0);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            counter2 = 0;
            Data(counter2);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            counter2--;
            Data(counter2);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            counter2++;
            Data(counter2);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            counter2 = team.Rows.Count - 1;
            Data(counter2);
        }
    }
}
