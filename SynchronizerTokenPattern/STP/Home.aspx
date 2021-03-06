﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="STP.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Type" content="text/html; CHARSET=utf-8">
    <title>STP</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta content="NOINDEX, NOFOLLOW" name="Robots">

    <link href="Resources/css/bootstrap.min.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/_all.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/additions.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/main.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/media-queries.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/site.css" type="text/css" rel="stylesheet" />
    
    <script src="Resources/scripts/Validation.js" type="text/javascript"></script>
    <script src="Resources/scripts/jquery.deferral.capture.js" type="text/javascript"></script>
    <script src="Resources/scripts/modernizr-2.7.2.js" type="text/javascript"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
</head>
<body onload="load()">
    <script>
        function load() {
            $.ajax({
                type: "POST",
                url: "Home.aspx/GetCSRFToken",
                data: JSON.stringify({}),
                contentType: 'application/json; charset=utf-8',
                dataType: 'text',
                async: true,
                success: function (response) {
                    var csrf = response;
                    document.getElementById("hdCsrfToken").value = csrf;
                },
                error: function (xhr, status, error) {
                    alert("Invalid Session");
                }
            });
        }        
    </script>
    <header role="banner">
        <div id="jquery-window-resize">
            <div class="row">
                <div class="col-md-3"></div>
            </div>
        </div>

        <div class="top-navigation-strap">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="top-navigation-content">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <form id="main" runat="server" method="POST" class="custom_border">
        <main id="content" role="main">
            <div class="container">
                <div class="sl-article-section">
                    <div class="row section top-buffer">

                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                            <asp:HiddenField ID="hdCsrfToken" runat="server" Value="" />
                        </div>

                        <div class="col-md-4">
                        </div>
                    </div>

                    <div class="row section top-buffer">

                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="btnSubmit" runat="server" Text="Click Me" BorderWidth="0px" OnClick="btnSubmit_Click" />
                        </div>

                        <div class="col-md-4">
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </form>
</body>
</html>
