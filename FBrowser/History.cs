using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBrowser
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        public string SelectedUrl { get; private set; } 
        public event Action<string> OnBookmarkSelected;


        sqlbaglantisi bgl = new sqlbaglantisi();

        private void History_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Name,Link From Tbl_History order by ID desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                SelectedUrl = dataGridView1.Rows[e.RowIndex].Cells["Link"].Value.ToString();

                OnBookmarkSelected?.Invoke(SelectedUrl);

                this.Close();
            }
        }
    }
}
