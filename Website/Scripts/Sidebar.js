$(document).ready(function() {
    $(".sidebar-collapselist").on("click", function () {
        $(".sidebar-collapselist:not(.collapsed)").not(this).click();
    });

    setActive();

    $('#showSidebar').on('click', function () {
        if ($('.sidebar-menu').is(':visible')) {
            $('.sidebar-menu').hide();
        } else {
            $('.sidebar-menu').show();
        }
        //$('.sidebar-menu').stop(true, true).hide("slide", { direction: "left" }, 1000);
        //$('#testing').animate({ width: 'toggle' }, 350);
    });

    $('#main').on('click', function () {
        debugger;
        if ($('.sidebar-menu').is(':visible')) {
            $('.sidebar-menu').hide();
        }
    });
});

function setActive() {
    var serviceId = $('#serviceId').val();
    if (typeof serviceId != "undefined") {
        $('#sidebar-lg li[data-serviceid="' + serviceId + '"]').addClass('active');
    } else {
        var courseId = $('#courseId').val();
        var typeId = $('#typeId').val();
        $('#sidebar-lg ul[data-trainingtypeid="' + typeId + '"] > li[data-courseid="' + courseId + '"]').addClass('active');
        $('#sidebar-lg ul[data-trainingtypeid="' + typeId + '"]').prev().click();
    }
}