namespace Animals_vet
{
    public partial class Form1 : Form
    {
        private readonly List<animalsI> pets = new()
        {
            new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
            new Dog("Buddy", new DateTime(2017, 8, 22), "Labrador", "Vaccinated", 30.0, "Black", "Rubber ball")
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            ListViewPets.Items.Clear();

            foreach (var pet in pets)
            {
                ListViewPets.Items.Add(
                    pet.Name,
                    pet.GetType() == typeof(Cat) ? 1 : 0
                );
            }
        }

        private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
        {
            if (ListViewPets.SelectedItems.Count == 0)
                return;

            animalsI selectedPet = pets[ListViewPets.SelectedItems[0].Index];

            if (selectedPet != null)
            {
                using Form3 detailsForm = new Form3(selectedPet);
                detailsForm.ShowDialog();
            }
        }
            private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            using (Form2 newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }
            LoadAllPets();
        }
    }
}
