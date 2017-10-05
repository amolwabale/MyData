var CustomerMasterDetail = new function () {
    var self = this;

    this.Ready = function () {
        $('#idCustomerMasterSidemenuItem').addClass('active');
    }
}
$(document).ready(CustomerMasterDetail.Ready);