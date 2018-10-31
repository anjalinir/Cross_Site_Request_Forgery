<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DSTP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Type" content="text/html; CHARSET=utf-8">
    <title>DSTP</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta content="NOINDEX, NOFOLLOW" name="Robots">

    <link href="Resources/css/bootstrap.min.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/_all.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/additions.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/main.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/media-queries.css" type="text/css" rel="stylesheet" />
    <link href="Resources/css/site.css" type="text/css" rel="stylesheet" />
</head>
<body>
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
    <form id="main" runat="server" method="post">
        <main id="content" role="main">
            <div class="container">
                <div class="sl-article-section">
                    <div class="row section top-buffer">

                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4 center">
                            <h1 style="color:#00827b; font-family:'Calisto MT'">Greenland State Bank</h1>
                        </div>

                        <div class="col-md-4">
                        </div>
                    </div>

                    <div class="row section top-buffer">
                        <div class="col-md-4"></div>
                        <div class="col-md-4 center">
                            <asp:Image ID="imgLogo" runat="server" ImageUrl="~/Resources/images/tree-logo.jpg"/>
                        </div>
                        <div class="col-md-4"></div>
                    </div>
                    

                    <div class="row section top-buffer">
                        <div class="col-md-4"></div>
                        <div class="col-md-4 customText">
                                        Username:
                        </div>
                        <div class="col-md-4"></div>
                    </div>

                    <div class="row section top-buffer">
                        <div class="col-md-4"></div>
                        <div class="col-md-4 customText">
                            <div>
                                <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
                                <div id="divFailed" class="alert alert-danger top-buffer" runat="server" visible="False">
                                    <asp:Label ID="lblFailed" runat="server" Visible="False" Text="" Font-Size=""></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4"></div>
                    </div>

                    <div class="row section top-buffer">
                        <div class="col-md-4"></div>
                        <div class="col-md-4 customText">
                                        Password:
                        </div>
                        <div class="col-md-4"></div>
                    </div>

                    <div class="row section top-buffer">
                        <div class="col-md-4"></div>
                        <div class="col-md-4 customText">
                            <div>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                                <div id="divFail" class="alert alert-danger center top-buffer" runat="server" visible="False">
                                    <asp:Label ID="lblFail" runat="server" Visible="False" Text="" Font-Size=""></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4"></div>
                    </div>

                    <div class="row section top-buffer">
                        <div class="col-md-4">
                        </div>

                        <div class="col-md-4">
                            <asp:Button ID="btnSubmit" runat="server" Text="Log On >" BorderWidth="0px" OnClick="btnSubmit_Click"/>
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
