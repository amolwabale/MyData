var CustomerMasterDetail = new function () {
    var self = this;

    this.Ready = function () {
        $('#idCustomerMasterSidemenuItem').addClass('active');

        //$("#idBtnSaveCustomerMaster").on("click", function (e) {
        //    e.preventDefault();
        //    var FormData = $('#idFormCustomerMaster').serializeArray();
        //    $.ajax({
        //        type: "POST",
        //        url: "CustomerMaster/SaveCustomerMaster",
        //        data: FormData
        //    }).done(function (dataresponse) {
                
        //    });
        //});

    }
}
$(document).ready(CustomerMasterDetail.Ready);