
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Log_in_control.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="demo"></div>
    <button onclick="getData()">Click</button>

    
    <script>

        var name, user, pass, email, question, type;

        var callback = function () {
            //console.log("ready");
            getData();
        };

        if (
            document.readyState === "complete" ||
            (document.readyState !== "loading" && !document.documentElement.doScroll)
        ) {
            callback();
        } else {
            document.addEventListener("DOMContentLoaded", callback);
        }
        
        function getData() {
            console.log("Ready2");
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
                if (this.readyState == 4 && this.status == 200) {
                    document.getElementById("demo").innerHTML =
                        this.responseText;

                    //document.getElementById('h1').style.display = "none";
                    //document.getElementById('h2').style.display = "none";
                    //document.getElementById('h4').style.display = "none";
                    //console.log(this.responseText);
                }
            };
            xhttp.open("POST", "reg1.aspx", true);
            xhttp.setRequestHeader("Content-Type", "application/json");
            
            xhttp.send();
        }
        

        //var uploadServerSideScriptPath = "reg1.aspx/Get";
        //var xhr = new XMLHttpRequest();  
        //xhr.open("POST", uploadServerSideScriptPath, false); 
        //xhr.setRequestHeader("Content-Type", "multipart/form-data");
        //xhr.setRequestHeader("Content-Type", "application/json");
        //xhr.setRequestHeader("X-File-Name", file.name);
        //xhr.setRequestHeader("X-File-Size", file.size);
        //xhr.setRequestHeader("X-File-Type", file.type);     
        //xhr.send(formData);

        var isValid = true;

        function checkName()
        {

            var re = /^[A - Za - z] +$/;

            var data = document.getElementById("name").value;
            if (!isValid)
            {
                return;
            }
            else if (data == "")
            {
                document.getElementById("h1").innerHTML = "Name can't be empty";
                document.getElementById("h1").style.display = "block";
                isValid = false;
            }
            else if (data.length < 2)
            {
                document.getElementById("h1").innerHTML = "Minimum 2 characters";
                document.getElementById("h1").style.display = "block";
                isValid = false;
            }
            //else if (!re.test(data))
            //{
            //    document.getElementById("h1").innerHTML = "Can not contain numbers or special characters";
            //    document.getElementById("h1").style.display = "block";
            //    isValid = false;
            //}
            else
            {
                document.getElementById("h1").innerHTML = "";
                document.getElementById("h1").style.display = "none";
                isValid = true;
            }
        }

        function checkUser()
        {
            var data = document.getElementById("user").value;

            if (!isValid)
            {
                return;
            }
            else if (data == "")
            {
                document.getElementById("h2").innerHTML = "User ID can't be empty";
                document.getElementById("h2").style.display = "block";
                isValid = false;
            }

            else
            {
                document.getElementById("h2").innerHTML = "";
                document.getElementById("h2").style.display = "none";
                isValid = true;
            }
        }

        function checkEmail()
        {

            var re = /\S +@\S +\.\S +/;

            var data = document.getElementById("email").value;

            if (!isValid)
            {
                return;
            }
            else if (data == "")
            {
                document.getElementById("h3").innerHTML = "Email can't be empty";
                document.getElementById("h3").style.display = "block";
                isValid = false;
            }
            //else if (!re.test(data))
            //{
            //    document.getElementById("h3").innerHTML = "Invalid Email";
            //    document.getElementById("h3").style.display = "block";
            //    isValid = false;
            //}
            else
            {
                document.getElementById("h3").innerHTML = "";
                document.getElementById("h3").style.display = "none";
                isValid = true;
            }
        }

        function checkPassword()
        {
            var data = document.getElementById("pass").value;

            if (!isValid)
            {
                return;
            }
            else if (data == "")
            {
                document.getElementById("h4").innerHTML = "Password can't be empty";
                document.getElementById("h4").style.display = "block";
                isValid = false;
            }
            else if (data.length < 4)
            {
                document.getElementById("h4").innerHTML = "Password length must be at least 4";
                document.getElementById("h4").style.display = "block";
                isValid = false;
            }
            else
            {
                document.getElementById("h4").innerHTML = "";
                document.getElementById("h4").style.display = "none";
                isValid = true;
            }
        }

        function checkQuestion()
        {

            var re = /^[A - Za - z] +$/;

            var data = document.getElementById("question").value;
            if (!isValid)
            {
                return;
            }
            else if (data == "")
            {
                document.getElementById("h5").innerHTML = "Please give an answer";
                document.getElementById("h5").style.display = "block";
                isValid = false;
            }
            else
            {
                document.getElementById("h5").innerHTML = "";
                document.getElementById("h5").style.display = "none";
                isValid = true;
            }
        }

        function checkReg1()
        {
            isValid = true;
            document.getElementById('h1').style.display = "none";
            document.getElementById('h2').style.display = "none";
            //document.getElementById('h3').style.display = "none";
            document.getElementById('h4').style.display = "none";

            checkName();
            checkUser();
            //checkEmail();
            checkPassword();

            if (!isValid) {
                return false;
            }
            else {

                name = document.getElementById("name").value;
                user = document.getElementById("user").value;
                pass = document.getElementById("pass").value;

                console.log("Ready1");
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function() {
                    if (this.readyState == 4 && this.status == 200) {
                        document.getElementById("demo").innerHTML =
                            this.responseText;

                        //document.getElementById('h1').style.display = "none";
                        //document.getElementById('h2').style.display = "none";
                        //document.getElementById('h4').style.display = "none";
                        //console.log(this.responseText);
                    }
                };
                xhttp.open("POST", "reg2.aspx", true);
                xhttp.setRequestHeader("Content-Type", "application/json");
            
                xhttp.send();
            }

            return true;
        }

        function checkReg2()
        {
            isValid = true;
            document.getElementById('h3').style.display = "none";
            document.getElementById('h5').style.display = "none";

            checkEmail();
            checkQuestion();

            if (!isValid) {
                return false;
            }
            else {

                email = document.getElementById("email").value;
                question = document.getElementById("question").value;
                type = document.querySelector('input[name="type"]:checked').value;

                console.log("Ready2");
                //var xhttp = new XMLHttpRequest();
                //xhttp.onreadystatechange = function() {
                //    if (this.readyState == 4 && this.status == 200) {
                //        document.getElementById("demo").innerHTML = this.responseText;

                //        //document.getElementById('h1').style.display = "none";
                //        //document.getElementById('h2').style.display = "none";
                //        //document.getElementById('h4').style.display = "none";
                //        //console.log(this.responseText);
                //    }
                //};
                //xhttp.open("POST", "confirmReg.aspx", true);
                //xhttp.setRequestHeader("Content-Type", "application/json");

                //var data = JSON.stringify({"name": name, "email": email, "user": user, "pass": pass, "question": question});
                ////var data = {"name": name, "email": email, "user": user, "pass": pass, "question": question};
            
                //xhttp.send(data);

                var formData = new FormData(); 

                formData.append("name", name);
                formData.append("email", email);
                formData.append("user", user);
                formData.append("pass", pass);
                formData.append("question", question);
                formData.append("type", type);

                var xmlHttp = new XMLHttpRequest();
                xmlHttp.onreadystatechange = function()
                {
                    if(xmlHttp.readyState == 4 && xmlHttp.status == 200)
                    {
                        alert(xmlHttp.responseText);
                    }
                }
                xmlHttp.open("post", "confirmReg.aspx"); 
                xmlHttp.send(formData); 
            }

            return true;
        }

        function submitReg1()
        {
            console.log("Submited");
        }

    </script>
</body>
</html>