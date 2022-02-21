<%@ Control EnableViewState="true" EnableTheming="true" Language="C#" AutoEventWireup="true" CodeBehind="CharacterDetails.ascx.cs" Inherits="com.test.rickandmorty.front.components.CharacterDetails" %>

<div class="modal fade bg-dark" id="modalDetail" tabindex="1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true" style="z-index: 999999999999999;">
        <div class="modal-dialog modal-xl modal-dialog-centered bg-dark" role="document">
            <div class="modal-content bg-dark">
                <div class="modal-header">
                    <h5 class="modal-title" id="detailModalLongTitle">
                        <i class="fa fa-users fa-2x" aria-hidden="true"></i>
                        Detalles del personaje</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <br />
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-7">
                            <h4>Nombre</h4>
                            <asp:Label runat="server" ID="lbl_Nombre" />
                            <br />
                            <h4>Especie</h4>
                            <asp:Label runat="server" ID="lbl_Especie" />
                            <br />
                            <h4>Genero</h4>
                            <asp:Label runat="server" ID="lbl_Genero" />
                            <br />
                            <h4>Estatus</h4>
                            <asp:Label runat="server" ID="lbl_Estatus" />
                            <br />
                            <h4>Origen</h4>
                            <asp:Label runat="server" ID="lbl_Origen" />
                        </div>
                        <div class="col-md-5">
                            <asp:Image runat="server" ID="imgCharacter" CssClass="card-img-top"/>
                        </div>
                    </div>
                    <br />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal" aria-label="Close">
                        Volver
                        <i class="fa fa-arrow-left" aria-hidden="true"></i>
                    </button>
                </div>
            </div>
        </div>
    </div>
<script>
    OpenModal($('#modalDetail'));
</script>