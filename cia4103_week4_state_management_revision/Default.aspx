<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 114px;
            height: 140px;
        }
        .auto-style3 {
            width: 113px;
            height: 142px;
        }
        .auto-style4 {
            width: 117px;
            height: 113px;
        }
        .auto-style5 {
            height: 91px;
        }
        .auto-style6 {
            height: 91px;
            width: 148px;
        }
        .auto-style7 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select your Flavor</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">
                        <img alt="" class="auto-style2" src="Smoothieimages/smoothie1.jpg" /></td>
                    <td class="auto-style5">
                        <h4>Mango Madness</h4>
                        <p>
                            Mango, Pineapple, Banana, Strawberries</p>
                        <p>
                            <a href="add.aspx?id=1">Add to Cart</a>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <img alt="" class="auto-style3" src="Smoothieimages/smoothie2.jpg" /></td>
                    <td>
                        <h4>BlueBerry Blitz</h4>
                        <p>
                            Blueberry, Banana, low-fat youghurt</p>
                        <p>
                            <a href="add.aspx?id=2">Add to Cart</a>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <img alt="" class="auto-style4" src="Smoothieimages/smoothie3.jpg" /></td>
                    <td>
                        <h4>Amazon</h4>
                        <p>
                            Raspberries, Blueberries, Stawberries, Blackberries, low-fat youghurt</p>
                        <p>
                            <a href="add.aspx?id=3">Add to Cart</a>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Checkout" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
