$(" #roku-buttons").click(function (val, where) {
    $.post('"http://" + where +":8060/keypress/" + val');
});

$("#home").click(function () {
    $.post("http://10.251.1.162:8060/keypress/home");
});

$("#back").click(function () {
    $.post("http://10.251.1.162:8060/keypress/back");
});

$("#up").click(function () {
    $.post("http://10.251.1.162:8060/keypress/up");
});

$("#left").click(function () {
    $.post("http://10.251.1.162:8060/keypress/left");
});

$("#right").click(function () {
    $.post("http://10.251.1.162:8060/keypress/right");
});

$("#down").click(function () {
    $.post("http://10.251.1.162:8060/keypress/down");
});

$("#select").click(function () {
    $.post("http://10.251.1.162:8060/keypress/select");
});

$("#rewind").click(function () {
    $.post("http://10.251.1.162:8060/keypress/rev");
});

$("#play").click(function () {
    $.post("http://10.251.1.162:8060/keypress/play");
});

$("#forward").click(function () {
    $.post("http://10.251.1.162:8060/keypress/fwd");
});

$("#quicklaunch").click(function (val) {
    $.post("http://10.251.1.162:8060/launch/1?contentID=" + val);
});

function quickLaunch(id) {
    $.post("http://10.251.1.162:8060/launch/" + id);
}