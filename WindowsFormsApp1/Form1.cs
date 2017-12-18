using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Queue orders = new Queue();

        SqlConnection connection;
        string connectionString;
        string carsCount;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateInventory(); // for inventory panel
            UpdateStats();         // for dashboard
        }

        private void UpdateStats()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars", connection);
                Int32 carsCount1 = (Int32)cmd.ExecuteScalar();
                carsCount = carsCount1.ToString();
                totalLabel.Text = carsCount;
            }
        }

        private void UpdateInventory()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cars", connection))
            {
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);
                carGrid.DataSource = carTable;
                carGrid.Columns[0].Width = 50;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardTab_Click(object sender, EventArgs e)
        {
            indicator.Top = dashboardTab.Top;
            inventoryPanel.Visible = false;
            dashboardPanel.Visible = true;
            ordersPanel.Visible = false;
        }

        private void inventoryTab_Click(object sender, EventArgs e)
        {
            indicator.Top = inventoryTab.Top;
            inventoryPanel.Visible = true;
            dashboardPanel.Visible = false;
            ordersPanel.Visible = false;
        }

        private void ordersTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ordersTab.Top;
            inventoryPanel.Visible = false;
            dashboardPanel.Visible = false;
            ordersPanel.Visible = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBox1.Text);
            orders.Enqueue(id);
            lstOrders.Items.Add(id);
            salesLabel.Text = orders.Count.ToString();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void dequeueBtn_Click(object sender, EventArgs e)
        {
            int order = Int32.Parse(lstOrders.Items[0].ToString());
            orders.Dequeue();
            lstOrders.Items.Remove(lstOrders.Items[0]);

            try
            {
                using (var sc = new SqlConnection(connectionString))
                using (var cmd = sc.CreateCommand())
                {
                    sc.Open();
                    cmd.CommandText = "DELETE FROM Cars WHERE id = @order";
                    cmd.Parameters.AddWithValue("@order", order);
                    cmd.ExecuteNonQuery();
                    UpdateStats();
                    UpdateInventory();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("SQL error " + ee);
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var sc = new SqlConnection(connectionString))
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "INSERT INTO Cars ([Make], [Name], [Type], [Price]) VALUES (@make, @name, @type, @price)";
                cmd.Parameters.AddWithValue("@make", newCarMake.Text);
                cmd.Parameters.AddWithValue("@name", newCarName.Text);
                cmd.Parameters.AddWithValue("@type", newCarType.Text);
                cmd.Parameters.AddWithValue("@price", newCarPrice.Text);
                cmd.ExecuteNonQuery();
                UpdateStats();
                UpdateInventory();
            }
        }
    }
}