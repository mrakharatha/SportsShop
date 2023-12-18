$("form").submit(function () {
    $(":submit").attr("disabled", "true").html(`<div class="spinner-border text-primary" role="status"> <span class="sr-only">Loading...</span></div>`);
});

$("input").on('change keypress keyup blur', function () {
    $(":submit").removeAttr("disabled", "false").html('ثبت');
});

$("select").on('change keypress keyup blur', function () {
    $(":submit").removeAttr("disabled", "false").html('ثبت');
});