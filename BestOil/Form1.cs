namespace BestOil;

public partial class Form1 : Form
{
    public Dictionary<string, float> petrolTypes=new();

    static float totalAmount = 0;
    public Form1()
    {
        InitializeComponent();
        petrolTypes.Add("Ai-92", 1.5f);
        petrolTypes.Add("Ai-95", 2.2f);
        petrolTypes.Add("Ai-98", 2.5f);
        foreach (var item in petrolTypes.Keys)
        {
            Petrolcmbbox.Items.Add(item);
        }
    }

    private void textBoxPricePetrol_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
        {
            e.Handled = true;
        }

        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }

    }



    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButtonLitr.Checked)
        {
            LitrtextBox.ReadOnly = false;
            MoneyTextBox.ReadOnly = true;
        }
        else
        {
            LitrtextBox.ReadOnly = true;
            MoneyTextBox.ReadOnly = false;
        }
    }

    private void textBoxPricePetrol_TextChanged(object sender, EventArgs e)
    {
        TotalAmountPetrol.Text = PricePetrol.Text;
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        if (LitrtextBox.ReadOnly == false && LitrtextBox.Text != null)
        {
            TotalAmountPetrol.Text = (float.Parse(LitrtextBox.Text) * float.Parse(PricePetrol.Text)).ToString();
        }
        else if (MoneyTextBox.ReadOnly == false && MoneyTextBox.Text != null)
        {
            TotalAmountPetrol.Text = (float.Parse(MoneyTextBox.Text) / float.Parse(PricePetrol.Text)).ToString();
        }
    }

    private void CheckedChanged(object sender, EventArgs e)
    {
        foreach (CheckBox item in panelFood.Controls)
        {
            if (item.Checked)
            {
                foreach (TextBox item2 in PanelTextBoxes.Controls)
                {
                    if (item2.Tag == item.Name)
                    {
                        item2.ReadOnly = false;
                    }
                }
            }
            else
            {
                foreach (TextBox item2 in PanelTextBoxes.Controls)
                {
                    if (item2.Tag == item.Name)
                    {
                        item2.ReadOnly = true;
                    }
                }
            }
        }
    }

    private void TextBoxCafe_TextChanged(object sender, EventArgs e)
    {
        float total = 0;
        foreach (TextBox item in PanelTextBoxes.Controls)
        {
            if (item.Tag == (sender as TextBox).Tag)
                total = (float.Parse(item.Text) * float.Parse((sender as TextBox).Text));
        }
        totalAmount += total;
        TotalAmountCafe.Text = totalAmount.ToString();
    }



    private void Calculate_Click(object sender, EventArgs e)
    {
        if (TotalAmountPetrol.Text == null && TotalAmountCafe.Text == null)
        {
            TotalAmountPetrol.Text = "0.0";
            TotalAmountCafe.Text = "0.0";
        }
        AllAmount.Text = (float.Parse(TotalAmountPetrol.Text) + float.Parse(TotalAmountCafe.Text)).ToString();
        MessageBox.Show($"You should pay {AllAmount.Text}, Good Bye");
    }
}