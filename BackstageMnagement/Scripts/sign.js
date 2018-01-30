$(document).ready(function(){
	//用户名不能为空：
		$("#userName").blur(function(){
			var userName=$(this).val();
			if(userName===''){
				$("#userError").html("*");
				return false;
			}else{
				$("#userError").html("");
			}
		})
		//密码不能为空：
		$("#pswd").blur(function(){
			var pswd=$(this).val();
			if(pswd===''){
				$("#pswdError").html("*");
				return false;
			}else{
				$("#pswdError").html("");
			}
		})

});


