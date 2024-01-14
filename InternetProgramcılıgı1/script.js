function login() {
    var username = document.getElementById("username").value; //Kullanıcı adın değeri
    var password = document.getElementById("password").value; //Parola değeri

    //Örnek kullanıcı adı ve parola
    var sampleUsername = "demo";
    var samplePassword = "password";

    if (username === sampleUsername && password === samplePassword) {
        // Giriş işlemi başarılı olduğunda tablo.html aç
        window.location.href = "biograpy.html";
    } else {
        alert("Kullanıcı adı veya parola yanlış!");
    }
}