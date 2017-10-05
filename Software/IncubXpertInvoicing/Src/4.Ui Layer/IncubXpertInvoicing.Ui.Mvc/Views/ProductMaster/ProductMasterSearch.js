var ProductMasterSearch = new function () {
    var self = this;
    this.ProductMasterDataTable = null;

    this.Ready = function () {
        $('#idProductMasterSidemenuItem').addClass('active');

        self.InitProductMasterDataTable();
    }

    this.InitProductMasterDataTable = function () {
        self.ProductMasterDataTable = $('#idProductMasterTable').DataTable({
            "serverSide": true,
            "processing": false,
            "ordering": false,
            "paging": true,
            "searching": false,
            "dom": '<"top row"<"inline col-sm-2"l><"inline centerAlign col-sm-4"i><"inline rightAlign col-sm-6"p>>',
            "pagingType": "full_numbers",
            "ajax": {
                "url": "ProductMaster/GetProductMasterList",
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
                        { data: 0 },
                        { data: 1 },
                        { data: 2 },
                        { data: 3 },
                        { data: 4 }
            ]
        });
    }
}
$(document).ready(ProductMasterSearch.Ready);