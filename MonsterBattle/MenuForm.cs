using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBattle
{
    public partial class MenuForm : Form
    {
        public string[] available_pokemon;
        public string selectedPokemon;

        public MenuForm()
        {
            InitializeComponent();
            pokemonListView.View = View.List;
            LoadPokemon();
        }

        public void LoadPokemon()
        {
            available_pokemon = new string[]
            {
                "Rayquaza",
                "Charizard",
                "Blaziken",
                "Goodra"
            };

            

            for(int i = 0; i < available_pokemon.Length; i++)
            {
                pokemonListView.Items.Add(available_pokemon[i].ToString());

            }
        }

        private void selectPokemonButton_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemonListView.SelectedItems[0].Text ;
            
            this.Close();
           
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void swicthRayquazaButton_Click(object sender, EventArgs e)
        {
            selectedPokemon = available_pokemon[0];
            
        }
    }
}
