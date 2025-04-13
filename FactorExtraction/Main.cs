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
            //启动程序加载保存因子
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
                MessageBox.Show($"请先载入因子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"光能暂未开放", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }


        }
        private void AddFactorToApp_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel 文件|*.xlsx;*.xls",
                Title = "选择 Excel 文件"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[,] bugDataArray;
                string[,] robotDataArray;
                string[,] squidDataArray;
                // 读取 Excel 到二维数组
                robotDataArray = LoadExcelToArray(openFileDialog.FileName, 0);
                bugDataArray = LoadExcelToArray(openFileDialog.FileName, 1);
                //squidDataArray = LoadExcelToArray(openFileDialog.FileName, 2);
                (robotFactorDataArray, robotFactorIntroduceDataArray) = SplitArrayByColon(robotDataArray);
                (bugFactorDataArray, bugFactorIntroduceDataArray) = SplitArrayByColon(bugDataArray);
                //(squidFactorDataArray, squidFactorIntroduceDataArray) = SplitArrayByColon(squidDataArray);
                unloadFactor = false;
            }
            loadContex.Text = "";//清除提示文字
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
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"错误：未选择敌人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"错误：错误的模式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        {   //退出程序保存因子
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
                // 遍历二维数组查找匹配项
                for (int i = 0; i < factors.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < factors.GetLength(1); j++)
                    {
                        // 检查当前行的第一列（名字列）是否匹配
                        if (factors[i, j]?.Equals(selectedName, StringComparison.OrdinalIgnoreCase) == true)
                        {
                            // 匹配成功，获取第二列（介绍列）的值
                            FactorIntroduction.Text = Intros[i, j]?.ToString() ?? "介绍为空";
                            found = true;
                            return;
                        }
                    }
                }

                if (!found)
                {
                    FactorIntroduction.Text = "未找到相关介绍";
                }
            }
        }
        private void PopulateColumns(string[,] data, int elementsPerColumn, int targetCol)
        {
            try
            {
                Random random = new Random();

                // 验证二维数组维度
                if (data.GetLength(1) < 3)
                    throw new ArgumentException("二维数组必须包含至少3列");
                // 提取并过滤空元素
                List<string> columnData = new List<string>();
                for (int row = 0; row < data.GetLength(0); row++)
                {
                    string value = data[row, targetCol];

                    // 过滤空值（包括null和空字符串）
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        columnData.Add(value);
                    }

                }
                // 当选择模式为0时，移除特定元素
                if (ChooseModeBox.SelectedIndex == 0)
                {
                    var itemsToRemove = new HashSet<string> { "花式转盘", "精挑细选", "权限覆盖" };
                    columnData.RemoveAll(item => itemsToRemove.Contains(item));
                }
                // 验证抽取数量有效性
                if (elementsPerColumn > columnData.Count)
                    throw new InvalidOperationException(
                        $"第{targetCol + 1}列元素数量不足，需要{elementsPerColumn}个，实际只有{columnData.Count}个");

                // Fisher-Yates洗牌算法（无放回抽样）
                Shuffle(columnData, random);

                // 获取前N个元素
                List<String> selectedItems = columnData.GetRange(0, elementsPerColumn);

                // 更新对应列表控件
                UpdateListBox(targetCol, selectedItems);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"错误：{ex.Message}", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // 初始化二维数组
                string[,] dataArray = new string[rowCount, colCount];

                // 填充数据（从第一行第一列开始）
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        // 获取单元格值（自动处理空单元格）
                        var cellValue = worksheet.Cells[row, col].Text;
                        dataArray[row - 1, col - 1] = cellValue; // 数组索引从0开始
                    }
                }

                return dataArray;
            }
        }
        private static (string[,], string[,]) SplitArrayByColon(string[,] originalArray)
        {
            // 检查输入数组有效性
            if (originalArray == null)
                throw new ArgumentNullException(nameof(originalArray), "输入数组不能为 null");

            int rows = originalArray.GetLength(0);
            int cols = originalArray.GetLength(1);

            // 检查行数有效性
            if (rows <= 0)
                throw new ArgumentException("原数组必须包含至少一行数据", nameof(originalArray));

            // 初始化二维数组容器（注意使用二维数组类型）
            string[,] arrayPart1 = new string[rows - 1, cols];
            string[,] arrayPart2 = new string[rows - 1, cols];

            int targetRowIndex = 0; // 目标二维数组的行索引

            for (int i = 1; i < rows; i++) // 跳过首行
            {
                for (int j = 0; j < cols; j++)
                {
                    string original = originalArray[i, j];
                    if (string.IsNullOrWhiteSpace(original))
                        continue; // 保持null值


                    // 替换中文分号为英文分号
                    string modified = original.Replace('：', ':');

                    // 按英文分号分割（注意使用一维数组接收结果）
                    string[] parts = modified.Split(':', StringSplitOptions.None);

                    // 验证分割结果
                    if (parts.Length != 2)
                        MessageBox.Show($"部分数据不符合格式", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // 存储到二维数组（注意使用二维索引）
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
            // 订阅源ListBox的双击事件
            sourceListBox.MouseDoubleClick += (sender, e) =>
            {
                // 验证是否左键双击
                if (e.Button != MouseButtons.Left || e.Clicks != 2)
                    return;

                // 获取选中的项目
                if (sourceListBox.SelectedItem == null)
                    return;
                // 检查是否已存在
                if (targetListBox.Items.Contains(sourceListBox.SelectedItem.ToString()))
                {
                    return;
                }
                // 检查容量
                if (targetListBox.Items.Count == maxItems)
                {
                    // 可选：自动移除最旧的非重复项
                    for (int i = 0; i < maxItems; i++)
                    {
                        if (!targetListBox.Items[i].ToString().Contains(sourceListBox.SelectedItem.ToString()))
                        {
                            targetListBox.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
                // 添加到目标ListBox
                targetListBox.Items.Add(sourceListBox.SelectedItem);
            };
        }
        private void SetupDoubleClickDelete(ListBox sourceListBox)
        {
            //ConventionSelect.SelectedIndexChanged -= ConventionSelect_SelectedIndexChanged;
            //AdditionalSelect.SelectedIndexChanged -= AdditionalSelect_SelectedIndexChanged;
            //HellSelect.SelectedIndexChanged -= HellSelect_SelectedIndexChanged;
            // 订阅源ListBox的双击事件
            sourceListBox.MouseDoubleClick += (sender, e) =>
            {
                // 验证是否左键双击
                if (e.Button != MouseButtons.Left || e.Clicks != 2)
                    return;

                // 获取选中的项目
                if (sourceListBox.SelectedItem == null)
                    return;
                // 添加到目标ListBox

                sourceListBox.Items.Remove(sourceListBox.SelectedItem);
                //ConventionSelect.SelectedIndexChanged += ConventionSelect_SelectedIndexChanged;
                //AdditionalSelect.SelectedIndexChanged += AdditionalSelect_SelectedIndexChanged;
                //HellSelect.SelectedIndexChanged += HellSelect_SelectedIndexChanged;
            };
        }
        private String[,]? LoadData(String[,] dataArray,String ArrayName)
        {
            // 尝试从文件加载
            dataArray = DataManager.LoadArrayFromFile(ArrayName);
            unloadFactor = false;
            if (dataArray == null)
            {
                // 文件不存在或加载失败，显示提示
                loadContex.Text = "←点击加载因子文件";
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

        // 保存二维数组到文件
        public static void SaveArrayToFile(string[,] array,String fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(array);
                File.WriteAllText(GetDataFilePath(fileName), json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败: {ex.Message}");
            }
        }

        // 从文件加载二维数组
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
                MessageBox.Show($"加载失败,请重新导入因子: {ex.Message}");
                return null;
            }
        }
    }

}
