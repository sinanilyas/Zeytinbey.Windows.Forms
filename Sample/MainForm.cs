using Zeytinbey.Windows.Forms;
using Zeytinbey.Windows.Forms.Turkish;

namespace Sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MesajKutusuButton_Click(object sender, EventArgs e)
        {
            MesajKutusu.BilgiGoster("Ba�ar�l�.");
            MesajKutusu.HataGoster("Ba�ar�s�z.");

            var onaylandiMi = MesajKutusu.OnayIste("Kay�t silinecektir.");
            if (onaylandiMi) MesajKutusu.BilgiGoster("Kay�t silindi.");
        }

        private void MessageBoxHelperButton_Click(object sender, EventArgs e)
        {
            MessageBoxHelper.ShowInfo("Success.");
            MessageBoxHelper.ShowError("Failed.");

            var isConfirmed = MessageBoxHelper.ShowConfirmation("Record will be deleted.");
            if (isConfirmed) MessageBoxHelper.ShowInfo("Record deleted.");

            MessageBoxHelper.Show("Message.");
            MessageBoxHelper.Show("Message.", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        }
    }
}