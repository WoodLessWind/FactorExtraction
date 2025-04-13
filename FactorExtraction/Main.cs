using OfficeOpenXml;
using Newtonsoft.Json;
namespace FactorExtraction
{
    public partial class FactorExtraction : Form
    {
        public string[,] bugFactorDataArray;
        public string[,] bugFactorIntroduceDataArray;
        public string[,] robotFactorDataArray;
        public string[,] robotFactorIntroduceDataArray;
        //public string[,] squidFactorDataArray;
        //public string[,] squidFactorIntroduceDataArray;
        bool unloadFactor = true;
        int chooseMode;
        int conventionMax = 1;
        int additionalMax = 3;
        int hellMax = 1;
        public FactorExtraction()
        {
            InitializeComponent();
            //����������ر�������
            bugFactorDataArray=LoadData(bugFactorDataArray, "bugFactorDataArray");
            bugFactorIntroduceDataArray=LoadData(bugFactorIntroduceDataArray, "bugFactorDataArray");
            robotFactorDataArray=LoadData(robotFactorDataArray, "robotFactorDataArray");
            robotFactorIntroduceDataArray=LoadData(robotFactorIntroduceDataArray, "robotFactorIntroduceDataArray");
            //squidFactorDataArray=LoadData(squidFactorDataArray,"squidFactorDataArray");
            //squidFactorIntroduceDataArray=LoadData(squidFactorIntroduceDataArray,"squidFactorIntroduceDataArray");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ChooseModeBox.SelectedIndex = 2;
            ChooseEnemyBox.SelectedIndex = 0;
            SetupDoubleClickTransfer(ConventionExtraction, ConventionSelect, conventionMax);
            SetupDoubleClickTransfer(AdditionalExtraction, AdditionalSelect, additionalMax);
            SetupDoubleClickTransfer(HellExtraction, HellSelect, hellMax);
            SetupDoubleClickDelete(ConventionSelect);
            SetupDoubleClickDelete(AdditionalSelect);
            SetupDoubleClickDelete(HellSelect);
        }
        private void ExtractionButton_Click(object sender, EventArgs e)
        {
            if (unloadFactor)
            {
                MessageBox.Show($"������������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            chooseMode = ChooseModeBox.SelectedIndex;
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    PopulateColumns(bugFactorDataArray, 3, 0);
                    PopulateColumns(bugFactorDataArray, 5, 1);
                    if (chooseMode != 0)
                        PopulateColumns(bugFactorDataArray, 3, 2);
                    break;
                case 1:
                    PopulateColumns(robotFactorDataArray, 3, 0);
                    PopulateColumns(robotFactorDataArray, 5, 1);
                    if (chooseMode != 0)
                        PopulateColumns(robotFactorDataArray, 3, 2);
                    break;
                case 2:
                    //PopulateColumns(squidFactorDataArray, 3, 0);
                    //PopulateColumns(squidFactorDataArray, 5, 1);
                    //if (chooseMode != 0)
                    //    PopulateColumns(squidFactorDataArray, 3, 2);
                    MessageBox.Show($"������δ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }


        }
        private void AddFactorToApp_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel �ļ�|*.xlsx;*.xls",
                Title = "ѡ�� Excel �ļ�"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[,] bugDataArray;
                string[,] robotDataArray;
                string[,] squidDataArray;
                // ��ȡ Excel ����ά����
                robotDataArray = LoadExcelToArray(openFileDialog.FileName, 0);
                bugDataArray = LoadExcelToArray(openFileDialog.FileName, 1);
                //squidDataArray = LoadExcelToArray(openFileDialog.FileName, 2);
                (robotFactorDataArray, robotFactorIntroduceDataArray) = SplitArrayByColon(robotDataArray);
                (bugFactorDataArray, bugFactorIntroduceDataArray) = SplitArrayByColon(bugDataArray);
                //(squidFactorDataArray, squidFactorIntroduceDataArray) = SplitArrayByColon(squidDataArray);
                unloadFactor = false;
            }
            loadContex.Text = "";//�����ʾ����
        }
        private void ConventionExtraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    UpdateFactorIntroductionLabel(ConventionExtraction, bugFactorDataArray, bugFactorIntroduceDataArray);
                    break;
                case 1:
                    UpdateFactorIntroductionLabel(ConventionExtraction, robotFactorDataArray, robotFactorIntroduceDataArray);
                    break;
                //case 2:
                //UpdateFactorIntroductionLabel(ConventionExtraction, squidFactorDataArray, squidFactorIntroduceDataArray);
                //break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }
        private void AdditionalExtraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    UpdateFactorIntroductionLabel(AdditionalExtraction, bugFactorDataArray, bugFactorIntroduceDataArray);
                    break;
                case 1:
                    UpdateFactorIntroductionLabel(AdditionalExtraction, robotFactorDataArray, robotFactorIntroduceDataArray);
                    break;
                //case 2:
                //UpdateFactorIntroductionLabel(AdditionalExtraction, squidFactorDataArray, squidFactorIntroduceDataArray);
                //break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void HellExtraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    UpdateFactorIntroductionLabel(HellExtraction, bugFactorDataArray, bugFactorIntroduceDataArray);
                    break;
                case 1:
                    UpdateFactorIntroductionLabel(HellExtraction, robotFactorDataArray, robotFactorIntroduceDataArray);
                    break;
                //case 2:
                //UpdateFactorIntroductionLabel(HellExtraction, squidFactorDataArray, squidFactorIntroduceDataArray);
                //break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void ConventionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    UpdateFactorIntroductionLabel(ConventionSelect, bugFactorDataArray, bugFactorIntroduceDataArray);
                    break;
                case 1:
                    UpdateFactorIntroductionLabel(ConventionSelect, robotFactorDataArray, robotFactorIntroduceDataArray);
                    break;
                //case 2:
                //UpdateFactorIntroductionLabel(ConventionSelect, squidFactorDataArray, squidFactorIntroduceDataArray);
                //break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void AdditionalSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    UpdateFactorIntroductionLabel(AdditionalSelect, bugFactorDataArray, bugFactorIntroduceDataArray);
                    break;
                case 1:
                    UpdateFactorIntroductionLabel(AdditionalSelect, robotFactorDataArray, robotFactorIntroduceDataArray);
                    break;
                //case 2:
                //UpdateFactorIntroductionLabel(AdditionalSelect, squidFactorDataArray, squidFactorIntroduceDataArray);
                //break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void HellSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseEnemyBox.SelectedIndex)
            {
                case 0:
                    UpdateFactorIntroductionLabel(HellSelect, bugFactorDataArray, bugFactorIntroduceDataArray);
                    break;
                case 1:
                    UpdateFactorIntroductionLabel(HellSelect, robotFactorDataArray, robotFactorIntroduceDataArray);
                    break;
                //case 2:
                //UpdateFactorIntroductionLabel(HellSelect, squidFactorDataArray, squidFactorIntroduceDataArray);
                //break;
                default:
                    MessageBox.Show($"����δѡ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void ChooseModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseModeBox.SelectedIndex)
            {
                case 0:
                    AdditionalSelect.Size = new Size(213, 64);
                    additionalMax = 2;
                    HellFactorLabelSelect.Enabled = false;
                    HellSelect.Enabled = false;
                    HellExtraction.Items.Clear();
                    break;
                case 1:
                    AdditionalSelect.Size = new Size(213, 64);
                    additionalMax = 2;
                    HellFactorLabelSelect.Enabled = true;
                    HellSelect.Enabled = true;
                    break;
                case 2:
                    AdditionalSelect.Size = new Size(213, 94);
                    additionalMax = 3;
                    HellFactorLabelSelect.Enabled = true;
                    HellSelect.Enabled = true;
                    break;
                default:
                    MessageBox.Show($"���󣺴����ģʽ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void SelectReset_Click(object sender, EventArgs e)
        {
            ConventionExtraction.Items.Clear();
            AdditionalExtraction.Items.Clear();
            HellExtraction.Items.Clear();
            FactorIntroduction.Text = null;
        }
        private void DecideReset_Click(object sender, EventArgs e)
        {
            ConventionSelect.Items.Clear();
            AdditionalSelect.Items.Clear();
            HellSelect.Items.Clear();
        }
        private void ShowFactor_Click(object sender, EventArgs e)
        {
            switch (ChooseModeBox.SelectedIndex)
            {
                case 0:
                    if (ConventionSelect.Items.Count==1&& AdditionalSelect.Items.Count==2)
                    {

                    }
                    break;
                default:
                    break;
            }
            SelectFactor.ShowOrOpen();
        }
        private void FactorExtraction_FormClosing(object sender, FormClosingEventArgs e)
        {   //�˳����򱣴�����
            DataManager.SaveArrayToFile(bugFactorDataArray, "bugFactorDataArray");
            DataManager.SaveArrayToFile(bugFactorIntroduceDataArray, "bugFactorIntroduceDataArray");
            DataManager.SaveArrayToFile(robotFactorDataArray, "robotFactorDataArray");
            DataManager.SaveArrayToFile(robotFactorIntroduceDataArray, "robotFactorIntroduceDataArray");
            //DataManager.SaveArrayToFile(squidFactorDataArray,"squidFactorDataArray");
            //DataManager.SaveArrayToFile(squidFactorIntroduceDataArray,"squidFactorIntroduceDataArray");
        }




        public void UpdateFactorIntroductionLabel(ListBox listBox, String[,] factors, String[,] Intros)
        {
            if (listBox.SelectedIndex == -1)
            {
                return;
            }
            string? selectedName = listBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedName))
            {
                bool found = false;
                // ������ά�������ƥ����
                for (int i = 0; i < factors.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < factors.GetLength(1); j++)
                    {
                        // ��鵱ǰ�еĵ�һ�У������У��Ƿ�ƥ��
                        if (factors[i, j]?.Equals(selectedName, StringComparison.OrdinalIgnoreCase) == true)
                        {
                            // ƥ��ɹ�����ȡ�ڶ��У������У���ֵ
                            FactorIntroduction.Text = Intros[i, j]?.ToString() ?? "����Ϊ��";
                            found = true;
                            return;
                        }
                    }
                }

                if (!found)
                {
                    FactorIntroduction.Text = "δ�ҵ���ؽ���";
                }
            }
        }
        private void PopulateColumns(string[,] data, int elementsPerColumn, int targetCol)
        {
            try
            {
                Random random = new Random();

                // ��֤��ά����ά��
                if (data.GetLength(1) < 3)
                    throw new ArgumentException("��ά��������������3��");
                // ��ȡ�����˿�Ԫ��
                List<string> columnData = new List<string>();
                for (int row = 0; row < data.GetLength(0); row++)
                {
                    string value = data[row, targetCol];

                    // ���˿�ֵ������null�Ϳ��ַ�����
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        columnData.Add(value);
                    }

                }
                // ��ѡ��ģʽΪ0ʱ���Ƴ��ض�Ԫ��
                if (ChooseModeBox.SelectedIndex == 0)
                {
                    var itemsToRemove = new HashSet<string> { "��ʽת��", "����ϸѡ", "Ȩ�޸���" };
                    columnData.RemoveAll(item => itemsToRemove.Contains(item));
                }
                // ��֤��ȡ������Ч��
                if (elementsPerColumn > columnData.Count)
                    throw new InvalidOperationException(
                        $"��{targetCol + 1}��Ԫ���������㣬��Ҫ{elementsPerColumn}����ʵ��ֻ��{columnData.Count}��");

                // Fisher-Yatesϴ���㷨���޷Żس�����
                Shuffle(columnData, random);

                // ��ȡǰN��Ԫ��
                List<String> selectedItems = columnData.GetRange(0, elementsPerColumn);

                // ���¶�Ӧ�б�ؼ�
                UpdateListBox(targetCol, selectedItems);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"����{ex.Message}", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string[,] LoadExcelToArray(string filePath, int enemyIndex)
        {

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[enemyIndex];
                int rowCount = worksheet.Dimension.End.Row;
                int colCount = worksheet.Dimension.End.Column;

                // ��ʼ����ά����
                string[,] dataArray = new string[rowCount, colCount];

                // ������ݣ��ӵ�һ�е�һ�п�ʼ��
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        // ��ȡ��Ԫ��ֵ���Զ�����յ�Ԫ��
                        var cellValue = worksheet.Cells[row, col].Text;
                        dataArray[row - 1, col - 1] = cellValue; // ����������0��ʼ
                    }
                }

                return dataArray;
            }
        }
        private static (string[,], string[,]) SplitArrayByColon(string[,] originalArray)
        {
            // �������������Ч��
            if (originalArray == null)
                throw new ArgumentNullException(nameof(originalArray), "�������鲻��Ϊ null");

            int rows = originalArray.GetLength(0);
            int cols = originalArray.GetLength(1);

            // ���������Ч��
            if (rows <= 0)
                throw new ArgumentException("ԭ��������������һ������", nameof(originalArray));

            // ��ʼ����ά����������ע��ʹ�ö�ά�������ͣ�
            string[,] arrayPart1 = new string[rows - 1, cols];
            string[,] arrayPart2 = new string[rows - 1, cols];

            int targetRowIndex = 0; // Ŀ���ά�����������

            for (int i = 1; i < rows; i++) // ��������
            {
                for (int j = 0; j < cols; j++)
                {
                    string original = originalArray[i, j];
                    if (string.IsNullOrWhiteSpace(original))
                        continue; // ����nullֵ


                    // �滻���ķֺ�ΪӢ�ķֺ�
                    string modified = original.Replace('��', ':');

                    // ��Ӣ�ķֺŷָע��ʹ��һά������ս����
                    string[] parts = modified.Split(':', StringSplitOptions.None);

                    // ��֤�ָ���
                    if (parts.Length != 2)
                        MessageBox.Show($"�������ݲ����ϸ�ʽ", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // �洢����ά���飨ע��ʹ�ö�ά������
                    arrayPart1[targetRowIndex, j] = parts[0].Trim();
                    arrayPart2[targetRowIndex, j] = parts[1].Trim();
                }
                targetRowIndex++;
            }

            return (arrayPart1, arrayPart2);
        }
        private void Shuffle<T>(IList<T> list, Random random)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
        private void UpdateListBox(int columnIndex, List<String> items)
        {
            object[] objectItems = items.Cast<object>().ToArray();
            switch (columnIndex)
            {
                case 0:
                    ConventionExtraction.Items.Clear();
                    ConventionExtraction.Items.AddRange(objectItems);
                    break;
                case 1:
                    AdditionalExtraction.Items.Clear();
                    AdditionalExtraction.Items.AddRange(objectItems);
                    break;
                case 2:
                    HellExtraction.Items.Clear();
                    HellExtraction.Items.AddRange(objectItems);
                    break;
            }
        }
        private void SetupDoubleClickTransfer(ListBox sourceListBox, ListBox targetListBox, int maxItems)
        {
            // ����ԴListBox��˫���¼�
            sourceListBox.MouseDoubleClick += (sender, e) =>
            {
                // ��֤�Ƿ����˫��
                if (e.Button != MouseButtons.Left || e.Clicks != 2)
                    return;

                // ��ȡѡ�е���Ŀ
                if (sourceListBox.SelectedItem == null)
                    return;
                // ����Ƿ��Ѵ���
                if (targetListBox.Items.Contains(sourceListBox.SelectedItem.ToString()))
                {
                    return;
                }
                // �������
                if (targetListBox.Items.Count == maxItems)
                {
                    // ��ѡ���Զ��Ƴ���ɵķ��ظ���
                    for (int i = 0; i < maxItems; i++)
                    {
                        if (!targetListBox.Items[i].ToString().Contains(sourceListBox.SelectedItem.ToString()))
                        {
                            targetListBox.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
                // ��ӵ�Ŀ��ListBox
                targetListBox.Items.Add(sourceListBox.SelectedItem);
            };
        }
        private void SetupDoubleClickDelete(ListBox sourceListBox)
        {
            //ConventionSelect.SelectedIndexChanged -= ConventionSelect_SelectedIndexChanged;
            //AdditionalSelect.SelectedIndexChanged -= AdditionalSelect_SelectedIndexChanged;
            //HellSelect.SelectedIndexChanged -= HellSelect_SelectedIndexChanged;
            // ����ԴListBox��˫���¼�
            sourceListBox.MouseDoubleClick += (sender, e) =>
            {
                // ��֤�Ƿ����˫��
                if (e.Button != MouseButtons.Left || e.Clicks != 2)
                    return;

                // ��ȡѡ�е���Ŀ
                if (sourceListBox.SelectedItem == null)
                    return;
                // ��ӵ�Ŀ��ListBox

                sourceListBox.Items.Remove(sourceListBox.SelectedItem);
                //ConventionSelect.SelectedIndexChanged += ConventionSelect_SelectedIndexChanged;
                //AdditionalSelect.SelectedIndexChanged += AdditionalSelect_SelectedIndexChanged;
                //HellSelect.SelectedIndexChanged += HellSelect_SelectedIndexChanged;
            };
        }
        private String[,]? LoadData(String[,] dataArray,String ArrayName)
        {
            // ���Դ��ļ�����
            dataArray = DataManager.LoadArrayFromFile(ArrayName);
            unloadFactor = false;
            if (dataArray == null)
            {
                // �ļ������ڻ����ʧ�ܣ���ʾ��ʾ
                loadContex.Text = "��������������ļ�";
                unloadFactor = true;
                return null;
            }
            return dataArray;
        }


    }
    public class DataManager
    {
        private static string GetDataFilePath(String fileName)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appName = "FactorExtraction";
            string dataDir = Path.Combine(appDataPath, appName);
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);
            return Path.Combine(dataDir, fileName);
        }

        // �����ά���鵽�ļ�
        public static void SaveArrayToFile(string[,] array,String fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(array);
                File.WriteAllText(GetDataFilePath(fileName), json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����ʧ��: {ex.Message}");
            }
        }

        // ���ļ����ض�ά����
        public static string[,] LoadArrayFromFile(String fileName)
        {
            try
            {
                string filePath = GetDataFilePath(fileName);
                if (!File.Exists(filePath))
                    return null;

                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<string[,]>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����ʧ��,�����µ�������: {ex.Message}");
                return null;
            }
        }
    }

}
