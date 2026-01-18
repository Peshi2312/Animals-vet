namespace Animals_vet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TitleVet = new Label();
            ListViewPets = new ListView();
            imageListPets = new ImageList(components);
            buttonAddNewPetClick = new Button();
            SuspendLayout();
            // 
            // TitleVet
            // 
            TitleVet.Anchor = AnchorStyles.Top;
            TitleVet.Font = new Font("Segoe UI", 29F);
            TitleVet.Location = new Point(314, 84);
            TitleVet.Name = "TitleVet";
            TitleVet.Size = new Size(268, 105);
            TitleVet.TabIndex = 0;
            TitleVet.Text = "VetClinic";
            // 
            // ListViewPets
            // 
            ListViewPets.LargeImageList = imageListPets;
            ListViewPets.Location = new Point(100, 178);
            ListViewPets.Name = "ListViewPets";
            ListViewPets.Size = new Size(683, 268);
            ListViewPets.SmallImageList = imageListPets;
            ListViewPets.TabIndex = 1;
            ListViewPets.UseCompatibleStateImageBehavior = false;
            ListViewPets.MouseClick += ListViewPetsMouseClick;
            // 
            // imageListPets
            // 
            imageListPets.ColorDepth = ColorDepth.Depth16Bit;
            imageListPets.ImageStream = (ImageListStreamer)resources.GetObject("imageListPets.ImageStream");
            imageListPets.TransparentColor = Color.Transparent;
            imageListPets.Images.SetKeyName(0, "Dog.png");
            imageListPets.Images.SetKeyName(1, "Cat.png");
            // 
            // buttonAddNewPetClick
            // 
            buttonAddNewPetClick.BackColor = Color.Violet;
            buttonAddNewPetClick.Location = new Point(683, 476);
            buttonAddNewPetClick.Name = "buttonAddNewPetClick";
            buttonAddNewPetClick.Size = new Size(219, 58);
            buttonAddNewPetClick.TabIndex = 2;
            buttonAddNewPetClick.Text = "Add new Pet";
            buttonAddNewPetClick.UseVisualStyleBackColor = false;
            buttonAddNewPetClick.Click += ButtonAddNewPetClick;
            buttonAddNewPetClick.MouseClick += ListViewPetsMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(914, 546);
            Controls.Add(buttonAddNewPetClick);
            Controls.Add(ListViewPets);
            Controls.Add(TitleVet);
            Name = "Form1";
            Text = "Vet Clinik";
            Load += OnLoad;
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label TitleVet;
        private ListView ListViewPets;
        private ImageList imageListPets;
        private Button buttonAddNewPetClick;
    }
}
