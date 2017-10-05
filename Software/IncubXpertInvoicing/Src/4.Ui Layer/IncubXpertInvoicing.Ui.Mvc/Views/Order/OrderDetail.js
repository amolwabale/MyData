var OrderDetail = new function () {
    var self = this;

    this.Ready = function () {
        $('#idOrderSidemenuItem').addClass('active');
    }
}
$(document).ready(OrderDetail.Ready);