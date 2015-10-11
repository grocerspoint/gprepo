<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <section class="login"><link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
	<div class="titulo">Staff Login</div>
	<form action="#" method="post" enctype="application/x-www-form-urlencoded">
    	<input type="text" required title="Username required" placeholder="Username" data-icon="U">
        <input type="password" required title="Password required" placeholder="Password" data-icon="x">
        <div class="olvido">
        	<div class="col"><a href="#" title="Ver Carásteres">Register</a></div>
            <div class="col"><a href="#" title="Recuperar Password">Fotgot Password?</a></div>
        </div>
        <a href="#" class="enviar">Submit</a>
    </form>
</section>
    </div>
    </form>
</body>
</html>
