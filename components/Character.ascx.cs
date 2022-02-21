using com.test.rickandmorty.backend.entity;
using com.test.rickandmorty.backend.events;
using System;
using System.Web.UI;

namespace com.test.rickandmorty.front.components
{
    public partial class Character : UserControl
    {
        internal Action<object, CharacterEventArgs> Click;
        public ECharacter Item { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Item is null)
                return;

            lbl_Name.InnerText = Item.name;
            lbl_species.Text = Item.species;
            lbl_status.Text = Item.status;
            imgCharacter.ImageUrl = Item.image;
            divCharacter.Attributes["onclick"] = string.Format("VerDetalles({0});", searchDetails.ClientID);
        }

        protected void searchDetails_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, new CharacterEventArgs(Item));
        }
    }


}