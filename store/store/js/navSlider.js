		
$("#menu-toggle").click(function() {
	var pos = $('#navigation').offset().left;
	if (pos == -320) {
		$("#navigation").animate( {"left": "0px"}, "slow"),
		$(this).animate( {"left": "308px"}, "slow");
		$("i", this).removeClass("icon-chevron-right");
		$("i", this).addClass("icon-chevron-left");
	} else {
		$("#navigation").animate( {"left": "-320px"}, "slow"),
		$(this).animate( {"left": "0px"}, "slow");
		$("i", this).removeClass("icon-chevron-left");
		$("i", this).addClass("icon-chevron-right");
	}	
});

$(".slider_menuList > li > ul").hide();
	$(document).on('click', '.slider_menuList > li > a', function(event){
		$(".slider_menuList > li > ul").stop().slideUp();
		$(this).next(".slider_menuList > li > ul").stop().slideToggle();
});	

		
		
		
		
		
		
		