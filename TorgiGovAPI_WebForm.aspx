<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TorgiGovAPI_WebForm.aspx.cs" Inherits="TorgiGovAPI_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>Получение данных с сайта https://torgi.gov.ru/</div><br />
    <form id="form1" runat="server">
        <select id="bidKind" runat="server">
            <option value="0">--выбрать вид торгов--</option>
            <option value="1">1 - Аренда, безвозмездное пользование, доверительное управление имуществом, иные договоры..</option>
            <option value="2">2 - Аренда и продажа земельных участков</option>
            <option value="3">3 - Строительство</option>
            <option value="4">4 - Охотхозяйственные соглашения</option>
            <option value="5">5 - Пользование участками недр</option>
            <option value="6">6 - Государственно-частное партнерство (соглашения о ГЧП/МЧП, концессионные соглашения)</option>
            <option value="7">7 - Аренда лесных участков и продажа лесных насаждений</option>
            <option value="8">8 - Продажа государственного и муниципального имущества</option>
            <option value="9">9 - Передача прав на единые технологии</option>
            <option value="10">10 - Водопользование</option>
            <option value="11">11 - Рыболовство и добыча водных биоресурсов</option>
            <option value="12">12 - ЖКХ</option>
            <option value="13">13 - Реализация имущества должников</option>
            <option value="14">14 - Создание искусственных земельных участков</option>
            <option value="15">15 - Размещение рекламных конструкций</option>
            <option value="16">16 - Продажа объектов электроэнергетики</option>
            <option value="17">17 - Лицензии на оказание услуг связи</option>
        </select>
        <br />
        от: <asp:Calendar ID="publishDateFrom" runat="server"></asp:Calendar>
        до: <asp:Calendar ID="publishDateTo" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Старт" />
    </form>
</body>
</html>
