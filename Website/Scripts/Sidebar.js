$(document).ready(function() {
    $(".sidebar-collapselist").on("click", function () {
        $(".sidebar-collapselist:not(.collapsed)").not(this).click();
    });
    setActive();

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