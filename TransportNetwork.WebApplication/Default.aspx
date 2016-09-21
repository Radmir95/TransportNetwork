<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TransportNetwork.WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
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
                    <p>Хотелось бы выразить благодарность от лица всей нашей группы за поездку в Булгары, она удалась на славу. Нам удалось ни только получить яркие впечатления от экскурсии, но и провести время в дороге с комфортом, с приятным водителем и приятной музыкой.</p>
                    <p><strong>Анна Гордеева</strong></p>
                </li>
                <li class="middle">
                    <p>
                        Здравствуйте!
Большое спасибо за транспортное сопровождение нашего мероприятия. Организация работы просто на высшем уровне. Приятно иметь дело с профессионалами. Рад буду обратиться к вам и в дальнейшем.
Отдельное спасибо менеджеру Миляуше за профессиональное и доброжелательное отношение.
Водителю Ильнуру за внимательное и человечное отношение к пассажирам, соблюдение расписания движения.
                    </p>
                    <p><strong>Александр Савченко</strong></p>
                </li>
                <li>
                    <p>Большое спасибо за поездку в Йошкар Олы! Водитель очень вежливый, нигде не торопил нас. Мы совершенно довольны. Отдельное спасибо Миляуше за терпеливое отношение!</p>
                    <p><strong>Александр Шевченко</strong></p>
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
