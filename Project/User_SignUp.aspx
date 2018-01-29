﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User_MasterPage.master" AutoEventWireup="true" CodeFile="User_SignUp.aspx.cs" Inherits="User_SignUp"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .affix {
            
            left:675px;
            width:570px;
            height:290.4px;
        }
    </style>
    <br/>
    <br/>
    <div class="container-fluid" runat="server">
    <section class="container">
		<div class="container-page" runat="server">				
			<div class="col-md-6">
            <h3 class="dark-grey">Registration</h3>

            <div class="form-group col-lg-6">
                <label>First Name</label>
                <asp:TextBox ID="firstname"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-lg-6">
                <label>Last Name</label>
                <asp:TextBox ID="lastname"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-lg-12">
                <label>Mobile Number</label>
                <asp:TextBox ID="mobileno"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-lg-12">
                <label>Home Number</label>
                <asp:TextBox ID="homeno"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-lg-12">
                <label>State</label>
                <asp:TextBox ID="state"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-lg-12">
                <label>Address</label>
                <asp:TextBox id="address"  CssClass="form-control" TextMode="multiline" Columns="50" Rows="3" style="width: 509px; height: 108px;" runat="server" />
            </div>
            <div class="form-group col-lg-12">
                <label>Pin Code</label>
                <asp:TextBox ID="pincode"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-lg-12">
                <label>Email Address</label>
                <asp:TextBox ID="email"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>



            <div class="form-group col-lg-6">
                <label>Password</label>
                <asp:TextBox ID="password"  CssClass="form-control" runat="server" type="password"></asp:TextBox>
            </div>
            <div class="form-group col-lg-6">
                <label>Repeat Password</label>
                <asp:TextBox   CssClass="form-control" runat="server"></asp:TextBox>
            </div>



        </div>
		
			<div class="col-md-6" data-spy="affix" data-offset-top="0" runat="server">
				<h3 class="dark-grey">Terms and Conditions</h3>
				<p>
					By clicking on "Register" you agree to The Company's' Terms and Conditions
				</p>
				<p>
					While rare, prices are subject to change based on exchange rate fluctuations - 
					should such a fluctuation happen, we may request an additional payment. You have the option to request a full refund or to pay the new price. (Paragraph 13.5.8)
				</p>
				<p>
					Should there be an error in the description or pricing of a product, we will provide you with a full refund (Paragraph 13.5.6)
				</p>
				<p>
					Acceptance of an order by us is dependent on our suppliers ability to provide the product. (Paragraph 13.5.6)
				</p>
				
				<asp:Button CssClass="btn btn-primary" id="register" Text="Register"  runat="server" OnClick="Register_Click" />
			</div>
		</div>
	</section>
</div>

   
   
</asp:Content>

