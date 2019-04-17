	
	$(".smallphoto a").click(function(){
		var img=$(this).children("img").attr("src");
		//alert(img);
		$(".bigphoto img").attr("src",img);
		
	});
