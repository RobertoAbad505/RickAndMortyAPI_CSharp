using com.test.rickandmorty.backend.entity;
using System;
using System.Web;
using System.Web.UI;

namespace com.test.rickandmorty.front.components
{
    public partial class CharacterDetails : System.Web.UI.UserControl
    {
        private ECharacter Character { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_Nombre.Text = Character.name;
            lbl_Especie.Text = Character.species;
            lbl_Genero.Text = Character.gender;
            lbl_Estatus.Text = Character.status;
            lbl_Origen.Text = Character.origin.name;
            imgCharacter.ImageUrl = Character.image;
            ScriptManager.RegisterStartupScript((HttpContext.Current.Handler as Page), typeof(Page), "DetailModal", "OpenModal($('#modalDetail'));", true);
        }

        public CharacterDetails SetCharacter(ECharacter c) { this.Character = c; return this; }
    }
}