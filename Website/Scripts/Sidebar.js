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

    });
});

function setActive() {
    var serviceId = $('#serviceId').val();
    if (typeof serviceId != "undefined") {
        $('li[data-serviceid="' + serviceId + '"]').addClass('active');
    } else {
        var courseId = $('#courseId').val();
        var typeId = $('#typeId').val();
        $('ul[data-trainingtypeid="' + typeId + '"] > li[data-courseid="' + courseId + '"]').addClass('active');
        $('ul[data-trainingtypeid="' + typeId + '"]').prev().click();
    }
}