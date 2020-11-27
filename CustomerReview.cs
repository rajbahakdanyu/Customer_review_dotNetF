using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_review_dotNetF
{
    public partial class CustomerReview : Form
    {
        public CustomerReview()
        {
            InitializeComponent();
            BindGrid();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Review r = new Review(); //Creating object

                r.ReviewerName = nameTxt.Text;
                r.ReviewerEmail = emailTxt.Text;
                r.ReviewerPhone = mobileTxt.Text;
                r.FoodRating = int.Parse(foodCombo.Text); //Converting String to int
                r.ServiceRating = Convert.ToInt32(serviceCombo.Text); //Converting String to int
                r.EnviromentRating = int.Parse(enviromentCombo.Text);
                r.Suggestions = suggestTxt.Text;

                bool flag = r.Save(r);

                if (flag == true)
                {
                    ClearForm();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        } //Submit data

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        } //Clear all field

        private void ClearForm()
        {
            nameTxt.Text = String.Empty;        
            emailTxt.Text = String.Empty;
            mobileTxt.Text = String.Empty;
            suggestTxt.ResetText();
            foodCombo.SelectedIndex = -1;
            serviceCombo.SelectedIndex = -1;
            enviromentCombo.SelectedIndex = -1;
        } //Clear all field

        private void BindGrid()
        {
            Review obj = new Review();
            List<Review> listReview = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listReview);
            gridReview.DataSource = dt;
        } //Binding gridView

        private void BindChart(List<Review> list)
        {

        }
    }
}
