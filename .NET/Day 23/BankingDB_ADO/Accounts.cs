using System.Data.SqlClient;
namespace BankingDB_ADO
{
    public class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public int accBalance { get; set; }
        public bool accIsActive { get; set; }
        public int accBranch { get; set; }

        public List<Accounts> allAccounts()
        {
            List<Accounts> accountList = new List<Accounts>();
            SqlConnection conn = new SqlConnection("server=8790060CC7795EB;database=BankingDB_EF;integrated security=true");
            SqlCommand cmd = new SqlCommand("Select * from AccountsInfo", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                accountList.Add(new Accounts()
                {
                    accNo = Convert.ToInt32(reader[0]),
                    accName = reader[1].ToString(),
                    accType = reader[2].ToString(),
                    accBalance = Convert.ToInt32(reader[3]),
                    accIsActive = Convert.ToBoolean(reader[4]),
                    accBranch = Convert.ToInt32(reader[5])
                }
              );
            }
            reader.Close();

            conn.Close();

            return accountList;
        }
        public void addNewAccounts(int uaccNo, string uaccName, string uaccType, int uaccBalance, bool uaccActive, int uaccBranch)
        {
            Accounts newUserAcc = new Accounts();
            //newUserAcc.accNo = uaccNo;
            //newUserAcc.accName = uaccName;
            //newUserAcc.accType = uaccType;
            //newUserAcc.accBalance = uaccBalance;
            //newUserAcc.accBranch = uAccBranch;
            SqlConnection conn = new SqlConnection("server=8790060CC7795EB;database=BankingDB_EF;integrated security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into AccountsInfo values(@accNo, @accName,@accType, @accBalance, @accIsActive, @accBranch)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@accNo", uaccNo);
            cmd.Parameters.AddWithValue("@accName", uaccName);
            cmd.Parameters.AddWithValue("@accType", uaccType);
            cmd.Parameters.AddWithValue("@accBalance", uaccBalance);
            cmd.Parameters.AddWithValue("@accIsActive", uaccActive);
            cmd.Parameters.AddWithValue("@accBranch", uaccBranch);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();






        }
        public void deleteAccounts(int uaccNo)
        {

            SqlConnection conn = new SqlConnection("server=8790060CC7795EB;database=BankingDB_EF;integrated security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from AccountsInfo where accNo = @uaccNo";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uaccNo", uaccNo);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void updateName(int uaccNo, string uName)
        {

            SqlConnection conn = new SqlConnection("server=8790060CC7795EB;database=BankingDB_EF;integrated security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update AccountsInfo set accName = @uName where accNo = @uaccNo";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uaccNo", uaccNo);
            cmd.Parameters.AddWithValue("@uName", uName);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
