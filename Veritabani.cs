
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace YollukProgrami
{
    public class Veritabani
    {
        private OleDbConnection con;
        private OleDbDataAdapter dataAdapter;
        private OleDbCommand command;
        private DataSet dataSet;

        public void baglan()
        {

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\data\\vt.accdb");


        }

        public void ekle(Hesaplamalar hesap)
        {
            baglan();
            con.Open();
            string sql = "insert into yolluk (yevmiye, yolmesafehesap, surehesap, tasitUcreti, toplam, yolmesafeucreti) values ('"+hesap.Yevmiye()+"','"+hesap.YolMesafeHesap()+"','"+hesap.SureHesap()+"','"+hesap.tasitUcreti()+"','"+hesap.total()+"','"+hesap.YolMesafeUcreti()+"') ";
            command = new OleDbCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();


        }

    }
}
