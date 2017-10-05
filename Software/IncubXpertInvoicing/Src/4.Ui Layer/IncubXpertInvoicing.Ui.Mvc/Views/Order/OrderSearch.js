var OrderSearch = new function () {
    var self = this;
    this.OrderDataTable = null;

    this.Ready = function () {
        $('#idOrderSidemenuItem').addClass('active');

        self.InitOrderDataTable();
    }

    this.InitOrderDataTable = function () {
        self.OrderDataTable = $('#idOrderTable').DataTable({
            "serverSide": true,
            "processing": false,
            "ordering": false,
            "paging": true,
            "searching": false,
            "dom": '<"top row"<"inline col-sm-2"l><"inline centerAlign col-sm-4"i><"inline rightAlign col-sm-6"p>>',
            "pagingType": "full_numbers",
            "ajax": {
                "url": "Order/GetOrderList",
                "type": "POST",
                "dataSrc": 'data',
                "data": function (d) {

                }
            },
            "columns": [
                        {
                            data: null,
                            className: "center",
                            defaultContent: '<a href="#" title="Edit" ><span class="fa fa-edit"></span></a>&nbsp&nbsp&nbsp<a  href="#" title="View" ><span class="fa fa-eye"></span></a>'
                        },
                        {
                            data: null,
                            className: "center",
                            defaultContent: '<a href="#" title="Edit" >View Invoice</a>'
                        },
                        { data: 0 },
                        { data: 1 },
                        { data: 2 },
                        { data: 3 }
            ]
        });
    }
}
$(document).ready(OrderSearch.Ready);