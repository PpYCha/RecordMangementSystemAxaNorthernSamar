using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages
{
    public partial class ViewInformationForm : Form
    {
        public ViewInformationForm()
        {
            InitializeComponent();
        }

        public int selected_client_id;
        Client client = new Client();
       
        AxaContext ctx = new AxaContext();



        private void ViewInformationForm_Load(object sender, EventArgs e)
        {
          
                client = ctx.Clients.Find(selected_client_id);
     
                //myReportDocument.Load((Application.StartupPath + "\\CrystalReport1.rpt"));
                ReportDocument myReportDocument = new ReportDocument();
         
            myReportDocument.Load((Application.StartupPath + "\\client_CrystalReport.rpt"));

            myReportDocument.SetParameterValue("param_client_id", client.ClientId);
            myReportDocument.SetParameterValue("cb_param_client_id", client.ClientId);
            myReportDocument.SetParameterValue("cp_param_client_id", client.ClientId);
            crystalReportViewer1.ReportSource = myReportDocument;
          
          

        }
    }



}
