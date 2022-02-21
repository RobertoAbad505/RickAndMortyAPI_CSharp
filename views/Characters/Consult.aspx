<%@ Page Title=" Personajes" MaintainScrollPositionOnPostback="true"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consult.aspx.cs" Inherits="com.test.rickandmorty.front.views.characters.Consult" %>
<%@ Register TagPrefix="cc1" TagName="ctrl" Src="~/components/Character.ascx" %>
<%@ Register Src="~/components/Paginacion.ascx" TagPrefix="cc1" TagName="customPag" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">        
    <div class="container-fluid pl-5">        
        <br />
        <div class="row">
            <div runat="server" id="divPagContainer" class="col-sm-12 col-md-12 col-lg-12"></div>
        </div>
        <hr />
        <div class="row">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <div id="divCharacters" runat="server" class="flex-container"></div>
            </div>
        </div>
    </div>    
</asp:Content>
