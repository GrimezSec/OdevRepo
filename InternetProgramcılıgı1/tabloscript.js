var showResult = false;  

document.addEventListener("DOMContentLoaded", function () {
    showMultiplicationTable();  


    document.getElementById("number1").addEventListener("input", updateMultiplicationTable);
    document.getElementById("number2").addEventListener("input", updateMultiplicationTable);
    document.getElementById("showButton").addEventListener("click", function () {
        showResult = true;
        showMultiplicationTable();
    });
});

function updateMultiplicationTable() {
    if (showResult) {
        showResult = false;  
        showMultiplicationTable(); 
    }
}

function showMultiplicationTable() {
    var number1 = parseInt(document.getElementById("number1").value) || 0;
    var number2 = parseInt(document.getElementById("number2").value) || 0;

    var table = "<table>";
    for (var i = 1; i <= 10; i++) {
        table += "<tr>";
        for (var j = 1; j <= 10; j++) {
            var result = i * j;
            var cellColor = (showResult && i === number1 && j === number2) ? "green" : "";
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
