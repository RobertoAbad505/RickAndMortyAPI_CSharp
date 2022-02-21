using com.test.rickandmorty.backend.entity;
using com.test.rickandmorty.backend.events;
using System;
using System.Web.UI.HtmlControls;

namespace com.test.rickandmorty.front.components
{
    public partial class Paginacion : System.Web.UI.UserControl
    {
        internal Action<object, ChangePageEventArgs> OnSelectedIndexChanging;
        private EPaginacion p { get; set; }
        private int pageSize;
        private int pageIndex;
        protected void Page_Init(object sender, EventArgs e)
        {
            label_Tantos.Text = string.Format("Mostrando {0} de {1} personajes", pageSize, p.count);
            label_Pagina.Text = string.Format("Página {0} de {1}", pageIndex, p.pages);
            int max = pageIndex + 5;
            for (int i = pageIndex; i < max; i++)
            {
                HtmlButton button = new HtmlButton();
                button.ServerClick += Button_ServerClick;
                button.Attributes["class"] = "btn btn-dark pagbtn " + (pageIndex == i ? "active" : "");
                button.InnerText = i.ToString();
                divPaginacion.Controls.Add(button);
            }
        }
        private void Button_ServerClick(object sender, EventArgs e) => 
            Response.Redirect("~/views/Characters/Consult.aspx?index=" + ((HtmlButton)sender).InnerText);
        internal void SetPaginacion(EPaginacion p, int pageSize, int pageIndex)
        {
            this.divPaginacion.Controls.Clear();
            this.p = p;
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
        }
    }
}