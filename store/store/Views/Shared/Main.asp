<!DOCTYPE html>
<html lang="zh-TW">
<head>
	<!--#include file="includeBtn/btn_head.asp" -->
	<!--下述套程式時移除，btn_head.asp內的路徑改為/IIE/css/-->
	<link rel="stylesheet" type="text/css" href="./css/reset.css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">   
	<link rel="stylesheet" type="text/css" href="./css/css.css">
	<link rel="stylesheet" type="text/css" href="./css/backstage.css">
</head>
<body>
	<!--#include file="includeBtn/btn_bsTop.asp" -->
	<div class="container open-sidebar">
		<!--#include file="includeBtn/btn_sub_menu.asp" -->
		<div class="main-content">
			<div class="content">
				
				<div class="ft_copyright">Copyright © 2018 <%=Session("Company") %> All rights reserved.</div>
			</div><!-- .content -->
		</div><!-- .main-content -->
	</div><!-- .container -->
	<!--#include file="includeBtn/btn_footer.asp" -->
	
		
	<!--下述套程式時移除，btn_head.asp內的路徑改為/IIE/css/-->
	<script type="text/javascript" src="https://code.jquery.com/jquery-1.9.1.js"></script>
	<script type="text/javascript">
	if (localStorage.getItem("openmenu") == null || localStorage.getItem("openmenu") == undefined || localStorage.getItem("openmenu") == '') { //假如無資料就設定資料
		localStorage.setItem("openmenu", "Open");
	}
	$(window).load(function(){
		$("[data-toggle]").click(function() {
			var toggle_el = $(this).data("toggle");
			$(toggle_el).toggleClass("open-sidebar");
			$(".main-content").toggleClass("full");
			if ($(toggle_el).hasClass("open-sidebar")) {  //判斷到有此class代表打開 沒有代表關閉
				localStorage.setItem("openmenu", "Open");
			} else {
				localStorage.setItem("openmenu", "Close");
			}
		});
	});
	$(document).ready(function () {
		var toggle_el = $("[data-toggle]").data("toggle");
		$(toggle_el).removeClass("open-sidebar");   //移除列表預設開啟狀態
		$(".main-content").addClass("full");   //設定右邊頁面滿版
		if (localStorage.getItem("openmenu") == 'Open') {  //打開列表
			$(toggle_el).addClass("open-sidebar");
			$(".main-content").removeClass("full");  //移除右邊頁面滿版
		} 
	});
	
	$(window).resize(function(){
		var toggle_el = $("[data-toggle]").data("toggle");
		if ($(window).width() <= 1300){	
			$(toggle_el).removeClass("open-sidebar");
			/*$(".main-content").addClass("full");
			$(".main-content").removeClass("full");*/
		}	
	});
</script>

<script src="./js/submenu.js"></script>
</body>
</html>


