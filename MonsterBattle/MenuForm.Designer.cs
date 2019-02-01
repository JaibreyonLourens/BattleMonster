namespace MonsterBattle
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectPokemonButton = new System.Windows.Forms.Button();
            this.pokemonListView = new System.Windows.Forms.ListView();
            this.textLabel = new System.Windows.Forms.Label();
            this.swicthRayquazaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectPokemonButton
            // 
            this.selectPokemonButton.Location = new System.Drawing.Point(12, 385);
            this.selectPokemonButton.Name = "selectPokemonButton";
            this.selectPokemonButton.Size = new System.Drawing.Size(776, 53);
            this.selectPokemonButton.TabIndex = 0;
            this.selectPokemonButton.Text = "Select pokemon";
            this.selectPokemonButton.UseVisualStyleBackColor = true;
            this.selectPokemonButton.Click += new System.EventHandler(this.selectPokemonButton_Click);
            // 
            // pokemonListView
            // 
            this.pokemonListView.Location = new System.Drawing.Point(12, 102);
            this.pokemonListView.MultiSelect = false;
            this.pokemonListView.Name = "pokemonListView";
            this.pokemonListView.Size = new System.Drawing.Size(776, 277);
            this.pokemonListView.TabIndex = 1;
            this.pokemonListView.UseCompatibleStateImageBehavior = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(12, 19);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(266, 29);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Select a new Pokemon:";
            // 
            // swicthRayquazaButton
            // 
            this.swicthRayquazaButton.Location = new System.Drawing.Point(645, 19);
            this.swicthRayquazaButton.Name = "swicthRayquazaButton";
            this.swicthRayquazaButton.Size = new System.Drawing.Size(143, 56);
            this.swicthRayquazaButton.TabIndex = 3;
            this.swicthRayquazaButton.Text = "Switch Rayquaza";
            this.swicthRayquazaButton.UseVisualStyleBackColor = true;
            this.swicthRayquazaButton.Click += new System.EventHandler(this.swicthRayquazaButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swicthRayquazaButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.pokemonListView);
            this.Controls.Add(this.selectPokemonButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPokemonButton;
        private System.Windows.Forms.ListView pokemonListView;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button swicthRayquazaButton;
    }
}