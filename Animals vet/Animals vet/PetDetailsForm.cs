using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animals_vet
{
    public partial class Form3 : Form
    {
        private readonly animalsI? pet;
        public Form3(animalsI? pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        public Form3()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public animalsI Animal { get; internal set; }
        private void FillPetInfo(object sender, EventArgs e)
        {
            if (pet == null)
                return;
            this.labelPetName.Text = pet?.Name;
            this.textBoxType.Text = pet?.GetType().Name;
            this.dateTimePicker1.Text = pet.Birthday.ToString();
            this.textBoxBreed.Text = pet.Breed;
            this.textBoxColor.Text = pet.Color;
            this.textBoxWeight.Text = pet.Weight.ToString();
            this.textBoxMedicalhistory.Text = pet.MedicalHistory;
            this.textBoxStatus.Text = pet.Status.ToString();

            if (!string.IsNullOrEmpty(pet.Image) && File.Exists(pet.Image))
            {
                this.pictureBoxImage.Image = Image.FromFile(pet.Image);
            }

            if (pet is Cat cat)
            {
                this.textBoxFavToy.Text = cat.FavoriteToy;
            }
            else
            {
                this.textBoxFavToy.Visible = false;
                this.labelFavtoy.Visible = false;
            }

            this.buttonAdopt.Enabled = this.pet.Status != Status.Adopted;
        }
        private void buttonAdopt_Click_1(object sender, EventArgs e)
        {
            pet.Status = Status.Adopted;
            textBoxStatus.Text = pet.Status.ToString();
            buttonAdopt.Enabled = false;
        }

        private void S(object sender, EventArgs e)
        {

        }
    }
}
