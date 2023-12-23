using System.Windows.Forms;

namespace Belirsizlik_Altında_Karar_Verme
{
    public partial class Form1 : Form
    {

        public int nmbr;
        List<TextBox> productBoxes = new List<TextBox>();
        List<TextBox> situationBoxes = new List<TextBox>();
        DataGridView dataGridView = new DataGridView();
        DataGridViewRow row;
        DataGridViewColumn column;



        public Form1()
        {
            InitializeComponent();
            startModel.Hide();
            prodLabel.Hide();
            sttsnLabel.Hide();
            choiceBox.Text = "Kâr veya maliyet seçimi yapın";
            choiceBox.Hide();
            alphaValueBtn.Hide();
            hurwiczBtn.Hide();
            pessimistBtn.Hide();
            optimistBtn.Hide();
            equalProbBtn.Hide();
            regBtn.Hide();
        }

        private void createModel_Click(object sender, EventArgs e)
        {
            if (prodNmbr.Text != "" && sittnNmbr.Text != "")
            {
                if (int.TryParse(prodNmbr.Text, out nmbr) && int.TryParse(sittnNmbr.Text, out nmbr))
                {
                    startModel.Show();
                    for (int i = 0; i < Convert.ToInt32(prodNmbr.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Name = (i + 1).ToString() + ". Product";
                        textBox.PlaceholderText = (i + 1) + ". Karar "; 
                        textBox.Location = new System.Drawing.Point(462, 263 + (i * 33));
                        textBox.Size = new System.Drawing.Size(125, 27);

                        productBoxes.Add(textBox);




                    }
                    for (int i = 0; i < Convert.ToInt32(sittnNmbr.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Name = (i + 1).ToString() + ". Situation";
                        textBox.PlaceholderText = (i + 1) + ". Durum "; 
                        textBox.Location = new System.Drawing.Point(669, 263 + (i * 33));
                        textBox.Size = new System.Drawing.Size(125, 27);
                        situationBoxes.Add(textBox);




                    }
                    foreach (TextBox textBox in productBoxes)
                    {
                        // TextBox'ı Form'a ekle
                        tabPage1.Controls.Add(textBox);

                    }
                    foreach (TextBox textBox in situationBoxes)
                    {
                        
                        tabPage1.Controls.Add(textBox);

                    }

                    sttsnLabel.Show();
                    prodLabel.Show();
                    createModel.Hide();


                }
                else
                {
                    MessageBox.Show("Lütfen sayı girişi yapın.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }

        }


        private void startModel_Click(object sender, EventArgs e)
        {


            //Boşluk Kontrolü
            bool isEmpty = situationBoxes.Any(textBox => textBox.Text == "") || productBoxes.Any(textBox => textBox.Text == "");

            if (isEmpty != true)
            {
                startModel.Hide();
                choiceBox.Show();
                alphaValueBtn.Show();
                hurwiczBtn.Show();
                pessimistBtn.Show();
                optimistBtn.Show();
                equalProbBtn.Show();
                regBtn.Show();
                // DataGridView oluşturulması
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
                

                // DataGridView'e satır ve sütunların eklenmesi
                dataGridView.Columns.Add("Durum", "Ürün");
                foreach (TextBox sttn in situationBoxes)
                {
                    dataGridView.Columns.Add(sttn.Text, sttn.Text);
                }

                // DataGridView'e satırların eklenmesi
                foreach (TextBox prod in productBoxes)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView);
                    row.Cells[0].Value = prod.Text;
                    dataGridView.Rows.Add(row);
                }

                // Form'a DataGridView'in eklenmesi
                tabPage2.Controls.Add(dataGridView);
                tabControl1.SelectedTab = tabPage2;
                // Satır ve sütun ekleme engelleme
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AllowUserToResizeRows = false;
                dataGridView.AllowUserToResizeColumns = false;

                // Sütun başlıklarını ReadOnly yapma
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.ReadOnly = true;
                }

                // Her satırın ilk hücresini ReadOnly yapma
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells[0].ReadOnly = true;
                    }
                }

                // Diğer hücrelerin ReadOnly özelliğini kaldırma
                for (int i = 1; i < dataGridView.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Rows.Count; j++)
                    {
                        dataGridView.Rows[j].Cells[i].ReadOnly = false;
                    }
                }
            }


