namespace VX.PwdGen;

public partial class PwdGenForm : Form
{

    pwdgen generator;

    public PwdGenForm()
    {
        InitializeComponent();
        generator = new pwdgen();
    }

    private void bt_generate_Click(object sender, EventArgs e) => tb_password.Text = generator.Generate((int)nud_length.Value);

    private void bt_save_Click(object sender, EventArgs e)
    {
        if ("" == tb_password.Text)
        {
            MessageBox.Show("Нечего сохранять!");
            return;
        }
        var dialog = new SaveFileDialog();
        if (dialog.ShowDialog() != DialogResult.OK) return;
        using (var sw = new StreamWriter(dialog.FileName))
            sw.WriteLine($"{tb_password.Text}\t{DateTime.Now}");
    }

    private void bt_exit_Click(object sender, EventArgs e) => Close();

    private void cb_mode_CheckedChanged(object sender, EventArgs e)
    {
        var cb = sender as CheckBox;
        pwdgenModes flag = 0;
        if (cb == cb_upperRussian) flag = pwdgenModes.UpperRussian;
        if (cb == cb_lowerRussian) flag = pwdgenModes.LowerRussian;
        if (cb == cb_upperEnglish) flag = pwdgenModes.UpperEnglish;
        if (cb == cb_lowerEnglish) flag = pwdgenModes.LowerEnglish;
        if (cb == cb_numbers) flag = pwdgenModes.Numbers;
        if (cb == cb_chars) flag = pwdgenModes.Chars;
        var mode = generator.mode;
        mode.BoolFlag(flag, cb.Checked);
        generator.mode = mode;
    }

    void setLength(int value)
    {
        if (value > nud_length.Maximum) value = (int)nud_length.Maximum;
        if (value < nud_length.Minimum) value = (int)nud_length.Minimum;

        nud_length.ValueChanged -= nud_length_ValueChanged;
        nud_length.Value = value;
        nud_length.ValueChanged += nud_length_ValueChanged;

        if (value > pb_length.Maximum) value = pb_length.Maximum;
        if (value < pb_length.Minimum) value = pb_length.Minimum;

        pb_length.Value = value;           
    }

    private void pb_length_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        setLength(e.X);
    }
    
    private void nud_length_ValueChanged(object sender, EventArgs e) => setLength((int)nud_length.Value);

    private void pb_length_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        setLength(e.X);
    }
}