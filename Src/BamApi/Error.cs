using System;
using System.Text;
using System.Windows.Forms;

namespace BamApi
{
    public partial class Error : Form
    {
        public Error(Exception ex)
        {
            InitializeComponent();

            var sb = new StringBuilder();

            sb.AppendLine(ex.Message);
            sb.AppendLine("STACK TRACE");
            sb.AppendLine(ex.StackTrace);

            if (ex.InnerException != null)
            {
                sb.AppendLine("INNER EXCEPTION");
                sb.AppendLine(ex.InnerException.Message);
            }

            txtError.Text = sb.ToString();
        }
    }
}