using ManageCinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCinema.Admin
{
    public partial class FormatMovieUC : UserControl
    {
        BindingSource formatList = new BindingSource();
        public FormatMovieUC()
        {
            InitializeComponent();
            LoadFormatMovie();
        }

        private void LoadFormatMovie()
        {
            dtgvFormatMovie.DataSource = formatList;
            LoadFormatMovieList();
            LoadMovieIDIntoCombobox(cbxMovieID);
            LoadScreenIDIntoCombobox(cbxScreenID);
            AddFormatBinding();
        }

        private void AddFormatBinding()
        {
            txtFormatID.DataBindings.Add("Text", dtgvFormatMovie.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }

        private void LoadScreenIDIntoCombobox(ComboBox cbx)
        {
            cbx.DataSource = TypeScreenDAO.GetListTypeScreen();
            cbx.DisplayMember = "ID";
            cbx.ValueMember = "ID";
        }

        private void LoadMovieIDIntoCombobox(ComboBox cbx)
        {
            cbx.DataSource = MovieDAO.GetListMovie();
            cbx.DisplayMember = "ID";
            cbx.ValueMember = "ID";
        }

        private void LoadFormatMovieList()
        {
            formatList.DataSource = FormatMovieDAO.GetListFormatMovie();
        }
    }
}
