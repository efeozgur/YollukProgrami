
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;

namespace YollukProgrami
{
    public class Veritabani
    {
        private OleDbConnection con;
        private OleDbDataAdapter dataAdapter;
        private OleDbCommand command;
        private DataSet dataSet;
        private OleDbDataReader reader;

        public void baglan()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\vt.accdb");


        }

        public void ekle(Hesaplamalar hesap)
        {
            baglan();
            con.Open();
            string sql = "insert into yolluk (yevmiye, yolmesafehesap, surehesap, tasitUcreti, toplam, yolmesafeucreti) values ('" + hesap.Yevmiye() + "','" + hesap.YolMesafeHesap() + "','" + hesap.SureHesap() + "','" + hesap.tasitUcreti() + "','" + hesap.total() + "','" + hesap.YolMesafeUcreti() + "') ";
            command = new OleDbCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public DataTable Listele()
        {
            baglan();
            con.Open();
            dataAdapter = new OleDbDataAdapter("select * from yolluk", con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }


        public void DeleteAll()
        {
            
            baglan();
            con.Open();
            command=new OleDbCommand("delete from yolluk");
            command.Connection = con; 
            command.ExecuteNonQuery();
            con.Close();

        

        }
    }
}
