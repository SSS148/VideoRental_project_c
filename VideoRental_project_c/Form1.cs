using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_project_c
{
    public partial class Form1 : Form
    {
        opertionLogic opertion = new opertionLogic();
        int bookId = 0,opertionTsk=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void VideoCost_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void movie_year_TextChanged(object sender, EventArgs e)
        {
            //here i need to get the cost of the product 
            try
            {
                int cost=opertion.genCost(Convert.ToInt32(movie_year.Text));
                VideoCost.Value = cost;
            }
            catch (Exception ex)
            {

            }
        }

        private void VideoAdd_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.insertMovie(VideoTitle.Text, VideoRatting.Text, movie_year.Text, Convert.ToInt32(VideoCopies.Value), Convert.ToInt32(VideoCost.Value), VideoPlot.Text, VideoGenre.Text))
            {
                MessageBox.Show("Record is Inserted ");
                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
            }
            else {
                MessageBox.Show("Need to check once ");
            }
        }

        private void VideoUpdate_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.updateMovie(Convert.ToInt32(txt_MovieID.Text),VideoTitle.Text, VideoRatting.Text, movie_year.Text, Convert.ToInt32(VideoCopies.Value), Convert.ToInt32(VideoCost.Value), VideoPlot.Text, VideoGenre.Text))
            {
                MessageBox.Show("Record is Edited");
                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }
        }

        private void VideoDelete_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.deleteMovie(Convert.ToInt32(txt_MovieID.Text)))
            {
                MessageBox.Show("Record is removed ");
                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }
        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.InsClient(CustomerFName.Text+" "+CustomerLName.Text,CustomerMobile.Value.ToString(),CustomerAddress.Text))
            {
                MessageBox.Show("Record is Inserted ");

                CustomerAddress.Text = "";
                CustomerFName.Text = "";
                CustomerLName.Text = "";
                CustomerMobile.Value = 0;

                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }

        }

        private void CustomerUpdate_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.UpdtClient(Convert.ToInt32(txt_CustomerID.Text),CustomerFName.Text + " " + CustomerLName.Text, CustomerMobile.Value.ToString(), CustomerAddress.Text))
            {
                MessageBox.Show("Record is Edited ");
                txt_CustomerID.Text = "";
                CustomerAddress.Text = "";
                CustomerFName.Text = "";
                CustomerLName.Text = "";
                CustomerMobile.Value = 0;

                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }

        }

        private void Customer_Delete_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.DelClient(Convert.ToInt32(txt_CustomerID.Text)))
            {
                MessageBox.Show("Record is Removed");

                txt_CustomerID.Text = "";
                CustomerAddress.Text = "";
                CustomerFName.Text = "";
                CustomerLName.Text = "";
                CustomerMobile.Value = 0;


                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }

        }

        private void btn_BookVideo_Click(object sender, EventArgs e)
        {

            //here need to pass the data 
            if (opertion.bookMovie(txt_MovieID.Text,txt_CustomerID.Text,dtp_IssueDate.Text.ToString()))
            {
                MessageBox.Show("Movie is Issued on Rent");


                txt_CustomerID.Text = "";
                txt_MovieID.Text = "";
                CustomerAddress.Text = "";
                CustomerFName.Text = "";
                CustomerLName.Text = "";
                CustomerMobile.Text = "";



                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;

            }
            else
            {
                MessageBox.Show("Need to check once ");
            }


        }

        private void btn_ReturnVideo_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.returnMovie(bookId,txt_MovieID.Text, txt_CustomerID.Text, dtp_IssueDate.Text.ToString(),dtp_ReturnDate.Text.ToString()))
            {

                txt_CustomerID.Text = "";
                txt_MovieID.Text = "";
                CustomerAddress.Text = "";
                CustomerFName.Text = "";
                CustomerLName.Text = "";
                CustomerMobile.Text = "";



                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
                bookId = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }
        }

        private void btn_DeleteVideo_Click(object sender, EventArgs e)
        {
            //here need to pass the data 
            if (opertion.delBookMovie(bookId))
            {

                MessageBox.Show("Movie is Removed ");

                txt_CustomerID.Text = "";
                txt_MovieID.Text = "";
                CustomerAddress.Text = "";
                CustomerFName.Text = "";
                CustomerLName.Text = "";
                CustomerMobile.Text = "";



                VideoTitle.Text = "";
                VideoRatting.Text = "";
                VideoGenre.Text = "";
                VideoPlot.Text = "";
                movie_year.Text = "";
                VideoCopies.Value = 0;
                VideoCost.Value = 0;
                bookId = 0;
            }
            else
            {
                MessageBox.Show("Need to check once ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (opertion.topRnkMovie()) { 
            

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (opertion.topRnkClient())
            {


            }
        }

        private void show_videos_Click(object sender, EventArgs e)
        {

            opertion.showMovie(all_data_Show_grid);
            opertionTsk = 2;
        }

        private void show_rentals_Click(object sender, EventArgs e)
        {

            opertion.showBooking(all_data_Show_grid);
            opertionTsk = 3;
        }

        private void all_data_Show_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (opertionTsk) {
                case 1:
                    txt_CustomerID.Text= all_data_Show_grid.CurrentRow.Cells[0].Value.ToString();
                    String g = all_data_Show_grid.CurrentRow.Cells[1].Value.ToString();
                    String[] nm = g.Split(' ');
                    CustomerFName.Text = nm[0];
                    CustomerLName.Text = nm[1];
                    CustomerMobile.Value= Convert.ToInt64(all_data_Show_grid.CurrentRow.Cells[2].Value);
                    CustomerAddress.Text= all_data_Show_grid.CurrentRow.Cells[3].Value.ToString();


                    break;

                case 2:

                    txt_MovieID.Text= all_data_Show_grid.CurrentRow.Cells[0].Value.ToString();
                   VideoTitle.Text = all_data_Show_grid.CurrentRow.Cells[1].Value.ToString();
                    VideoRatting.Text = all_data_Show_grid.CurrentRow.Cells[2].Value.ToString();
                    movie_year.Text = all_data_Show_grid.CurrentRow.Cells[3].Value.ToString();
                    VideoCopies.Value=Convert.ToInt32(all_data_Show_grid.CurrentRow.Cells[4].Value);
                    VideoCost.Value = Convert.ToInt32(all_data_Show_grid.CurrentRow.Cells[5].Value);
                    VideoPlot.Text=all_data_Show_grid.CurrentRow.Cells[6].Value.ToString();
                    VideoGenre.Text= all_data_Show_grid.CurrentRow.Cells[7].Value.ToString();
                    break;

                case 3:
                    bookId= Convert.ToInt32(all_data_Show_grid.CurrentRow.Cells[0].Value);
                    txt_MovieID.Text = all_data_Show_grid.CurrentRow.Cells[1].Value.ToString();
                    txt_CustomerID.Text = all_data_Show_grid.CurrentRow.Cells[2].Value.ToString();
                    dtp_IssueDate.Text = all_data_Show_grid.CurrentRow.Cells[3].Value.ToString();
                    break;
            }
            opertionTsk = 0;
        }

        private void show_customers_Click(object sender, EventArgs e)
        {
            opertion.showCustomer(all_data_Show_grid);
            opertionTsk = 1;
        }
    }
}
