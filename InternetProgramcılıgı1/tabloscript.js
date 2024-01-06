// tabloscript.js
document.addEventListener("DOMContentLoaded", function () {
    showMultiplicationTable();  // Sayfa yüklendiğinde çarpım tablosunu göster

    // Sayı 1 ve Sayı 2 input alanlarına herhangi bir değer girildiğinde çarpım tablosunu güncelle
    document.getElementById("number1").addEventListener("input", updateMultiplicationTable);
    document.getElementById("number2").addEventListener("input", updateMultiplicationTable);
});

function updateMultiplicationTable() {
    showMultiplicationTable();  // Çarpım tablosunu güncelle
}

function showMultiplicationTable() {
    var number1 = parseInt(document.getElementById("number1").value) || 0;
    var number2 = parseInt(document.getElementById("number2").value) || 0;

    var table = "<table>";
    for (var i = 1; i <= 10; i++) {
        table += "<tr>";
        for (var j = 1; j <= 10; j++) {
            var result = i * j;
            var cellColor = (number1 * number2 === result) ? "green" : "";
            table += "<td style='background-color:" + cellColor + "'>" + result + "</td>";
        }
        table += "</tr>";
    }
    table += "</table>";

    var multiplicationTableContainer = document.getElementById("tablo");
    if (multiplicationTableContainer) {
        multiplicationTableContainer.innerHTML = table;
    } else {
        console.error("tablo bulunamadı.");
    }
}
