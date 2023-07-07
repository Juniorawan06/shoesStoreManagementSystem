using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace winShoesStoreManagementSystem
{
    public partial class frmBarCodeGeneration : Form
    {
        public frmBarCodeGeneration()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");

        private void GenerateBarcode(string data)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 200,
                    Width = 400,
                    Margin = 10
                }
            };

            Bitmap barcodeBitmap = writer.Write(data);

            barcodeBitmap.Save("barcode.png", ImageFormat.Png);
            pictureBox1.Image = barcodeBitmap;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {

            string checkQry = "SELECT COUNT(*) FROM tblBarcodes WHERE brand = '" + cmbBrand.Text + "' and category = '" + cmbCategory.Text + "' and style = '" + cmbStyle.Text + "' and color = '" + cmbColor.Text + "' and size = '" + cmbSize.Text + "';";
            SqlCommand cmd = new SqlCommand(checkQry, con);

            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();



            if (count == 0)
            {
                    string qry = "insert into tblBarcodes values ('" + cmbBrand.Text + "','" + cmbCategory.Text + "','" + cmbStyle.Text + "','" + cmbColor.Text + "','" + cmbSize.Text + "');";
                    SqlCommand insertCmd = new SqlCommand(qry, con);

                    con.Open();
                    insertCmd.ExecuteNonQuery();

                    string sql = "SELECT TOP 1 * FROM tblBarcodes ORDER BY barcode DESC";

                    SqlCommand barcodeCmd = new SqlCommand(sql, con);
                    int barCode = (int)barcodeCmd.ExecuteScalar();
                    con.Close();

                    string inputData = barCode.ToString();
                    GenerateBarcode(inputData);
            }
            else
            {
                MessageBox.Show("The Barcode for the Item already exists");
            }
        }

        private void frmBarCodeGeneration_Load(object sender, EventArgs e)
        {
            
            string qry = "SELECT * FROM tblPurchases";

            // Retrieve data from the database
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DataTable dtBrand = new DataTable();
            ad.Fill(dtBrand);

            DataTable dtCategory = new DataTable();
            ad.Fill(dtCategory);

            DataTable dtStyle = new DataTable();
            ad.Fill(dtStyle);

            DataTable dtColor = new DataTable();
            ad.Fill(dtColor);

            DataTable dtSize = new DataTable();
            ad.Fill(dtSize);

            // Create a new row for the default value
            DataRow dr = dt.NewRow();
            dr["brand"] = "--Select--";
            dr["category"] = "--Select--";
            dr["style"] = "--Select--";
            dr["color"] = "--Select--";
            dr["size"] = "--Select--";

            // Insert the default row at the beginning of the DataTable
            dt.Rows.InsertAt(dr, 0);

            cmbBrand.DataSource = dtBrand;
            cmbBrand.DisplayMember = "brand";

            cmbCategory.DataSource = dtCategory;
            cmbCategory.DisplayMember = "category";

            cmbStyle.DataSource = dtStyle;
            cmbStyle.DisplayMember = "style";

            cmbColor.DataSource = dtColor;
            cmbColor.DisplayMember = "color";

            cmbSize.DataSource = dtSize;
            cmbSize.DisplayMember = "size";
        }
    }
}
