<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Log_in_control.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       
    <noscript>
        <div id="js">
            <h2>Please enable Javascript</h2>
        </div>
    </noscript>
        
        
        <div id="demo">
        </div>
        <div id="demo1">
        </div>
        

<script>

    var callback = function () {
        //console.log("ready");
        //loadDoc('login.aspx', myFunction);
        check_cookie();
    };

    if  (document.readyState === "complete" || (document.readyState !== "loading" && !document.documentElement.doScroll) )
    {
        callback();
    }
    else
    {
        document.addEventListener("DOMContentLoaded", callback);
    }
    

  function loadDoc(url, cFunction) {
  var xhttp;
  xhttp=new XMLHttpRequest();
  xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
      cFunction(this);
    }
  };
  xhttp.open("POST", url, true);
  xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
  xhttp.send("load=yes");
  
  

  }

    var reg_firstname, reg_lastname, reg_email, reg_phone, reg_ans_1, reg_ans_2, reg_pass, res;
    var fcheck = 1;
    var lcheck = 1;
    var echeck = 1;
    var echeckexist = 1;
    var pcheck = 1;
    var q1check = 1;
    var q2check = 1;
    var passcheck = 1;
    var cpasscheck = 1;

    function check_firstname() {
        var fname = document.getElementById('fname').value;
        if (fname.length <= 0) {
            document.getElementById('fnameErr').innerHTML = "First name can't be empty!";
            fcheck = 1;
        }
        else {
            fcheck = 0;
        }
    }

    function check_lastname() {
        
        var lname = document.getElementById('lname').value;
        if (lname.length <= 0) {
            document.getElementById('lnameErr').innerHTML = "Last name can't be empty!";
            lcheck = 1;
        }
        else {
            lcheck = 0;
        }
    }

    function check_email() {
        
        var email = document.getElementById('email').value;
        var pos = email.indexOf("@");
        var pos1 = email.lastIndexOf(".");
        var e = 1;
        if (email.length <= 0) {
            document.getElementById('emailErr').innerHTML = "Email can't be empty!";
            echeck = 1;
        }

        else if (pos < 0) {
            document.getElementById('emailErr').innerHTML = "Email is not valid!";
            echeck = 1;

        }

        else if ( pos > pos1 ) {
            document.getElementById('emailErr').innerHTML = "Email is not valid!";
            echeck = 1;
        }
   
        else {
            echeck = 0;
        }
    }

    function check_email_exist() {
        var email = document.getElementById('email').value;
        var xhttp;
        xhttp=new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                //document.getElementById('emailexistErr').innerHTML = xhttp.responseText;

                var check = xhttp.responseText;
                res = check.substring(0, 4);

                call();
                
            }
        };
        
        var url = "email_check.aspx?reg_email="+email+"&load=yes";
        xhttp.open("GET", url, true);
        xhttp.send();

        
        

    }

    function call() {
         
        var n = res.localeCompare("EXIST");
        //alert(n);
        if (n == -1) {
            document.getElementById('emailexistErr').innerHTML = "Email is already exiest!";
            echeckexist = 1;
        }
        else {
             echeckexist = 0;
        }
    }

    function check_phone() {
        
        var phone = document.getElementById('phone').value;
        if (phone.length <= 0) {
            document.getElementById('phoneErr').innerHTML = "Phone can't be empty!";
            pcheck = 1;
        }

        else if (isNaN(phone)) {
            document.getElementById('phoneErr').innerHTML = "Phone number can't be charecter!";
            pcheck = 1;
        }

        else {
            pcheck = 0;
        }
    }

    function check_question1() {
        var question1 = document.getElementById('question1').value;
        if (question1.length <= 0) {
            document.getElementById('question1Err').innerHTML = "Answer can't be empty!";
            q1check = 1;
        }
        else {
            q1check = 0;
        }
    }

    function check_question2() {
        var question2 = document.getElementById('question2').value;
        if (question2.length <= 0) {
            document.getElementById('question2Err').innerHTML = "Answer can't be empty!";
            q2check = 1;
        }
        else {
            q2check = 0;
        }
    }

    function check_pass() {
        var pass = document.getElementById('pass').value;
        if (pass.length <= 0) {
            document.getElementById('passErr').innerHTML = "Password can't be empty!";
            passcheck = 1;
        }

        else if (pass.length < 8) {
            document.getElementById('passErr').innerHTML = "Password must contains 8 char!";
            passcheck = 1;
        }

        else {
            passcheck = 0;
        }
    }

    function check_cpass() {
        var pass = document.getElementById('pass').value;
        var cpass = document.getElementById('cpass').value;
        var n = pass.localeCompare(cpass);
        if (cpass.length <= 0) {
            document.getElementById('cpassErr').innerHTML = "Confirm Password can't be empty!";
            cpasscheck = 1;
        }

        else if (n != 0) {
            document.getElementById('cpassErr').innerHTML = "Password & Confirm password did not match!";
            cpasscheck = 1;
        }

        else {
            cpasscheck = 0;
        }
    }

    function load() {
        document.getElementById('fnameErr').innerHTML = " ";
        document.getElementById('lnameErr').innerHTML = " ";
        document.getElementById('emailErr').innerHTML = " ";
        document.getElementById('emailexistErr').innerHTML = " ";

        //echeckexist = 0;
        //alert(echeckexist);
        check_firstname();
        check_lastname();
        check_email();
        check_email_exist();
        
        
        if (fcheck == 0 && lcheck == 0 && echeck == 0 && echeckexist == 0) {
            //alert("he"+echeckexist);
            reg_firstname = document.getElementById('fname').value;
            reg_lastname = document.getElementById('lname').value;
            reg_email = document.getElementById('email').value;

        var xhttp;
        xhttp=new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML = xhttp.responseText;
            }
        };
        
        var url = "reg_2.aspx?load=yes";
        xhttp.open("GET", url, true);
        xhttp.send();

        }
  
        
    }

    function load_reg_2() {
        document.getElementById('phoneErr').innerHTML = " ";
        document.getElementById('question1Err').innerHTML = " ";
        document.getElementById('question2Err').innerHTML = " ";
        document.getElementById('passErr').innerHTML = " ";
        document.getElementById('cpassErr').innerHTML = " ";

        check_phone();
        check_question1();
        check_question2();
        check_pass();
        check_cpass();

        if (pcheck == 0 && q1check==0 && q2check==0 && passcheck==0 && cpasscheck==0)
        {
            reg_phone = document.getElementById('phone').value;
            reg_ans_1 = document.getElementById('question1').value;
            reg_ans_2 = document.getElementById('question2').value;
            reg_pass = document.getElementById('pass').value;
            reg_type = "user";

            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
               
                alert("Registation Completed Successfully Now Please Login");
                loadDoc('login.aspx', myFunction);

            }
            };
       
            var url = "insert_value.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("reg_firstname=" + reg_firstname + "&reg_lastname=" + reg_lastname + "&reg_email=" + reg_email + "&reg_phone="
            +reg_phone+"&reg_ans_1="+reg_ans_1+"&reg_ans_2="+reg_ans_2+"&reg_pass="+reg_pass+"&reg_type="+reg_type+"&load=yes");

            
	

        }

           
    }

    

    function myFunction(xhttp) {
        document.getElementById("demo").innerHTML = xhttp.responseText;
    }

    var useremailcheck = 1;
    var userpasscheck = 1;

    var user_email, user_pass, res_string;

    function check_useremail() {
        var useremail = document.getElementById('useremail').value;
        if (useremail.length <= 0) {
            document.getElementById('useremailErr').innerHTML = "Email can't be empty!";
            useremailcheck = 1;
        }
        else {
            useremailcheck = 0;
        }
    }

    function check_userpass() {
        var userpass = document.getElementById('userpass').value;
        if (userpass.length <= 0) {
            document.getElementById('userpassErr').innerHTML = "Password can't be empty!";
            userpasscheck = 1;
        }
        else {
            userpasscheck = 0;
        }
    }
    function set_cookie() {
        var checkbok_clik = document.getElementById("rememberchk").checked;
        if (checkbok_clik == true) {
            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

                //alert( xhttp.responseText);
            }
            };
       
            var url = "set_cookie.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes"); 
        }
    }
    function load_home() {
         //alert(res_string);
        var n = res_string.localeCompare("users");
        //alert(n);
        
        var m = res_string.localeCompare("admin");
       
        if (n == 0) {
            set_cookie();
            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

                document.getElementById("demo").innerHTML = xhttp.responseText;
            }
            };
       
            var url = "user_home_page.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes"); 
        }

        else if (m == 0) {
            set_cookie();
            var xhttp;
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                    document.getElementById("demo").innerHTML = xhttp.responseText;
                }
            };

            var url = "admin_home_page.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
        }
        else {
            alert("Wrong User Email Or Password Try Again");
            
        }

    }
    var checkcookie = 1;
    function checkCookie(){
        var cookieEnabled = navigator.cookieEnabled;
        // alert(cookieEnabled);
        if (cookieEnabled == true) {

            checkcookie = 0;
        }
        else {
            alert("Your Browser Cookie is Disable Please Make It Enable First")
            checkcookie = 1;
        }
       // return cookieEnabled || showCookieFail();
    }
    var respon;

    function load_home_cookie() {
        //alert(res_string);
        var n = respon.localeCompare("users");
        //alert(n);

        var m = respon.localeCompare("admin");

        if (n == 0) {
            //set_cookie();
            var xhttp;
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                    document.getElementById("demo").innerHTML = xhttp.responseText;
                }
            };

            var url = "user_home_page.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
        }

        else if (m == 0) {
            var xhttp;
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                    document.getElementById("demo").innerHTML = xhttp.responseText;
                }
            };

            var url = "admin_home_page.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
        }
        else {
            loadDoc('login.aspx', myFunction);
        }
    }
    function check_cookie() {
            var xhttp;
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                   //alert(xhttp.responseText);
                    var check = xhttp.responseText;
                    respon = check.substring(0, 5);
                    load_home_cookie();
                }
            };

            var url = "check_cookie.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
    }
    var block;
    function load_block() {
        var n = block.localeCompare("noooo");
        //alert(n);

        //var m = respon.localeCompare("admin");

        if (n == 0) {
            load_home();
        }
        else {
            //alert("You are block for 5 minute");
        }
    }
    function block_check(){
            var xhttp;
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                   //alert(xhttp.responseText);
                    var check = xhttp.responseText;
                    block = check.substring(0, 5);
                    load_block();
                }
            };

            var url = "block_check.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
    }
    var alert_mes, respt;
    function load_load() {
        var n = respt.localeCompare("Try");
        //alert(respt);

        //var m = respon.localeCompare("admin");

        if (n == 0) {
            //load_home();
            alert(alert_mes);
            loadDoc('login.aspx', myFunction);

        }
        else {
            logcheck_2();
        }
        
    }
    function final_check() {
        var xhttp;
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                   //alert(xhttp.responseText);
                    var check = xhttp.responseText;
                    //block =
                    alert_mes = check.substring(0, 45);
                    respt = check.substring(0, 3);
                    //alert(resp);
                    load_load();
                }
            };

            var url = "final_check.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
    }
    function logcheck_2() {
        document.getElementById('useremailErr').innerHTML = " ";
        document.getElementById('userpassErr').innerHTML = " ";
        check_useremail();
        check_userpass();
        checkCookie();
        if (useremailcheck == 0 && userpasscheck == 0 && checkcookie == 0) {
            
            user_email = document.getElementById('useremail').value;
            user_pass = document.getElementById('userpass').value;
            
            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

                //alert(xhttp.responseText);
                ///loadDoc('login.aspx?load=yes', myFunction);
                var check = xhttp.responseText;
                res_string = check.substring(0, 5);
                block_check();
                //alert(res_string);
                
                
            }
            };
       
            var url = "validation_check.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("user_email=" + user_email + "&user_pass=" + user_pass+"&load=yes");

        }
    }
    function logcheck() {
        //check_cookie();
        final_check();
        
        
    }

    function registation() {
        var xhttp;
        xhttp=new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML = xhttp.responseText;
            }
        };
        var url = "reg_1.aspx?load=yes";
        xhttp.open("GET", url, true);
        xhttp.send();
    }

    function forget_pass() {
        var xhttp;
        xhttp=new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML = xhttp.responseText;
            }
        };
        var url = "forget_pass.aspx?load=yes";
        xhttp.open("GET", url, true);
        xhttp.send();
    }

    function load_back_login() {
        loadDoc('login.aspx', myFunction);
    }
    var check_forget_emailErr = 1;
    var check_forget_ans1Err = 1;
    var check_forget_ans2Err = 1;

    var forget_email, forget_ans1, forget_ans2, res_forget;

    function check_forget_email() {
        var forget_email = document.getElementById('forget_email').value;
        if (forget_email.length <= 0) {
            document.getElementById('forget_emailErr').innerHTML = "Email can't be empty!";
            check_forget_emailErr = 1;
        }
        else {
            check_forget_emailErr = 0;
        }
    }

    function check_forget_ans1() {
        var forget_ans1 = document.getElementById('forget_ans1').value;
        if (forget_ans1.length <= 0) {
            document.getElementById('forget_ans1Err').innerHTML = "Answer can't be empty!";
            check_forget_ans1Err = 1;
        }
        else {
            check_forget_ans1Err = 0;
        }
    }

    function check_forget_ans2() {
        var forget_ans2 = document.getElementById('forget_ans2').value;
        if (forget_ans2.length <= 0) {
            document.getElementById('forget_ans2Err').innerHTML = "Answer can't be empty!";
            check_forget_ans2Err = 1;
        }
        else {
            check_forget_ans2Err = 0;
        }
    }

    function load_next() {
        var n = res_forget.localeCompare("valid");
        
       
        if (n == 0) {
            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

                document.getElementById("demo").innerHTML = xhttp.responseText;
            }
            };
       
            var url = "change_pass.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes"); 
        }
        
        else {
            alert("Wrong User Email Or Answer Try Again")

        }
    }

    function check_forget_pass() {
        document.getElementById('forget_emailErr').innerHTML = " ";
        document.getElementById('forget_ans1Err').innerHTML = " ";
        document.getElementById('forget_ans2Err').innerHTML = " ";
        check_forget_email();
        check_forget_ans1();
        check_forget_ans2();

        if (check_forget_emailErr == 0 && check_forget_ans1Err==0 && check_forget_ans2Err==0) {
            forget_email = document.getElementById('forget_email').value;
            forget_ans1 = document.getElementById('forget_ans1').value;
            forget_ans2 = document.getElementById('forget_ans2').value;

            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

                //alert(xhttp.responseText);
                //loadDoc('login.aspx', myFunction);
                var check = xhttp.responseText;
                res_forget = check.substring(0, 5);
                //alert(res_string);
                load_next();

            }

            };
       
            var url = "check_forget_info.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("forget_email=" + forget_email + "&forget_ans1=" + forget_ans1 + "&forget_ans2=" + forget_ans2 +"&load=yes");



        }
    }

    var checkforget_pass = 1;
    var checkforget_cpass = 1;
    var forget_pass, forget_cpass;
    function check_f_pass() {
        var pass = document.getElementById('forget_pass').value;
        if (pass.length <= 0) {
            document.getElementById('forget_passErr').innerHTML = "Password can't be empty!";
            checkforget_pass = 1;
        }

        else if (pass.length < 8) {
            document.getElementById('forget_passErr').innerHTML = "Password must contains 8 char!";
            checkforget_pass = 1;
        }

        else {
            checkforget_pass = 0;
        }
    }

    function check_f_cpass() {
        var pass = document.getElementById('forget_pass').value;
        var cpass = document.getElementById('forget_cpass').value;
        var n = pass.localeCompare(cpass);
        if (cpass.length <= 0) {
            document.getElementById('forget_cpassErr').innerHTML = "Confirm Password can't be empty!";
            checkforget_cpass = 1;
        }

        else if (n != 0) {
            document.getElementById('forget_cpassErr').innerHTML = "Password & Confirm password did not match!";
            checkforget_cpass = 1;
        }

        else {
            checkforget_cpass = 0;
        }
    }

    function change_pass_new() {
        document.getElementById('forget_passErr').innerHTML = " ";
        document.getElementById('forget_cpassErr').innerHTML = " ";
        check_f_pass();
        check_f_cpass();
        if (checkforget_pass == 0 && checkforget_cpass==0) {
            forget_pass = document.getElementById('forget_pass').value;
            
            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

                alert("Password Reset Succesfully Please Login");
                loadDoc('login.aspx', myFunction);
                //var check = xhttp.responseText;
                //res_forget = check.substring(0, 5);
                //alert(res_string);
                //load_next();

            }

            };
       
            var url = "update_pass.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("forget_pass=" + forget_pass +"&load=yes");

        }
        
    }

    function log_out() {
            var xhttp;
            xhttp=new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {

              //  alert("Password Reset Succesfully Please Login");
                loadDoc('login.aspx', myFunction);
                //var check = xhttp.responseText;
                //res_forget = check.substring(0, 5);
                //alert(res_string);
                //load_next();

            }

            };
       
            var url = "log_out.aspx";
            xhttp.open("POST", url, true);
            xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xhttp.send("load=yes");
    }
    
        
</script>
  
   
</body>
</html>
