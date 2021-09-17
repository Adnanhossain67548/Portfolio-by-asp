$("#submit-button").click(function (e) {
    $(".modal").show();
    $("#User-name-box").text(`Hi! ${$("#name-box").val()}`)

});

$(".modal").hide();

$(".closing").click(function () {
    $(".modal").hide();
});

$(document).scroll(function () {
    if ($(document).scrollTop() >= 550) {
        $('#navvy').removeAttr("id");
        $('#profile-pic').parent().attr("id", "profile-picture");
    } else {
        $('#nav-bard').parent().attr("id", "navvy");
        $('#profile-picture').removeAttr("id");
    }
});

$(function () {
    $('[data-toggle="popover"]').popover()
})