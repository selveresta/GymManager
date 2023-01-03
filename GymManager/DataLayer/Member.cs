using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace GymManager.DataLayer
{
    public class Member
    {
        public int MemberID { get; set; }
        public int CardNumber { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Notes { get; set; }
        public byte[] Image { get; set; }

        // Loads member data
        public void LoadMember(SqlDataReader reader)
        {
            //MemberID = Int32.Parse(reader["Id"].ToString());
            MemberID = reader.GetInt32(0);
            if (!reader.IsDBNull(1))
            {
                CardNumber = reader.GetInt32(1);
            }
            LName = reader["LastName"].ToString();
            FName = reader["FirstName"].ToString();
            Sex = reader["Sex"].ToString();
            if (!reader.IsDBNull(4))
            {
                DateOfBirth = reader.GetDateTime(4);
            }
            Street = reader["Street"].ToString();
            Suburb = reader["Suburb"].ToString();
            City = reader["City"].ToString();
            HomePhone = reader["HomePhone"].ToString();
            Email = reader["email"].ToString();
            Occupation = reader["Occupation"].ToString();
            //PersonalTrainer = reader["PersonalTrainer"].ToString();
            Notes = reader["Notes"].ToString();
            if (!reader.IsDBNull(15))
            {
                Image = (byte[])reader["Image"];
            }
        }
    }
    public class Members
    {
        public static DataTable GetAllMembers()
        {
            DataTable dataset;
            using (SqlConnection con = DB.GetSqlConnection())
            {
                String sql = "";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dataset = new DataTable();
                sda.Fill(dataset);
                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = dataset;
                //membersDataGridView.DataSource = bSource;
                sda.Update(dataset);
                return dataset;
            }
        }
    }
}
