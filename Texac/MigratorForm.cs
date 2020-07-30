using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using Texac.Domain;
using Texac.RestClient;

namespace Texac
{
    public partial class MigratorForm : Form
    {
        RestClient.RestClient rest = new RestClient.RestClient();

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

        private void button1_Click_1(object sender, EventArgs e)
        {



            outToLog(DateTime.Now + " " + " - test REST");


            Master m = new Domain.Master
            {
                masterId = 1,
                caption = "One master",
                details = new List <Detail> {
                    new Detail {title="примечание 1", amount=0.5, detailId = 1, masterId=1 },
                    new Detail {title="примечание 2", amount=0.5, detailId = 2, masterId=1 }
                }
            };

            string json = JsonConvert.SerializeObject(m);

            outToLog(json);
            outToLog("");
            //Master jMaster = rest.getEntyty<Master>(40);
            List<Master> jMasterList = rest.getEntytyList<Master>();
            outToLog(JsonConvert.SerializeObject(jMasterList));


            outToLog("");
            //Master jMaster = rest.getEntyty<Master>(40);
            List<Detail> jDetailList = rest.getEntytyList<Detail>();
            outToLog(JsonConvert.SerializeObject(jMasterList));


        }

        private void btnCopyData_Click(object sender, EventArgs e)
        {
            // copyEmployeeTable();
            // copyOrderTable();
            copyMatCardTable();
        }

        private void copyMatCardTable()
        {
            string sql = "SELECT ID, NППЗаказа, NППДетали, NДеталиОснастки, НаименованиеДетали, Материал, КузнечнаяОперация, РазмерыДетали, Количество, КоличествоДеталей, ФрезОбр, СтрогОбр, ШлифОбр, ВремяФрез, ВремяСтрог, ВремяШлиф, ВесЗаготовки, ВесВсего, ДополнДляЗакНар, ДатаРедактТехн, Склад, КодЕдИзм, CODEMAT, annealing, term, strogterm, ВесДетали, ordered, Материа FROM МатериальнаяКарта WHERE NППЗаказа>=80000";

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                MaterialCard m = new MaterialCard();
                m.matCardId = r.GetInt32(0);
                m.orderId = r.GetInt32(1);

                if (r[2] != DBNull.Value)
                    m.detailNumber = r.GetInt16(2);

                if (r[3] != DBNull.Value)
                    m.detailTONumber = r.GetString(3);

                if (r[4] != DBNull.Value)
                    m.detailTOTitle = r.GetString(4);

                if (r[5] != DBNull.Value)
                    m.materialTitle = r.GetString(5);

                if (r[6] != DBNull.Value)
                    m.blackSmithOp = r.GetString(6);

                if (r[7] != DBNull.Value)
                    m.detailSize= r.GetString(7);

                m.blankQty = r.GetFloat(8);
                m.detailQty = r.GetFloat(9);

                if (r[10] != DBNull.Value)
                    m.millingOp = r.GetString(10);
                if (r[11] != DBNull.Value)
                    m.planerOp = r.GetString(11);
                if (r[12] != DBNull.Value)
                    m.grindingOp = r.GetString(12);

                if (r[13] != DBNull.Value)
                    m.millingTime = r.GetFloat(13);

                if (r[14] != DBNull.Value)
                    m.planerTime = r.GetFloat(14);

                if (r[15] != DBNull.Value)
                    m.grindingTime = r.GetFloat(15);

                if (r[16] != DBNull.Value)
                    m.weight = r.GetFloat(16);

                if (r[17] != DBNull.Value)
                    m.weightTotal = r.GetFloat(17);

                if (r[18] != DBNull.Value)
                    m.supplementToOrder = r.GetBoolean(18);

                if (r[19] != DBNull.Value)
                    m.technologyEditTime = r.GetDateTime(19);

                if (r[20] != DBNull.Value)
                    m.storeId = r.GetInt16(20);

                if (r[21] != DBNull.Value)
                    m.unitOfMeasureId = r.GetInt16(21);

                if (r[22] != DBNull.Value)
                    m.materialCode = r.GetInt32(22);

                if (r[23] != DBNull.Value)
                    m.annealing = r.GetBoolean(23);

                if (r[24] != DBNull.Value)
                    m.thermalOp = r.GetString(24);

                if (r[25] != DBNull.Value)
                    m.planerThermalOp = r.GetString(25);

                if (r[26] != DBNull.Value)
                    m.detailWeight = r.GetDouble(26);

                if (r[27] != DBNull.Value)
                    m.ordered = r.GetBoolean(27);

                string json = JsonConvert.SerializeObject(m, Formatting.None, new JsonSerializerSettings
              {
                  NullValueHandling = NullValueHandling.Ignore
              });
//              MessageBox.Show(json);

                MaterialCard m2 = rest.saveEntity<MaterialCard>(m);
                if (m2.matCardId < 1)
                {
                    break;
                }
            }
            r.Close();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Done!");
        }

