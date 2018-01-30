$(document).ready(function(){
	//当窗口改变时执行：
	window.onresize=resizeBanner;
		function resizeBanner(){
		    var winW = $(window).width();
		    if($(window).width()>639){
				$(".pageLeft").css({"display":"block"});
				$("#helloWords").css("display","block");
			}else{
		    	$("#helloWords").css("display","none");
		    }
		}
	
	//控制菜单：	
	$("#menuLogo").click(function(){
	    $(".pageLeft").slideToggle("slow");
	})
})
