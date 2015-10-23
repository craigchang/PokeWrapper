using PokeWrapper.API;
using PokeWrapper.DataContracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PokedexWindowsForm
{
    public partial class PokedexForm : Form
    {
        private static string baseUrl = "http://pokeapi.co/";

        public PokedexForm()
        {
            InitializeComponent();

            PokemonDataContract pokemon = DataContractGenerator<PokemonDataContract>.getInstance(2);

            List<SpriteDataContract> sprites = pokemon.httpGetPokemonSprites();
            this.pokemonSprite.Load(baseUrl + sprites.ElementAt(0).Image);

            this.labelPokemonName.Text = pokemon.PkdxId.ToString() + " " + pokemon.Name;
            this.labelSpecies.Text = pokemon.Species;

            this.labelType.Text = "";
            List<TypeDataContract> types = pokemon.httpGetPokemonTypes();
            for (int i = 0; i < types.Count; i++)
            {
                this.labelType.Text += types.ElementAt(i).Name;
                if (i < types.Count - 1)
                    this.labelType.Text += ", ";
            }


            this.labelAbilities.Text = "";
            List<AbilityDataContract> abilities = pokemon.httpGetPokemonAbilities();
            for (int i = 0; i < abilities.Count; i++)
            {
                this.labelAbilities.Text += abilities.ElementAt(i).Name;
                if (i < abilities.Count - 1)
                    this.labelAbilities.Text += ", ";
            }

            this.labelHP.Text = pokemon.Hp.ToString();
            this.labelAttack.Text = pokemon.Attack.ToString();
            this.labelDefence.Text = pokemon.Defense.ToString();
            this.labelSpecialAttack.Text = pokemon.SpAtk.ToString();
            this.labelSpecialDefence.Text = pokemon.SpDef.ToString();
            this.labelSpeed.Text = pokemon.Speed.ToString();

            this.labelEvYield.Text = pokemon.EvYield;

            this.labelGrowthRate.Text = pokemon.GrowthRate;

            this.labelMaleFemaleRatio.Text = pokemon.MaleFemaleRatio;

            List<MoveDataContract> moves = pokemon.httpGetPokemonMoves();

            foreach (MoveDataContract move in moves)
            {
                ListViewItem listViewItemMove = new ListViewItem(move.LearnType);
                listViewItemMove.SubItems.Add(move.Level.ToString());
                listViewItemMove.SubItems.Add(move.Name);
                listViewItemMove.SubItems.Add(move.PP.ToString());
                this.listViewMoveList.Items.Add(listViewItemMove);
            }

            this.listViewMoveList_ColumnClick(null, new ColumnClickEventArgs(0));
        }

        private void listViewMoveList_ColumnClick(object o, ColumnClickEventArgs e)
        {
            this.listViewMoveList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }
}