            else
            {
                MessageBox.Show("Lütfen ürünler veya durumlar kısmında boş alan bırakmayın.");
            }

        }
        //İyimserlik Hesaplama
        private void optimistBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.Text == "Kâr")
            {


                // En büyük değeri tutmak için bir değişken tanımla
                int maxCellValue = int.MinValue;
                string optimalChoice = "";

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();

                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);

                            // En büyük değeri güncelle
                            if (cellValue > maxCellValue)
                            {
                                maxCellValue = cellValue;
                                optimalChoice = choice;
                                
                                
                                
                            }
                        }
                    }
                }

                // En büyük değeri ve optimal seçimi göster
                MessageBox.Show(choiceBox.Text + " İyimserlik Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + maxCellValue.ToString());
            }
            else

            {
                // En büyük değeri tutmak için bir değişken tanımla
                int minCellValue = int.MaxValue;
                string optimalChoice = "";

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();

                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);

                            // En küçük değeri güncelle
                            if (cellValue < minCellValue)
                            {
                                minCellValue = cellValue;
                                optimalChoice = choice;
                            }
                        }
                    }
                }
                
                // En optimal seçimi gösteriyoruz
                MessageBox.Show(choiceBox.Text + " İyimserlik Ölçütü İçin En optimal seçim: "+" [ " + optimalChoice + " ] " + ", Değer: " + minCellValue.ToString());

            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        private void pessimistBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.Text == "Kâr")
            {

                // En küçük değeri tutmak için bir değişken tanımla
                
                int biggestRowValue = int.MinValue;
                string optimalChoice = "";

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    int minCellValue = int.MaxValue;
                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();
                    
                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);

                            // En küçük değeri güncelle
                            if (cellValue < minCellValue)
                            {
                                minCellValue = cellValue;
                                


                            }
                        }
                    }
                    if (minCellValue > biggestRowValue)
                    {
                        biggestRowValue = minCellValue;
                        optimalChoice = choice;

                    }



                }
                // En büyük değeri ve optimal seçimi göster
                MessageBox.Show(choiceBox.Text + " Kötümserlik Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + biggestRowValue.ToString());

            }

            else
            {


                // En küçük değeri tutmak için bir değişken tanımla

                int smallestRowValue = int.MaxValue;
                string optimalChoice = "";

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    int maxCellValue = int.MinValue;
                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();

                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);

                            // En küçük değeri güncelle
                            if (cellValue > maxCellValue)
                            {
                                maxCellValue = cellValue;



                            }
                        }
                    }
                    if (maxCellValue < smallestRowValue)
                    {
                        smallestRowValue = maxCellValue;
                        optimalChoice = choice;

                    }



                }
                // En büyük değeri ve optimal seçimi göster
                MessageBox.Show(choiceBox.Text + " Kötümserlik Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + smallestRowValue.ToString());

            }
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void hurwiczBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.Text == "Kâr")
            {
                
                string optimalChoice = "";
                double biggestHurwicsValue = double.MinValue;

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {


                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();
                    int maxCellValue = int.MinValue;
                    int minCellValue = int.MaxValue;
                    double hurwicsValue = double.MinValue;


                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {

                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);

                            // En küçük değeri güncelle
                            if (cellValue > maxCellValue)
                            {
                                maxCellValue = cellValue;

                            }
                            if (cellValue < minCellValue)
                            {
                                minCellValue = cellValue;
                            }
                        }
                        hurwicsValue = (maxCellValue * Convert.ToDouble(alphaValueBtn.Text)) + (minCellValue * (1 - Convert.ToDouble(alphaValueBtn.Text)));

                    }

                    if (hurwicsValue > biggestHurwicsValue)
                    {
                        optimalChoice = choice;
                        biggestHurwicsValue = hurwicsValue;
                    }




                }

                MessageBox.Show(choiceBox.Text + " Hurwics Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + biggestHurwicsValue.ToString());
            }

            else
            {
                
                string optimalChoice = "";
                double smallestHurwicsValue = double.MaxValue;

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {


                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();
                    int maxCellValue = int.MinValue;
                    int minCellValue = int.MaxValue;
                    double hurwicsValue = double.MaxValue;


                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {

                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);

                            // En küçük değeri güncelle
                            if (cellValue > maxCellValue)
                            {
                                maxCellValue = cellValue;

                            }
                            if (cellValue < minCellValue)
                            {
                                minCellValue = cellValue;
                            }
                        }
                        hurwicsValue = (minCellValue * Convert.ToDouble(alphaValueBtn.Text)) + (maxCellValue * (1 - Convert.ToDouble(alphaValueBtn.Text)));

                    }

                    if (hurwicsValue < smallestHurwicsValue)
                    {
                        optimalChoice = choice;
                        smallestHurwicsValue = hurwicsValue;
                    }




                }

                MessageBox.Show(choiceBox.Text + " Hurwics Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + smallestHurwicsValue.ToString());
            }


        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       

        private void equalProbBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.Text == "Kâr")
            {


                // En büyük değeri tutmak için bir değişken tanımla
                
                string optimalChoice = "";
                
                double biggestRow = double.MinValue;

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    double rowsum = 0;
                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();

                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            double cellValue = Convert.ToInt32(cell.Value);

                            rowsum += cellValue / (dataGridView.Columns.Count - 1);

                        }
                    }
                   
                    // En büyük değeri güncelle
                    if (rowsum > biggestRow)
                    {
                        biggestRow = rowsum;
                        optimalChoice = choice;
                    }

                }

                // En büyük değeri ve optimal seçimi göster
                MessageBox.Show(choiceBox.Text + " Eş Olasılık Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + biggestRow.ToString());
            }
            else
            {


                // En büyük değeri tutmak için bir değişken tanımla
                
                string optimalChoice = "";

                double smallestRow = double.MaxValue;

                // DataGridView'deki tüm satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    double rowsum = 0;
                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();

                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        if (cell.Value != null)
                        {
                            double cellValue = Convert.ToInt32(cell.Value);

                            rowsum += cellValue / (dataGridView.Columns.Count - 1);

                        }
                    }

                    // En büyük değeri güncelle
                    if (rowsum < smallestRow)
                    {
                        smallestRow = rowsum;
                        optimalChoice = choice;
                    }

                }

                // En büyük değeri ve optimal seçimi göster
                MessageBox.Show(choiceBox.Text + " Eş Olasılık Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + smallestRow.ToString());
            }
            
        }
       

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.Text == "Kâr")
            {
                string optimalChoice = "";
                int maxCell = int.MinValue;
                //Sütunları dolaş
                for (int columnIndex = 1; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    DataGridViewColumn column = dataGridView.Columns[columnIndex];
                    int maxValue = int.MinValue;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        DataGridViewCell cell = row.Cells[column.Index];
                        int cellValue = Convert.ToInt32(cell.Value);

                        if (cellValue > maxValue)
                        {
                            maxValue = cellValue;
                        }
                    }
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        DataGridViewCell cell = row.Cells[column.Index];
                        cell.Value = Math.Abs(Convert.ToInt32(cell.Value) - maxValue);
                        //Mutlak değerde işlem yapmamızı sağladı

                    }
                }
                //Satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    int minCell = int.MaxValue;

                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();


                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        ;
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);
                            if (cellValue < minCell)
                            {
                                minCell = cellValue;
                            }


                        }
                    }
                    if (maxCell < minCell)
                    {
                        maxCell = minCell;
                        optimalChoice = choice;
                    }
                }
                MessageBox.Show(choiceBox.Text+" Pişmanlık Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + maxCell.ToString());
            }

            else
            {
                string optimalChoice = "";
                int minCell = int.MaxValue;
                //Sütunları dolaş
                for (int columnIndex = 1; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    DataGridViewColumn column = dataGridView.Columns[columnIndex];
                    int minValue = int.MaxValue;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        DataGridViewCell cell = row.Cells[column.Index];
                        int cellValue = Convert.ToInt32(cell.Value);

                        if (cellValue < minValue)
                        {
                            minValue = cellValue;
                        }
                    }
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        DataGridViewCell cell = row.Cells[column.Index];
                        cell.Value = Math.Abs(Convert.ToInt32(cell.Value) - minValue);
                        //Mutlak değerde işlem yapmamızı sağladı

                    }
                }
                //Satırları dolaş
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    int maxCell = int.MinValue;

                    // Satırın ilk hücresinin değeri
                    DataGridViewCell firstCell = row.Cells[0];
                    string choice = firstCell.Value.ToString();


                    // Satırın hücrelerini dolaş
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        // Hücrenin değeri
                        DataGridViewCell cell = row.Cells[i];
                        ;
                        if (cell.Value != null)
                        {
                            int cellValue = Convert.ToInt32(cell.Value);
                            if (cellValue > maxCell)
                            {
                                maxCell = cellValue;
                            }


                        }
                    }
                    if (maxCell < minCell)
                    {
                        minCell = maxCell;
                        optimalChoice = choice;
                    }
                }
                MessageBox.Show(choiceBox.Text + " Pişmanlık Ölçütü İçin En optimal seçim: " + " [ " + optimalChoice + " ] " + ", Değer: " + minCell.ToString());
            }


        }

        
    }
}