using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TAREA5
{
    public partial class REPORTVIEWER : Form
    {
        public REPORTVIEWER()
        {
            InitializeComponent();
        }

        private void REPORTVIEWER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDProductosCrudDataSet.tablaProductos' table. You can move, or remove it, as needed.
            this.tablaProductosTableAdapter.Fill(this.BDProductosCrudDataSet.tablaProductos);


            this.reportViewer1.RefreshReport();
        }
    }
}
