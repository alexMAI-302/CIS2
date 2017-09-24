using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            _TBtoken.Text = "BadRenMip1sNW8rbsHMU";
        }

        /// <summary>
        /// Полготовка ДГВ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnFill_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = int.Parse(_tbSize.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect matrix size\nTry again");
                return;
            }

            #region Причесывает ДГВ

            _dGW.RowCount = n;
            _dGW.ColumnCount = n;
            _dGW.RowHeadersVisible = false;
            _dGW.ColumnHeadersVisible = false;

            for (int i = 0; i < n; i++)
            {
                _dGW.Columns[i].Width = 50;
                _dGW.Rows[i].Height = 50;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        _dGW[i, j].Value = 1;
                    }
                    if (j >= i)
                    {
                        _dGW[i, j].ReadOnly = true;
                    }
                }
            } 

            #endregion
        }

        /// <summary>
        /// Заполняет матрицу под главной диагональю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Ячейка</param>
        private void _dGW_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _dGW[e.RowIndex, e.ColumnIndex].Value = 1.0 / Convert.ToDouble(_dGW[e.ColumnIndex, e.RowIndex].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input\nTry again");
                return;
            }
        }

        /// <summary>
        /// JSON, HTTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnGo_Click(object sender, EventArgs e)
        {
            Matrix mtx = new Matrix();
            for (int i = 0; i < _dGW.Rows.Count; i++)
            {
                mtx.matrix.Add(new double[_dGW.Rows.Count]);
                for (int j = 0; j < _dGW.Columns.Count; j++)
                    mtx.matrix[i][j] = Convert.ToDouble(_dGW[j, i].Value);
            }
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Matrix));
            using (FileStream stream = new FileStream("matrix.json", FileMode.Create))
            {
                serializer.WriteObject(stream, mtx);
            }

            //POST
            string response = string.Empty;
            string URI = "http://www.ws-dss.com/ws_jobs.json";
            string postparams = String.Format("ws_job[ws_method_id]=30&ws_job[input]={0}", File.ReadAllText("matrix.json"));
            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URI);
            req.Method = "POST";
            req.ContentLength = postparams.Length;
            req.Headers.Add("user-token", _TBtoken.Text);

            using (var writer = new StreamWriter(req.GetRequestStream()))
            {
                writer.Write(postparams);
            }

            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                //if (resp.StatusCode != HttpStatusCode.OK)
                //    throw new ApplicationException("error " + resp.StatusCode.ToString());
                using (Stream respStream = resp.GetResponseStream())
                {
                    if (respStream != null)
                    {
                        using (StreamReader sr = new StreamReader(respStream))
                        {
                            response = sr.ReadToEnd();
                        }
                    }
                }
            }

            string output = response.Substring(response.IndexOf("output"));
            _rTB.Text = output;
        }
    }
}
