using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac
{
    public partial class MigratorForm : Form
    {
        public MigratorForm()
        {
            InitializeComponent();
        }

        void outToLog(string output)
        {
            if (!string.IsNullOrWhiteSpace(tbLog.Text))
            {
                tbLog.AppendText("\r\n" + output);
            }
            else
            {
                tbLog.AppendText(output);
            }
            tbLog.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int griafikId;
            string nomerDoc=null;
            string naimenovanie=null;
            DateTime? srokVypolneniya=null;
            DateTime? data=null;
            DateTime? dataVypolneniya = null ;
            int? ord=null;

            outToLog(DateTime.Now + " " + " - cтарт");

            using (NpgsqlConnection conPg = new NpgsqlConnection(Properties.Settings.Default.pgConStr))
            {
                try
                {
                    NpgsqlCommand cmdPg = new NpgsqlCommand("insert into grafiki_meropriyatij(griafik_id, nomer_doc, naimenovanie, srok_vypolneniya, data, data_vypolneniya, ord) values (@griafik_id, @nomer_doc, @naimenovanie, @srok_vypolneniya, @data, @data_vypolneniya, @ord);", conPg);
                    conPg.Open();
                    using (OleDbConnection conOLE = new OleDbConnection(Properties.Settings.Default.connStr))
                    {
                        OleDbCommand cmdOLE = new OleDbCommand("SELECT ГрафикN, Nдокумента, НаименованиеГрафика, СрокВыполнения, Дата, ДатаВыполнения, Ord FROM ГрафикиМероприятий;", conOLE);
                        try
                        {
                            conOLE.Open();
                            OleDbDataReader reader = cmdOLE.ExecuteReader();
                            while (reader.Read())
                            {
                                griafikId = reader.GetInt32(0);

                                if (DBNull.Value != reader[1])
                                {
                                    nomerDoc = reader.GetString(1);
                                }

                                if (DBNull.Value != reader[2])
                                {
                                    naimenovanie = reader.GetString(2);
                                }
                                if (DBNull.Value != reader[3])
                                {
                                    srokVypolneniya = reader.GetDateTime(3);
                                }
                                if (DBNull.Value != reader[4])
                                {
                                    data = reader.GetDateTime(4);
                                }
                                if (DBNull.Value != reader[5])
                                {
                                    dataVypolneniya = reader.GetDateTime(5);
                                }
                                if (DBNull.Value != reader[6])
                                {
                                    ord = reader.GetInt32(6);
                                }
                                cmdPg.Parameters.Clear();
                                cmdPg.Parameters.AddWithValue("@griafik_id", griafikId);
                                cmdPg.Parameters.AddWithValue("@nomer_doc", nomerDoc);
                                cmdPg.Parameters.AddWithValue("@naimenovanie", naimenovanie);
                                cmdPg.Parameters.AddWithValue("@srok_vypolneniya",srokVypolneniya );
                                cmdPg.Parameters.AddWithValue("@data", data);
                                cmdPg.Parameters.AddWithValue("@data_vypolneniya", dataVypolneniya);
                                cmdPg.Parameters.AddWithValue("@ord", ord);

                                cmdPg.ExecuteScalar();
                            }
                        }
                        catch (Exception ex)
                        {
                            outToLog(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    outToLog(ex.Message);
                }
            }
            outToLog(DateTime.Now + " " + " - готово");
        }
    }
}
