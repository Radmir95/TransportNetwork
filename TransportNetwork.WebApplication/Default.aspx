<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TransportNetwork.WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <header class="clearFix">
        <div class="wrap">
            <a id="logo" href="#">Пасажироперевозки</a>
            <hr>
            <nav>
                <div id="nav">
                    <strong>Navigation</strong>
                    <ul>
                        <li>
                            <input type="button" name="Registration" class="btn btn-default btn-lg active" value="Регистрация" />
                        </li>
                        <li>
                            <input type="button" name="Login" value="Вход" class="btn btn-default btn-lg active" /></li>
                    </ul>
                </div>
            </nav>
        </div>
    </header>
    <hr>
    <div id="intro">
        <div class="inner">
            <div class="wrap clearFix">
                <h1>Share something. <strong>Worldwide.</strong></h1>
                <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.</p>
                <a href="#" class="button">SIGN UP</a>
            </div>
        </div>
    </div>
    <!-- / #intro -->
    <hr>
    <div id="content">
        <div class="wrap clearFix">
            <h2>SOME OF THE COOL FEATURES</h2>
            <div class="clearFix">
                <div class="col floatLeft">
                    <img src="images/icon-location.png" alt="" class="icon">
                    <h3>Location Services</h3>
                    <p>Maecenas faucibus mollis interdum. Donec ullamcorper nulla non metus auctor fringilla. Nulla vitae elit libero, austo odio, dapibus ac facilisis in.</p>
                </div>
                <div class="col floatRight">
                    <img src="images/icon-backup.png" alt="" class="icon">
                    <h3>24/7 Back Up</h3>
                    <p>Maecenas faucibus mollis interdum. Donec ullamcorpe it libero, a pharetra r nulla non metus auctor fringilla. Nulla vitae elit libero, a pharetra augue. Cras justo odio, dapibus ac facilisis in.</p>
                </div>
            </div>
            <div class="clearFix">
                <div class="col floatLeft">
                    <img src="images/icon-twitter.png" alt="" class="icon">
                    <h3>Twitter Integration</h3>
                    <p>Maecenas faucibus mollis interdum. Donec <a href="#">ullamcorper nulla</a> non metus auctor fringilla. Nulla vitae elit libero, a pharetra augue. Cras justo odio, dapibus ac facilisis in.</p>
                </div>
                <div class="col floatRight">
                    <img src="images/icon-stats.png" alt="" class="icon">
                    <h3>Full Realtime Statistics</h3>
                    <p>Maecenas faucibus mollis interdum. Donec ullamcorper nuletus auctor fringilla. Nulla vitae elit libero, a pharetra augue. Cras justo odio, dapibus ac facilisis in.</p>
                </div>
            </div>
            <div class="clearFix">
                <div class="col floatLeft">
                    <img src="images/icon-tools.png" alt="" class="icon">
                    <h3>Highly Customisable</h3>
                    <p>Maecenas faucibus mollis interdum. Donec ullamcorper nulla non auctor fringilla. Nulla viit libero, a pharetra tae elit libero, a pharetra augue. Cras justo odio, dapibus ac facilisis in.</p>
                </div>
                <div class="col floatRight">
                    <img src="images/icon-awards.png" alt="" class="icon">
                    <h3>Award Winner Service</h3>
                    <p>Maecenas follis interdum. Metus auctor it libero, a pharetra  fringilla. Nulla vitae elit libero, a pharetra augue. Cras justo odio, dapibus ac facilisis in.</p>
                </div>
            </div>
            <div class="buttonCentered"><a href="#" class="button iconRight">TAKE A FEATURE TOUR <i class="more"></i></a></div>
            <h2>WHAT OUR CUSTOMERS ARE SAYING</h2>
            <ul class="cols clearFix">
                <li>
                    <p>Nullam id dolor id nibh ultricies vehicula id elit. Donec id elit non mi porta gravida at eget metus. Aenean lacinia bibendum nulla sed consectetur. Donec sed odio dui. Vivamus sagittis.</p>
                    <p><strong>John Doe</strong>, Apple</p>
                </li>
                <li class="middle">
                    <p>Nullam id dolor id nibh ultricies vehicula id elit. Donec id elit non mi porta gravida at eget metus. Aenean lacinia bibendum nulla sed consectetur. Donec sed odio dui. Vivamus sagittis.</p>
                    <p><strong>John Doe</strong>, Apple</p>
                </li>
                <li>
                    <p>Nullam id dolor id nibh ultricies vehicula id elit. Donec id elit non mi porta gravida at eget metus. Aenean lacinia bibendum nulla sed consectetur. Donec sed odio dui. Vivamus sagittis.</p>
                    <p><strong>John Doe</strong>, Apple</p>
                </li>
            </ul>

        </div>
    </div>
    <!-- / #content -->
    <hr class="noPrint">
    <div id="twitter">
        <div class="wrap clearFix">
            <span class="icon"></span>
            <p>Etiam porta sem malesuada magna mollis euismod. Nullam quis risus eget urna mollis <a href="#">domain.com</a> <small>2 days ago</small></p>
        </div>
    </div>
    <hr>
    <footer class="clearFix">
        <div class="wrap clearFix">
            <p class="floatRight">
                Copyright &copy; 2016 <a href="#">Your Name</a> &ndash; All Rights Reserved<br>
            </p>
        </div>
    </footer>

</asp:Content>
