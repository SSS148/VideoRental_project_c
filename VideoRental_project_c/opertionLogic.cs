using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_project_c
{
    public  class opertionLogic
    {
        public SqlConnection sqlConn;

        //write the connection sstring to assthe data form one for to the database 
        public String connectioString = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=movie_C;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        public SqlCommand sqlCmd;

        //data reader is used to read thedata from the database table 
        public SqlDataReader sqlReader;


        public void CmdIns(String query)
        {
            sqlConn = new SqlConnection(connectioString);
            sqlConn.Open();
            sqlCmd = new SqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable Entries(String qry)
        {
            DataTable tbl = new DataTable();

            sqlConn = new SqlConnection(connectioString);

            sqlConn.Open();

            sqlCmd = new SqlCommand(qry,sqlConn);

            sqlReader = sqlCmd.ExecuteReader();

            tbl.Load(sqlReader);

            sqlConn.Close();

            return tbl;
        }

      // to give bill this  

        public int getCost(int movieID) {

            String sql = "select * from movieData where movieID=" + movieID + "";
            DataTable tbl = new DataTable();
            tbl = Entries(sql);
            return Convert.ToInt32(tbl.Rows[0]["cost"].ToString());
        }


        //genrate cost of movie according to the year entered

        public int genCost(int Year) {
            try
            {
                //get the date 
                DateTime dt = DateTime.Now;
                int curnt = dt.Year;
                if ((curnt - Year) > 5)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        // insert new movie record to database

        public Boolean insertMovie(String name, String rating,String year, int Copies, int Cost, String Plot,String Genre) {
            try
            {
                String Qry = "insert into MovieData(title, ratting,year,copies,cost,plot,genre)values('" + name+"','"+rating+"','"+year+"',"+Copies+","+Cost+",'"+Plot+"','"+Genre+"')";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
            
        }


        // update movie

        public Boolean updateMovie(int movieID, String name, String rating, String year, int Copies, int Cost, String Plot, String Genre)
        {
            try
            {
                String Qry = "update MovieData set title='" + name+"', ratting='"+rating+"',year='"+year+"',copies="+Copies+",cost="+Cost+",plot='"+Plot+"',genre='"+Genre+"' where movieID="+movieID+"";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // delete movie from database

        public Boolean deleteMovie(int movieID)
        {
            try
            {
                String Qry = "delete from MovieData  where movieID=" + movieID + "";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //insert new customer

        public Boolean InsClient(String name,String mobile,String address)
        {
            try
            {
                String Qry = "insert into ClientData(name,mobile,address) values('" + name+"','"+mobile+"','"+ address+ "')";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // update new client from database

        public Boolean UpdtClient(int clientID,String name, String mobile, String address)
        {
            try
            {
                String Qry = "Update ClientData set name='"+name+"',mobile='"+mobile+"',address='"+ address + "' where clientID="+clientID+"";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // delete client information  

        public Boolean DelClient(int clientID)
        {
            try
            {
                String Qry = "delete from ClientData  where clientID=" + clientID + "";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // new movie booking code

        public Boolean bookMovie(String movieID,String clientID,String BookingDate)
        {
            try
            {
                String Qry = "insert into bookingData(movieID,clientID,bookingDate,returnDate) values('"+movieID+"','"+clientID+"','"+BookingDate+"','book')";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // return the booked movie

        public Boolean returnMovie(int bookID,String movieID, String clientID, String BookingDate,String returnDate)
        {
            try
            {
                String Qry = "update bookingData set movieID='"+movieID+"',clientID='"+clientID+"',bookingDate='"+BookingDate+"',returnDate='"+returnDate+"' where bookID="+bookID+"";
                CmdIns(Qry);
                int cost = getCost(Convert.ToInt32(movieID));
                //get the days for the booking 
                DateTime nw = DateTime.Now;

                DateTime old = Convert.ToDateTime(BookingDate);

                String diff = (nw - old).TotalDays.ToString();


                Double DaysInterval = Math.Round(Convert.ToDouble(diff));
                if (DaysInterval <= 0) {
                    DaysInterval = 1;
                }

                MessageBox.Show("Your Bill is $"+(cost* DaysInterval));

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // delete booked movie

        public Boolean  delBookMovie(int bookID)
        {
            try
            {
                String Qry = "delete from bookingData where bookID=" + bookID + "";
                CmdIns(Qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // top ranked movie

        public Boolean topRnkMovie()
        {
            try
            {

                int x = 0, y = 0, cunt = 0;
                String Title = "";

                DataTable tblvideo = new DataTable();

                tblvideo = Entries("select * from MovieData");


                while (x < tblvideo.Rows.Count)
                {
                    DataTable Rental = new DataTable();

                    Rental =Entries("select * from bookingData where movieID=" + Convert.ToInt32(tblvideo.Rows[x]["movieID"]) + "");


                    if (Rental.Rows.Count > cunt)
                    {

                        Title = tblvideo.Rows[x]["title"].ToString();
                        cunt = Rental.Rows.Count;

                    }
                    x++;
                }


                MessageBox.Show("Top Ranking Movie Name   is  " + Title);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // top ranked client

        public Boolean topRnkClient()
        {
            try
            {

                int x = 0, y = 0, cunt = 0;
                String Title = "";

                DataTable tblvideo = new DataTable();

                tblvideo = Entries("select * from ClientData");


                while (x < tblvideo.Rows.Count)
                {
                    DataTable Rental = new DataTable();

                    Rental = Entries("select * from bookingData where clientID=" + Convert.ToInt32(tblvideo.Rows[x]["clientID"]) + "");


                    if (Rental.Rows.Count > cunt)
                    {

                        Title = tblvideo.Rows[x]["name"].ToString();
                        cunt = Rental.Rows.Count;

                    }
                    x++;
                }


                MessageBox.Show("Top Ranking Client Name   is  " + Title);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void showCustomer(DataGridView dgv) {
            String sl = "select * from ClientData";
            DataTable dataTable = new DataTable();
            dataTable = Entries(sl);
            dgv.DataSource = dataTable;

        }
        public void showMovie(DataGridView dgv)
        {
            String sl = "select * from MovieData";
            DataTable dataTable = new DataTable();
            dataTable = Entries(sl);
            dgv.DataSource = dataTable;

        }
        public void showBooking(DataGridView dgv)
        {
            String sl = "select * from bookingData";
            DataTable dataTable = new DataTable();
            dataTable = Entries(sl);
            dgv.DataSource = dataTable;

        }
    }
}
