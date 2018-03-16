<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Post.aspx.cs" Inherits="WebMethod.Post" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>

	<script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
	<script>
		$(function () {
			cJSON = { req: "HelloWorld" };
			$.ajax({
				type: "POST",
				url: "Post.aspx/GetMethod",
				async: false,
				data: JSON.stringify(cJSON),
				//data: cString,
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				success: function (response) {
					if (response != null && response.d != null) {
						res_json = JSON.parse(response.d);
						console.dir(res_json);
					}
				},
				error: function (xhr) {
					//發生錯誤之處理程序
				}
			});
		});
	</script>
</head>
<body>
	<form id="form1" runat="server">
		<div>
		</div>
	</form>
</body>
</html>
