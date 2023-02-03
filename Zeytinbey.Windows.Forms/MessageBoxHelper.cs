namespace Zeytinbey.Windows.Forms;

public static class MessageBoxHelper
{
    public static bool ShowConfirmation(string text, bool isYesDefault = false)
    {
        var defaultButton = isYesDefault ? MessageBoxDefaultButton.Button1 : MessageBoxDefaultButton.Button2;
        text = $@"{text}{Environment.NewLine}{Environment.NewLine}Are you sure?";

        var dialogResult = MessageBox.Show(text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);

        return dialogResult == DialogResult.Yes;
    }

    public static void ShowError(string text)
    {
        MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void ShowInfo(string text)
    {
        MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void Show(string text)
    {
        MessageBox.Show(text);
    }

    public static void Show(string text, string caption)
    {
        MessageBox.Show(text, caption);
    }

    public static void Show(string text, string caption, MessageBoxButtons buttons)
    {
        MessageBox.Show(text, caption, buttons);
    }

    public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
        MessageBox.Show(text, caption, buttons, icon);
    }

    public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
    {
        MessageBox.Show(text, caption, buttons, icon, defaultButton);
    }

    public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
    {
        MessageBox.Show(text, caption, buttons, icon, defaultButton, options);
    }

    public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton)
    {
        MessageBox.Show(text, caption, buttons, icon, defaultButton, options, displayHelpButton);
    }
}