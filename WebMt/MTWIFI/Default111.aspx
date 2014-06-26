<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default111.aspx.cs" Inherits="MTWIFI._Default" %>
<!--
<!DOCTYPE>
<html>
<script type="text/javascript">
// 此函数为和路由器交互的函数
    function login(token) {
        var url = '<%=APIURL %>';
        var jqxhr = $.post(url, { "token": token }, function (msg) {
            var jsonObj2 = eval('(' + msg + ')');
            if (jsonObj2.ret > 0) {
                window.location.href = "<%=GoURL %>";
            }
            else {
                alert("认证失败！");
            }
        })
        .error(function () { alert("与服务器通讯失败!"); });
    }


// 此函数为和服务器交互,获取token的并自动和路由器交互的函数
function Submit()
{
    $.get("verify.aspx", function (data) {
        var jsonObj2 = eval('(' + data + ')');
        if (jsonObj2.ret > 0) {
            login(jsonObj2.token);
        }
    });
}
</script>
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
    <link rel="stylesheet" href="js/jquery/jquery.mobile-1.2.1.css" />
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery/jquery.mobile-1.2.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div data-role="page" data-theme="a">
        <div data-role="header" data-position="inline">
            <h1>
                无线免费WiFi</h1>
        </div>
        <div data-role="content" data-theme="a">

        </div>
        <a data-ajax="false" href="javascript:Submit();" data-role="button">点击使用</a>
    </div>
    </form>
</body>
</html>
-->
