function setWindowName() {
    if (window.location.href.indexOf("tab.aspx") > -1) {
        return;
    }
    var wName = new Date().getTime();
    if (window.name.length == 0) {
        var serviceURL = "/UtilService.asmx/SetWindowName";
        $.ajax({
            type: "POST",
            url: serviceURL,
            data: '{"name":"' + wName + '"}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSuccessCall,
            error: OnErrorCall
        });
    }

    function OnSuccessCall(response) {
        if (!response.d) {
            window.location.replace("/pages/tab.aspx");
        } else {
            window.name = wName;
        }
    }

    function OnErrorCall(response) {
        alert("Fail!:" + response.status + " " + response.statusText);
    }
};

//function createAuthCookie() {
//    if (document.cookie.indexOf('userAuth=1') == -1) { //cookie does not exist; create it;
//        var date = new Date();
//        date.setTime(date.getTime() + (60 * 1000)); // 60 seconds
//        $.cookie('userAuth', date.getTime(), { expires: date });
//    }
//}

//function removeAuthCookie() {
//    if (document.cookie.indexOf('userAuth=1') != -1) {
//        $.cookie("userAuth", null, { path: '/' });
//        $.removeCookie('userAuth', { path: '/' });
//    }

//    return true;
//}

//function countdown() {
//    if (document.cookie.indexOf('userAuth=1') != -1) {

//        var countDownDate = new Date();
//        countDownDate.setTime($.cookie('userAuth'));

//        // Update the count down every 1 second
//        var x = setInterval(function () {

//            // Get todays date and time
//            var now = new Date().getTime();

//            // Find the distance between now an the count down date
//            var distance = countDownDate - now;

//            // Time calculations for days, hours, minutes and seconds
//            var days = Math.floor(distance / (1000 * 60 * 60 * 24));
//            var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
//            var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
//            var seconds = Math.floor((distance % (1000 * 60)) / 1000);

//            // Display the result in the element with id="demo"
//           // document.getElementById("demo").innerHTML = days + "d " + hours + "h "
//            //    + minutes + "m " + seconds + "s ";


//            // If the count down is finished, write some text
//            if (distance < 0) {
//                clearInterval(x);
//                countDownDate = null;
//                document.getElementById("demo").innerHTML = "EXPIRED";
//               //  location.reload();
//            }
//        }, 1000);
//    }
//}