function startTimer(duration, display) {
    var timer = duration, minutes, seconds;
    var countdown = setInterval(function () {
        if (--timer >= 0) {
            minutes = parseInt(timer / 60, 10);
            seconds = parseInt(timer % 60, 10);

            minutes = minutes < 10 ? "0" + minutes : minutes;
            seconds = seconds < 10 ? "0" + seconds : seconds;

            display.textContent = minutes + ":" + seconds;
        } else {
            document.getElementById("sendBtn").innerHTML = "ارسال مجدد کد"
            document.getElementById("sendBtn").disabled = false;
            clearInterval(countdown);
        }

    }, 1000);
}


window.onload = starttimer();
function starttimer() {
    document.getElementById("sendBtn").innerHTML = `ارسال مجدد کد در  <span id="time">3:00</span> دیگر<i id="icon-arrow" class="bx bx-left-arrow-alt"></i>`
    document.getElementById("sendBtn").disabled = true;
    var threeMinutes = 3*60,
        display = document.querySelector('#time');
    startTimer(threeMinutes, display);
};