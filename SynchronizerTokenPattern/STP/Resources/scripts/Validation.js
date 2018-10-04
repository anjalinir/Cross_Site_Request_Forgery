function GetToken() {
    alert("Method");
    alert("Methoderrewrew");
    alert("label " + $("#Label1").text());
}

//function GetToken() {
//    alert("Valid Method");
//    //var csrf = document.getElementById("hdCsrfToken").value;
//    var re = $("#Label1").text();
//    alert("label " + re);
//    //alert("csrf " + csrf);
//    $.ajax({
//        type: "POST",
//        url: "Home.aspx/GetCSRFToken",
//        //data: JSON.stringify({ csrfToken: $('#hdCsrfToken').val() }),
//        data: JSON.stringify({ csrfToken: $("#Label1").text() }),
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        async: false,
//        cache: false,
//        success: function (response) {
//            alert("Valid Session");
//            return true;
//        },
//        error: function (xhr, status, error) {
//            try {
//                var errorMsg = JSON.parse(xhr.responseText).Message;
//                alert(errorMsg);
//            }
//            catch (ex) {
//                alert("Internal Server error");
//            }
//            return false;
//        }
//    });
//    alert("End of the validation");
//}