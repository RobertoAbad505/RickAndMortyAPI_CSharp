<%@ Control EnableViewState="true" EnableTheming="true" Language="C#" AutoEventWireup="true" CodeBehind="Character.ascx.cs" Inherits="com.test.rickandmorty.front.components.Character" %>

<div runat="server" id="divCharacter" class="card border border-light cmpnt bg-dark" style="width: 18rem;" >
    <asp:Image runat="server" ID="imgCharacter" CssClass="card-img-top"/>
    <div class="card-body text-left"  >
        <h2 runat="server" id="lbl_Name" class="card-title"></h2>
        <h5 style="margin-bottom: -10px;">Especie</h5>
        <asp:Label runat="server" ID="lbl_species" CssClass="text-weight-bold"></asp:Label><br />
        <h5 style="margin-bottom: -10px;">Status</h5>
        <asp:Label runat="server" ID="lbl_status" CssClass="text-weight-bold"></asp:Label><br />
        <asp:LinkButton runat="server" ID="searchDetails" OnClick="searchDetails_Click" Style="display: none;" />
    </div>
</div>
<script>
    function VerDetalles(i) {
        i.click();
        return;
    }
</script>


