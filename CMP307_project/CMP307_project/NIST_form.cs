using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CMP307_project
{
    public partial class NIST_form : Form
    {
        public string keyword;

        private dynamic deserialiseJSON(string strJSON)
        {
            dynamic data = 0;

            try
            {
                data = JsonConvert.DeserializeObject(strJSON);
                Console.WriteLine(data.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            return data;
        }

        public NIST_form()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NIST_form_Load(object sender, EventArgs e)
        {
            try 
            { 
                REST_client rClient = new REST_client();
    
                rClient.endPoint = "https://services.nvd.nist.gov/rest/json/cves/2.0/?pubStartDate=2022-09-04T00:00:00.000&pubEndDate=2022-12-04T00:00:00.000&keywordSearch=" + keyword;
                rClient.httpMethod = httpVerb.GET;

                // Send request 
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest();

                // Convert json string into object
                var data = deserialiseJSON(strResponse);
                int resultCount = data.totalResults;

                // Display vulnerability count
                lbl_count.Text = resultCount.ToString();

                // Add vulnerabilities to list box
                for(int i = 0; i < resultCount; i++)
                {                            
                    lv_vulnerabilities.Items.Add((i+1)+". "+data.vulnerabilities[i].cve.descriptions[0].value.ToString(), i);               
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

}
    }
}
