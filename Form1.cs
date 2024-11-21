namespace practice5
{
	public partial class Form1 : Form
	{
		private List<HomeAppliance> homeAppliances = new();

		public Form1()
		{
			InitializeComponent();
		}

		private void addHomeApplianceButton_Click(object sender, EventArgs e)
		{
			try
			{
				string brand = brandTextBox.Text == "Brand" ? string.Empty : brandTextBox.Text;
				int price = int.Parse(priceTextBox.Text);

				homeAppliances.Add(new HomeAppliance(brand, price));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void addMicrowaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				string brand = brandTextBox.Text == "Brand" ? string.Empty : brandTextBox.Text;
				int price = int.Parse(priceTextBox.Text);
				int volume = int.Parse(paramTextBox.Text);

				homeAppliances.Add(new Microwave(brand, price, volume));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void addFridgeButton_Click(object sender, EventArgs e)
		{
			try
			{
				string brand = brandTextBox.Text == "Brand" ? string.Empty : brandTextBox.Text;
				int price = int.Parse(priceTextBox.Text);
				int temp = int.Parse(paramTextBox.Text);

				homeAppliances.Add(new Fridge(brand, price, temp));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			printTextBox.Text = string.Empty;
			foreach (var item in homeAppliances)
				printTextBox.Text += item.ToString() + "\r\n";
		}

		private void brandTextBox_Enter(object sender, EventArgs e)
		{
			if (brandTextBox.Text == "Brand")
			{
				brandTextBox.Clear();
				brandTextBox.ForeColor = Color.Black;
			}
		}
		private void brandTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(brandTextBox.Text) || brandTextBox.Text == "Brand")
			{
				brandTextBox.Text = "Brand";
				brandTextBox.ForeColor = Color.Gray;
			}
		}

		private void priceTextBox_Enter(object sender, EventArgs e)
		{
			if (priceTextBox.Text == "Price")
			{
				priceTextBox.Clear();
				priceTextBox.ForeColor = Color.Black;
			}
		}

		private void priceTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(priceTextBox.Text) || priceTextBox.Text == "Price")
			{
				priceTextBox.Text = "Price";
				priceTextBox.ForeColor = Color.Gray;
			}
		}

		private void paramTextBox_Enter(object sender, EventArgs e)
		{
			if (paramTextBox.Text == "Temperture/Volume")
			{
				paramTextBox.Clear();
				paramTextBox.ForeColor = Color.Black;
			}
		}

		private void paramTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(paramTextBox.Text) || paramTextBox.Text == "Temperture/Volume")
			{
				paramTextBox.Text = "Temperture/Volume";
				paramTextBox.ForeColor = Color.Gray;
			}
		}
	}
}
