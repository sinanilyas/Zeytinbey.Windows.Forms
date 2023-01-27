namespace Zeytinbey.Windows.Forms.Turkish;

public static class MesajKutusu
{
    public static bool OnayIste(string mesaj, bool evetDugmesiVarsayilanMi = false)
    {
        var varsayilanDugme = evetDugmesiVarsayilanMi ? MessageBoxDefaultButton.Button1 : MessageBoxDefaultButton.Button2;
        mesaj = $@"{mesaj}{Environment.NewLine}{Environment.NewLine}Devam etmek istiyor musunuz?";

        var cevap = MessageBox.Show(mesaj, @"Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, varsayilanDugme);

        return cevap == DialogResult.Yes;
    }

    public static void HataGoster(string mesaj)
    {
        MessageBox.Show(mesaj, @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void BilgiGoster(string mesaj)
    {
        MessageBox.Show(mesaj, @"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}