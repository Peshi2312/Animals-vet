using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animals_vet
{
    public partial class Form2 : Form
    {
        private animalsI selectedPet 
        { 
            get;
            set; 
        }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(animalsI selectedPet)
        {
            InitializeComponent();
            this.selectedPet = selectedPet;
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public animalsI Animal { get; set; }
        private string petImage;
        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = false;
            this.textBoxFavouritetoy.Visible = false;
            this.labelInfoFavToy.Visible = false;
        }

        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = true;
            this.textBoxFavouritetoy.Visible = true;
        }

        public void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }

            animalsI newAnimal = CreateNewAnimal();
            if (newAnimal != null)
            {
                this.Animal = newAnimal;
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private bool CheckIfInputsAreValid()
            => CheckIfValid(this.textBoxname, 3, this.labelinfoName) && CheckIfValid(this.textBoxBreed, 5, this.labelinfoBreed) &&
    CheckIfValid(this.textBoxMedicalhisto, 10, this.labelMedicalhis) && CheckIfValid(this.textBoxColor, 3, this.labelInfoColor) && CheckIfValidDouble(this.textBoxWeight, this.labelinfoWeight, 0.5) && CheckIfNotEmpty(this.petImage, this.labelInfoImage);


        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Trim().Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double parsedValue) && parsedValue >= min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value);
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private animalsI CreateNewAnimal()
        {
            string name = this.textBoxname.Text.Trim();
            string breed = this.textBoxBreed.Text.Trim();
            string medicalHistory = this.textBoxMedicalhisto.Text.Trim();
            string color = this.textBoxColor.Text.Trim();
            string favoriteToy = this.textBoxFavouritetoy.Text.Trim();
            DateTime birthday = this.dateTimePickerbirthday.Value;
            double weight = double.Parse(this.textBoxWeight.Text.Trim());

            animalsI animal;
            if (this.radioButtonCat.Checked)
            {
                animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                animal = new Dog(name, birthday, breed, medicalHistory, weight, color, favoriteToy);
            }

            animal.Image = petImage;
            return animal;
        }

        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight,
            string color)
        {
            string favToy = this.textBoxFavouritetoy.Text.Trim();
            if (!CheckIfValid(this.textBoxFavouritetoy, 3, this.labelInfoFavToy))
            {
                return null;
            }

            return new Cat(name, birthday, breed, medicalHistory, weight, color, favToy);
        }

        private void ImageTextBox_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            openFileDialog.Filter =
                "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                 textBoxImage.Text = Path.GetFileName(petImage);
            }
        }

    }
}
