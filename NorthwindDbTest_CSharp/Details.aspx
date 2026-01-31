<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="NorthwindDbTest_CSharp.Details" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="./">Home</a></li>
                <li class="breadcrumb-item"><a href="./Products">Prodcuts</a></li>
                <li class="breadcrumb-item active" aria-current="page">Product Details</li>
            </ol>
        </nav>
        <div class="col-12 mt-2">
            <div class="table-responsive">
                <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="false" Width="100%" CellPadding="3" CssClass="table table-sm table-striped table-light" > 
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="Name" />
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="supplier" HeaderText="Supplier" />
                        <asp:BoundField DataField="catagory" HeaderText="Catagory" />
                        <asp:BoundField DataField="quantityPerUnit" HeaderText="Quantity Per Unit" />
                        <asp:BoundField DataField="unitPrice" HeaderText="Unit Price" />
                        <asp:BoundField DataField="unitsInStock" HeaderText="Units In Stock" />
                        <asp:BoundField DataField="unitsOnOrder" HeaderText="Units On Order" />
                        <asp:BoundField DataField="reorderLevel" HeaderText="Reorder Level" />
                        <asp:BoundField DataField="discontinued" HeaderText="Discontinued" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="col-12 mt-2">
            <div class="table-responsive">
                <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="false" Width="100%" CellPadding="3" CssClass="table table-sm table-striped table-light" > 
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="Order ID" />
                        <asp:BoundField DataField="shipName" HeaderText="Customer Name" />
                        <asp:BoundField DataField="orderDate" HeaderText="Date Ordered" />
                        <asp:BoundField DataField="shippedDate" HeaderText="Date Shipped" />
                        <asp:BoundField DataField="shipAddress" HeaderText="Address" />
                        <asp:BoundField DataField="quantity" HeaderText="Amount Shipped" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:content>

