
namespace FactorExtraction
{
    public partial class SelectFactor : Form
    {
        public static SelectFactor Instance { get; private set; }
        private SelectFactor() => InitializeComponent();
        public static void ShowOrOpen(int selectedIndex)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new SelectFactor();
            }
            Instance.SetLabel();
            Instance.SetIntroLabel();
            Instance.Show();
            Instance.BringToFront();
        }
        private void SetLabel()
        {
            ConventionFactorLabel.Text = FactorExtraction.factorLabel[0] ?? "";
            AdditionalFactorLabel1.Text = FactorExtraction.factorLabel[1] ?? "";
            AdditionalFactorLabel2.Text = FactorExtraction.factorLabel[2] ?? "";
            AdditionalFactorLabel3.Text = FactorExtraction.factorLabel[3] ?? "";
            HellFactorLabel.Text = FactorExtraction.factorLabel[4] ?? "";
        }
        private void SetIntroLabel()
        {
            ConventionFactorIntroduction.Text = FactorExtraction.UpdateFactorIntroductionLabel(FactorExtraction.bugFactorDataArray, FactorExtraction.bugFactorIntroduceDataArray, ConventionFactorLabel);
            AdditionalFactorIntroduction1.Text = FactorExtraction.UpdateFactorIntroductionLabel(FactorExtraction.bugFactorDataArray, FactorExtraction.bugFactorIntroduceDataArray, AdditionalFactorLabel1);
            AdditionalFactorIntroduction2.Text = FactorExtraction.UpdateFactorIntroductionLabel(FactorExtraction.bugFactorDataArray, FactorExtraction.bugFactorIntroduceDataArray, AdditionalFactorLabel2);
            AdditionalFactorIntroduction3.Text = FactorExtraction.UpdateFactorIntroductionLabel(FactorExtraction.bugFactorDataArray, FactorExtraction.bugFactorIntroduceDataArray, AdditionalFactorLabel3);
            HellFactorIntroduction.Text = FactorExtraction.UpdateFactorIntroductionLabel(FactorExtraction.bugFactorDataArray, FactorExtraction.bugFactorIntroduceDataArray, HellFactorLabel);
        }
    }
}
