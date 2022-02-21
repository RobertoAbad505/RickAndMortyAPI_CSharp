using com.test.rickandmorty.backend.comun;
using com.test.rickandmorty.backend.control.characters;
using com.test.rickandmorty.backend.entity;
using com.test.rickandmorty.backend.events;
using com.test.rickandmorty.front.components;
using System;
using System.Collections.Generic;

namespace com.test.rickandmorty.front.views.characters
{
    public partial class Consult : System.Web.UI.Page
    {
        private int pageIndex { get; set; }
        private Paginacion Pag { get; set; }
        public List<ECharacter> Personajes { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["index"] is null)
                pageIndex = 1;
            else
                pageIndex = Convert.ToInt32(Request.QueryString["index"].ToString());

            SetContent();
        }
        private void SetContent()
        {
            Resultado res = new Characters().GetByPage(pageIndex);
            if (res.Succes)
            {
                object[] data = res.Data as object[];
                Personajes = data[0] as List<ECharacter>;
                InitPaginación(data[1] as EPaginacion);
                this.divCharacters.Controls.Clear();
                foreach (ECharacter i in Personajes)
                {
                    Character c = (Character)LoadControl("~/components/Character.ascx");
                    c.Click += SeeCharacterDetails;
                    c.Item = i;
                    this.divCharacters.Controls.Add(c);
                }
            }
        }
        private void InitPaginación(EPaginacion p)
        {
            this.divPagContainer.Controls.Clear();
            Pag = (Paginacion)LoadControl("~/components/Paginacion.ascx");
            Pag.SetPaginacion(p, Personajes.Count, pageIndex);
            Pag.OnSelectedIndexChanging += OnChangePage;
            this.divPagContainer.Controls.Add(Pag);
        }
        private void OnChangePage(object sender, ChangePageEventArgs pageEvent)
        {
            pageIndex = pageEvent.RequestIndex;
            SetContent();
        }
        private void SeeCharacterDetails(object characterSender, CharacterEventArgs args)
        {
            this.divCharacters.Controls.Add(((CharacterDetails)LoadControl("~/components/CharacterDetails.ascx")).SetCharacter(args.Character));
        }

    }
}