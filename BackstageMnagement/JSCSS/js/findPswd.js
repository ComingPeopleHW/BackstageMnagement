$(document).ready(function(){
//初始化-选项：
$("#questionOne").css("color","rgb(90,180,219)");
//选择哪种--验证方式
	$("#questionOne").click(
		function(){
			$(this).css("color","rgb(90,180,219)");
			$("#questionTwo").css("color","rgba(0,0,0,0.8)");
			$(".toChose").children("span").animate({left:"4px"},1000);
			$("#oneWay").css("display","block");
			$("#twoWay").css("display","none");
		}
	)
	$("#questionTwo").click(
		function(){
			$(this).css("color","rgb(90,180,219)");
			$("#questionOne").css("color","rgba(0,0,0,0.8)");
			$(".toChose").children("span").animate({left:"90px"},1000);
			$("#oneWay").css("display","none");
			$("#twoWay").css("display","block");
		}
	)
	
	
	
})