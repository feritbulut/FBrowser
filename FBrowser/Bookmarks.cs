using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FBrowser
{
    public partial class Bookmarks : Form
    {
        public string SelectedUrl { get; private set; }
        public event Action<string> OnBookmarkSelected;

        public Bookmarks()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bookmarks_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Bookmarks", bgl.baglanti());
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
