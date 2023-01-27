namespace Zeytinbey.Windows.Forms;

public static class MessageBoxHelper
{
    public static bool ShowConfirmation(string message, bool isYesDefault = false)
    {
        var defaultButton = isYesDefault ? MessageBoxDefaultButton.Button1 : MessageBoxDefaultButton.Button2;
        message = $@"{message}{Environment.NewLine}{Environment.NewLine}Are you sure?";

        var dialogResult = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);

        return dialogResult == DialogResult.Yes;
    }

    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void ShowInfo(string message)
    {
        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}