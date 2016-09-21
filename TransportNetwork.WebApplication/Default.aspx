<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TransportNetwork.WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <header class="clearFix">
        <div class="wrap">
            <a id="logo" href="#">Пассажироперевозки</a>
            <hr>
            <nav>
                <div id="nav">
                    <strong>Navigation</strong>
                    <ul>
                        <li>
                            <input type="button" name="Registration" class="btn btn-default btn-lg spaces" value="Регистрация" />
                        </li>
                        <li>
                            <input type="button" name="Login" value="Вход" class="btn btn-default btn-lg spaces" /></li>
                    </ul>
                </div>
            </nav>
        </div>
    </header>
    <hr>
    <div id="intro">
        <div class="inner">
            <div class="wrap clearFix">
                <h1>Быстро. Недорого. С комфортом.</h1>
                <p>Профессиональные водители с комфортом доставят ВАС и ВАШИХ близких в нужное место в назначенный час. </p>
            </div>
        </div>
    </div>
    <!-- / #intro -->
    <hr>
    <div id="content">
        <div class="wrap clearFix">
            <h2>Почему люди выбирают нас</h2>
            <div class="clearFix">
                <div class="col floatLeft">
                    <img src="images/icon-location.png" alt="" class="icon">
                    <h3>До нужного места</h3>
                    <p>Довозим до нужного Вам места прямо от Вашего дома.</p>
                </div>
                <div class="col floatRight">
                    <img src="images/icon-backup.png" alt="" class="icon">
                    <h3>24/7 круглосуточно</h3>
                    <p>Поездки в любое удобное для Вас и Ваших близких время.</p>
                </div>
            </div>
            <div class="clearFix">
                 <div class="col floatLeft">
                    <img src="images/icon-tools.png" alt="" class="icon">
                    <h3>Высокая надежность</h3>
                    <p>Перед каждый рейсом все наши автомобили проходят тщательную проверку</p>
                </div>
                <div class="col floatRight">
                    <img src="images/icon-stats.png" alt="" class="icon">
                    <h3>Больше 3 лет работы</h3>
                    <p>У нас богатый опыт работы с клиентами. Мы на рынке уже более 3 лет</p>
                </div>
            </div>
           
            <div class="buttonCentered"><a href="#" class="button iconRight">TAKE A FEATURE TOUR <i class="more"></i></a></div>
            <h2>Что говорят о нас наши клиенты</h2>
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
            <p>Все ваши желания и предложения можете отправлять на sonictrans@yandex.ru</p>
        </div>
    </div>
    <hr>
   

</asp:Content>
