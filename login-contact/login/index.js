function CheckDangNhap(){
    var mess = document.getElementById('ui_error_message');
    var username = document.getElementById('login_username');
    var password = document.getElementById('login__password');
    if (username.value == '' && password.value == '')
    {
      
        document.getElementById('login_username').style.backgroundColor = '#E0B4B4'
        document.getElementById('login__password').style.backgroundColor = '#E0B4B4'
        mess.innerHTML +=   
        `
                <div class='insert'>
                    <ul class ='error'>
                        <li>Please enter your e-mail</li>
                        <li>Please enter a valid e-mail</li>
                        <li>Please enter your password</li>
                        <li>Your password must be at least 6 characters</li>
                    </ul>
                </div>
            `
    }
}

function CheckPass()
{
    var mess = document.getElementById('ui_error_message');
    var username = document.getElementById('login_username');
    var password = document.getElementById('login__password');
    if(password.value.length < 6 && password.value.length>1)
    {
        console.log(password)
        mess.innerHTML += 
       `
                <div class='insert'>
                    <ul class ='error'>
                        <li>Your password must be at least 6 characters</li>
                    </ul>
                </div>
        `
           
    }
}

function Checkemail()
{
    var mess = document.getElementById('ui_error_message');
    var letter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    var username = document.getElementById('login_username');
    var password = document.getElementById('login__password');
    if (username.value == '' &&  password.value.length > 1)
    {
        document.getElementById('login_username').style.backgroundColor = '#E0B4B4';
        mess.innerHTML += 
        `
            <div class='insert'>
                <ul class ='error'>
                    <li>Please enter your e-mail</li>
                    <li>Plese enter a valid e-mail</li>
                </ul>
            </div>
        `
       
    } else if (!username.value.match(letter) && password.value>1)
    {
        document.getElementById('login_username').style.backgroundColor = '#E0B4B4';
        document.getElementById('login__password').style.backgroundColor = '#E0B4B4'
        mess.innerHTML += 
        `
                <div class='insert'>
                    <ul class ='error'>
                        <li>Please enter a valid e-mail</li>
                        <li>Please enter your password</li>
                        <li>Your password must be at least 6 characters</li>
                    </ul>
                </div>       
          `     
    } 
}
var btnLoggin = document.getElementById('s');
btnLoggin.onclick = function (event){
    var mess = document.getElementById('ui_error_message');
    mess.innerHTML = ' ';
    event.preventDefault();
    CheckDangNhap();    
    Checkemail();  
    CheckPass();
    
}