        void copyEmployeeTable()
        {
            string sql = "SELECT id, NТабельный, Подразделение, Звено, Имя, Фамилия, ФИО, ПрофессияДолжность, Разряд, Операция, ВыполняемыеОперации, ДатаНайма, Работает, Категория, Адрес, ДомашнийТелефон, ДатаРождения, МестоРождения, МестоУчебы, ГодОкУЗ, Факультет, Специальность, ПредМР, Примечания, УслТруда, КТУ, WORKERSUM, UserLogin, Руководитель, PassportSeria, RealAdress, FamilyStatus, PassportNumber, PassportDate, PassportOffice, PersonalNumber, MobilePhoneZone, MobilePhone, Profession1, Profession2, Profession3, Profession4, Profession5, Profession6, Rost, Razmer, RazmerObuvi, ПрофессияСИЗ, КодРазмера, Sex FROM РаботникиЦеха";// where NТабельный=11980";

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Employee emp = new Employee();
                emp.employeeId = r.GetInt32(0);
                emp.nTabelnyj = r.GetInt32(1);
                emp.deptId = r.GetInt16(2);
                if (r[3] != DBNull.Value)
                    emp.zveno = r.GetString(3);
                if (r[4] != DBNull.Value)
                    emp.firstName = r.GetString(4);
                if (r[5] != DBNull.Value)
                    emp.secondName = r.GetString(5);
                if (r[6] != DBNull.Value)
                    emp.fullName = r.GetString(6);
                if (r[7] != DBNull.Value)
                    emp.position = r.GetInt16(7);
                if (r[8] != DBNull.Value)
                    emp.rank = r.GetByte(8);
                if (r[11] != DBNull.Value)
                    emp.dateOfEmployment = r.GetDateTime(11);
                if (r[12] != DBNull.Value)
                    emp.working = r.GetBoolean(12);
                if (r[13] != DBNull.Value)
                    emp.categoryId = r.GetByte(13);
                if (r[14] != DBNull.Value)
                    emp.address = r.GetString(14);
                if (r[15] != DBNull.Value)
                    emp.homePhone = r.GetString(15);
                if (r[16] != DBNull.Value)
                    emp.birthday = r.GetDateTime(16);
                if (r[17] != DBNull.Value)
                    emp.birthplace = r.GetString(17);
                if (r[18] != DBNull.Value)
                    emp.education = r.GetString(18);
                if (r[19] != DBNull.Value)
                    emp.eduYear = r.GetInt16(19);
                if (r[20] != DBNull.Value)
                    emp.faculty = r.GetString(20);
                if (r[21] != DBNull.Value)
                    emp.specialty = r.GetString(21);
                if (r[22] != DBNull.Value)
                    emp.previousEmployment = r.GetString(22);
                if (r[23] != DBNull.Value)
                    emp.note = r.GetString(23);
                if (r[24] != DBNull.Value)
                    emp.workingConditions = r.GetDouble(24);
                if (r[25] != DBNull.Value)
                    emp.salary = r.GetDouble(25);
                if (r[27] != DBNull.Value)
                    emp.userLogin = r.GetString(27);
                if (r[28] != DBNull.Value)
                    emp.managerId = r.GetInt32(28);
                if (r[29] != DBNull.Value)
                    emp.passportSeries = r.GetString(29);
                if (r[30] != DBNull.Value)
                    emp.realAddress = r.GetString(30);
                if (r[31] != DBNull.Value)
                    emp.familyStatus = r.GetString(31);
                if (r[32] != DBNull.Value)
                    emp.passportNumber = r.GetString(32);
                if (r[33] != DBNull.Value)
                    emp.passportDate = r.GetDateTime(33);
                if (r[34] != DBNull.Value)
                    emp.passportOffice = r.GetString(34);
                if (r[35] != DBNull.Value)
                    emp.personalNumber = r.GetString(35);
                if (r[36] != DBNull.Value)
                    emp.mobilePhoneZone = r.GetString(36);
                if (r[37] != DBNull.Value)
                    emp.mobilePhone = r.GetString(37);
                if (r[38] != DBNull.Value)
                    emp.professionId1 = r.GetInt16(38);
                if (r[39] != DBNull.Value)
                    emp.professionId2 = r.GetInt16(39);
                if (r[40] != DBNull.Value)
                    emp.professionId3 = r.GetInt16(40);
                if (r[41] != DBNull.Value)
                    emp.professionId4 = r.GetInt16(41);
                if (r[42] != DBNull.Value)
                    emp.professionId5 = r.GetInt16(42);
                if (r[43] != DBNull.Value)
                    emp.professionId6 = r.GetInt16(43);
                if (r[44] != DBNull.Value)
                    emp.height = r.GetInt32(44);
                if (r[45] != DBNull.Value)
                    emp.clothingSize = r.GetInt32(45);
                if (r[46] != DBNull.Value)
                    emp.shoeSize = r.GetInt32(46);
                if (r[47] != DBNull.Value)
                    emp.meansOfProtectionByPosition = r.GetInt32(47);
                if (r[48] != DBNull.Value)
                    emp.clothingSizeTypeId = r.GetByte(48);
                if (r[49] != DBNull.Value)
                    emp.gender = r.GetString(49);

                /*
              string json = JsonConvert.SerializeObject(emp, Formatting.None, new JsonSerializerSettings
              {
                  NullValueHandling = NullValueHandling.Ignore
              });
              MessageBox.Show(json);
              */

                Employee emp2 = rest.saveEntity<Employee>(emp);

            }
            r.Close();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Done!");
        }

        void copyOrderTable()
        {
            string sql = "SELECT NППЗаказа, NЗаказаЗавода, NЗаказа, ГрафикN, ВидГрафика, ОснованиеЗаказа, ДатаПолученияЗаказа, ОбозначениеТО, КодТО, NИзделия, NДетали, Кол_во, ФКол_во, Заказчик, ПланДатаИзготовления, КодПриоритета, ПланТП, ДатаТП, ДатаПоступленияЦех, ФактДатаИзготовления, ПланТрудоемкость, ЦехИсполнитель, Отчет, ДатаОтчета, Технолог, Слесарь, СодержаниеЗаявки, ФактТрудоемкость, NНакладной, NАкта, СкладПолуч, НеодноврВыпЗак, Конструктор, p_unit, pause, OrderCards, Life, Lifeday, ObjectType, Quckly, MaterialDate, Запчасть, Стойкость, Доп_заказ, TNVED, PriceDate, PeoDate, OtizDate FROM Заказы";// where NППЗаказа=1";

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Order o = new Order();
                o.orderId = r.GetInt32(0);
                o.orderNumber = r.GetString(1);
                o.orderFullNumber = r.GetString(2);

                if (r[3] != DBNull.Value)
                    o.graphId = r.GetInt32(3);

                if (r[4] != DBNull.Value)
                    o.graphTypeId = r.GetByte(4);

                if (r[5] != DBNull.Value)
                    o.reasonOrder = r.GetByte(5);

                if (r[6] != DBNull.Value)
                    o.orderDate = r.GetDateTime(6);

                if (r[7] != DBNull.Value)
                    o.obozTo = r.GetString(7);

                if (r[8] != DBNull.Value)
                    o.kodTO = r.GetInt16(8);

                o.productNumber = r.GetString(9);

                o.partNumber = r.GetString(10);

                if (r[11] != DBNull.Value)
                    o.qty = r.GetInt32(11);

                if (r[12] != DBNull.Value)
                    o.realQty = r.GetInt32(12);

                if (r[13] != DBNull.Value)
                    o.customerId = r.GetInt32(13);

                if (r[14] != DBNull.Value)
                    o.planDate = r.GetDateTime(14);

                if (r[15] != DBNull.Value)
                    o.priorityId = r.GetByte(15);

                if (r[16] != DBNull.Value)
                    o.planTechDate = r.GetDateTime(16);

                if (r[17] != DBNull.Value)
                    o.techDate = r.GetDateTime(17);

                if (r[18] != DBNull.Value)
                    o.shopDate = r.GetDateTime(18);

                if (r[19] != DBNull.Value)
                    o.factReadyDate= r.GetDateTime(19);

                if (r[20] != DBNull.Value)
                   o.planLabourIntensity = r.GetDouble(20);

                if (r[21] != DBNull.Value)
                    o.performerShop = r.GetInt32(21);

                if (r[22] != DBNull.Value)
                    o.includeInReport = r.GetBoolean(22);

                if (r[23] != DBNull.Value)
                    o.reportDate = r.GetDateTime(23);

                if (r[24] != DBNull.Value)
                    o.technologistId = r.GetInt32(24);

                if (r[25] != DBNull.Value)
                    o.locksmithId = r.GetInt32(25);

                if (r[26] != DBNull.Value)
                    o.orderNote = r.GetString(26);

                if (r[27] != DBNull.Value)
                    o.factLabourIntensity = r.GetDouble(27);

                if (r[28] != DBNull.Value)
                    o.consignmentNote = r.GetString(28);

                if (r[29] != DBNull.Value)
                    o.actNumber = r.GetString(29);

                if (r[30] != DBNull.Value)
                    o.destinationStore = r.GetString(30);

                if (r[31] != DBNull.Value)
                    o.anotherTimeReady = r.GetBoolean(31);

                if (r[32] != DBNull.Value)
                    o.designerId = -1; //// !!!!!!!!!!!!  r.GetInt32(32);

                if (r[33] != DBNull.Value)
                    o.unitOfMeasureId = -1;/// r.GetInt32(33);

                if (r[34] != DBNull.Value)
                    o.stopped = r.GetBoolean(34);

                if (r[35] != DBNull.Value)
                    o.orderCard = r.GetInt32(35);

                if (r[36] != DBNull.Value)
                    o.serviceLifeYear = r.GetInt16(36);

                if (r[37] != DBNull.Value)
                    o.serviceLifeDay = r.GetInt32(37);

                if (r[38] != DBNull.Value)
                    o.objectType = r.GetByte(38);

                if (r[39] != DBNull.Value)
                    o.urgent = r.GetBoolean(39);

                if (r[40] != DBNull.Value)
                    o.materialDate = r.GetDateTime(40);

                if (r[41] != DBNull.Value)
                    o.spare= r.GetBoolean(41);

                if (r[42] != DBNull.Value)
                    o.resistance = r.GetInt32(42);

                if (r[43] != DBNull.Value)
                    o.additionalOrder = r.GetBoolean(43);

                if (r[44] != DBNull.Value)
                    o.classifier = r.GetDecimal(44).ToString();

                if (r[45] != DBNull.Value)
                    o.priceDate = r.GetDateTime(45);

                if (r[46] != DBNull.Value)
                    o.peoDate  = r.GetDateTime(46);

                if (r[47] != DBNull.Value)
                    o.otizDate = r.GetDateTime(47);
                /*

                string json = JsonConvert.SerializeObject(o, Formatting.None, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

    */

                Order o2 = rest.saveEntity<Order>(o);
                if (o2.orderId < 1)
                {
                    break; 
                }

//                MessageBox.Show(json);

            }

            r.Close();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Done!");

        }
    }
}
