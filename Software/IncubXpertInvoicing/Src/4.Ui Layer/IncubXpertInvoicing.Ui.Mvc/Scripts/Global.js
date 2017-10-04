var Global = new function () {
    var self = this;

    this.Ready = function () {

        $('.sidebar').on('click', function () {
            $(this).siblings().removeClass('active');
            $(this).addClass('active');
        });

    }
}
$(document).ready(Global.Ready);